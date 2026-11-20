namespace _04_1._7_Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            double totalPeople = 0;
            double musalaClimbers = 0;
            double monblanClimbers = 0;
            double kilimanjaroClimbers = 0;
            double k2Climbers = 0;
            double everestClimbers = 0;

            for (int i = 1; i <= numberOfGroups; i++)
            {
                int peoplePerGroup = int.Parse(Console.ReadLine());
                
                totalPeople += peoplePerGroup;

                if (peoplePerGroup <= 5)
                {
                    musalaClimbers += peoplePerGroup;
                }
                else if (peoplePerGroup >= 6 && peoplePerGroup <= 12)
                {
                    monblanClimbers += peoplePerGroup;
                }
                else if (peoplePerGroup >= 13 && peoplePerGroup <= 25)
                {
                    kilimanjaroClimbers += peoplePerGroup;
                }
                else if (peoplePerGroup >= 26 && peoplePerGroup <= 40)
                {
                    k2Climbers += peoplePerGroup;
                }
                else if (peoplePerGroup >= 41)
                {
                    everestClimbers += peoplePerGroup;
                }
            }

            double musalaTotal = musalaClimbers / totalPeople * 100;
            double monblanTotal = monblanClimbers / totalPeople * 100;
            double kilimanjaroTOtal = kilimanjaroClimbers / totalPeople * 100;
            double k2Total = k2Climbers / totalPeople * 100;
            double everestTotal = everestClimbers / totalPeople * 100;

            Console.WriteLine($"{musalaTotal:F2}%");
            
            Console.WriteLine($"{monblanTotal:F2}%");

            Console.WriteLine($"{kilimanjaroTOtal:F2}%");

            Console.WriteLine($"{k2Total:F2}%");

            Console.WriteLine($"{everestTotal:F2}%");




        }
    }
}
