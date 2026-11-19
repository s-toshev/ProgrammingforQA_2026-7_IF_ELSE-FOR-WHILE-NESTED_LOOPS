namespace _02_1._2_BonusPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (startingPoints <= 100)
            {
                bonusPoints = 5;
            }
            else if (startingPoints > 100 && startingPoints <= 1000)
            {
                bonusPoints = startingPoints * 0.20;
            }
            else if (startingPoints > 1000)
            {
                bonusPoints = startingPoints * 0.10;
            }

            if (startingPoints % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }

            if (startingPoints % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }


            Console.WriteLine(bonusPoints);
            Console.WriteLine(startingPoints+bonusPoints);

        }
    }
}
