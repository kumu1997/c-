using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart2
{
    class Program
    {
        private static void Main()
        {
            Console.Clear();
            int a=5, b=3, c=10, d=20;
            PerformAddOperation(a, b);
            PerformAddOperation(c, d);
        }
        static void PerformAddOperation(int x,int y)
        {
            int addResult = 0;
            addResult = x + y;
            Console.WriteLine($"{x}+{y}={addResult}");
           
        }
    }
}
