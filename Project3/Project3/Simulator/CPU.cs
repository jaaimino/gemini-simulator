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
 * Autoresetevent
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    public class CPU
    {
        private short[] registers; //[0=A][1=B][2=Acc][3=Zero][4=One][5=PC][6=MAR][7=MDR][8=TEMP][9=IR][10=CC]
        private Memory memory;

        //For pipelining
        private InstructionData[] queue;
        private int stall;

        public CPU(Memory memory)
        {
            this.memory = memory;
            this.stall = 0;
            this.queue = new InstructionData[4];
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
            this.stall = 0;
        }

        public void Cycle()
        {
            if (true) //Read from settings file to see if pipelining is activated
            {
                //If stall is set, don't move everything
                if (stall >= 1)
                {
                    queue[3] = queue[2];
                    queue[2] = NOPFactory();
                    stall = stall - 1;
                    Console.WriteLine("Delay is " + stall);
                }
                else //No stall, so move along
                {
                    queue[3] = queue[2];
                    queue[2] = queue[1];
                    queue[1] = queue[0];
                    short inst = FindNextInstruction();
                    queue[0] = (inst < 0) ? null : new InstructionData(inst);
                }

                //Set up threads to do next step

                //Fetch Thread
                ((FetchThread)ThreadManager.pipeThreads[0]).registers = this.registers;
                ((FetchThread)ThreadManager.pipeThreads[0]).inst = queue[0];

                //Decode Thread
                ((DecodeThread)ThreadManager.pipeThreads[1]).inst = queue[1];

                //Execute Thread
                ((ExecuteThread)ThreadManager.pipeThreads[2]).inst = queue[2];
                ((ExecuteThread)ThreadManager.pipeThreads[2]).cpu = this;

                //Store Thread
                ((StoreThread)ThreadManager.pipeThreads[3]).inst = queue[3];
                ((StoreThread)ThreadManager.pipeThreads[3]).cpu = this;

                //Set all other threads so they can execute
                foreach (OperationThread t in ThreadManager.pipeThreads)
                {
                    t.listener.Set();
                }

                //Waits on other threads
                foreach (AutoResetEvent a in ThreadManager.threadListeners)
                {
                    a.WaitOne();
                }

                //Add one to PC
                if (!isDone() && (stall <= 0))
                {
                    registers[5]++;
                }

                if (isDone())
                {
                }
            }
            else //Do non-pipeline stuff here
            {
                short instruction = FindNextInstruction();
                registers[9] = instruction;

                //Break apart short value to parts
                short opcode = (short)Translator.decodeCommand(instruction);
                Boolean immediate = Translator.decodeImmediateFlag(instruction);
                short operand = (short)Translator.decodeOperand(instruction);

                //Add one to PC
                registers[5]++;

                //Carry out instruction
                //ALU.execute(this, inst);
            }
        }

        public void stallPipeLine(int cycles)
        {
            this.stall += cycles;
        }

        private InstructionData NOPFactory()
        {
            const short NOP = 28672;
            InstructionData inst = new InstructionData(28672);
            inst.opcode = Translator.decodeCommand(NOP);
            inst.immediate = false;
            inst.operand = Translator.decodeOperand(NOP);
            return inst;
        }

        /**
         * Fetch the next instruction to be done based on PC
         * and memory input
         */
        public short FindNextInstruction()
        {
            if (getPC() < memory.getInstructions().Count())
            {
                return memory.getInstructionAtIndex(getPC());
            }
            else
            {
                return -1;
            }
        }

        private Boolean queueIsEmpty()
        {
            return (null == queue[0] && null == queue[1] && null == queue[2] && null == queue[3]);
        }

        public Boolean isDone()
        {
            
            return (getPC() > memory.getInstructionCount()-1) && queueIsEmpty();
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

        public InstructionData[] getQueue()
        {
            return this.queue;
        }
    }
}
