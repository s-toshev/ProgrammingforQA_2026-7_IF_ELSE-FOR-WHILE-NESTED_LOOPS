namespace _05._2_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();
            string checkPassword = "";

            while (password != checkPassword)
            {
                checkPassword = Console.ReadLine();
            }

            if (password == checkPassword)
            {
                Console.WriteLine($"Welcome {userName}!");
            }
        }
    }
}
