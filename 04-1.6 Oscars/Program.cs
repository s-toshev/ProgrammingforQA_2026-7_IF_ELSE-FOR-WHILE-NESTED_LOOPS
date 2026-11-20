namespace _04_1._6_Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int numberOfJury = int.Parse(Console.ReadLine());
            double totalPoints = academyPoints;
            string juryName;
            double juryPoints;

            for (int i = 1; i <= numberOfJury; i++)
            {
                juryName = Console.ReadLine();
                juryPoints = double.Parse(Console.ReadLine());

                double juryPointsTransformed = (juryName.Length * juryPoints) / 2;

                totalPoints = totalPoints  + juryPointsTransformed;


                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
                    return;
                }
            }


            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - totalPoints):F1} more!");
            }

        }
    }
}
