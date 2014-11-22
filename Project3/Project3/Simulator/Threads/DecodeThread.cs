using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    class DecodeThread : OperationThread
    {
        public DecodeThread(AutoResetEvent mainListener) : base(mainListener)
        {
        }
        public override void run() //Do decoding inside here
        {
            while (true)
            {
                listener.WaitOne();
                if (base.done)
                {
                    break;
                }
                if (null != inst)
                {
                    inst.opcode = (short)Translator.decodeCommand(inst.inst);
                    inst.immediate = Translator.decodeImmediateFlag(inst.inst);
                    inst.operand = (short)Translator.decodeOperand(inst.inst);
                }
                mainListener.Set();
            }
        }
    }
}
