namespace BasicMath1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath math = new BasicMath();
            Console.Write("Please enter first number: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Please enter valid number.");
            }

            Console.Write("Please enter second number: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Please enter valid number.");
            }

            double result = math.Add(num1, num2);
            Console.WriteLine("Addition result: " + result);

            double result2 = math.Subtract(num1, num2);
            Console.WriteLine("Addition result: " + result2);

            double result3 = math.Multiply(num1, num2);
            Console.WriteLine("Addition result: " + result3);

            double result4 = math.Divide(num1, num2);
            Console.WriteLine("Addition result: " + result4);
        }
    }
}
