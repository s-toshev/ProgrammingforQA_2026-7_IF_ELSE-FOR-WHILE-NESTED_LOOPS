namespace _05._6_MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command ="";
            int maxNum = int.MinValue;
            int currentNum = 0; 

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                currentNum = int.Parse(command);

                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }


            }

            Console.WriteLine(maxNum);

        }
    }
}
