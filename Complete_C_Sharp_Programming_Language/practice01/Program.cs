using System;
using System.Text;

namespace Practice_01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int soluong;
            double diemToan = 9.5;
            int x1 = 1;

            //long long = 15; --> tên biến giống tên cú pháp --> sai

            string name = "Ngô Anh Đức";

            Console.WriteLine("Hello Ngô Anh Đức!");
            Console.WriteLine($"Ten = {name}, điểm ={diemToan}"); //cách 1: truyền hiển thị biến
            Console.WriteLine("điểm toán = {0}, tên = {1}", diemToan, name); //cách 2: truyền và hiển thị giá trị biến

            // Cách thức ép kiểu
            double d = 1 / 2;
            Console.WriteLine($"d={1}/{2} = {d}");
            double d2 = (double)1 / 2;
            Console.WriteLine($"d={1}/{2}={d2}");

            double d3 = 1.0 / 2;
            Console.WriteLine($"d={1}/{2}={d3}");

            // hiển thị kiểu dữ liệu không tường minh - Implicit Type
            var x = 15;
            Console.WriteLine("Kiểu của x= {0}", x.GetType().ToString());

            //khai báo hằng số - quy tắc Hằng số khai báo biến phải code In Hoa example khai báo pi là sai phải là PI
            const double PI = 3.14;
            //const double pi = 3.14; khai báo sai convension

            Console.ReadLine();
        }
    }
}