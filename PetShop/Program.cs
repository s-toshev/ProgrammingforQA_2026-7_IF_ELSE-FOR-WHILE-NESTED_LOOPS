namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodCansDogs =int.Parse(Console.ReadLine());
            int catFoodCans = int.Parse(Console.ReadLine());
            double dogPrice = 2.50;
            int catPrice = 4;
            double dogPriceFinal = dogPrice * foodCansDogs;
            int catPriceFinal = catPrice * catFoodCans;

            double endSum = dogPriceFinal + catPriceFinal;

            Console.WriteLine($"{endSum} lv.");

        }
    }
}
