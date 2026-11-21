namespace _05._8_Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string studentName = Console.ReadLine();
            double grade = 0.0;
            int gradeCounter = 0;
            double gradeTotal = 0.0;
            int failCounter = 0;

            while (true)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    
                    failCounter++;


                    if (failCounter >= 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {gradeCounter} grade");
                        break;
                    }
                }

                gradeTotal += grade;

                gradeCounter++;

                if (gradeCounter == 12)
                {
                    Console.WriteLine($"{studentName} graduated. Average grade: {(gradeTotal/12):f2}");

                    break;
                }

            }






        }
    }
}
