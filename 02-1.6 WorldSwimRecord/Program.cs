namespace _02_1._6_WorldSwimRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double recordInSeconds = double.Parse(Console.ReadLine());
           double distanceInMeters = double.Parse(Console.ReadLine());
           double timeInSeconds = double.Parse(Console.ReadLine());

            double distanceLost = Math.Floor(distanceInMeters / 15.0);
            double secondsLost = distanceLost * 12.5;

            double finalTime = secondsLost + (timeInSeconds*distanceInMeters);

            if (finalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:F2} seconds.");
            }
            else if (finalTime >= recordInSeconds) 
            {
                double timeLeft = (finalTime - recordInSeconds);
                Console.WriteLine($"No, he failed! He was {timeLeft:F2} seconds slower.");
            }

        }
    }
}
