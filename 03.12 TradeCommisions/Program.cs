namespace _03._12_TradeCommisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volumeOfOrders = double.Parse(Console.ReadLine());
            double percentage = 0;

            if (city == "Sofia")
            {
                if (volumeOfOrders > 10000)
                {
                    percentage = 0.12;
                }
                else if (volumeOfOrders <= 10000 && volumeOfOrders > 1000)
                {
                    percentage = 0.08;
                }
                else if (volumeOfOrders <= 1000 && volumeOfOrders > 500)
                {
                    percentage = 0.07;
                }
                else if (volumeOfOrders <= 500 && volumeOfOrders >= 0)
                {
                    percentage = 0.05;
                }
            }
            else if (city == "Varna")
            {
                if (volumeOfOrders > 10000)
                {
                    percentage = 0.13;
                }
                else if (volumeOfOrders <= 10000 && volumeOfOrders > 1000)
                {
                    percentage = 0.10;
                }
                else if (volumeOfOrders <= 1000 && volumeOfOrders > 500)
                {
                    percentage = 0.075;
                }
                else if (volumeOfOrders <= 500 && volumeOfOrders >= 0)
                {
                    percentage = 0.045;
                }
            }
            else if (city == "Plovdiv")
            {
                if (volumeOfOrders > 10000)
                {
                    percentage = 0.145;
                }
                else if (volumeOfOrders <= 10000 && volumeOfOrders > 1000)
                {
                    percentage = 0.12;
                }
                else if (volumeOfOrders <= 1000 && volumeOfOrders > 500)
                {
                    percentage = 0.08;
                }
                else if (volumeOfOrders <= 500 && volumeOfOrders >= 0)
                {
                    percentage = 0.055;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }


            double result = volumeOfOrders * percentage;

            if (result >= 0 && volumeOfOrders >= 0)
            {
                Console.WriteLine($"{result:F2}");
            }
            else if (volumeOfOrders < 0)
            {
                Console.WriteLine("error");

            }

        }
    }
}
