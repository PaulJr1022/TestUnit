namespace TestUnit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var calculator = new Calculator();

            Console.WriteLine("Simple Calculator");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition: {calculator.Add(num1, num2)}");
            Console.WriteLine($"Subtraction: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {calculator.Multiply(num1, num2)}");

            try
            {
                Console.WriteLine($"Division: {calculator.Divide(num1, num2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
