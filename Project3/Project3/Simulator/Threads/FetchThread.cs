using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class FetchThread : OperationThread
    {
        Instruction instruction;
        short[] registers;

        public FetchThread(Instruction instruction, short[] registers) : base()
        {
            thrd.Name = "Fetch Thread";
            this.instruction = instruction;
            this.registers = registers;
        }
        public override void run()
        {
            base.run();
            registers[9] = this.instruction.inst;
        }
    }
}
