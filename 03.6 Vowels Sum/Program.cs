namespace _03._6_Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
          
            int count = 0;

        

            for (int i = 0; i <= text.Length - 1; i++)
            {
                char symbol = text[i];

                if (symbol == 'a')
                {
                    count = count + 1;
                }
                else if (symbol == 'e')
                {
                    count = count + 2;
                }
                else if (symbol == 'i')
                {
                    count = count + 3;
                }
                else if (symbol == 'o')
                {
                    count = count + 4;
                }
                else if (symbol == 'u')
                {
                    count = count + 5;
                }
            }

            Console.WriteLine(count);
        }
    }
}
