using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.

            decimal a, b, c;
            Console.WriteLine("Input a:");
            a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Input c:");
            c = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication of three numbers is {a} * {b} * {c} = {a * b * c}");
            Console.ReadLine();

        }
    }
}
