namespace _03_1._1_Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ticketPremiere = 12.00;
            double ticketNormal = 7.50;
            double ticketDiscount = 5.00;

            string typeOfMovie = Console.ReadLine();
            int numberOfRows = int.Parse(Console.ReadLine());
            int numberOfColumns = int.Parse(Console.ReadLine());
            
            int seats = numberOfColumns * numberOfRows;

            double result = 0;

            if (typeOfMovie == "Premiere")
            {
               result = seats * ticketPremiere;
            }
            else if (typeOfMovie == "Normal")
            {
                result = (seats * ticketNormal);
            }
            else if (typeOfMovie == "Discount")
            {
                result = (seats * ticketDiscount);
            }

            Console.WriteLine($"{result:F2} leva");
        }
    }
}
