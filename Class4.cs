using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Class4
    {
        static void Main5(String[] args)
        {
            Person perOne = new Person();
            perOne.FirstName = "Harsha";
            perOne.LastName = "Nemani\n";
            
            Person perTwo = new Person();
            perTwo.FirstName = "Amit";
            perTwo.LastName = "Das";
          

            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(perOne.LastName);
        
            Console.WriteLine(perTwo.FirstName);
            Console.WriteLine(perTwo.LastName);
           

        }
    }
    class Person
    {
        string firstName;
        string lastName;
       

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
       
       
    }
}
