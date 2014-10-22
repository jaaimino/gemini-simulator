using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Frame
    {
        private int tag;
        public int data;
        public Boolean dirty;

        public Frame(int tag)
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
