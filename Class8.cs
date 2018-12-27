using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurssiveMethods

{
    class Class8
    {
        static void Main(string[] args)
        {
            int number = 5;

            Console.WriteLine("Non recurssive way");
            Console.WriteLine(FactorialNonRecurssive(number));

            Console.WriteLine("Recurssive way");
            Console.WriteLine(Factorial(number));
        }

        //Non-Recurssive way
        public static int FactorialNonRecurssive(int n)
        {
            if (n == 0)
                return 1;
            int value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
                Console.WriteLine(i);
            }
            return value;
        }

        //Recursive way

        public static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }

    }
}
