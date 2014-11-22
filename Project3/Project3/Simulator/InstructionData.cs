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
        public Boolean immediate;
        public Boolean complete;
        public Boolean memop;
        public short result;
        public Boolean predictedBranch;

        public InstructionData(short inst)
        {
            this.inst = inst;
            this.memop = false;
            this.immediate = false;
            this.complete = false;
            this.predictedBranch = false;
        }
    }
}
