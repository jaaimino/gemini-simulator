using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    class StoreThread : OperationThread
    {
        public CPU cpu;

        public StoreThread(AutoResetEvent mainListener) : base(mainListener)
        {
        }

        public override void run()
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
                    //Console.WriteLine("Opcode for exec: " + inst.opcode + " flag for exec " + inst.flag + " operand for exec: " + inst.operand);
                    ALU.memoryoperation(cpu, inst);
                }
                mainListener.Set();
            }
        }
    }
}
