/**
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
    /**
     * Takes in list of strings (file lines)
     * 
     */
    public class IPE
    {
        List<String> instructions;
        Dictionary<String, int> labelMap;
        List<short> encodedInstructions;

        public IPE(String fileName)
        {
            this.instructions = File.ReadAllLines(fileName).ToList<String>();
            labelMap = new Dictionary<string, int>();
            encodedInstructions = new List<short>();
        }

        /**
         * Loop through file calling ParseLine on each line
         */
        public void Parse()
        {
            for (int i = 0; i < instructions.Count; i++)
            {
                String line = instructions.ElementAt(i);
                line = stripComments(line);
                ParseLine(line);
                //Should clear out line if it's empty

                //Console.WriteLine(i + " " + line);
            }
        }

        /**
         * Parse a single line in the file
         * - First determine what format it's in
         * - Then call encode with args
         */
        private void ParseLine(String line)
        {
            Match match;

            //Is it a label?
            match = new Regex(@"^(?<label>.*?)\s*:$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["label"].Value;
                return;
            }

            //Is it a command with no arguments?
            match = new Regex(@"^\s*(?<command>.{2,3})\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                Console.WriteLine("Found command with no args [" + command + "]");

                //Do call to encode here

                return;
            }

            //Is it a command with an immediate argument?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s*(?<arg>[#][$]\d*)\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                String immediate = match.Groups["arg"].Value;
                Console.WriteLine("Found command with immediate [" + command + "] [" + immediate + "]");

                //Do call to encode here

                return;
            }

            //Is it a command with a memory argument?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s*(?<arg>[$]\d*)\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                String arg = match.Groups["arg"].Value;
                Console.WriteLine("Found command with memory [" + command + "] [" + arg + "]");

                //Do call to encode here

                return;
            }

            Console.WriteLine("Invalid line");
        }

        /*
         * Finds everything after and including comment character \s*(?P<test>[!].*)
         */
        private static String stripComments(String line)
        {
            return Regex.Replace(line, @"\s*[!].*", "");
        }

        public List<short> getEncodedInstructions()
        {
            return this.encodedInstructions;
        }

        private void Encode(String command, String arg, Boolean immediate)
        {
            short encodedInstruction = 0;
            encodedInstruction = Encoder.encodeCommand(encodedInstruction, command);
            encodedInstruction = Encoder.encodeImmediateFlag(encodedInstruction, immediate);
            encodedInstruction = Encoder.encodeOperand(encodedInstruction, arg);
            encodedInstructions.Add(encodedInstruction);
        }
    }
}
