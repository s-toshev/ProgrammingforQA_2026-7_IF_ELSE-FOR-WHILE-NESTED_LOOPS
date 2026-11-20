namespace _04_1._8_Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGames = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int totalPoints = startingPoints;
            double winCount = 0;
            double gameCount = 0;

            for (int i = 1; i <= numberOfGames; i++)
            {
                string gameStage = Console.ReadLine();

                if (gameStage == "W")
                {
                    winCount++;
                    gameCount++;
                    totalPoints = totalPoints + 2000;
                }
                else if (gameStage == "F")
                {
                    gameCount++;
                    totalPoints = totalPoints + 1200;
                }
                else if (gameStage == "SF")
                {
                    gameCount++;
                    totalPoints = totalPoints + 720;
                }
            }

            double averagePoints = (totalPoints - startingPoints) / numberOfGames;
            double winPercentage = winCount / gameCount * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{winPercentage:F2}%");


        }
    }
}
