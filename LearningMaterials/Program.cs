namespace LearningMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packagesPens = int.Parse(Console.ReadLine());
            int packagesMarkers = int.Parse(Console.ReadLine());
            int litersOfDetergent = int.Parse(Console.ReadLine());
            
            int deductionPercentage = int.Parse(Console.ReadLine());
            double percentageParsed = deductionPercentage / 100.0;
           
            double pricePensPerPack = 5.80;
            double priceMarkersPerPack = 7.20;
            double detergentPrice = 1.20;

            double penPriceFinal = pricePensPerPack * packagesPens;
            double markerPriceFinal = priceMarkersPerPack * packagesMarkers;
            double detergentPriceFinal = detergentPrice * litersOfDetergent;

            double finalPriceNoPromo = penPriceFinal + markerPriceFinal + detergentPriceFinal;
            double deduction = finalPriceNoPromo * percentageParsed;

            double finalPriceDeducted = finalPriceNoPromo - deduction;

            Console.WriteLine(finalPriceDeducted);

        }
    }
}
