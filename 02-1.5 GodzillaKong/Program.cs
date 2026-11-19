namespace _02_1._5_GodzillaKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int participants = int.Parse(Console.ReadLine());
            double clothesPricePerParticipant = double.Parse(Console.ReadLine());

            double decorPrice = movieBudget * 0.10;

            if (participants > 150)
            {
                clothesPricePerParticipant = clothesPricePerParticipant - (clothesPricePerParticipant * 0.10);
            }

            double clothesTotalPrice = participants * clothesPricePerParticipant;


            if (clothesTotalPrice + decorPrice > movieBudget)
            {
                double missingMoney = (clothesTotalPrice + decorPrice) - movieBudget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {missingMoney:F2} leva more.");
            }
            else if (clothesTotalPrice + decorPrice <= movieBudget)
            {
                double remainingMoney = movieBudget - (clothesTotalPrice + decorPrice);
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remainingMoney:F2} leva left.");

            }
        }
    }
}
