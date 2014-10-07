/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Model for Memory
 * Will handle cache and possible 
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Memory
    {
        //Class members
        private MainMemory memory;
        private List<short> instructions;
        private Cache cache;

        //Statistics
        int missCount;
        int hitCount;

        public Memory(List<short> instructions)
        {
            memory = new MainMemory(256);
            this.instructions = instructions;
            this.cache = new Cache(1, 12); //Should change these probably
        }

        public List<short> getInstructions()
        {
            return this.instructions;
        }

        /**
         *
         * 
         */
        public void setMemoryLocation(int address, int value)
        {
            memory.blocks[address].data = value;
        }

        public int getMemoryLocation(int address)
        {
            return memory.blocks[address].data;
        }

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
