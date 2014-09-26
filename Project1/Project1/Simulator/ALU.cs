/**
 * Author: Jacob Aimino
 * 
 * Desc: Will contain functions for executing arbitrary binary things
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    static class ALU
    {

        /*
        - LDA #$val Sets the accumulator with the value
        - LDA $m	Sets the accumulator from a memory location
        - STA $m  Store the accumulator to a memory location
        - ADD $m	Add the value in memory to the accumulator
          ADD #$val     Add the value to the accumulator
        - SUB $m	Subtract the value in memory to the accumulator
          SUB #$val     Subtract the value to the accumulator
        - MUL $m        Multiply the accumulator by the value in memory
          MUL #$val     Multiply the accumulator by the value 
        - DIV $m        Divide the accumulator by the value in memory
          DIV #$val     Divide the accumulator by the value
        - AND $m	Logical "and" of memory and accumulator
          AND #$val     Logical "and" of value and accumulator
        - OR  $m	Logical "or" of memory and accumulator
          OR  #$val     Logical "or" or value and the accumulator
        - SHL #$val Shift the accumulator by the number of bits to the left
        - NOTA		Logical "not" of accumulator
        - BA lbl        Always branch to label (goto)
        - BE lbl	Branch to label if operation resulted in 0
        - BL lbl        Branch to label if operation resulted in Negative
        - BG lbl        Branch to label if operation resulted in Positive 
        - NOP           No Operation (Implemented by adding Zero to the ACC)
        - HLT           Quit the program (not needed if the last line of the program is the end)
        */

        /**
         * There's probably a better way of doing this.. but oh well ;)
         */
        public void execute(short opcode, Boolean immediateflag, short operand){
            switch (opcode)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
            }
        }

        private void LDA()
        {

        }

    }
}
