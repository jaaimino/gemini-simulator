/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Model for CPU
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class CPU
    {
        private int pc;
        private short inst;
        private Boolean complete;

        public CPU()
        {
            this.pc = 0;
            this.complete = false;
        }

        private void fetchInstruction(int pc)
        {

        }

        private void decodeInstruction()
        {

        }

        public Boolean isDone()
        {
            return this.complete;
        }

        //
        // Boring getters and setters below here
        //
        public int getPC()
        {
            return pc;
        }

        public void setPC(int pc)
        {
            this.pc = pc;
        }
    }
}
