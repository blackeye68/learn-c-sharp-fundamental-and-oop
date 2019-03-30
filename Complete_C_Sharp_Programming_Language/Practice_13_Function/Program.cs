using System;
using System.Text;

namespace Practice13_Function
{
    class Program
    {
        static int CalculateFactorial(int n)
        {
            int factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static string GiaiPhuongTrinhBac1(double a, double b)
        {
            if(a == 0 && b == 0)
            {
                return "Phương trình vô số nghiệm";
            }
            if (a == 0 && b != 0) {
                return "Phương trình vô nghiệm";
            }
            return "x = " + (-b / a);
        }

        static int Min(int a, int b)
        {
            return Math.Min(a, b);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //test tính giai thừa 1 số nguyên
            int result = CalculateFactorial(9);
            Console.WriteLine($"Factorial of {9}! = {result}");

            // test giải phương trình bậc 1
            string nghiem = GiaiPhuongTrinhBac1(4,0);
            Console.WriteLine(nghiem);

            //test tham số thực và tham số hình thức
            int x = 8;
            int y = 15;

            int t = Min(x, y);

            Console.ReadLine();
        }
    }
}