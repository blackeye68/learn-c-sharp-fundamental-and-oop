using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Write a C# Sharp program to swap two numbers.
            //Input the First Number : 5
            //Input the Second Number : 6
            //Expected Output: 
            //After Swapping :
            //First Number : 6
            //Second Number : 5
            int firstNumber, secondNumber, temp;
            Console.WriteLine("Nhập số thứ nhất:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai:");
            secondNumber = int.Parse(Console.ReadLine());
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("Sau khi đảo ngược !");
            Console.WriteLine($"Số thứ nhất = {firstNumber}");
            Console.WriteLine($"Số thứ hai = {secondNumber}");


            Console.ReadLine();

        }
    }
}
