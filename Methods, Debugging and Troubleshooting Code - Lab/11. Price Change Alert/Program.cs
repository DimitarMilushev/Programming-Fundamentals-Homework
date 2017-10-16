using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPrices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double prices = double.Parse(Console.ReadLine());

            for (int i = 0; i < numPrices - 1; i++)
            {
                double slot = double.Parse(Console.ReadLine());
                double div = Proc(prices, slot);
                bool SignificantDifference = Change(div, threshold);
                string message = Get(slot, prices, div, SignificantDifference);
                Console.WriteLine(message);

                prices = slot;
            }
        }
        private static string Get(double slot, double prices, double Difference,
            bool etherTrueOrFalse)
        {
            string to = "";
            if (Difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", slot);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", prices, slot, Difference);
            }
            else if (etherTrueOrFalse && (Difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", prices, slot, Difference);
            }
            else if (etherTrueOrFalse && (Difference < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", prices, slot, Difference);
            return to;
        }
        private static bool Change(double threshold, double Difference)
        {
            if (Math.Abs(threshold) >= Difference)
            {
                return true;
            }
            return false;
        }
        private static double Proc(double l, double slot)
        {
            double r = (slot - l) / l;
            return r;
        }
    }
}