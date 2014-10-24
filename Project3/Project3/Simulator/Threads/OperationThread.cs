using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    class OperationThread
    {
        public Thread thrd;

        public OperationThread()
        {
            thrd = new Thread(this.run);
            thrd.Start();
        }

        public virtual void run()
        {
            Thread.Sleep(4);
        }

    }
}
