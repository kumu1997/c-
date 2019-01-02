using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b,addResult=0;
            a = 5;
            b = 3;
            addResult = a + b;
            Console.WriteLine($"{a}+{b}={addResult}");
            DisplayMessage();
            


        }
        static void DisplayMessage()
        {
            Console.WriteLine("Process is Done");
            Console.WriteLine("Finished on time : " + DateTime.Now.ToShortTimeString()); 
        }
    }
}
