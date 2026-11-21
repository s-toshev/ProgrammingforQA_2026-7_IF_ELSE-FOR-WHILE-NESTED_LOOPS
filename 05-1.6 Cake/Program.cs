namespace _05_1._6_Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());

            int cakeSize = cakeLength * cakeWidth;
            string command = "";
            int pieceTaken = 0;

            while (true)
            {
                command = Console.ReadLine();

                command = command.ToUpper();

                if (command != "STOP")
                {
                    pieceTaken = int.Parse(command);
                    cakeSize = cakeSize - pieceTaken;

                    if (cakeSize < 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
                        break;
                    }

                }
                else if (command == "STOP")
                {
                    Console.WriteLine($"{cakeSize} pieces are left.");
                    break;
                }


            }
        }
    }
}
