using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello World " + name);
            
           Random random = new Random();
            Console.WriteLine(random.Next(1,11));
        }
    }
}