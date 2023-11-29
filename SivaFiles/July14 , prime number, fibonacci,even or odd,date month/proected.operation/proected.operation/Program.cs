namespace proected.operation
{
    public class Calculator
    {
        protected double number1;
        protected double number2;

        protected void GetNumbersFromConsole()
        {
            Console.WriteLine("Enter the first number:");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = Convert.ToDouble(Console.ReadLine());
        }

        protected double Add()
        {
            return number1 + number2;
        }

        protected double Subtract()
        {
            return number1 - number2;
        }

        protected double Multiply()
        {
            return number1 * number2;
        }

        protected double Divide()
        {
            if (number2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            else
            {
                return number1 / number2;
            }
        }

        protected double Modulo()
        {
            return number1 % number2;
        }

        protected double Power()
        {
            return Math.Pow(number1, number2);
        }

        public void PerformOperations()
        {
            GetNumbersFromConsole();

            double additionResult = Add();
            Console.WriteLine($"Addition: {number1} + {number2} = {additionResult}");

            double subtractionResult = Subtract();
            Console.WriteLine($"Subtraction: {number1} - {number2} = {subtractionResult}");

            double multiplicationResult = Multiply();
            Console.WriteLine($"Multiplication: {number1} * {number2} = {multiplicationResult}");

            double divisionResult = Divide();
            Console.WriteLine($"Division: {number1} / {number2} = {divisionResult}");

            double moduloResult = Modulo();
            Console.WriteLine($"Modulo: {number1} % {number2} = {moduloResult}");

            double powerResult = Power();
            Console.WriteLine($"Power: {number1} ^ {number2} = {powerResult}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.PerformOperations();
        }
    }
}