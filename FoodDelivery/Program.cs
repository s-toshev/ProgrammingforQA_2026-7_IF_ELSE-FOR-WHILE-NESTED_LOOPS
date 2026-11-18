namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegeMenu = 8.15;
            double deliveryPrice = 2.50;

            double totalBill;

           

            int numberOfChickenMenus = int.Parse(Console.ReadLine());
            int numberOfFishMenus = int.Parse(Console.ReadLine());
            int numberOfVegeMenus = int.Parse(Console.ReadLine());

            double priceTotalChickenMenu = chickenMenu * numberOfChickenMenus;
            double priceTotalFishMenu = fishMenu * numberOfFishMenus;
            double priceTotalVegeMenu = vegeMenu * numberOfVegeMenus;

            totalBill = priceTotalChickenMenu + priceTotalFishMenu + priceTotalVegeMenu;

            double dessertPrice = totalBill * 0.20;

            double priceFinal = totalBill + dessertPrice + deliveryPrice;

            Console.WriteLine(priceFinal);

        }
    }
}
