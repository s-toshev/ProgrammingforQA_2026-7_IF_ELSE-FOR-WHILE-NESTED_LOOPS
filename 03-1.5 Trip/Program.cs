namespace _03_1._5_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double moneySpent = 0.0;
            string accomodationType = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
              
                if (season == "summer")
                {
                    accomodationType = "Camp";
                    moneySpent = budget * 0.30;
                }
                else if (season == "winter")
                {
                    accomodationType = "Hotel";
                    moneySpent = budget * 0.70;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    accomodationType = "Camp";
                    moneySpent = budget * 0.40;
                }
                else if (season == "winter")
                {
                    accomodationType = "Hotel";
                    moneySpent = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                accomodationType = "Hotel";
                moneySpent = budget * 0.90;

            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accomodationType} - {moneySpent:F2}");


        }
    }
}
