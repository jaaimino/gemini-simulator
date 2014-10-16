using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Block
    {
        int tag;
        public Boolean dirty;
        public int data;

        public Block(int tag)
        {
            this.tag = tag;
            this.dirty = false;
            this.data = 0;
        }

        public int getTag()
        {
            return this.tag;
        }
    }
}
