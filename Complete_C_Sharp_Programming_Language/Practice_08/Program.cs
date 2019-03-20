using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Write a C# Sharp program to print on screen the 
            //output of adding, subtracting, multiplying and dividing of 
            //two numbers which will be entered by the user.
            decimal a, b;
            char operation;
            Console.WriteLine("Input a:");
            a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Input operation (+, -, *, /, %):");
            operation = Console.ReadLine()[0];


            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Adding of {a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"Subtracting of {a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"Multiplying of {a} * {b} = {a * b}");
                    break;
                case '/':
                    if(a == 0 || b == 0)
                    {
                        Console.WriteLine("Error ! Không thể chia cho 0 hoặc 0 chia cho 1 số !");
                    } else
                    {
                        Console.WriteLine($"Dividing of {a} / {b} = {a / b}");
                    }
                    break;
                case '%':
                    Console.WriteLine($"Modulo of {a} % {b} = {a % b}");
                    break;
                default:
                    Console.WriteLine("Error ! Bạn đã không nhập vào một phép toán !");
                    break;
            }


            Console.ReadLine();

        }
    }
}
