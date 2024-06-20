using OOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Concrete
{
    public class PersonVisuallizer2 
    {
        public void Print(Person person)
        {
         
                Console.WriteLine($" {person.Id}");
                Console.WriteLine($" {person.Name}");
                Console.WriteLine($" {person.SureName}");


            }
        }
    }

