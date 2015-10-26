/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Model for CPU
 * 
 * Array Indicies for registers is [0=A][1=B][2=Acc][3=Zero][4=One][5=PC]
 * 
 *- A:  ALU input, target of ACC, TEMP, MAR, MDR, and PC
  - B:  ALU input, target of ZERO or ONE
  - ACC:  ALU output

  - ZERO:constant zero, used for LDA instruction
  - ONE:  constant one, used to increment PC and MAR
  - PC: program counter
  - MAR:  memory address register
  - MDR:  memory data register
  - TEMP:temporary ACC storage while updating PC and MAR
  - IR: instruction register, the source of the starting
      address for each machine instruction's microprogram
  - CC: Condition Code Register
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class CPU
    {
        private short[] registers; //[0=A][1=B][2=Acc][3=Zero][4=One][5=PC][6=MAR][7=MDR][8=TEMP][9=IR][10=CC]
        private Memory memory;

        public CPU(Memory memory)
        {
            this.memory = memory;
            registers = new short[11];
            registers[0] = 0; //A
            registers[1] = 0; //B
            registers[2] = 0; //Acc
            registers[3] = 0; //ZERO
            registers[4] = 1; //ONE
            registers[5] = 0; //PC
            registers[6] = 0; //MAR
            registers[7] = 0; //MDR
            registers[8] = 0; //TEMP
            registers[9] = 0; //IR (Get first instruction ready to process)
            registers[10] = 0; //CC
        }

        public void Cycle()
        {
            FetchInstruction();
            short instruction = registers[9];

            //Break apart short value to parts
            short opcode = (short)Translator.decodeCommand(instruction);
            Boolean immediate = Translator.decodeImmediateFlag(instruction);
            short operand = (short)Translator.decodeOperand(instruction);

            //Add one to PC
            registers[5]++;

            //Carry out instruction
            ALU.execute(this, opcode, immediate, operand);
        }

        /**
         * Fetch the next instruction to be done based on PC
         * and memory input
         */
        public void FetchInstruction()
        {
            registers[9] = memory.getInstructionAtIndex(getPC());
        }

        public Boolean isDone()
        {
            return registers[5] > memory.getInstructionCount()-1;
        }

        //-------------------------------------------------
        // Boring getters and setters below here
        //-------------------------------------------------
        public Memory getMemory()
        {
            return this.memory;
        }

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
