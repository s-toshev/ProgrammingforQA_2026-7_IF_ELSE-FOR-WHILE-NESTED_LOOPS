namespace _06._6_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfFloors = int.Parse(Console.ReadLine());
            int numberOfRoomsPerFloor = int.Parse(Console.ReadLine());


            for (int i = numberOfFloors; i > 0; i--)
            {



                for (int j = 0; j < numberOfRoomsPerFloor; j++)
                {

                    if (i == numberOfFloors)
                    {
                        Console.Write($"L{i}{j} ");

                    }

                    if (i % 2 != 0 && i != numberOfFloors)
                    {

                        Console.Write($"A{i}{j} ");

                    }

                    if (i % 2 == 0 && i != numberOfFloors)
                    {
                        Console.Write($"O{i}{j} ");

                    }


                }
                Console.WriteLine();
                
            }


        }
    }
}
