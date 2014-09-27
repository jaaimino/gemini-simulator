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
    public class Simulation
    {
        private Memory memory;
        private CPU cpu;

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
            cpu.cycle(this);
        }

        public Boolean isDone()
        {
            return cpu.isDone(memory.getInstructionCount());
        }

        //Minus one for one indexed instruction list
        public short getNextInstruction()
        {
            if (cpu.getPC() > memory.getInstructionCount()-1)
            {
                return -1;
            }
            return memory.getInstructionAtIndex(cpu.getPC());
        }

        public int getInstructionCount()
        {
            return memory.getInstructionCount();
        }

        public short[] getRegisterValues()
        {
            return cpu.getRegisterValues();
        }

        public Memory getMemory()
        {
            return this.memory;
        }

        public CPU getCPU()
        {
            return this.cpu;
        }
    }
}
