using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printduplicatechars
{
    class Class22
    {
        public static void Main(string [] args)
        {
            string strInput = Console.ReadLine();
          
                var dict = new Dictionary<char, int>();
                foreach (var item in strInput)
                {
                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }
                    else
                    {
                        dict.Add(item, 1);
                    }
                }                
                foreach (var item in dict)
                {
                    if (item.Value > 1)
                    {
                        Console.WriteLine(item.Key);
                    }
                }                        

        }
       
    }
}
