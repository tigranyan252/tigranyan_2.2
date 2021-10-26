using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y < 0) Console.WriteLine("точка лежит в четвёртой четверти");
            else Console.WriteLine("точка не лежит в четвёртой четверти");

        }
    }
}
