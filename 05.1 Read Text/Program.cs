namespace _05._1_Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(input);
                }

            }

        }
    }
}
