using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice20_Project_DictionaryApp
{
    class Program
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();
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
            Console.ReadLine();
        }

        private static void menu()
        {
            Console.WriteLine("1. Add new word !");
            Console.WriteLine("2. Edit word !");
            Console.WriteLine("3. Look-up word !");
            Console.WriteLine("4. Delete word !");
            Console.WriteLine("Bạn chọn chức năng nào ? (gõ từ 1 - 4 để chọn chức năng tương ứng)");
            int features = int.Parse(Console.ReadLine());
            try
            {
                switch (features)
                {
                    case 1:
                        CreateNewWord();
                        break;
                    case 2:
                        EditWord();
                        break;
                    case 3:
                        SearchWord();
                        break;
                    case 4:
                        DeleteWord();
                        break;
                    default:
                        Console.WriteLine("Bạn chọn nhầm chức năng rồi !");
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Lỗi gì đó: " + ex.Message);
            }
   
        }

        private static void DeleteWord()
        {
            Console.WriteLine("Mời bạn nhập vào từ muốn xóa:");
            string english = Console.ReadLine();
            if (dictionary.ContainsKey(english))
            {
                dictionary.Remove(english);
            }
            else
            {
                Console.WriteLine($"Không tìm thấy từ [{english}] để xóa !");
            }
        }

        private static void SearchWord()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng Anh");
            string english = Console.ReadLine();
            if (dictionary.ContainsKey(english))
            {
                string vietnamese = dictionary[english];
                Console.WriteLine($"Nghĩa của từ [{english}] là [{vietnamese}]");
            }
            else
            {
                Console.WriteLine($"Từ điển chưa có cập nhật từ [{english}]");
            }
        }

        private static void EditWord()
        {
            Console.WriteLine("Nhập vào từ tiếng Anh để sửa lại nghĩa:");
            string english = Console.ReadLine();
            if(dictionary.ContainsKey(english) == false)
            {
                Console.WriteLine($"Không tìm thấy [{english}] để sửa !");
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại nghĩa tiếng Việt !");
                string vietnamese = Console.ReadLine();
                dictionary[english] = vietnamese;
            }
        }

        private static void CreateNewWord()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng Anh:");
            string english = Console.ReadLine();
            if (dictionary.ContainsKey(english))
            {
                Console.WriteLine($"Từ [{english}] đã tồn tại rồi !");
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào nghĩa tiếng Việt");
                string vietnamese = Console.ReadLine();
                dictionary.Add(english, vietnamese);

            }
        }
    }
}
