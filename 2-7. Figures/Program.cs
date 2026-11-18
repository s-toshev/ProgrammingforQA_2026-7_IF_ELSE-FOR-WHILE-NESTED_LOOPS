namespace _2_7.Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double finalResult;

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                finalResult = side * side;
            }
            else if (figure == "rectangle")
            {
                double oneSide = double.Parse(Console.ReadLine());
                double otherSide = double.Parse(Console.ReadLine());
                finalResult = oneSide * otherSide;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                finalResult = Math.PI * (radius * radius);
            }
            else if (figure == "triangle")
            {
                double triangleLength = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                finalResult = (triangleLength * triangleHeight) / 2;
            }
            else
            {
                Console.WriteLine("Invalid figure!");
                return;
            }

            Console.WriteLine("{0:F3}", finalResult);
        }
    }
}
