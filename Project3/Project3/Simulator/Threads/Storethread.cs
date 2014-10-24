using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class StoreThread : OperationThread
    {
        public StoreThread() : base()
        {
            thrd.Name = "Store Thread";
        }
        public override void run()
        {
            base.run();
        }
    }
}
