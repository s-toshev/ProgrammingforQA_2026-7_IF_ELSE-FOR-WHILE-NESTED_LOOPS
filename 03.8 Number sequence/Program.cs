namespace _03._8_Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtyOfNumbers = int.Parse(Console.ReadLine());
            int numbers = 0;
            int maxNumber = 0;
            int minNumber = 0;

            for (int i = 1; i <= qtyOfNumbers; i++)
            {
                numbers = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    maxNumber = numbers;
                }

                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }

                if (i == 1)
                {
                    minNumber = numbers;
                }

                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
