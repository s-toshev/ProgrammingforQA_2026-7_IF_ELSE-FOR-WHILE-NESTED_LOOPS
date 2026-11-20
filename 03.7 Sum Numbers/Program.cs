namespace _03._7_Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtyOfNumbers = int.Parse(Console.ReadLine());
            int numbers;
            int result = 0;

            for (int i = 1; i <= qtyOfNumbers; i++)
            {
                numbers = int.Parse(Console.ReadLine());

                result = result + numbers;


            }

            Console.WriteLine(result);
        }
    }
}
