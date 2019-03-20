using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_04_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài Tập : SWITCH
            //Cho a,b là 2 số nguyên, kt là 1 ký tự nhập từ bàn phím (+,-,*,/)
            //Nếu nhập kt là phép toán nào thì tự động tính toán cho a,b.

            Console.OutputEncoding = Encoding.UTF8;
            int a, b;
            char kt;
            Console.WriteLine("Nhập a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phép toán (+, -, *, /)");
            kt = Console.ReadLine()[0];
            // Ở trong ngoặc nhấn tổ hợp phím Shift + Enter --> tự có dấu ; và xuống dòng
            switch (kt)
            {
                case '+':
                    Console.WriteLine($"{a}+{b}={a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a}-{b}={a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a}*{b}={a * b}");
                    break;
                case '/':
                    Console.WriteLine($"{a}/{b}={a / b}");
                    break;
            }


            Console.ReadLine();
        }
    }
}
