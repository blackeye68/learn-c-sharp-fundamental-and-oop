using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03_Conditional_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //if(i % 2 = 0)
            //{
            //    Console.WriteLine("i là số chẵn");
            //}
            //else
            //{
            //    Console.WriteLine("i là số lẻ");
            //}

            //Cách 2: câu điều kiện lồng nhau
            double diem;
            Console.WriteLine("Mời bạn nhập vào 1 điểm:");
            diem = double.Parse(Console.ReadLine());
            string ketqua = diem >= 5 ? "Đậu" : "Rớt";
            Console.WriteLine("Điểm = {0} ==> {1}", diem, ketqua);
            Console.ReadLine();

            //double diem;
            //Console.WriteLine("Mời bạn nhập vào 1 điểm:");
            //diem = double.Parse(Console.ReadLine());
            //if(diem >= 5)
            //{
            //    Console.WriteLine("Điểm ={0} ==> Đậu", diem);
            //}
            //else
            //{
            //    Console.WriteLine("Điểm ={0} ==> Rớt", diem);
            //}

                //Console.ReadLine();
        }
    }
}
