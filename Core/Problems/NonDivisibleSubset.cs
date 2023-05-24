using Core.Helpers;
using System.Numerics;

namespace Core.Problems
{
	internal class NonDivisibleSubset : IProblem
	{
		public object Solve(object input)
		{
			(int k, int[] a) = input.ToInt_IntArray(',', ' ');

			return DoWork(k, a.ToList());
		}

		public static int DoWork(int k, List<int> s)
		{
			if (k < 2) return 1;
			int[] arr = new int[k];
			for (int i = 0; i < s.Count; i++)
			{
				arr[s[i] % k]++;
			}
			int answer = 0;
			for (int i = 1; i < k / 2; i++)
			{
				answer += Math.Max(arr[i], arr[k - i]);
			}
			if (arr[0] > 1) answer++;
			if (k % 2 == 0 && arr[k / 2] > 0)
			{
				answer++;
			}
			if (k % 2 != 0)
			{
				answer += Math.Max(arr[k / 2], arr[k - k / 2]);
			}
			return answer;

		}

		private static void FigureItOut(int x, BigInteger int1, IEnumerable<int> distinct, int k, Dictionary<BigInteger, HashSet<BigInteger>> lists)
		{
			BigInteger int2 = distinct.ElementAt(x);

			decimal divisor = Divisor(int1, int2, k);

			if (!IsDivisible(divisor))
			{
				var found = false;
				lists[int1].ToList().ForEach(l =>
				{
					if (IsDivisible(Divisor(l, int2, k)))
						found = true;
				});

				if (!found)
				{
					lists[int1].Add(int2);
				}
			}
		}

		private static decimal Divisor(BigInteger int1, BigInteger int2, int k)
		{
			return (decimal.Parse(int1.ToString()) + decimal.Parse(int2.ToString())) / k;
		}

		private static bool IsDivisible(decimal divisor)
		{
			return Decimal.Round(divisor, 0) == divisor;
		}
	}
}
