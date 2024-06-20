using OOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Concrete
{
    public class PersonVisuallizer1 
    {
        public void Print(Person person)
        {
            Console.WriteLine($"Person {person.Id}");
            Console.WriteLine($"Person {person.Name}");
            Console.WriteLine($"Person {person.SureName}");
           
         
        }

    }
}
