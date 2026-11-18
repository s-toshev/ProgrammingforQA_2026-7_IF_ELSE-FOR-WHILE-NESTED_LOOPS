namespace BasketBallEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int yearlyTax = int.Parse(Console.ReadLine());

            double shoesPrice = yearlyTax - (yearlyTax * 0.40);
            double clothesPrice = shoesPrice - (shoesPrice*0.20);
            double ballPrice = clothesPrice - (clothesPrice * 0.75);
            double basketAccessories = ballPrice - (ballPrice * 0.80);

            double totalExpenses = shoesPrice + clothesPrice + ballPrice + basketAccessories + yearlyTax;

            Console.WriteLine(totalExpenses);







        }
    }
}
