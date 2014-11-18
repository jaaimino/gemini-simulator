/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Execute Thread
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    class ExecuteThread : OperationThread
    {
        public CPU cpu;
        public ExecuteThread(AutoResetEvent mainListener) : base(mainListener){}

        /**
         * Run exectute thread.
         * Should check for any issues/stalls/missed branches
         */
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
                    ALU.execute(cpu, inst.opcode, inst.flag, inst.operand);
                }
                mainListener.Set();
            }
        }
    }
}
