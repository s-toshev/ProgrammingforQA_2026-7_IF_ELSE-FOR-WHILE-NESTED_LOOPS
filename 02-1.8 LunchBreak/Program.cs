namespace _02_1._8_LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());  
            int breakLength = int.Parse(Console.ReadLine());

            double lunchTime = breakLength * 0.125;
            double restTime = breakLength * 0.25;

            double timeLeft = breakLength - lunchTime - restTime;

            if (timeLeft >= episodeLength)
            {
                double freeTimeLeft = Math.Ceiling(timeLeft - episodeLength);
                Console.WriteLine($"You have enough time to watch {movieName} and left with {freeTimeLeft} minutes free time.");
            }
            else if (timeLeft < episodeLength)
            {
                double timeNotEnough = Math.Ceiling(episodeLength - timeLeft);
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {timeNotEnough} more minutes.");

            }
        }
    }
}
