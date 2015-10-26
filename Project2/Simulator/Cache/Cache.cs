using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Cache
    {
        private int setSize; //(Min of 1 word, Max of 2 words)
        private int numFrames; //(Min of 2 blocks, Max of 16 blocks)
        private Set[] sets;

        /**
         * Frame Size, num frames
         */
        public Cache(int setSize, int numFrames)
        {
            this.setSize = setSize;
            this.numFrames = numFrames;
            this.sets = new Set[numFrames / setSize];
            initSets(setSize, numFrames / setSize);
        }

        private void initSets(int setSize, int numSets)
        {
            for (int i = 0; i < numSets; i++)
            {
                sets[i] = new Set(setSize);
            }
        }

        /**
         * Find set associated with address
         */
        private int findSet(int address)
        {
            //Console.WriteLine(address % sets.Length);
            return address % sets.Length;
        }

        /**
         * Finds set associated with address, then frame
         */
        private Frame find(int address)
        {
            return sets[findSet(address)].getFrame(address);
        }

        /**
         * Should be called if address is not in cache
         * and needs to be paged in
         */
        public void pageBlock(int address, MainMemory memory)
        {
            int frameLoc = randomFrame(setSize);
            Frame oldFrame = sets[findSet(address)].getFrameFromIndex(frameLoc);
            Frame frame = new Frame(address);
            frame.data = memory.addresses[address];

            //Old frame was written to and needs to be written back
            if(null != oldFrame && oldFrame.dirty)
            {
                memory.addresses[oldFrame.getTag()] = oldFrame.data;
            }
            sets[findSet(address)].replaceFrame(frameLoc, frame);
        }

        /**
         * Should always make sure block is in cache before calling this
         */
        public void writeAddress(int address, int value)
        {
            Frame target = find(address);
            target.data = value;
            target.dirty = true;
        }

        /**
         * Should always make sure block is in cache before calling this
         */
        public int readAddress(int address)
        {
            return find(address).data;
        }

        /**
         * Check if cache contains specified block
         */
        public Boolean containsBlock(int address)
        {
            return sets[findSet(address)].containsFrame(address);
        }

        private int randomFrame(int setSize)
        {
            int rand = new Random().Next(0, setSize);
            //Console.WriteLine(rand);
            return rand;
        }
    }
}
