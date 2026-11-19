namespace _03_1._6_Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();

            double result = 0.0;
            string evenOdd = "";

            switch (action)
            {
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        return;
                    }
                    result = num1 / num2;

                    Console.WriteLine($"{num1} / {num2} = {result:F2}");

                    break;
                case "%":

                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        return;
                    }

                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                    break;
                case "+":
                    result = num1 + num2;

                    if (result % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    else
                    {
                        evenOdd = "odd";
                    }

                    Console.WriteLine($"{num1} + {num2} = {result} - {evenOdd}");

                    break;
                case "-":
                    result = num1 - num2;

                    if (result % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    else
                    {
                        evenOdd = "odd";
                    }

                    Console.WriteLine($"{num1} - {num2} = {result} - {evenOdd}");
                    break;
                case "*":
                    result = num1 * num2;

                    if (result % 2 == 0)
                    {
                        evenOdd = "even";
                    }
                    else
                    {
                        evenOdd = "odd";
                    }

                    Console.WriteLine($"{num1} * {num2} = {result} - {evenOdd}");
                    break;
            }
        }
    }
}
