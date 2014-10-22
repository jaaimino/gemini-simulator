using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Set
    {
        private Frame[] frames;

        public Set(int setSize)
        {
            this.frames = new Frame[setSize];
        }

        public Frame getFrame(int address)
        {
            foreach (Frame frame in frames)
            {
                if(null != frame && frame.getTag() == address)
                    return frame;
            }
            return null;
        }

        public Frame getFrameFromIndex(int index)
        {
            return frames[index];
        }

        public void replaceFrame(int index, Frame frame)
        {
            frames[index] = frame;
        }

        public Boolean containsFrame(int address)
        {
            for (int i = 0; i < frames.Length; i++)
            {
                if (null != frames[i] && frames[i].getTag() == address) return true;
            }
            return false;
        }
    }
}
