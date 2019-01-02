using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Class7
    {
        static void Main(string[] args)
        {
      
            Dictionary<string, string> capitals = new Dictionary<string, string>();

            capitals.Add("Russia", "Moscow");

            capitals.Add("Italy", "Rome");

            capitals.Add("England", "London");

            capitals.Add("Spain", "Madrid");

            capitals.Add("Germany", "Berlin");

           /* foreach(var item in capitals)
            {
                Console.WriteLine(item.Key);
            }*/

            for(int i=0;i<capitals.Count;i++)
            {
                Console.WriteLine(capitals.Keys.ElementAt(i));
            }

            Console.WriteLine(capitals["Russia"]);

        }
    }
}
