using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public abstract class Cache
    {
        int blockSize; //(Min of 1 word, Max of 2 words)
        Block[] blocks; //(Min of 2 blocks, Max of 16 blocks)

        /**
         * Find address as defined by mapping function
         */
        abstract public int findAddress(int address);

        /**
         * Frame Size, num frames
         */
        public Cache(int blockSize, int blocks)
        {
            this.blockSize = blockSize;
            this.blocks = new Block[blocks];
        }

        /**
         * Should always make sure block is in cache before calling this
         */
        public void writeBlock(int address, int value)
        {
            Block target = blocks[findAddress(address)];
            target.data = value;
            target.dirty = true;
        }

        /**
         * Should always make sure block is in cache before calling this
         */
        public int readBlock(int address)
        {
            return blocks[findAddress(address)].data;
        }

        public Boolean containsBlock(int address)
        {
            if (null == blocks[findAddress(address)])
            {
                return false;
            }
            return blocks[findAddress(address)].getTag() == address;
        }
        
    }
}
