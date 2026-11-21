namespace _05._5_AccountBallance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double sum = 0.0;
            double totalSum = 0.0;


            while (true)
            {

                input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }

                sum = double.Parse(input);

                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {sum:f2}");

                totalSum += sum;





            }

            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
