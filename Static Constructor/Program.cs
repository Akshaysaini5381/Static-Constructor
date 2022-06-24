using System;

namespace Static_Constructor
{
    class Program
    {
        static int num = 100;
        static Program()
        {
            num = 200;
            Console.WriteLine("static constructor "+num);
        }
        static void Main(string[] args)
        {
            num = 300;
            Console.WriteLine(num);
            
        }
    }
}
