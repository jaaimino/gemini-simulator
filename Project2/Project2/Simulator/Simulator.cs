/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Controller for cpuulation
 * 
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    static class Simulator
    {
        public const String OUTPUT_FILE_TYPE = ".out";
        private static GeminiSimForm form;
        private static Memory memory;
        private static CPU cpu;

        /*
         * Start a new cpuulation
         */
        public static void startSimulation(String fileName, GeminiSimForm form)
        {
            if (IsValidFile(fileName))
            {
                Simulator.form = form;
                memory = new Memory(readAllLines(fileName));
                cpu = new CPU(memory);
                form.updateViewElements(nextInstructionPreview(), cpu.getRegisterValues(), memory.getInstructionCount(), cpu.isDone());
            }
            else
            {
                MessageBox.Show("Assembly file should have extension " + OUTPUT_FILE_TYPE, "File Error");
            }
        }

        /* 
         * Take one step in simulation
         */
        public static Boolean stepSimulation()
        {
            if (null != cpu && null != memory && !cpu.isDone())
            {
                try
                {
                    cpu.Cycle();
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Segmentation fault on line " + cpu.getPC() + ". Resetting simulation.", "RunTime Exception");
                    resetSimulation(Simulator.form);
                    return false;
                }
                form.updateViewElements(nextInstructionPreview(), cpu.getRegisterValues(), memory.getInstructionCount(), cpu.isDone());
            }
            return true;
        }

        /*
         * Run cpuulation through to the end
         */
        public static void runSimulation()
        {
            //Should just call step until cpu is done
            while (null != cpu && null != memory && !cpu.isDone())
            {
                if (!stepSimulation())
                    break;
            }
        }

        public static void resetSimulation(GeminiSimForm form)
        {
            if (null != memory && null != cpu)
            {
                memory = new Memory(memory.getInstructions());
                cpu = new CPU(memory);
                Simulator.form = form;
                form.updateViewElements(nextInstructionPreview(), cpu.getRegisterValues(), memory.getInstructionCount(), cpu.isDone());
            }
        }

        private static List<short> readAllLines(String fileName)
        {
            List<short> lines = new List<short>();
            BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open));
            int pos = 0;
            short length = (short)reader.BaseStream.Length;
            while (pos < length)
            {
                short s = (short)reader.ReadInt16();
                //Console.WriteLine(Convert.ToString(s, 2));
                lines.Add(s);
                pos += sizeof(short);
            }
            reader.Close();
            return lines;

        }

        private static short nextInstructionPreview()
        {
            if ((cpu.getPC()) < memory.getInstructionCount())
            {
                return memory.getInstructionAtIndex(cpu.getPC());
            }
            else
            {
                return -1;
            }
        }

        private static Boolean IsValidFile(String fileName)
        {
            return Path.GetExtension(fileName).Equals(OUTPUT_FILE_TYPE);
        }
    }
}
