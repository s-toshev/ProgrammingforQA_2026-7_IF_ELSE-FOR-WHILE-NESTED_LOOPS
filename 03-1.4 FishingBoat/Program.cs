namespace _03_1._4_FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMen = int.Parse(Console.ReadLine());

            int boatPrice = 0;
            double discount = 0.0;

            if (season == "Spring")
            {
                boatPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatPrice = 4200;
            }
            else if (season == "Winter")
            {
                boatPrice = 2600;
            }

            if (fisherMen > 0 && fisherMen <= 6)
            {
                discount = 0.10;


            }
            else if (fisherMen >= 7 && fisherMen <= 11)
            {
                discount = 0.15;
            }
            else if (fisherMen >= 12 && fisherMen <= 18)
            {
                discount = 0.25;
            }

            double tempSum = boatPrice - (boatPrice * discount);
            double finalCost = 0.0;

            if (fisherMen % 2 == 0 && (season == "Summer" || season == "Spring" || season == "Winter"))
            {

                finalCost = tempSum - (tempSum * 0.05);

            }
            else
            {
                finalCost = tempSum;
            }

            if (groupBudget >= finalCost)
            {
                Console.WriteLine($"Yes! You have {(groupBudget - finalCost):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(finalCost - groupBudget):F2} leva.");

            }

        }
    }
}
