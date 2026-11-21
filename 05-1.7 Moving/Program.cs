namespace _05_1._7_Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int totalFreeSpace = width * height * length;
            int currentBox = 0;
            string command = "";

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Done" && totalFreeSpace > 0)
                {
                    Console.WriteLine($"{totalFreeSpace} Cubic meters left.");
                    break;
                }
                else if (command != "Done")
                {
                    currentBox = int.Parse(command);

                    totalFreeSpace -= currentBox;

                    if (totalFreeSpace < 0)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(totalFreeSpace)} Cubic meters more.");
                        break;
                    }

                    
                }
            }
        }
    }
}
