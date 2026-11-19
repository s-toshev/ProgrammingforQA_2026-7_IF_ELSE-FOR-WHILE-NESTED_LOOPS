namespace _02_1._3_TimePlus15Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if ((minutes + 15) < 60)
            {
                minutes = minutes + 15;
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                {
                    hours++;
                    if (hours == 24)
                    {
                        hours = 0;
                    }
                    minutes = (minutes + 15) - 60;

                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:{minutes:D2}");
                        
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes}");
                    }
                

            }
            }
        }
    }
}
