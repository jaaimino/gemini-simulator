using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Block
    {
        private int id;
        public int data;
        public Boolean dirty;

        public Block(int id)
        {
            this.id = id;
            this.data = 0;
            this.dirty = false;
        }
    }
}
