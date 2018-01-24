using System;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inLine;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Dit is een testapplicatie");
            Console.WriteLine("Input: ");
            inLine = Console.ReadLine();
            Console.WriteLine("Output: {0}", inLine);
            TestClass.myStruct mys;
            mys.myInt = 0;
            mys.myString = "abcd";
            Console.WriteLine("test: {0} :::: {1}",mys.myInt,mys.myString);
        }
    }
}
