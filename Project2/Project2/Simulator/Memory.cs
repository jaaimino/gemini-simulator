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
        //Utility type
        public enum CacheType { ONEWAY, TWOWAY };

        //Class members
        private MainMemory memory;
        private List<short> instructions;
        private Cache cache;

        //Statistics
        int missCount;
        int hitCount;

        public Memory(CacheType type, List<short> instructions)
        {
            memory = new MainMemory(256);
            this.instructions = instructions;
            this.cache = InitCache(type);
        }

        private Cache InitCache(CacheType type)
        {
            switch (type)
            {
                case CacheType.TWOWAY:
                    return new TwoWayCache();
                default:
                    return new OneWayCache(1, 12);
            }
        }

        public List<short> getInstructions()
        {
            return this.instructions;
        }

        /**
         * Will check if it's in cache, if it is, call cache set value
         * Else, write directly to main memory
         */
        public void setMemoryLocation(int address, int value)
        {
            memory.blocks[address] = value;
        }

        /**
         * Will check cache for value first, if it's there, read from cache
         * If not, will grab data from main memory and put it in cache,
         * randomly replacing a block
         */
        public int getMemoryLocation(int address)
        {
            return memory.blocks[address];
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
