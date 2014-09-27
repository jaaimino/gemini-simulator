/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Model for CPU
 * 
 * Array Indicies for registers is [0=A][1=B][2=Acc][3=Zero][4=One][5=PC]
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
        private short[] registers; //[0=A][1=B][2=Acc][3=Zero][4=One][5=PC][6=MAR][7=MDR][8=TEMP][9=IR][10=CC]

        public CPU()
        {
            registers = new short[11];
            registers[0] = 0;
            registers[1] = 0;
            registers[2] = 0;
            registers[3] = 0; //Should stay at 0
            registers[4] = 1; //Should stay at 1
            registers[5] = 0; //PC here
            registers[6] = 0;
            registers[7] = 0;
            registers[8] = 0;
            registers[9] = 0;
            registers[10] = 0;
        }

        public void cycle(Simulation sim)
        {
            short instruction = sim.getMemory().getInstructionAtIndex(registers[5]);
            short opcode = (short)Decoder.decodeCommand(instruction);
            Boolean immediate = Decoder.decodeImmediateFlag(instruction);
            short operand = (short)Decoder.decodeOperand(instruction);
            ALU.execute(sim, opcode, immediate, operand);
            registers[5]++;
        }

        public Boolean isDone(int instructionCount)
        {
            return registers[5] > instructionCount-1;
        }

        //-------------------------------------------------
        // Boring getters and setters below here
        //-------------------------------------------------

        public short getRegisterValue(int index)
        {
            return registers[index];
        }

        public void setRegisterValue(int index, short value)
        {
            registers[index] = value;
        }

        public short[] getRegisterValues()
        {
            return registers;
        }

        public int getPC()
        {
            return registers[5];
        }

        public void setPC(short pc)
        {
            this.registers[5] = pc;
        }
    }
}
