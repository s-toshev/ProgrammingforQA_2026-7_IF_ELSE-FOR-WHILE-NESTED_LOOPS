namespace _6.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double protectionNylonPrice = 1.50;
            double paintPrice = 14.50;
            double paintThinnerPrice = 5.00;

            int nylonNeeded = int.Parse(Console.ReadLine()) + 2;
            int paintNeeded = int.Parse(Console.ReadLine());
            int thinnerNeeded = int.Parse(Console.ReadLine());
            int hoursForWorkersToCompleteTheJob = int.Parse(Console.ReadLine());

            double paintNeededTotal = paintNeeded + (paintNeeded * 0.10);

            double finalPriceProtectionNylon = protectionNylonPrice * nylonNeeded;
            double finalPaintPrice = paintPrice * paintNeededTotal;
            double finalThinnerPrice = paintThinnerPrice * thinnerNeeded;
            double packPriceAddToTotal = 0.40;

            double totalMaterialsPrice = packPriceAddToTotal + finalPriceProtectionNylon + finalPaintPrice + finalThinnerPrice;
            double payPerHourWorkers = totalMaterialsPrice * 0.30;
            double totalPayWorkers = payPerHourWorkers * hoursForWorkersToCompleteTheJob;

            double totalSpent = totalMaterialsPrice + totalPayWorkers;

            Console.WriteLine(totalSpent);


        }
    }
}
