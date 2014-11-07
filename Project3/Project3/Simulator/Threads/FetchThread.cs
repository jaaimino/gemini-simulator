using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    /**
     * Need to 
     */
    public class FetchThread : OperationThread
    {
        public short[] registers;

        public FetchThread(AutoResetEvent mainListener) : base(mainListener){}

        public override void run()
        {
            while (true)
            {
                listener.WaitOne();
                if (done)
                {
                    break;
                }
                if (null != inst)
                {
                    registers[9] = this.inst.inst;
                }
                mainListener.Set();
            }
        }
    }
}
