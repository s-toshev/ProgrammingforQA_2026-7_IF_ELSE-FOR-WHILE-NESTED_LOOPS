using System.Net.Security;

namespace _05_1._5_Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            int coinCounter = 0;

            //2 lv, 1 lv, 0.50 lv, 0.20lv, 0,10lv, 0,05lv, 0,02lv, 0,01 lv.

            while (input > 0)
            {
                if (input - 2 >= 0)
                {
                    input -= 2;
                    coinCounter++;
                }
                else if (input - 1 >= 0)
                {
                    input -= 1;
                    coinCounter++;
                }
                else if (input - 0.50m >= 0)
                {
                    input -= 0.50m;
                    coinCounter++;
                }
                else if (input - 0.20m >= 0)
                {
                    input -= 0.20m;
                    coinCounter++;
                }
                else if (input - 0.10m >= 0)
                {
                    input -= 0.10m;
                    coinCounter++;
                }
                else if (input - 0.05m >= 0)
                {
                    input -= 0.05m;
                    coinCounter++;

                }
                else if (input - 0.02m >= 0)
                {
                    input -= 0.02m;
                    coinCounter++;
                }
                else if (input - 0.01m >= 0)
                {
                    input -= 0.01m;
                    coinCounter++;
                }

             
            }

            Console.WriteLine(coinCounter);
        }
    }
}
