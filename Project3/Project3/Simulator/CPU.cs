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

namespace Project3
{
    public class CPU
    {
        private short[] registers; //[0=A][1=B][2=Acc][3=Zero][4=One][5=PC][6=MAR][7=MDR][8=TEMP][9=IR][10=CC]
        private Memory memory;

        //For pipelining
        private Instruction[] queue;
        private List<Instruction> viewList;
        private int delay;

        public CPU(Memory memory)
        {
            this.memory = memory;
            this.delay = 0;
            this.queue = new Instruction[4];
            this.viewList = new List<Instruction>();
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
            if (true) //Read from settings file to see if pipelining is activated
            {
                //Do any setup first
                short inst = FindNextInstruction();
                queue[0] = (inst < 0) ? null : new Instruction(inst);
                if (null != queue[0])
                {
                    viewList.Add(queue[0]);
                }

                //Console.WriteLine("Starting threads.");
                OperationThread pipe1 = (null == queue[0]) ? null : new FetchThread(queue[0], registers); //Fetch - Get the instruction into the IR...
                OperationThread pipe2 = (null == queue[1]) ? null : new DecodeThread(queue[1]); //Decode - Determine what the instruction wants to do...
                OperationThread pipe3 = (null == queue[2]) ? null : new ExecuteThread(queue[2], this); //Execute - Perform the instruction
                OperationThread pipe4 = (null == queue[3]) ? null : new StoreThread(); //Store - If needed, write back any data to registers AND memory.

                if (null != pipe1)
                {
                    pipe1.thrd.Join();
                    //Console.WriteLine(pipe1.thrd.Name + " reported back.");
                    //Console.WriteLine("IR Has: " + registers[9]);
                }

                if (null != pipe2)
                {
                    pipe2.thrd.Join();
                    //Console.WriteLine(pipe2.thrd.Name + " reported back.");
                }

                if (null != pipe3)
                {
                    pipe3.thrd.Join();
                    //Console.WriteLine(pipe3.thrd.Name + " reported back.");
                }

                if (null != pipe4)
                {
                    pipe4.thrd.Join();
                    //Console.WriteLine(pipe4.thrd.Name + " reported back.");
                }

                //Do post execute stuff
                if (null != queue[3])
                {
                    viewList.Remove(queue[3]);
                }
                queue[3] = queue[2];
                queue[2] = queue[1];
                queue[1] = queue[0];
                //Console.WriteLine("All threads finished.");

                //Add one to PC
                registers[5]++;
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
                ALU.execute(this, opcode, immediate, operand);
            }
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
            
            return (registers[5] > memory.getInstructionCount()-1) && queueIsEmpty();
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

        public List<Instruction> getViewList()
        {
            return this.viewList;
        }
    }
}
