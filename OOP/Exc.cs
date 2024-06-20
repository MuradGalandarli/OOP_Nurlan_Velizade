using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Exc:Exception
    {
        public string ExcName { get; set; }
        public Exc(string message) : base(message) 
        {
        
        }
    }
}
