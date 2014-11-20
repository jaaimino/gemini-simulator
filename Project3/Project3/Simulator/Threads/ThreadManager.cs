using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    public static class ThreadManager
    {
        private static Thread[] threads;
        public static AutoResetEvent[] threadListeners;
        public static OperationThread[] pipeThreads;

        public static void initialize()
        {
            threadListeners = new AutoResetEvent[4];
            threadListeners[0] = new AutoResetEvent(false);
            threadListeners[1] = new AutoResetEvent(false);
            threadListeners[2] = new AutoResetEvent(false);
            threadListeners[3] = new AutoResetEvent(false);
            pipeThreads = new OperationThread[4];
            pipeThreads[0] = new FetchThread(threadListeners[0]);
            pipeThreads[1] = new DecodeThread(threadListeners[1]);
            pipeThreads[2] = new ExecuteThread(threadListeners[2]);
            pipeThreads[3] = new StoreThread(threadListeners[3]);
            threads = new Thread[4];
            for (int i = 0; i < threads.Count(); i++)
            {
                threads[i] = new Thread(pipeThreads[i].run);
                threads[i].Start();
            }
        }

        public static void stopAllThreads()
        {
            Console.WriteLine("Stopping all threads");
            foreach (OperationThread o in pipeThreads)
            {
                o.done = true;
                o.listener.Set();
            }
        }
    }
}
