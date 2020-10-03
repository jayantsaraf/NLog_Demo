using System;

namespace NLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition Problem \n Enter 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Add_Number add = new Add_Number();
            Console.WriteLine("Result is" + add.Sum(a,b));
        }
    }
}
