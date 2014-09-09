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
        private static Simulation sim;

        /*
         * Start a new simulation
         */
        public static void startSimulation(String fileName)
        {
            if (!Path.GetExtension(fileName).Equals(".a"))
            {
                MessageBox.Show("Assembly file should have extension .a", "File Error");
            }
            sim = new Simulation();
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
