namespace _03_1._8_On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalminute = int.Parse(Console.ReadLine());

            int examTimeInMinutes = (hourOfExam * 60) + minuteOfExam;
            int arrivalTimeInMinutes = (arrivalHour * 60) + arrivalminute;

            if (examTimeInMinutes > arrivalTimeInMinutes)
            {

                if (examTimeInMinutes - arrivalTimeInMinutes <= 30)
                {
                    Console.WriteLine("On time");

                    if (examTimeInMinutes - arrivalTimeInMinutes < 60)
                    {
                        Console.WriteLine($"{examTimeInMinutes - arrivalTimeInMinutes} minutes before the start");
                    }

                }
                else if (examTimeInMinutes - arrivalTimeInMinutes > 30 && examTimeInMinutes - arrivalTimeInMinutes < 60)
                {
                    Console.WriteLine("Early");

                    if (examTimeInMinutes - arrivalTimeInMinutes < 60)
                    {
                        Console.WriteLine($"{examTimeInMinutes - arrivalTimeInMinutes} minutes before the start");
                    }
                }

                int minutes;

                if (examTimeInMinutes - arrivalTimeInMinutes >= 60)
                {
                    int hoursCheck = examTimeInMinutes - arrivalTimeInMinutes;

                    int hours = hoursCheck / 60;
                     minutes = hoursCheck % 60;

               


                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
            }

            if (arrivalTimeInMinutes > examTimeInMinutes)
            {
                
                if (arrivalTimeInMinutes - examTimeInMinutes  >= 60)
                {
                    int hoursCheck1 = arrivalTimeInMinutes - examTimeInMinutes;

                    int hours1 = hoursCheck1 / 60;
                    int minutes1 = hoursCheck1 % 60;




                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours1}:{minutes1:D2} hours after the start");
                }


                if (arrivalTimeInMinutes - examTimeInMinutes < 60)
                {
                    Console.WriteLine("Late");

                    if (arrivalTimeInMinutes - examTimeInMinutes < 60)
                    {
                        Console.WriteLine($"{arrivalTimeInMinutes - examTimeInMinutes} minutes after the start");
                    }
                }

            }


            if (hourOfExam == arrivalHour && minuteOfExam == arrivalminute)
            {
                Console.WriteLine("On time");
            }
        }
    }
}
