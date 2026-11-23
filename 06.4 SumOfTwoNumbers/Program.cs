using System.Threading.Channels;

namespace _06._4_SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingInterval = int.Parse(Console.ReadLine());
            int endingInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int i, j;
            int combinationsCounter = 0;
            bool isFound = false;

            for (i = startingInterval; i <= endingInterval; i++)
            {


                for (j = startingInterval; j <= endingInterval; j++)
                {
                    combinationsCounter++;

                    if (i + j == magicNumber)
                    {
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    Console.Write($"Combination N:{combinationsCounter} ");
                    Console.WriteLine($"({i} + {j} = {magicNumber})");
                    return;
                }
            }

            Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicNumber}");

        }
    }
}
