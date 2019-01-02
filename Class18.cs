using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringcharactersidentification
{
    class Class18
    {
        public static void Main(string [] args)
        {
            string s = Console.ReadLine();
            int number=0,capital = 0, small = 0, special = 0, space = 0;
            char[] a = s.ToCharArray();
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] >= 48 && a[i] <= 58)
                    number += 1;
                else if (a[i] >= 65 && a[i] <= 90)
                    capital += 1;
                else if (a[i] >= 97 && a[i] <= 122)
                    small += 1;
                else if (a[i] == 32)
                    space += 1;
                else
                    special += 1;
            }
            Console.WriteLine("Numbers are               "  + number);
            Console.WriteLine("Capital Characters are    " + capital);
            Console.WriteLine("Small Characters are      " + small);
            Console.WriteLine("Space Characters are      " + space);
            Console.WriteLine("Special Characters are    " + special);

        }
    }
}
