using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Cache
    {
        int blockSize; //(Min of 1 word, Max of 2 words)
        Addresses[] blocks; //(Min of 2 blocks, Max of 16 blocks)

        /**
         * Frame Size, num frames
         */
        public Cache(int blockSize, int blocks)
        {
            this.blockSize = blockSize;
            this.blocks = new Addresses[blocks];
        }

        Boolean containsBlock(int blockNumber)
        {
            return false;
        }
    }
}
