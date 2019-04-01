using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice20_Project_DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viết phần mềm Demo tra cứu từ điển Anh - Việt
            // Phần mềm có các chức năng:
            //  1. Nhập từ mới vào từ điển
            //  2. Sửa từ trong từ điển
            //  3. Cho tra cứu từ điển: Nhập tiếng Anh để tra ra tiếng Việt
            //  4. Xóa từ trong từ điển
            //  5. Nâng cao: Thay đổi cấu trúc dữ liệu để làm bổ sung tra cứu từ đồng nghĩa

            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();

                Console.WriteLine("Bạn có tiếp tục dùng từ điển không ?(Y/N): ");
                string answer = Console.ReadLine();
                if(answer == "N")
                {
                    break;
                }
            }
            Console.WriteLine("BYE BYE !");
        }

        private static void menu()
        {
            Console.WriteLine("1. Add new word !");
            Console.WriteLine("2. Edit word !");
            Console.WriteLine("3. Look-up word !");
            Console.WriteLine("4. Delete word !");
            Console.WriteLine("Bạn chọn chức năng nào ? (gõ từ 1 - 4 để chọn chức năng tương ứng)");
            int function = int.Parse(Console.ReadLine());
            switch (function)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Bạn chọn nhầm chức năng rồi !");
                    break;
            }
        }
    }
}
