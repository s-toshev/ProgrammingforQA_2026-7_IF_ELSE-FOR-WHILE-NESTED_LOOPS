namespace _05_1._3_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
           
            int daysPassed = 0;
            int consecutiveSpendingDays = 0;

            while (true)
            {
                string action = Console.ReadLine();
                double moneyForSpendOrSave = double.Parse(Console.ReadLine());

                daysPassed++;

                if (action == "save")
                {
                    consecutiveSpendingDays = 0;
                    availableMoney += moneyForSpendOrSave;

                    if (availableMoney >= moneyNeededForVacation)
                    {
                        Console.WriteLine($"You saved the money for {daysPassed} days.");
                        break;
                    }

                }
                else if (action == "spend")
                {
                    consecutiveSpendingDays++;
                    availableMoney -= moneyForSpendOrSave;

                    if (consecutiveSpendingDays == 5)
                    {
                        Console.WriteLine($"You can't save the money.\n{daysPassed}");
                        break;
                    }

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                }
            }
        }
    }
}
