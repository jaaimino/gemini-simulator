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
        public AutoResetEvent listener; //Set by main to start doing next task
        protected Boolean done;

        public OperationThread()
        {
        }

        public virtual void run()
        {
        }

    }
}
