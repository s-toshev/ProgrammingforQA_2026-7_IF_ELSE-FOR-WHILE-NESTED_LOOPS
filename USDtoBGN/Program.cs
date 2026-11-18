namespace USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());

            double convertRate = 1.79549;

            double bgn = usd * convertRate;

            Console.WriteLine(bgn);

        }
    }
}
