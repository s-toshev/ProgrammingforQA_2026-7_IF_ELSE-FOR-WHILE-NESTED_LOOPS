namespace FirstFourApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.)

            Console.WriteLine("Hello SoftUni");


            //2.) 

            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);

            //3.)

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a * b;
            Console.Write("The Result is: ");
            Console.WriteLine(c);

            //4.)
            int i1 = int.Parse(Console.ReadLine());
            double d1 = i1 * 2.54;

            Console.Write("The result is: ");
            Console.WriteLine(d1);

        }
    }
}
