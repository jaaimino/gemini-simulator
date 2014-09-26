/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Controller for Simulation
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
        private static Simulation sim;

        /*
         * Start a new simulation
         */
        public static void startSimulation(String fileName)
        {
            if (IsValidFile(fileName))
            {
                sim = new Simulation(readAllLines(fileName));
            }
            else
            {
                MessageBox.Show("Assembly file should have extension " + OUTPUT_FILE_TYPE, "File Error");
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
                Console.WriteLine(Convert.ToString(s, 2));
                lines.Add(s);
		        pos += sizeof(short);
	        }
            return lines;
        }

        /*
         * Run simulation through to the end
         */
        public static void runSimulation()
        {
            sim.run();
        }

        /* 
         * Take one step in simulation
         */
        public static void stepSimulation()
        {
            sim.step();
        }

        private static Boolean IsValidFile(String fileName)
        {
            return Path.GetExtension(fileName).Equals(OUTPUT_FILE_TYPE);
        }
    }
}
