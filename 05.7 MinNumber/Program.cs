namespace _05._7_MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = "";
            int minNum = int.MaxValue;
            int currentNum = 0;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                currentNum = int.Parse(command);

                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }


            }

            Console.WriteLine(minNum);

        }
    }
}
