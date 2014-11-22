using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    public class FetchThread : OperationThread
    {
        public short[] registers;
        public CPU cpu;

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
                    //Hack to pre-load things if it's a branch and it should
                    if (Boolean.Parse(Settings.getValue("branchpredict")))
                    {
                        if (Translator.isBranch(inst.inst))
                        {
                            if (cpu.predictor.shouldBranch(inst.inst))
                            { 
                                inst.operand = (short)Translator.decodeOperand(inst.inst);
                                inst.predictedBranch = true;
                                cpu.setRegisterValue(5, inst.operand);
                                Console.WriteLine("Predicted branch.");
                                //Console.WriteLine("Should be " + inst.operand + " Found " + cpu.getRegisterValue(5));
                            }
                        }
                    }
                }
                mainListener.Set();
            }
        }
    }
}
