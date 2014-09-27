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
        /**
         * There's probably a better way of doing this.. but oh well ;)
         */
        public static void execute(Simulation sim, short opcode, Boolean immediateflag, short operand){
            switch (opcode)
            {
                case 0:
                    LDA(sim, immediateflag, operand);
                    break;
                case 1:
                    STA(sim, operand);
                    break;
                case 2:
                    ADD(sim, immediateflag, operand);
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

        /*
         * - LDA #$val Sets the accumulator with the value
         * - LDA $m	Sets the accumulator from a memory location
         */
        private static void LDA(Simulation sim, Boolean immediate, short operand)
        {
            CPU cpu = sim.getCPU();
            if (immediate)
            {
                cpu.setRegisterValue(2, operand);
            }
            else
            {
                cpu.setRegisterValue(2, (short)sim.getMemory().getMemoryLocation(operand));
            }
        }

        /*
         * - STA $m  Store the accumulator to a memory location
         */
        private static void STA(Simulation sim, int operand)
        {
            int acc = (int)(sim.getCPU().getRegisterValue(0)); //Get accumulator value
            sim.getMemory().setMemoryLocation(operand, acc);
        }

        /*
         * - ADD $m	Add the value in memory to the accumulator
         * - ADD #$val     Add the value to the accumulator
         */
        private static void ADD(Simulation sim, Boolean immediate, short operand)
        {
            CPU cpu = sim.getCPU();
            short acc = sim.getCPU().getRegisterValue(2);
            if (immediate)
            {
                cpu.setRegisterValue(2, (short)(acc+operand));
            }
            else
            {
                short value = (short)sim.getMemory().getMemoryLocation(operand);
                cpu.setRegisterValue(2, (short)(acc+value));
            }
        }

        /*
         * - SUB $m	Subtract the value in memory to the accumulator
         * - SUB #$val     Subtract the value to the accumulator
         */
        private static void SUB()
        {

        }

        /*
         * - MUL $m        Multiply the accumulator by the value in memory
         * - MUL #$val     Multiply the accumulator by the value 
         */
        private static void MUL()
        {

        }

        /*
         * - DIV $m        Divide the accumulator by the value in memory
         * - DIV #$val     Divide the accumulator by the value
         */
        private static void DIV()
        {

        }

        /*
         * - AND $m	Logical "and" of memory and accumulator
         * - AND #$val     Logical "and" of value and accumulator
         */
        private static void AND()
        {

        }

        /*
         * - OR  $m	Logical "or" of memory and accumulator
         * - OR  #$val     Logical "or" or value and the accumulator
         */
        private static void OR()
        {

        }

        /*
         * - SHL #$val Shift the accumulator by the number of bits to the left
         */
        private static void SHL()
        {

        }

        /*
         * - NOTA		Logical "not" of accumulator
         */
        private static void NOTA()
        {

        }

        /*
         * - BA lbl        Always branch to label (goto)
         */
        private static void BA()
        {

        }

        /*
         * - BE lbl	Branch to label if operation resulted in 0
         */
        private static void BE()
        {

        }

        /*
         * - BL lbl        Branch to label if operation resulted in Negative
         */
        private static void BL()
        {

        }

        /*
         * - BG lbl        Branch to label if operation resulted in Positive 
         */
        private static void BG()
        {

        }

        /*
         * - NOP           No Operation (Implemented by adding Zero to the ACC)
         */
        private static void NOP()
        {

        }

        /*
         * - HLT           Quit the program (not needed if the last line of the program is the end)
         */
        private static void HLT()
        {

        }

    }
}
