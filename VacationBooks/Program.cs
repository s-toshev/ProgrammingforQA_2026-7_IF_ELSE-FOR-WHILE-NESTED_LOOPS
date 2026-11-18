namespace VacationBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int totalTimePerBook = numberOfPages / pagesPerHour;
            int hoursPerDay = totalTimePerBook / numberOfDays;


            Console.WriteLine(hoursPerDay);



        }
    }
}
