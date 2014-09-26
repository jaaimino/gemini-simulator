/**
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
        private short[] addresses; //Maybe should be shorts? I dunno

        public Memory()
        {
            addresses = new short[256];
        }

        void setMemoryLocation(short value, short address)
        {
            addresses[address] = value;
        }

        short getMemoryLocation(short address)
        {
            return addresses[address];
        }

    }
}
