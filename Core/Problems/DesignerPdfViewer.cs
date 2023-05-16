using Core.Helpers;

namespace Core.Problems
{
    internal class DesignerPdfViewer : IProblem
    {
        private static readonly char[] _elements = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public object Solve(object input)
        {
            var arrays = input.ToStringArray(',');
            (int[] height, string word) = arrays.ToIntArray_String();

            return DoWork(height.ToList(), word);
        }

        private static int DoWork(List<int> h, string word)
        {
            var calculatedHeights = new List<int>();

            foreach (char character in word)
            {
                var index = Array.IndexOf(_elements, character);
                calculatedHeights.Add(h.ElementAt(index));
            }

            return calculatedHeights.Max() * word.Length;
        }
    }
}
