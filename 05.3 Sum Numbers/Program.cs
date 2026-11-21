namespace _05._3_Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int numberSum = 0;
            int currentNum = 0;

            while (startNumber > numberSum)
            {
                currentNum = int.Parse(Console.ReadLine());
                numberSum = numberSum + currentNum;

            }

            Console.WriteLine(numberSum);
        }
    }
}
