using System;

namespace HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Another obj = new Another();
            obj.print("Boobathi");
            obj.print(Console.ReadLine());

            Calculator calc = new Calculator();
           int sum =  calc.Add(5, 3);
            Console.WriteLine(sum);
        }
    }

    class Another
    {
        public void print(string name)
        {
          
            Console.WriteLine($"hi {name}!");
        }
    }
}