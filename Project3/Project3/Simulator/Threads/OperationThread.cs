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
        public int count;
        public Thread thrd;

        public OperationThread(string name)
        {
            count = 0;
            thrd = new Thread(this.run);
            thrd.Name = name;
            thrd.Start();
        }

        void run()
        {
            Console.WriteLine(thrd.Name + " starting.");

            do
            {
                Thread.Sleep(500);
                Console.WriteLine("In " + thrd.Name +
                                  ", count is " + count);
                count++;
            } while (count < 10);

            Console.WriteLine(thrd.Name + " terminating.");
        }

    }
}
