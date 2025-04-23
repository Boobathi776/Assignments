using System;

namespace HelloWorld   //to make a package or container like structure of our classes and namespaces
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            //Hello World! Program
            Console.WriteLine("Hello World!");

            //String passing to another class's method
            Another obj = new Another();
            obj.print("Boobathi");

            //get input from the user
            obj.print(Console.ReadLine());

            //Calculator program
            Calculator calc = new Calculator();
            int sum =  calc.Add(5, 3);
            Console.WriteLine("sum is : "+sum);
        }
    }

    class Another
    {
        public void print(string name)
        {
            //String interpolation "$" is used to done like this 
            Console.WriteLine($"hi {name}!");
        }
    }
}