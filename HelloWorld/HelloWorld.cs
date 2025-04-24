using System;

namespace HelloWorld   //to make a package or container like structure of our classes and namespaces
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Hello World! Program
            Console.WriteLine("Hello World!");

        
            //Calculator program
            Calculator calc = new Calculator();
            calc.callCalculator();
        }
    }
}