namespace _02_1._1_SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstCompetitorTime = int.Parse(Console.ReadLine());
            int secondCompetitorTime = int.Parse(Console.ReadLine());
            int thirdCompetitorTime = int.Parse(Console.ReadLine());

            int timeSum = firstCompetitorTime + secondCompetitorTime + thirdCompetitorTime;

            double minutes = Math.Floor(timeSum / 60.0);

            int seconds = timeSum % 60;

            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + seconds);
            }
            else 
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
               

        }
    }
}
