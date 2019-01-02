using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPart3
{
    class Class2
    {
        public static void Main(String[] args)
        {
            string firstEmployee = "Harsha Nemani";
            string secondEmployee = "Ashish";

            Console.WriteLine($"{firstEmployee}\n{secondEmployee}\n\n");
            changeNames(ref firstEmployee, ref secondEmployee);
            Console.WriteLine($"{firstEmployee}\n{secondEmployee}\n\n");
        }
        static void changeNames(ref string firstEmp,ref string secEmp)
        {
            firstEmp = "Varun Verma";
            secEmp = "Amit Das";
            Console.WriteLine($"{firstEmp}\n{secEmp}\n\n");
            //if we dont declare ref then the last output will be original names.
        }
    }
}
