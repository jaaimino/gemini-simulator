/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Model for Simulation
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
        CPU cpu;
        Memory memory;
        List<short> instructions;

        public Simulation(List<short> instructions)
        {
            this.instructions = instructions;
            this.cpu = new CPU();
            this.memory = new Memory();
        }

        public void run()
        {
            while (! cpu.isDone())
            {
                step();
            }
        }

        public void step()
        {

        }


    }
}
