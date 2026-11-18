namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int widith = int.Parse(Console.ReadLine()); 
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double percentageParsed = percentage / 100;
            double aquariumVolume = length* widith * height;
            double volumeInLiters = aquariumVolume * 0.001;
            double neededLiters = volumeInLiters * (1 - percentageParsed);

            Console.WriteLine(neededLiters);






        }
    }
}
