using Core.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Problems
{
    public class BillDivision : IProblem
    {
        public void Solve(object input)
        {
            string[] p = input.ToStringList(' ');
            var bill = JsonConvert.DeserializeObject<List<int>>(p[0]);
            var itemAnnaDoesntEat = int.Parse(p[1]);
            var amountAnnaPaid = int.Parse(p[2]);

            bonAppetit(bill, itemAnnaDoesntEat, amountAnnaPaid);
        }

        static void bonAppetit(List<int> bill, int k, int b)
        {
            Console.WriteLine(fairlySplit(bill, k, b));
        }

        static string fairlySplit(List<int> bill, int k, int b)
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
