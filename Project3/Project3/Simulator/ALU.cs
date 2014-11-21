/**
 * Author: Jacob Aimino
 * 
 * Desc: Will contain functions for executing arbitrary binary things
 * 
 * Should catch data hazards inside execute helper functions
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    static class ALU
    {
        /**
         * There's probably a better way of doing this.. but oh well ;)
         */
        public static void execute(CPU cpu, InstructionData inst)
        {
            switch (inst.opcode)
            {
                case 0:
                    LDA(cpu, inst);
                    break;
                case 1:
                    break;
                case 2:
                    ADD(cpu, inst);
                    break;
                case 3:
                    SUB(cpu, inst);
                    break;
                case 4:
                    MUL(cpu, inst);
                    break;
                case 5:
                    DIV(cpu, inst);
                    break;
                case 6:
                    AND(cpu, inst);
                    break;
                case 7:
                    OR(cpu, inst);
                    break;
                case 8:
                    SHL(cpu, inst);
                    break;
                case 9:
                    NOTA(cpu, inst);
                    break;
                case 10:
                    BA(cpu, inst);
                    break;
                case 11:
                    BE(cpu, inst);
                    break;
                case 12:
                    BL(cpu, inst);
                    break;
                case 13:
                    BG(cpu, inst);
                    break;
                case 14:
                    NOP();
                    break;
                case 15:
                    HLT(cpu);
                    break;
            }
        }

        /**
         * There's probably a better way of doing this.. but oh well ;)
         */
        public static void memoryoperation(CPU cpu, InstructionData inst)
        {
            switch (inst.opcode)
            {
                case 0:
                    break;
                case 1:
                    MemSTA(cpu, inst);
                    break;
                case 2:
                    //SetResult(cpu, inst);
                    break;
                case 3:
                    //SetResult(cpu, inst);
                    break;
                case 4:
                    //SetResult(cpu, inst);
                    break;
                case 5:
                    //SetResult(cpu, inst);
                    break;
                case 6:
                    //SetResult(cpu, inst);
                    break;
                case 7:
                    //SetResult(cpu, inst);
                    break;
                case 8:
                    //SetResult(cpu, inst);
                    break;
                case 9:
                    //SetResult(cpu, inst);
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
         * - Sets result in memory of generic accumulator function
         */
        private static void SetResult(CPU cpu, InstructionData inst)
        {
            cpu.setRegisterValue(2, inst.result);
        }

        /*
         * - LDA #$val Sets the accumulator with the value
         * - LDA $m	Sets the accumulator from a memory location
         * 
         * IMPORTANT: should stall pipeline by one cycle
         */
        private static void LDA(CPU cpu, InstructionData inst)
        {
            if (inst.immediate)
            {
                cpu.setRegisterValue(2, inst.operand);
            }
            else
            {
                cpu.setRegisterValue(2, (short)cpu.getMemory().getMemoryLocation(inst.operand));
            }
            cpu.stallPipeLine(1);
        }

        /*
         * - STA $m  Store the accumulator to a memory location
         */
        private static void MemSTA(CPU cpu, InstructionData inst)
        {
            int acc = (int)(cpu.getRegisterValue(2)); //Get accumulator value
            cpu.getMemory().setMemoryLocation(inst.operand, acc);
        }

        /*
         * - ADD $m	Add the value in memory to the accumulator
         * - ADD #$val     Add the value to the accumulator
         */
        private static void ADD(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (inst.immediate)
            {
                inst.result = (short)(acc + inst.operand);
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(inst.operand);
                inst.result = (short)(acc + value);
            }
            cpu.setRegisterValue(2, inst.result);
        }

        /*
         * - SUB $m	Subtract the value in memory to the accumulator
         * - SUB #$val     Subtract the value to the accumulator
         */
        private static void SUB(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (inst.immediate)
            {
                inst.result = (short)(acc - inst.operand);
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(inst.operand);
                inst.result = (short)(acc - value);
            }
            cpu.setRegisterValue(2, inst.result);
        }

        /*
         * - AND $m	Logical "and" of memory and accumulator
         * - AND #$val     Logical "and" of value and accumulator
         */
        private static void AND(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (inst.immediate)
            {
                inst.result = (short)(acc & inst.operand);
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(inst.operand);
                inst.result = (short)(acc & value);
            }
            cpu.setRegisterValue(2, inst.result);
        }

        /*
         * - OR  $m	Logical "or" of memory and accumulator
         * - OR  #$val     Logical "or" or value and the accumulator
         */
        private static void OR(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (inst.immediate)
            {
                inst.result = (short)(acc | inst.operand);
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(inst.operand);
                inst.result = (short)(acc | value);
            }
            cpu.setRegisterValue(2, inst.result);
        }

        /*
         * - SHL #$val Shift the accumulator by the number of bits to the left
         */
        private static void SHL(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            inst.result = (short)(acc << inst.operand);
            cpu.setRegisterValue(2, inst.result);
        }

        /*
         * - NOTA		Logical "not" of accumulator
         */
        private static void NOTA(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            inst.result = (short)~cpu.getRegisterValue(2);
            cpu.setRegisterValue(2, inst.result);
        }

        /*
         * - MUL $m        Multiply the accumulator by the value in memory
         * - MUL #$val     Multiply the accumulator by the value 
         */
        private static void MUL(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (inst.immediate)
            {
                inst.result = (short)(acc * inst.operand);
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(inst.operand);
                inst.result = (short)(acc * value);
            }
            cpu.setRegisterValue(2, inst.result);
            cpu.stallPipeLine(4);
        }

        /*
         * - DIV $m        Divide the accumulator by the value in memory
         * - DIV #$val     Divide the accumulator by the value
         */
        private static void DIV(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (inst.immediate)
            {
                inst.result = (short)(acc / inst.operand);
            }
            else
            {
                short value = (short)cpu.getMemory().getMemoryLocation(inst.operand);
                inst.result = (short)(acc / value);
            }
            cpu.setRegisterValue(2, inst.result);
            cpu.stallPipeLine(4);
        }

        /*
         * - BA lbl        Always branch to label (goto)
         */
        private static void BA(CPU cpu, InstructionData inst)
        {
            cpu.setRegisterValue(5, inst.operand);
            cpu.flushPipeline();
        }

        /*
         * - BE lbl	Branch to label if operation resulted in 0
         */
        private static void BE(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (acc == 0)
            {
                cpu.setRegisterValue(5, inst.operand);
                cpu.flushPipeline();
            }
        }

        /*
         * - BL lbl        Branch to label if operation resulted in Negative
         */
        private static void BL(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (acc < 0)
            {
                cpu.setRegisterValue(5, inst.operand);
                cpu.flushPipeline();
            }
        }

        /*
         * - BG lbl        Branch to label if operation resulted in Positive 
         */
        private static void BG(CPU cpu, InstructionData inst)
        {
            short acc = cpu.getRegisterValue(2);
            if (acc >= 0)
            {
                cpu.setRegisterValue(5, inst.operand);
                cpu.flushPipeline();
            }
        }

        /*
         * - NOP           No Operation (Implemented by adding Zero to the ACC)
         */
        private static void NOP()
        {
            Console.WriteLine("NOP executed");
        }

        /*
         * - HLT           Quit the program (not needed if the last line of the program is the end)
         */
        private static void HLT(CPU cpu)
        {
            cpu.setPC((short)(cpu.getMemory().getInstructionCount()+1));
            cpu.flushPipeline();
        }

    }
}
