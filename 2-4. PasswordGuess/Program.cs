namespace _2_4.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string realPassword = "s3cr3t!P@ssw0rd";

            if (password == realPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
