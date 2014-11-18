using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class InstructionData
    {
        public short inst;
        public short opcode;
        public short operand;
        public Boolean flag;
        public Boolean complete;
        public Boolean memop;

        public InstructionData(short inst)
        {
            this.inst = inst;
            this.memop = false;
            this.flag = false;
            this.complete = false;
        }
    }
}
