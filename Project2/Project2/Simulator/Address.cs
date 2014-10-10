using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Addresses
    {
        private int id;
        public int data;
        public Boolean dirty;

        public Addresses(int id)
        {
            this.id = id;
            this.data = 0;
            this.dirty = false;
        }
    }
}
