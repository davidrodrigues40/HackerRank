using System.Collections.Generic;

namespace Core
{
    public class Helper
    {
        public List<int> GetDigits(int input)
        {
            List<int> list = new List<int>();

            string stringDigits = input.ToString();
            foreach (char c in stringDigits)
            {
                list.Add(int.Parse(c.ToString()));
            }
            return list;
        }
    }
}
