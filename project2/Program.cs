
using System;
namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the lenght");
            float lenght = float.Parse(Console.ReadLine());
            Console.WriteLine("please enter the width");
            float width = float.Parse(Console.ReadLine());
            if(lenght == width)
            {
                Console.WriteLine("it's a square");
            }
            else
            {
                Console.WriteLine("it's just a rectangle");
            }

        }
    }
}
