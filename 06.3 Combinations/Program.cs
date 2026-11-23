namespace _06._3_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int iCount = 0;
            int jCount = 0;
            int kCount = 0;
            int totalCount = 0;

            for (int i = 0; i <= n; i++)
            {
                iCount++;

                for (int j = 0; j <= n; j++)
                {
                    jCount++;

                    for (int k = 0; k <= n; k++)
                    {
                        kCount++;
                        if (i + j + k == n)
                        {
                            totalCount++;

                        }
                    }

                }
            }
                
            Console.WriteLine(totalCount);

        }
    }
}
