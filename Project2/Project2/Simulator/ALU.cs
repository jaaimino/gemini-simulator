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

namespace Project2
{
    static class ALU
    {
        /**
         * There's probably a better way of doing this.. but oh well ;)
         */
        public static void execute(CPU cpu, short opcode, Boolean immediateflag, short operand)
        {
            switch (opcode)
            {
                case 0:
                    LDA(cpu, immediateflag, operand);
                    break;
                case 1:
                    STA(cpu, operand);
                    break;
                case 2:
                    ADD(cpu, immediateflag, operand);
                    break;
                case 3:
                    SUB(cpu, immediateflag, operand);
                    break;
                case 4:
                    MUL(cpu, immediateflag, operand);
                    break;
                case 5:
                    DIV(cpu, immediateflag, operand);
                    break;
                case 6:
                    AND(cpu, immediateflag, operand);
                    break;
                case 7:
                    OR(cpu, immediateflag, operand);
                    break;
                case 8:
                    SHL(cpu, operand);
                    break;
                case 9:
                    NOTA(cpu);
                    break;
                case 10:
                    BA(cpu, operand);
                    break;
                case 11:
                    BE(cpu, operand);
                    break;
                case 12:
                    BL(cpu, operand);
                    break;
                case 13:
                    BG(cpu, operand);
                    break;
                case 14:
                    NOP();
                    break;
                case 15:
                    HLT(cpu);
                    break;
            }
        }

        /*
         * - LDA #$val Sets the accumulator with the value
         * - LDA $m	Sets the accumulator from a memory location
         */
        private static void LDA(CPU cpu, Boolean immediate, short operand)
        {
            if (immediate)
            {
                cpu.setRegisterValue(2, operand);
            }
            else
            {
                cpu.setRegisterValue(2, (short)cpu.getMemory().getMemoryLocation(operand));
            }
        }

        /*
         * - STA $m  Store the accumulator to a memory location
         */
        private static void STA(CPU cpu, short operand)
        {
            int acc = (int)(cpu.getRegisterValue(2)); //Get accumulator value
            cpu.getMemory().setMemoryLocation(operand, acc);
        }

        /*
         * - ADD $m	Add the value in memory to the accumulator
         * - ADD #$val     Add the value to the accumulator
         */
        private static void ADD(CPU cpu, Boolean immediate, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (immediate)
            {
                cpu.setRegisterValue(2, (short)(acc + operand));
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(operand);
                cpu.setRegisterValue(2, (short)(acc + value));
            }
        }

        /*
         * - SUB $m	Subtract the value in memory to the accumulator
         * - SUB #$val     Subtract the value to the accumulator
         */
        private static void SUB(CPU cpu, Boolean immediate, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (immediate)
            {
                cpu.setRegisterValue(2, (short)(acc - operand));
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(operand);
                cpu.setRegisterValue(2, (short)(acc - value));
            }
        }

        /*
         * - AND $m	Logical "and" of memory and accumulator
         * - AND #$val     Logical "and" of value and accumulator
         */
        private static void AND(CPU cpu, Boolean immediate, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (immediate)
            {
                cpu.setRegisterValue(2, (short)(acc & operand));
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(operand);
                cpu.setRegisterValue(2, (short)(acc & value));
            }
        }

        /*
         * - OR  $m	Logical "or" of memory and accumulator
         * - OR  #$val     Logical "or" or value and the accumulator
         */
        private static void OR(CPU cpu, Boolean immediate, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (immediate)
            {
                cpu.setRegisterValue(2, (short)(acc | operand));
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(operand);
                cpu.setRegisterValue(2, (short)(acc | value));
            }
        }

        /*
         * - SHL #$val Shift the accumulator by the number of bits to the left
         */
        private static void SHL(CPU cpu, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            cpu.setRegisterValue(2, (short)(acc << operand));
        }

        /*
         * - NOTA		Logical "not" of accumulator
         */
        private static void NOTA(CPU cpu)
        {
            short acc = cpu.getRegisterValue(2);
            cpu.setRegisterValue(2, (short)~cpu.getRegisterValue(2));
        }

        /*
         * - MUL $m        Multiply the accumulator by the value in memory
         * - MUL #$val     Multiply the accumulator by the value 
         */
        private static void MUL(CPU cpu, Boolean immediate, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (immediate)
            {
                cpu.setRegisterValue(2, (short)(acc * operand));
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(operand);
                cpu.setRegisterValue(2, (short)(acc * value));
            }
        }

        /*
         * - DIV $m        Divide the accumulator by the value in memory
         * - DIV #$val     Divide the accumulator by the value
         */
        private static void DIV(CPU cpu, Boolean immediate, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (immediate)
            {
                cpu.setRegisterValue(2, (short)(acc / operand));
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(operand);
                cpu.setRegisterValue(2, (short)(acc / value));
            }
        }

        /*
         * - BA lbl        Always branch to label (goto)
         */
        private static void BA(CPU cpu, short operand)
        {
            cpu.setRegisterValue(5, operand);
        }

        /*
         * - BE lbl	Branch to label if operation resulted in 0
         */
        private static void BE(CPU cpu, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (acc == 0)
            {
                cpu.setRegisterValue(5, operand);
            }
        }

        /*
         * - BL lbl        Branch to label if operation resulted in Negative
         */
        private static void BL(CPU cpu, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (acc < 0)
            {
                cpu.setRegisterValue(5, operand);
            }
        }

        /*
         * - BG lbl        Branch to label if operation resulted in Positive 
         */
        private static void BG(CPU cpu, short operand)
        {
            short acc = cpu.getRegisterValue(2);
            if (acc >= 0)
            {
                cpu.setRegisterValue(5, operand);
            }
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
        private static void HLT(CPU cpu)
        {
            cpu.setPC((short)(cpu.getMemory().getInstructionCount()+1));
        }

    }
}
