using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class ExecuteThread : OperationThread
    {
        Instruction inst;
        CPU cpu;
        public ExecuteThread(Instruction inst, CPU cpu) : base()
        {
            thrd.Name = "Execute Thread";
            this.inst = inst;
            this.cpu = cpu;
        }
        public override void run()
        {
            base.run();
            //Console.WriteLine("Opcode for exec: " + inst.opcode + " flag for exec " + inst.flag + " operand for exec: " + inst.operand);
            ALU.execute(cpu, inst.opcode, inst.flag, inst.operand);
        }
    }
}
