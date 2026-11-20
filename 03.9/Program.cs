namespace _03._9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int qtyNum = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int numInput = 0;

            for (int i = 1; i <= qtyNum * 2; i++)
            {

                numInput = int.Parse(Console.ReadLine());


                if (i <= qtyNum)
                {
                    sum1 = sum1 + numInput;
                }

                if (i > qtyNum && i <= qtyNum * 2)
                {
                    sum2 = sum2 + numInput;
                }

            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                int result = Math.Abs(sum1 - sum2);

                Console.WriteLine($"No, diff = {result}");
            }

        }
    }
}
