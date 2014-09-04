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
        int[] addresses; //Maybe should be shorts? I dunno

        public Memory()
        {
            addresses = new int[256];
        }
    }
}
