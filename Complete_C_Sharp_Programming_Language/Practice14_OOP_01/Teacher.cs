using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14_OOP_01
{
    public class Teacher: Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
