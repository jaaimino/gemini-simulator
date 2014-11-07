using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    public class OperationThread
    {
        public Instruction inst;
        public AutoResetEvent mainListener;
        public AutoResetEvent listener; //Set by main to start doing next task
        public Boolean done;

        public OperationThread(AutoResetEvent mainListener)
        {
            this.listener = new AutoResetEvent(false);
            this.mainListener = mainListener;
        }

        public virtual void run()
        {

        }

    }
}
