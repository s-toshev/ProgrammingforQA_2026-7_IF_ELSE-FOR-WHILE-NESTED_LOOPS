namespace _04_1._1_Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 7; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
