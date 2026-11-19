namespace _03._10_InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 

            if (number <100 && number > 0 || number > 200 || number < 0){
                Console.WriteLine("invalid");
            }
            
        }
    }
}
