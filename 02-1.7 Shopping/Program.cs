namespace _02_1._7_Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int videoCardPrice = 250;
            double peterBudget = double.Parse(Console.ReadLine());
            int videoCardNumber = int.Parse(Console.ReadLine());
            int cpuNumber = int.Parse(Console.ReadLine());
            int ramNumber = int.Parse(Console.ReadLine());

            double cpuPrice = (videoCardPrice * videoCardNumber) * 0.35;
            double ramPrice = (videoCardPrice * videoCardNumber) * 0.10;

            double videoCardTotal = videoCardNumber * videoCardPrice;
            double cpuTotal = cpuPrice * cpuNumber;
            double ramTotal = ramPrice * ramNumber;

            double totalMoneySpent = videoCardTotal + cpuTotal + ramTotal;

            if (videoCardNumber > cpuNumber)
            {
                totalMoneySpent = totalMoneySpent - (totalMoneySpent * 0.15);

                if (totalMoneySpent <= peterBudget)
                {
                    double moneyLeft = peterBudget - totalMoneySpent;

                    Console.WriteLine($"You have {moneyLeft:F2} leva left!");
                }
                else
                {
                    double moneyMissing = totalMoneySpent - peterBudget;
                    Console.WriteLine($"Not enough money! You need {moneyMissing:F2} leva more!");
                }

            }
            else
            {

                if (totalMoneySpent <= peterBudget)
                {
                    double moneyLeft = peterBudget - totalMoneySpent;

                    Console.WriteLine($"You have {moneyLeft:F2} leva left!");
                }
                else
                {
                    double moneyMissing = totalMoneySpent - peterBudget;
                    Console.WriteLine($"Not enough money! You need {moneyMissing:F2} leva more!");
                }

            }


        }
    }
}
