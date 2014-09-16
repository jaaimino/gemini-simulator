/**
 * Author: Jacob Aimino
 * 
 * Desc: Parser for Assembler
 * 
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
    public class Parser
    {
        List<String> instructions;
        Dictionary<String, int> labelMap;
        List<short> encodedInstructions;

        public Parser(String fileName)
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
                //Console.WriteLine("Found command with no args [" + command + "]");
                //Do call to encode here
                encodedInstructions.Add(Encoder.Encode(command, "", false));
                return;
            }

            //Is it a command with an immediate argument?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s*[#][$](?<arg>\d*)\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                String immediate = match.Groups["arg"].Value;
                //Console.WriteLine("Found command with immediate [" + command + "] [" + immediate + "]");
                //Do call to encode here
                encodedInstructions.Add(Encoder.Encode(command, immediate, true));
                return;
            }

            //Is it a command with a memory argument?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s*[$](?<arg>\d*)\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                String arg = match.Groups["arg"].Value;
                //Console.WriteLine("Found command with memory [" + command + "] [" + arg + "]");
                //Do call to encode here
                encodedInstructions.Add(Encoder.Encode(command, arg, false));
                return;
            }

            //Console.WriteLine("Invalid line");
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
    }
}
