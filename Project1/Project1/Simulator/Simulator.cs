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
            if (Path.GetExtension(fileName).Equals(OUTPUT_FILE_TYPE))
            {
                sim = new Simulation();
            }
            else
            {
                MessageBox.Show("Assembly file should have extension " + OUTPUT_FILE_TYPE, "File Error");
            }
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
    }
}
