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

        public void logBranch(short instruction, Boolean taken)
        {
            if (table.ContainsKey(instruction))
            {
                table[instruction] = (taken) ? (table[instruction] - 1) : (table[instruction] + 1);
            }
            else
            {
                table[instruction] = (taken) ? 1 : -1;
            }
        }

        public Boolean shouldBranch(short instruction)
        {
            return false;
        }
    }
}
