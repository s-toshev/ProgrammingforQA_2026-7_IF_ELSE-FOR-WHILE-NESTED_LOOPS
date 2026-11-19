namespace _03_1._2_SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int outsideDegrees = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            
            string outfit = "";
            string shoes = "";

            switch (timeOfDay)
            {
                case "Morning":
                  
                    if (outsideDegrees >= 10 && outsideDegrees <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (outsideDegrees > 18 && outsideDegrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (outsideDegrees >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }

                    break;

                case "Afternoon":

                    if (outsideDegrees >= 10 && outsideDegrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (outsideDegrees > 18 && outsideDegrees <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (outsideDegrees >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }

                    break;

                case "Evening":

                    if (outsideDegrees >= 10 && outsideDegrees <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (outsideDegrees > 18 && outsideDegrees <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (outsideDegrees >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }

                    break;
            }

            Console.WriteLine($"It's {outsideDegrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
