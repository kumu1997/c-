using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArguments

{
    class Class9
    {
        public static void Main(string [] args)
        {
            DisplayPlayerInformation(7, "Ronaldo", 30, "portugal");
            DisplayPlayerInformation(10, "Messi", 50);
        }

        public static void DisplayPlayerInformation(int no,string name,int goals,string country="")
        {
            Console.WriteLine("Dettails from the first method");
            Console.WriteLine(no);
            Console.WriteLine(name);
            Console.WriteLine(goals);
            Console.WriteLine(country);
        }
    }
}
