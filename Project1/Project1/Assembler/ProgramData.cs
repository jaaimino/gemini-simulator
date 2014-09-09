/**
 * 
 * Author: Jacob Aimino
 *
 * Desc: Model for Assembly Program while it's
 * being parsed
 * 
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class ProgramData
    {
        List<String> labels;
        Dictionary<String, List<String>> labelDict;
        //Some sort of map needed here for labels
        //Maybe an array with each line of the program in a slot
        public ProgramData()
        {
            labelDict = new Dictionary<string, List<string>>();
        }

        public void addLabel(String name, List<String> lines)
        {
            labels.Add(name);
            labelDict.Add(name, lines);
        }
        public List<String> getLines(String label)
        {
            return labelDict[label];
        }
    }
}