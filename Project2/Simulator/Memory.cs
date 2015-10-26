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
        public int missCount;
        public int hitCount;

        public Memory(String cacheType, int cacheSize, List<short> instructions)
        {
            memory = new MainMemory(256);
            this.instructions = instructions;
            this.cache = InitCache(cacheType, cacheSize);
        }

        private Cache InitCache(String type, int cacheSize)
        {
            if (type.Equals("1"))
                return new Cache(2, cacheSize);
            else
                return new Cache(1, cacheSize);
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
            if (cache.containsBlock(address)) //Hit
            {
                Logger.writeLine("[Cache] Write hit at memory address " + address);
                hitCount++;
                cache.writeAddress(address, value);
            }
            else //Miss
            {
                Logger.writeLine("[Cache] Write miss at memory address " + address);
                missCount++;
                memory.addresses[address] = value;
            }
        }

        /**
         * Will check cache for value first, if it's there, read from cache
         * If not, will grab data from main memory and put it in cache,
         * randomly replacing a block then read
         */
        public int getMemoryLocation(int address)
        {
            if (cache.containsBlock(address)) //Hit
            {
                Logger.writeLine("[Cache] Read hit at memory address " + address);
                hitCount++;
                return cache.readAddress(address);
            }
            else //Miss
            {
                Logger.writeLine("[Cache] Read miss at memory address " + address + " going to page it in");
                missCount++;
                cache.pageBlock(address, memory);
                return cache.readAddress(address);
            }
        }

        public short getInstructionAtIndex(int index)
        {
            return instructions.ElementAt(index);
        }

        public int getInstructionCount()
        {
            return instructions.Count;
        }

        public Cache getCache()
        {
            return this.cache;
        }
    }
}
