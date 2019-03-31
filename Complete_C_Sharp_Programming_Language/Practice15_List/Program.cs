using System;
using System.Collections.Generic;
using System.Text;

namespace Practice15_List
{
    internal class Program
    {
        static void LearnList1()
        {
            // cấp phát bộ nhớ để sử dụng đối tượng List
            List<string> list = new List<string>();
            // thêm một phần tử (item) vào danh sách (list)
            list.Add("An");
            list.Add("Bình");
            list.Add("Hạnh");
            list.Insert(2, "Giải thoát"); // thêm item vào list tại 1 vị trí
            list.Add("Phúc");
            list.Remove("Bình"); // xóa item biết trước
            list.RemoveAt(0); // xóa item tại 1 vị trí

            Console.WriteLine("Danh sách các phần tử trong List là:");
            // duyệt list với for
            for(int i = 0; i< list.Count; i++)
            {
                string v = list[i];
                Console.WriteLine(v);
            }

        }

        static void LearnList2()
        {
            List<int> list = new List<int>();
            Random rd = new Random();
            // thêm 10 item vào list
            for(int i = 0; i < 10; i++)
            {
                list.Add(rd.Next(100));
            }
            Console.WriteLine("Các phần tử trong list gốc là:");
            // duyệt list với foreach
            foreach (int x in list)
            {
                Console.WriteLine(x + "\t");
            }

            // săp xếp các phần tử của list
            list.Sort();
            Console.WriteLine("Các phần tử trong list sau khi sắp xếp là:");
            foreach (int x in list)
            {
                Console.WriteLine(x + "\t");
            }

            // tìm kiếm trong list
            int k;
            Console.WriteLine("Mời bạn nhập vào số muốn tìm:");
            k = Convert.ToInt32(Console.ReadLine());
            int result = list.IndexOf(k);
            if (result < 0)
            {
                Console.WriteLine($"Không tìm thấy {k} trong list");
            }
            else
            {
                Console.WriteLine($"Tìm thấy {k} tại vị trí {result} trong list");
            }
        }

        private static void Main(string[] args)
        {
            // Lớp List trong C# thuộc thư viện System.Collections.Generic
            // List là một lựa chọn thay thế cho một mảng. List hoạt động như một danh sách liên kết
            // Ta có thể thêm và gỡ bỏ một item từ một List tại một vị trí đã xác định, nó có thể tự điều chỉnh kích cỡ một cách tự động
            // Nó cũng cho phép cấp phát bộ nhớ động, thêm, tìm kiếm, và sắp xếp các item trong một list.

            Console.OutputEncoding = Encoding.UTF8;
            LearnList1();

            LearnList2();

            Console.ReadLine();
        }
    }
}