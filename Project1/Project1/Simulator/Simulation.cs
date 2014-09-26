/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Data model for simulation. Also handles step logic
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Simulation
    {
        Memory memory;
        CPU cpu;

        public Simulation(List<short> instructions)
        {
            memory = new Memory(instructions);
            cpu = new CPU();
        }

        /**
         * Do one step of the simulation
         * 
         */
        public void step()
        {
            cpu.cycle();
        }

        public Boolean isDone()
        {
            return cpu.isDone(memory.getInstructionCount());
        }

        public short getNextInstruction()
        {
            return memory.getInstructionAtIndex(cpu.getPC());
        }

        public int[] getRegisterValues()
        {
            return cpu.getRegisterValues();
        }
    }
}
