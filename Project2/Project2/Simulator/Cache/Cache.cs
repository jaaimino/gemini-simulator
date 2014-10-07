using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Cache
    {
        int frameSize; //(Min of 1 word, Max of 2 words)
        int frames; //(Min of 2 blocks, Max of 16 blocks)

        public Cache(int frameSize, int frames)
        {
            this.frameSize = frameSize;
            this.frames = frames;
        }
    }
}
