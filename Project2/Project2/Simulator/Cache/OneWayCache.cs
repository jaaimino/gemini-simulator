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

        protected override void replaceBlock(int address, int cacheIndex)
        {

        }

        public override int findAddress(int address)
        {
            return address % this.frames.Length;
        }
    }
}
