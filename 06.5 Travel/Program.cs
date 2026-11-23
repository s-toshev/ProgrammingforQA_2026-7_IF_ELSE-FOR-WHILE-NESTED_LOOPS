namespace _06._5_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string destination = "";
            double totalSavedMoney = 0;
            double totalBudget = 0;
            double budget = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                  

                    return;
                }

                 budget = double.Parse(Console.ReadLine());

                totalBudget += budget;

                while (totalBudget > totalSavedMoney)
                {
                    double currentSavedMoney = double.Parse(Console.ReadLine());

                    totalSavedMoney += currentSavedMoney;

                    destination = input;

                    if (totalSavedMoney >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        totalSavedMoney = 0;
                        break;
                    }
                }

            }
        }
    }
}
