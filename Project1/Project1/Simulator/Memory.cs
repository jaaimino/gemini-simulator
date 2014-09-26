﻿/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Model for Memory
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Memory
    {
        private int[] addresses; //Maybe should be shorts? I dunno
        private List<short> instructions;

        public Memory(List<short> instructions)
        {
            addresses = new int[256];
            this.instructions = instructions;
        }

        void setMemoryLocation(short value, short address)
        {
            addresses[address] = value;
        }

        int getMemoryLocation(int address)
        {
            return addresses[address];
        }

        public short getInstructionAtIndex(int index)
        {
            return instructions.ElementAt(index);
        }
    }
}
