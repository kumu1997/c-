using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversewords
{
    class Class17
    {
        
            
            public static void  Main(string [] args)
            {
                string s=Console.ReadLine();
                string result = "";
                Stack temp = new Stack();

                foreach (string x in s.Split(' '))
                    temp.Push(x);

                while (temp.Count != 0)
                    result += temp.Pop();

                Console.WriteLine(result);
            }
        

        }
    }

