
namespace HelloWorld
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            try
            {
                if (b == 0)
                    Console.Write("Cannot divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
            }
            
            return (double)a / b;
        }
    }
}


