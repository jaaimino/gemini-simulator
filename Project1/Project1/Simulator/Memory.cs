/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Model for Memory
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Memory
    {
        private int[] addresses; //Maybe should be shorts? I dunno
        private List<short> instructions;

        public List<short> getInstructions()
        {
            return this.instructions;
        }

        public Memory(List<short> instructions)
        {
            addresses = new int[256];
            this.instructions = instructions;
        }

        public void setMemoryLocation(int address, int value)
        {
            addresses[address] = value;
        }

        public int getMemoryLocation(int address)
        {
            return addresses[address];
        }

        //Using 1 indexed list instead of zero indexed
        //Makes life easier in some respects
        public short getInstructionAtIndex(int index)
        {
            return instructions.ElementAt(index);
        }

        public int getInstructionCount()
        {
            return instructions.Count;
        }
    }
}
