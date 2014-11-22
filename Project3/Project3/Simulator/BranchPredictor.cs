/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Branch predictor for CPU
 * 
 * Contains logic functions and data
 * structure for branch prediction
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class BranchPredictor
    {
        private Dictionary<short, int> table;

        public BranchPredictor()
        {
            this.table = new Dictionary<short, int>();
        }

        /**
         * Should log whether the branch was taken or not on execute
         */
        public void logBranch(short instruction, Boolean taken)
        {
            if (table.ContainsKey(instruction))
            {
                table[instruction] = (taken) ? (table[instruction] + 1) : (table[instruction] - 1);
            }
            else
            {
                table[instruction] = (taken) ? 1 : -1;
            }
            /*
            Console.WriteLine("[-- Branch table --]");
            foreach (short s in table.Keys){
                Console.WriteLine(Translator.convertToHumanString(s) + ": " + table[s]);
            }*/
        }

        /**
         * If branch table contains the instruction key,
         * and likelyhood that branch should be taken is
         * greater than 0, do it, otherwise, nope
         * 
         */
        public Boolean shouldBranch(short instruction)
        {
            if (table.ContainsKey(instruction))
            {
                return table[instruction] > 0;
            }
            return false;
        }
    }
}
