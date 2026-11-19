namespace _03_1._9_Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double roomForOne = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;

            int daysOfStay = int.Parse(Console.ReadLine()); 
            string typeOfAccomodation = Console.ReadLine();
            string rating = Console.ReadLine();

            int nightsSpent = daysOfStay - 1;

            double totalSpent = 0.0;
            double finalSum = 0.0;

           if(typeOfAccomodation == "room for one person")
            {
                totalSpent = roomForOne * nightsSpent;  
                
            }
           else if (typeOfAccomodation == "apartment")
            {
                if (nightsSpent < 10)
                {
                    totalSpent = (apartment * nightsSpent) - ((apartment * nightsSpent) * 0.30);
                }
                else if(nightsSpent >= 10 && nightsSpent <=15)
                {
                    totalSpent = (apartment * nightsSpent) - ((apartment * nightsSpent) * 0.35);
                }
                else if (nightsSpent > 15)
                {
                    totalSpent = (apartment * nightsSpent) - ((apartment * nightsSpent) * 0.50);
                }
            }
           else if (typeOfAccomodation == "president apartment")
            {
                if (nightsSpent < 10)
                {
                    totalSpent = (presidentApartment * nightsSpent) - ((presidentApartment * nightsSpent) * 0.10);
                }
                else if (nightsSpent >= 10 && nightsSpent <= 15)
                {
                    totalSpent = (presidentApartment * nightsSpent) - ((presidentApartment * nightsSpent) * 0.15);
                }
                else if (nightsSpent > 15)
                {
                    totalSpent = (presidentApartment * nightsSpent) - ((presidentApartment * nightsSpent) * 0.20);
                }
            }


           if (rating == "positive")
            {
                finalSum = totalSpent + (totalSpent * 0.25);
            }
           else if (rating == "negative")
            {
                finalSum = totalSpent - (totalSpent * 0.10);
            }


            Console.WriteLine($"{finalSum:F2}");

        }
    }
}
