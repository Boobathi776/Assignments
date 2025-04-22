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