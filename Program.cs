using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Every_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double all = SquareDigits(n);
            Console.WriteLine(all);
        }

        private static double SquareDigits(int n)
        {
            List<string> list = new List<string>();
            double all = 0;
            double lenght = 0;

            while (n != 0)
            {
                double squareDigit = Math.Pow(n % 10, 2);
                list.Add(squareDigit.ToString());
                n /= 10;
            }

            for (int i = 0; i < list.Count; i++)
            {
                all += int.Parse(list[i]) * Math.Pow(10, lenght);
                lenght += list[i].Length;
            }

            return all;
        }
    }
}
