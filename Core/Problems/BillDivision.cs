using Core.Helpers;
using Newtonsoft.Json;

namespace Core.Problems
{
    public class BillDivision : IProblem
    {
        public object Solve(object input)
        {
            string[] p = input.ToStringList(' ');
            var bill = JsonConvert.DeserializeObject<List<int>>(p[0]);
            var itemAnnaDoesntEat = int.Parse(p[1]);
            var amountAnnaPaid = int.Parse(p[2]);

            if (bill == null) return string.Empty;

            return FairlySplit(bill, itemAnnaDoesntEat, amountAnnaPaid);
        }

        static string FairlySplit(List<int> bill, int k, int b)
        {
            bill.RemoveAt(k);

            var totalBill = bill.Sum();
            if (totalBill / 2 == b)
                return "Bon Appetit";
            else
                return (b - totalBill / 2).ToString();
        }
    }
}
