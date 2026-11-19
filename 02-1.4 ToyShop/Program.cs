namespace _02_1._4_ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double jigsawPrice = 2.60;
            double talkingDollPrice = 3;
            double bearToyPrice = 4.10;
            double minionToyPrice = 8.20;
            double truckToyPrice = 2;

            double tripPrice = double.Parse(Console.ReadLine());
           
            int numberOfJigsaws = int.Parse(Console.ReadLine());
            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            int numberOfBearToys = int.Parse(Console.ReadLine());
            int numberOfMinionToys = int.Parse(Console.ReadLine()); 
            int numberOfTruckToys = int.Parse(Console.ReadLine());

            int totalOrderOfToys = numberOfBearToys + numberOfJigsaws + numberOfMinionToys + numberOfTruckToys + numberOfTalkingDolls;

            double orderTotal = 0;
           
            double jigsawIncome = jigsawPrice * numberOfJigsaws;
            double talkingDollIncome = talkingDollPrice * numberOfTalkingDolls;
            double bearToyIncome = bearToyPrice * numberOfBearToys;
            double minionToyIncome = minionToyPrice * numberOfMinionToys;
            double truckToyIncome = truckToyPrice * numberOfTruckToys;

            orderTotal = jigsawIncome + talkingDollIncome + bearToyIncome + minionToyIncome + truckToyIncome;
           

            if (totalOrderOfToys >= 50)
            {
                orderTotal = orderTotal - (orderTotal * 0.25);    
            }

            double orderTotalMinusRent = orderTotal - (orderTotal * 0.10);


            if (orderTotalMinusRent >= tripPrice)
            {
                double moneyLeft = orderTotalMinusRent - tripPrice;

                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                double moneyMissing = tripPrice - orderTotalMinusRent;

                Console.WriteLine($"Not enough money! {moneyMissing:F2} lv needed.");
            }
        }
    }
}
