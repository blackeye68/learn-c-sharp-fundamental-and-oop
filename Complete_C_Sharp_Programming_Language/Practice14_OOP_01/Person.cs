using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14_OOP_01
{
    public class Person
    {
        public int age;
        public void SetAge(int n)
        {
            age = n;
        }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
