using OOP.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Concrete
{
    public class Person
    {
        private readonly IPersonVisualizer _person;
        public Person(IPersonVisualizer person)
        {
            _person = person;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
    }
}
