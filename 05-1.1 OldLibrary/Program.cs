namespace _05_1._1_OldLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            string currentBook = "";
            int bookCount = 0;

            while (true)
            {
                currentBook = Console.ReadLine();
                bookCount++;

                if (currentBook == favBook)
                {
                    Console.WriteLine($"You checked {bookCount - 1} books and found it.");
                    break;
                }

                if (currentBook == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!\nYou checked {bookCount - 1} books.");
                    break;
                }



            }
        }
    }
}
