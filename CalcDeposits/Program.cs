namespace CalcDeposits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositInMonths = int.Parse(Console.ReadLine());
            double yearlyPercentage =double.Parse(Console.ReadLine());
            double yearlyPercentageParsed = yearlyPercentage / 100;
            double totalLihva = depositSum * yearlyPercentageParsed;
            double lihvaOneMonth = totalLihva / 12;


            double finalSum = depositSum + (depositInMonths * lihvaOneMonth);

            Console.WriteLine(finalSum);
        }
    }
}
