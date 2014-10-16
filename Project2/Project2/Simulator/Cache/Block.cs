using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Block
    {
        private Boolean dirty;
        private int[] addresses;
        private int tag;

        public Block(int tag)
        {
            this.tag = tag;
        }

        public void setAddress(int localAddress, int value)
        {
            this.dirty = true;
            addresses[localAddress] = value;
        }

        public int getTag()
        {
            return this.tag;
        }
    }
}
