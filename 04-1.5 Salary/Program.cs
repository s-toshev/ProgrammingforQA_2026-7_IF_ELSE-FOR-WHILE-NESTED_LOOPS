namespace _04_1._5_Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int penalitySum = 0;

            for (int i = 1; i <= openTabs; i++)
            {
                string webSite = Console.ReadLine();

                if (webSite == "Facebook")
                {
                    penalitySum = penalitySum + 150;
                }
                else if (webSite == "Instagram")
                {
                    penalitySum = penalitySum + 100;

                }
                else if (webSite == "Reddit")
                {
                    penalitySum = penalitySum + 50;

                }

                if (salary <= penalitySum)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;


                }

            }

            if (salary > penalitySum)
            {
                Console.WriteLine(salary - penalitySum);

            }

        }
    }
}
