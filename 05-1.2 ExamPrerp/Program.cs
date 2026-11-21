namespace _05_1._2_ExamPrerp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int badGradeCounter = 0;
            int goodGradeCounter = 0;
            string lastTask = "";
            int grade = 0;

            double goodGrade = 0.0;

            while (true)
            {
                string task = Console.ReadLine();
                
                if (task != "Enough")
                {
                     grade = int.Parse(Console.ReadLine());
                }
                


                if (grade <= 4)
                {
                    badGradeCounter++;

                    if (badGradeCounter == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGradeCounter} poor grades.");
                        break;
                    }
                }

                if (task != "Enough")
                {
                    goodGradeCounter++;
                    goodGrade += grade;
                }

                   

                if (task == "Enough")
                {
                    Console.WriteLine($"Average score: {goodGrade/goodGradeCounter:f2}\nNumber of problems: {goodGradeCounter}\nLast problem: {lastTask}\n");
                    break;
                }

                lastTask = task;

            }
        }
    }
}
