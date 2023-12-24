namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator calculator = new BasicCalculator();

            Console.WriteLine("Welcome to the C# Console Calculator\n");

            while (true)
            {
                Console.WriteLine("Enter the operation (+, -, *, /) or 'exit' to quit:");
                string operation = Console.ReadLine();

                if (operation == "exit")
                    break;

                Console.WriteLine("Enter the first number:");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input for the number.");
                    continue;
                }

                Console.WriteLine("Enter the second number:");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input for the number.");
                    continue;
                }

                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = calculator.Add(num1, num2);
                        break;
                    case "-":
                        result = calculator.Subtract(num1, num2);
                        break;
                    case "*":
                        result = calculator.Multiply(num1, num2);
                        break;
                    case "/":
                        result = calculator.Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid operation entered.");
                        break;
                }

                Console.WriteLine($"Result: {result}\n");
            }

            Console.WriteLine("Calculator closed. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
