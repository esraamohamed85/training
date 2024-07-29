
using System;
namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) 
            {
                Console.WriteLine("your num is even");
            }
            else
            {
                Console.WriteLine("your num is odd");
            }

                
    
        }
    }
}
