using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /**
     * Need to 
     */
    public class FetchThread : OperationThread
    {
        Instruction instruction;
        short[] registers;

        public FetchThread() : base(){}

        public override void run()
        {
            while (true)
            {
                if (done)
                    break;
                listener.WaitOne();//Wait until main threads says to go
                registers[9] = this.instruction.inst;
            }
        }
    }
}
