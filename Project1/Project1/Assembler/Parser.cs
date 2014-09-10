/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Parser for Assembler
 * 
 *         (Note that $val indicates a memory location
                   #$val indicates an actual value from the text segment)

        - LDA #$val Sets the accumulator with the value
        - LDA $m	Sets the accumulator from a memory location
        - STA $m  Store the accumulator to a memory location
        - ADD $m	Add the value in memory to the accumulator
          ADD #$val     Add the value to the accumulator
        - SUB $m	Subtract the value in memory to the accumulator
          SUB #$val     Subtract the value to the accumulator
        - MUL $m        Multiply the accumulator by the value in memory
          MUL #$val     Multiply the accumulator by the value 
        - DIV $m        Divide the accumulator by the value in memory
          DIV #$val     Divide the accumulator by the value
        - AND $m	Logical "and" of memory and accumulator
          AND #$val     Logical "and" of value and accumulator
        - OR  $m	Logical "or" of memory and accumulator
          OR  #$val     Logical "or" or value and the accumulator
        - SHL #$val Shift the accumulator by the number of bits to the left
        - NOTA		Logical "not" of accumulator
        - BA lbl        Always branch to label (goto)
        - BE lbl	Branch to label if operation resulted in 0
        - BL lbl        Branch to label if operation resulted in Negative
        - BG lbl        Branch to label if operation resulted in Positive 
        - NOP           No Operation (Implemented by adding Zero to the ACC)
        - HLT           Quit the program (not needed if the last line of the program is the end)
 * 
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project1
{
    public static class Parser
    {
        public static ProgramData ParseSource(List<String> lines)
        {
            ProgramData data = new ProgramData();

            //Remove all
            for (int i = 0; i < lines.Count; i++)
            {
                String line = lines.ElementAt(i);
                line = stripComments(line);
                if (labelMatch(line))
                {
                    //Do something
                }
                else if (parseCommandWithImmediate(line))
                {
                    //Do something else
                }
                else if (parseCommandWithMemory(line))
                {
                    //Do something else
                }
                else if (parseCommandWithNoArgs(line))
                {
                    //Do something else
                }
                Console.WriteLine(i + " " + line);
            }
            return data;
        }

        /*
         * Finds everything after and including comment character \s*(?P<test>[!].*)
         */
        private static String stripComments(String line)
        {
            //Console.WriteLine("Before filter: " + line);
            line = Regex.Replace(line, @"\s*[!].*", "");
            //Console.WriteLine("After filter: " + line);
            return line;
        }

        /*
         * Match command with single immediate argument
         */
        private static Boolean labelMatch(String line)
        {
            Regex labelStmtFormat = new Regex(@"^(?<label>.*?)\s*:$");
            var labelStmtMatch = labelStmtFormat.Match(line);
            if (labelStmtMatch.Success)
            {
                var label = labelStmtMatch.Groups["label"].Value;
                Console.WriteLine("Found label " + label);
            }
            return labelStmtMatch.Success;
        }

        /*
         * Match command with no argument
         */
        private static Boolean parseCommandWithNoArgs(String line)
        {
            Regex labelStmtFormat = new Regex(@"^\s*(?<command>.{2,3})\s*$");
            Match labelStmtMatch = labelStmtFormat.Match(line);
            if (labelStmtMatch.Success)
            {
                String command = labelStmtMatch.Groups["command"].Value;
                Console.WriteLine("Found command with no args " + command);
            }
            return labelStmtMatch.Success;
        }

        /*
         * Match command with single immediate argument
         */
        private static Boolean parseCommandWithImmediate(String line)
        {
            Regex labelStmtFormat = new Regex(@"^\s*(?<command>\S{2,3})\s*(?<arg1>[#][$]\d*)\s*$");
            Match labelStmtMatch = labelStmtFormat.Match(line);
            if (labelStmtMatch.Success)
            {
                String command = labelStmtMatch.Groups["command"].Value;
                Console.WriteLine("Found command with immediate " + command);
            }
            return labelStmtMatch.Success;
        }

        /*
         * Match command with single memory argument
         */
        private static Boolean parseCommandWithMemory(String line)
        {
            Regex labelStmtFormat = new Regex(@"^\s*(?<command>\S{2,3})\s*(?<arg1>[$]\d*)\s*$");
            Match labelStmtMatch = labelStmtFormat.Match(line);
            if (labelStmtMatch.Success)
            {
                String command = labelStmtMatch.Groups["command"].Value;
                Console.WriteLine("Found command with memory " + command);
            }
            return labelStmtMatch.Success;
        }
    }
}
