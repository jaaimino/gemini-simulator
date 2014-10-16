using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public abstract class Cache
    {
        protected int blockSize; //(Min of 1 word, Max of 2 words)
        protected Block[] frames; //(Min of 2 blocks, Max of 16 blocks)

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
        public Cache(int blockSize, int blocks)
        {
            this.blockSize = blockSize;
            this.frames = new Block[blocks];
        }

        /**
         * Should always make sure block is in cache before calling this
         */
        public void writeAddress(int address, int value)
        {
            Block target = frames[findAddress(address)];
            target.data = value;
            target.dirty = true;
        }

        /**
         * Should always make sure block is in cache before calling this
         */
        public int readAddress(int address)
        {
            return frames[findAddress(address)].data;
        }

        /**
         * Check if cache contains specified block
         */
        public Boolean containsBlock(int address)
        {
            if (null == frames[findAddress(address)])
            {
                return false;
            }
            return frames[findAddress(address)].getTag() == address;
        }

    }
}
