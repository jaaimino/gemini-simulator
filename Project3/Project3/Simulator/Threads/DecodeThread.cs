using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class DecodeThread : OperationThread
    {
        Instruction inst;
        public DecodeThread(Instruction inst) : base()
        {
            thrd.Name = "Decode Thread";
            this.inst = inst;
        }
        public override void run() //Do decoding inside here
        {
            while (true)
            {
                if (base.done)
                {
                    break;
                }
                inst.opcode = (short)Translator.decodeCommand(inst.inst);
                inst.flag = Translator.decodeImmediateFlag(inst.inst);
                inst.operand = (short)Translator.decodeOperand(inst.inst);
            }
        }
    }
}
