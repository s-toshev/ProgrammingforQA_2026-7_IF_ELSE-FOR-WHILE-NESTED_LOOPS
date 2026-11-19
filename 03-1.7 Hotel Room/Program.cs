namespace _03_1._7_Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNightsStay = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            double studioPriceTotal = 0.0;
            double apartmentPriceTotal = 0.0;

            double discountStudio = 1;
            double discountApartment = 1;



            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;

                    if (numberOfNightsStay > 7 && numberOfNightsStay <= 14)
                    {
                        discountStudio = 0.05;

                        studioPriceTotal = (studioPrice - (studioPrice * discountStudio)) * numberOfNightsStay;
                    }
                    else if (numberOfNightsStay > 14)
                    {
                        discountStudio = 0.30;

                        studioPriceTotal = (studioPrice - (studioPrice * discountStudio)) * numberOfNightsStay;
                    }
                    else
                    {
                        studioPriceTotal = studioPrice * numberOfNightsStay;
                    }

                    if (numberOfNightsStay > 14)
                    {
                        discountApartment = 0.10;

                        apartmentPriceTotal = (apartmentPrice - (apartmentPrice * discountApartment)) * numberOfNightsStay;
                    }
                    else
                    {
                        apartmentPriceTotal = apartmentPrice * numberOfNightsStay;
                    }



                    Console.WriteLine($"Apartment: {apartmentPriceTotal:F2} lv.");
                    Console.WriteLine($"Studio: {studioPriceTotal:F2} lv.");

                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;


                    if (numberOfNightsStay > 14)
                    {
                        discountStudio = 0.20;

                        studioPriceTotal = (studioPrice - (studioPrice * discountStudio)) * numberOfNightsStay;
                    }
                    else
                    {
                        studioPriceTotal = studioPrice * numberOfNightsStay;
                    }


                    if (numberOfNightsStay > 14)
                    {
                        discountApartment = 0.10;

                        apartmentPriceTotal = (apartmentPrice - (apartmentPrice * discountApartment)) * numberOfNightsStay;
                    }
                    else
                    {
                        apartmentPriceTotal = apartmentPrice * numberOfNightsStay;
                    }

                    Console.WriteLine($"Apartment: {apartmentPriceTotal:F2} lv.");
                    Console.WriteLine($"Studio: {studioPriceTotal:F2} lv.");

                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;

                    studioPriceTotal = studioPrice * numberOfNightsStay;

                    if (numberOfNightsStay > 14)
                    {
                        discountApartment = 0.10;

                        apartmentPriceTotal = (apartmentPrice - (apartmentPrice * discountApartment)) * numberOfNightsStay;
                    }
                    else
                    {
                        apartmentPriceTotal = apartmentPrice * numberOfNightsStay;
                    }


                    Console.WriteLine($"Apartment: {apartmentPriceTotal:F2} lv.");
                    Console.WriteLine($"Studio: {studioPriceTotal:F2} lv.");
                    break;

            }



        }
    }
}
