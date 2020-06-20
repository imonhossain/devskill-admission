using System;

namespace Answer6
{
    class Program
    {
        delegate long multi(int x, int y);
        static void Main(string[] args)
        {
            multi Multiply = (x, y) => x * y;
            Console.WriteLine(Multiply(2, 3));
            //Console.WriteLine("Hello World!");
        }
    }
}
