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
        int lineNumber;

        public Parser(String fileName)
        {
            this.instructions = File.ReadAllLines(fileName).ToList<String>();
            labelMap = new Dictionary<string, int>();
            encodedInstructions = new List<short>();
            lineNumber = 0;
        }

        /**
         * Loop through file calling ParseLine on each line
         */
        public void Parse()
        {
            this.lineNumber = 0;
            for (int i = 0; i < instructions.Count; i++ )
            {
                String line = instructions.ElementAt(i);
                line = stripComments(line);
                if (! new Regex(@"^\s*$").Match(line).Success) //If the entire line is whitespace, ignore
                {
                    if (ParseLine(line))
                    {
                        lineNumber++;
                        Console.WriteLine(lineNumber + " " + line);
                    }
                }
            }
        }

        /**
         * Parse a single line in the file
         * - First determine what format it's in
         * - Then call encode with args
         */
        private Boolean ParseLine(String line)
        {
            Match match;

            //Is it a label?
            match = new Regex(@"^(?<label>.*?)\s*:$").Match(line);
            if (match.Success)
            {
                String label = match.Groups["label"].Value;
                labelMap.Add(label, lineNumber+1);
                return true;
            }

            //Is it a command with no arguments?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                //Console.WriteLine("Found command with no args [" + command + "]");
                //Do call to encode here
                encodedInstructions.Add(Encoder.Encode(command, "", false));
                return true;
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
                return true;
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
                return true;
            }

            //Is it a command in branch command format?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s*(?<label>\S+)$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                String label = match.Groups["label"].Value;
                Console.WriteLine("Found command with branch [" + command + "] " + " [" + label + "]");
                //Do call to encode here
                encodedInstructions.Add(Encoder.Encode(command, "", false));
                return true;
            }
            Console.WriteLine("Invalid line");
            return false;
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
