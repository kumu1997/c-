using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp

{
    class Class6
    {
        static void Main7(String [] args)
        {
            ArrayList array = new ArrayList();

            int a;

                array.Add("First");
                array.Add("2");
                array.Add("3.5d");
            Console.WriteLine("Default Values");
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }

            
            array.Insert(2, "Three");
            array.Insert(4, "5");
            Console.WriteLine("\nAfter Inserting values");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
