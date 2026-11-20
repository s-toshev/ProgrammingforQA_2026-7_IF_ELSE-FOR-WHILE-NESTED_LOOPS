using System.Collections;

namespace _04_1._2_Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int maxNum = 0;
            int sum = 0;
            ArrayList arr = new ArrayList();

            for (int i = 1; i <= num; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNum)
                {
                    maxNum = currentNumber;
                }


                arr.Add(currentNumber);



            }


            arr.Remove(maxNum);

            foreach (int item in arr)
            {
                sum = sum + item;
            }

            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                int finalSum = Math.Abs(sum - maxNum);

                Console.WriteLine("No");
                Console.WriteLine($"Diff = {finalSum}");
            }

        }
    }
}
