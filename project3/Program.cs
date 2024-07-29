namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your num");
            int num = int.Parse(Console.ReadLine());
            if (num>0)
            {
                Console.Write(" it's positive number");
            }
            else if(num<0)
            {
                Console.WriteLine("it's negative number");
            }
            else {
                Console.WriteLine("try again");
                 }

        }
    }
}
