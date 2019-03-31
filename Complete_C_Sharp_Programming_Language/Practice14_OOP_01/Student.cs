using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14_OOP_01
{
    class Student : Person
    {
        public void GoToClass()
        {
            Console.WriteLine("I’m going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
}
