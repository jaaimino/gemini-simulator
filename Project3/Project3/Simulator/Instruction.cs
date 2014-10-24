using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Instruction
    {
        public short inst;
        public short opcode;
        public short operand;
        public Boolean flag;
        public Boolean complete;

        public Instruction(short inst)
        {
            this.inst = inst;
        }
    }
}
