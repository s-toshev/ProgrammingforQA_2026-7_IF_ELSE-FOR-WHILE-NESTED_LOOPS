namespace _05._4_Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNum = 0;

            while (true)
            {
                

                startNum = startNum * 2 + 1;

                if (startNum > number)
                {
                    break;
                }

                Console.WriteLine(startNum);
                
                
            } 
        }
    }
}
