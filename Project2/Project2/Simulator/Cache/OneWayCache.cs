/**
 * Author: Jacob Aimino
 * 
 * Desc: One-Way Associative (Direct Mapped) Cache Model
 * 
 * Frame # = Block # % Cache Size 
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class OneWayCache : Cache
    {
        public OneWayCache(int blockSize, int blocks) : base(blockSize, blocks)
        {

        }

        public override void pageBlock(int address, MainMemory memory)
        {
            int cacheIndex = findAddress(address);
            if (null != frames[cacheIndex] && frames[cacheIndex].dirty)
            {
                int oldAddress = frames[cacheIndex].getTag();
                memory.blocks[oldAddress] = frames[cacheIndex].data;
            }
            frames[cacheIndex] = new Block(address);
            frames[cacheIndex].data = memory.blocks[address];

        }

        public override int findAddress(int address)
        {
            return address % this.frames.Length;
        }
    }
}
