using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Photo
    {
       public int phg;
        public Photo()
        {
            this.phg = 16;
        }
        public Photo(int Phg)
        {
            this.phg = Phg;
        }
        public int ListPhg()
        {
            return this.phg;
        }
    }
}
