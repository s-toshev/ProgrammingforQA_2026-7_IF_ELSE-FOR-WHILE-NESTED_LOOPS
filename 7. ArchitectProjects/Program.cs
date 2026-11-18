namespace _7._ArchitectProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timePerProject = 3;
            int timeForAllProjects = numberOfProjects * timePerProject;

            Console.WriteLine($"The architect {architectName} will need {timeForAllProjects} hours to complete {numberOfProjects} project/s.");

        }
    }
}
