using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
