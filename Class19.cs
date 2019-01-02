using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removeduplicatestringcharacters
{
    class Class19
    {
        public static void Main(string [] args)
        {
            String value1 = Removeduplicatechars("Google");
            Console.WriteLine(value1);
        }

        static string Removeduplicatechars(string key)
        {
            string temp = "";
            string result = "";

            foreach(char value in key)
            {
                if(temp.IndexOf(value)==-1)
                {
                    temp += value;
                    result += value;
                }
            }
            return result;
        }
    }
}
