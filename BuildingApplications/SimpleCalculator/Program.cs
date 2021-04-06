using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Please enter first Number");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Please enter second Number");
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());

                Console.WriteLine("Please enter Operation e.g (+, /, *, -)");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine($"Results = {result}");

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
