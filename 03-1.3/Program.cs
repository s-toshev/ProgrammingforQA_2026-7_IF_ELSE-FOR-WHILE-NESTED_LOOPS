namespace _03_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosePrice = 5.0;
            double daliaPrice = 3.80;
            double tulipPrice = 2.80;
            double narcisPrice = 3.0;
            double gladiolaPrice = 2.50;

            double flowerTotal = 0.0;


            switch (typeOfFlower)
            {
                case "Roses":
                    
                    flowerTotal = rosePrice * numberOfFlowers;
                    if (numberOfFlowers > 80)
                    {
                        flowerTotal = flowerTotal - (flowerTotal * 0.10);
                    }
                    break;

                case "Dahlias":
                    flowerTotal = daliaPrice * numberOfFlowers;

                    if (numberOfFlowers > 90)
                    {
                        flowerTotal = flowerTotal - (flowerTotal * 0.15);
                    }

                    break;

                case "Tulips":
                    flowerTotal = tulipPrice * numberOfFlowers;

                    if (numberOfFlowers > 80)
                    {
                        flowerTotal = flowerTotal - (flowerTotal * 0.15);
                    }

                    break;

                case "Narcissus":
                    flowerTotal = narcisPrice * numberOfFlowers;

                    if (numberOfFlowers < 120)
                    {
                        flowerTotal = flowerTotal + (flowerTotal * 0.15);
                    }

                    break;

                case "Gladiolus":
                    flowerTotal = gladiolaPrice * numberOfFlowers;

                    if (numberOfFlowers < 80)
                    {
                        flowerTotal = flowerTotal + (flowerTotal * 0.20);
                    }

                    break;
            }


            if (budget >= flowerTotal)
            {
                double remainingSum = budget - flowerTotal;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {remainingSum:F2} leva left.");
            }
            else
            {
                double missingMoney = flowerTotal - budget;
                Console.WriteLine($"Not enough money, you need {missingMoney:F2} leva more.");
            }

        }
    }
}
