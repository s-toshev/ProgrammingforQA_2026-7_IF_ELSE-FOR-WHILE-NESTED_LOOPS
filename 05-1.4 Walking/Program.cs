namespace _05_1._4_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int totalSteps = 0;
            int goal = 10000;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;

                    if (totalSteps >= 10000)
                    {
                        Console.WriteLine($"Goal reached! Good job!\n{totalSteps - 10000} steps over the goal!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                        break;
                    }

                }
                else
                {
                    int dailySteps = int.Parse(input);
                    totalSteps += dailySteps;

                    if (totalSteps >= 10000)
                    {
                        Console.WriteLine($"Goal reached! Good job!\n{totalSteps - 10000} steps over the goal!");
                        break;
                    }

                }


            }
        }
    }
}
