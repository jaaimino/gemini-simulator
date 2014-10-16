using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Cache
    {
        private int blockSize; //(Min of 1 word, Max of 2 words)
        private Block[] blocks; //(Min of 2 blocks, Max of 16 blocks)

        /**
         * Find address as defined by mapping function
         */
        abstract public int findAddress(int address);

        /**
         * Should be called if address is not in cache
         * and needs to be paged in
         */
        public abstract void pageBlock(int address, MainMemory memory);

        /**
         * Frame Size, num frames
         */
        public Cache(int blockSize, int numBlocks)
        {
            this.blockSize = blockSize;
            this.blocks = new Block[numBlocks];
        }

        /**
         * Should always make sure block is in cache before calling this
         */
        public void writeAddress(int address, int value)
        {
            Frame target = blocks[findAddress(address)];
            target.data = value;
            target.dirty = true;
        }

        /**
         * Should always make sure block is in cache before calling this
         */
        public int readAddress(int address)
        {
            return blocks[findAddress(address)].data;
        }

        /**
         * Check if cache contains specified block
         */
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
