using ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        double num1, num2;
        string operation;

        Console.WriteLine("Calculator\n");

        while (true)
        {
            Console.Write("Enter first number: ");
            if (double.TryParse(Console.ReadLine(), out num1)) break;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        while (true)
        {
            Console.Write("Enter operation (+, -, *, /): ");
            operation = Console.ReadLine();
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/") break;
            Console.WriteLine("Invalid operation. Please enter one of +, -, *, /.");
        }

        while (true)
        {
            Console.Write("Enter second number: ");
            if (double.TryParse(Console.ReadLine(), out num2)) break;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        // Factory Method. Skapar ett objekt

        IOperation calculatorOperation = OperationFactory.Instance.CreateOperation(operation);

        // Strategy. Använder Calculator context för att genomföra operationen. 

        Calculator calculator = new Calculator();
        calculator.SetOperation(calculatorOperation);

        if (calculatorOperation != null)
        {
            try
            {
                double result = calculator.ExecuteOperation(num1, num2);
                Console.WriteLine($"{num1} {operation} {num2} = {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operation.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
