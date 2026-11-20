namespace _04_1._4_Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageNum = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            int evenBdayMoney = 0;
            int brotherTax = 0;
            int oddBdayCounter = 0;
            double toysMoney = 0.0;
            double savedMoneyTotal = 0.0;

            for (int i = 1; i <= ageNum; i++)
            {

                if (i % 2 == 0)
                {


                    evenBdayMoney = evenBdayMoney + (i * 10) / 2;
                    brotherTax++;
                   
                }

                if (i % 2 != 0)
                {
                    oddBdayCounter++;
                }

            }
            evenBdayMoney = evenBdayMoney - brotherTax;

            toysMoney = oddBdayCounter * pricePerToy;

            savedMoneyTotal = toysMoney + evenBdayMoney;

            if (savedMoneyTotal >= washerPrice)
            {
                Console.Write("Yes! ");
                Console.Write($"{(savedMoneyTotal - washerPrice):F2}");
            }
            else
            {
                Console.Write("No! ");
                Console.Write($"{(washerPrice - savedMoneyTotal):F2}");
            }


        }
    }
}
