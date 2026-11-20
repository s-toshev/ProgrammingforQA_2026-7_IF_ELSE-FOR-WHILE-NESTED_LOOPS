namespace _04_1._3_Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double lowerThan200 = 0.0;
            double between200to399 = 0.0;
            double between400and599 = 0.0;
            double between600and799 = 0.0;
            double equalOrMoreThan800 = 0.0;
            double totalSum = 0.0;

            for (int i = 1; i <= numbers; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                
                if (currentNum < 200)
                {
                    lowerThan200++;
                }
                else if (currentNum >=200 && currentNum <= 399)
                {
                    between200to399++;
                }
                else if (currentNum >=400 && currentNum <= 599)
                {
                    between400and599++;
                }
                else if (currentNum >=600 &&  currentNum <= 799)
                {
                    between600and799++;
                }
                else if (currentNum >= 800)
                {
                   equalOrMoreThan800++;
                }


            }

            totalSum = lowerThan200 + between200to399 + between400and599 + between600and799 + equalOrMoreThan800;

            double p1 = lowerThan200 / totalSum * 100;
            double p2 = between200to399 / totalSum * 100;
            double p3 = between400and599 / totalSum * 100;
            double p4 = between600and799 / totalSum * 100;
            double p5 = equalOrMoreThan800 / totalSum * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");

        }
    }
}
