using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!"); 
            Console.WriteLine(2+2);
            var str = "Hello";
            str += " world";
            str = "äsd";
            str = "asdfsdf";
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
