namespace radToDeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double degResult = rad * 180/Math.PI;

            Console.WriteLine(degResult);




        }
    }
}
