/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Main Memory model
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class MainMemory
    {
        public int[] blocks;

        public MainMemory(int size)
        {
            this.blocks = new int[size];
            initializeBlocks(size);
        }

        private void initializeBlocks(int size)
        {
            for (int i = 0; i < size; i++)
            {
                blocks[i] = 0;
            }
        }
    }
}
