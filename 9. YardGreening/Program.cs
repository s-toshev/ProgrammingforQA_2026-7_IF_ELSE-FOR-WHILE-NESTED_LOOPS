namespace _9._YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double sqMforGreening = double.Parse(Console.ReadLine());

            double pricePerSqM = 7.61;

            double discount = 0.18;

            double basePrice = sqMforGreening * pricePerSqM;
            double discountSum = basePrice*discount;
            double finalPrice = basePrice - discountSum;

            Console.WriteLine($"The final price is: {finalPrice} lv.");

            Console.WriteLine($"The discount is: {discountSum} lv.");



        }
    }
}
