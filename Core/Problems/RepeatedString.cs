using Core.Helpers;
using System.Diagnostics;

namespace Core.Problems
{
	internal class RepeatedString : IProblem
	{
		private static Stopwatch _stopWatch = new();
		object IProblem.Solve(object input)
		{
			(string s, long n) = input.ToString_Long(',');

			List<RepeatedResponse> responses = new();
			_stopWatch.Start();
			var value = DoWork(s, n);
			_stopWatch.Stop();
			responses.Add(new RepeatedResponse { name = "DoWork", value = value, time = _stopWatch.Elapsed.ToString() });

			_stopWatch.Reset();
			_stopWatch.Start();
			value = MyWork(s, n);
			_stopWatch.Stop();
			responses.Add(new RepeatedResponse { name = "MyWork", value = value, time = _stopWatch.Elapsed.ToString() });

			return responses;
		}

		private static long DoWork(string s, long n)
		{
			long count = 0;
			foreach (char c in s)
			{
				if (c == 'a')
				{
					count++;
				}
			}

			if (n < s.Length)
				return count;

			long factor = (n / s.Length); // 3.3
			long rem = (n % s.Length); // 1
			count = factor * count; // 3 * 3 = 9
			for (int i = 0; i < rem; i++)
			{
				if (s[i] == 'a')
				{
					count++;
				}
			}
			_stopWatch.Stop();

			return count;
		}

		private static long MyWork(string s, long n)
		{

			if (s.Length == 1)
			{
				if (s == "a") return n;
				return 0;
			}

			var charArray = s.ToCharArray();

			long count = 0;
			charArray.ToList().ForEach(c => { if (c == 'a') count++; });

			IEnumerable<char> charArr = new List<char>(charArray);

			long factor = (n / s.Length);
			count = factor * count;

			long rem = (n % s.Length);
			s.Take((int)rem).ToList().ForEach(c => { if (c == 'a') count++; });

			return count;
		}
	}

	internal class RepeatedResponse
	{
		public string name { get; set; }
		public long value { get; set; }
		public string time { get; set; }
	}
}
