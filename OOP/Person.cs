using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public int BirthDate { get; set; }
        public int FamilyId { get; set; }

        public int SonId { get; set; }

        public List<Person> Generation1 { get; set; }
        public List<Person> Generation2 { get; set;}
        public List<Person> Generation3 { get; set;}
        public List<Person> Generation4 { get; set;}

        






    }
}
