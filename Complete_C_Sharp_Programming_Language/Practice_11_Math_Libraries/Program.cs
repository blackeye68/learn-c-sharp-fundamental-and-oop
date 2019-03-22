using System;
using System.Text;

namespace Practice_11_Math_Libraries
{
    internal class Program
    {
        private static void TestMathLibraries()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Please you input a number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Căn bậc 2 của {a} = {Math.Sqrt(a)}");   // Math.Sqrt() - hàm tính căn bậc hai của một số
            Console.WriteLine("Please you input a number b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a,b)}");  // Math.Pow(a,b) - hàm tính a lũy thừa b

            Console.WriteLine("Please you input a corner: ");
            int corner = Convert.ToInt32(Console.ReadLine());
            double radian = Math.PI * corner / 180;     // radian - đơn vị đo góc phẳng
            Console.WriteLine($"Sin of corner {corner} = Sin({corner}) = {Math.Sin(radian)}");  //Math.Sin(radian) - hàm tính Sin
            Console.WriteLine($"Cos of corner {corner} = Cos({corner}) = {Math.Cos(radian)}");  //Math.Cos(radian)  - hàm tính Cos
            Console.WriteLine($"Tan of corner {corner} = Tan({corner}) = {Math.Tan(radian)}");  //Math.Tan(radian)  - hàm tính Tan
            Console.WriteLine($"Cotan of corner {corner} = Cotan({corner}) " +
                $"= {1 /Math.Tan(radian)} or = {Math.Cos(radian)/Math.Sin(radian)}");   // 2 công thức tính Cotan của góc

            double x = 7.783928282;
            Console.WriteLine($"x ban đầu = {x}");
            Console.WriteLine($"x sau khi làm tròn = {Math.Round(x, 3)}"); //Math.Round() - hàm làm tròn số thực, x là số, 
                                                                           //số 3 là chữ số làm tròn sau dấu phẩy


            Console.ReadLine();
        }

        private static void Main(string[] args)
        {
            TestMathLibraries();
        }
    }
}