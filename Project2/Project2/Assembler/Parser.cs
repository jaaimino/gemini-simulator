/**
 * Author: Jacob Aimino
 * 
 * Desc: Parser for Assembler
 * 
 **/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
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
         * Should do this more than once actually.
         */
        public void Parse()
        {
            CleanLines(); //Get rid of all empty lines and comments
            BuildLabelMap(); //Prepare label map so I can use it with branching
            ParseCommands(); //Do actual instruction parsing and encoding
            Console.WriteLine("Actual line count is: " + encodedInstructions.Count());
        }

        /**
         * Should clear out all empty lines and comments
         */
        private void CleanLines()
        {
            List<String> filteredList = new List<string>();
            for (int i = 0; i < instructions.Count; i++)
            {
                String line = instructions.ElementAt(i);
                line = StripComments(line);
                if (!new Regex(@"^\s*$").Match(line).Success) //If the entire line is whitespace, don't keep it
                {
                    filteredList.Add(line);
                }
            }
            instructions = filteredList;
        }

        /*
         * Finds everything after and including comment character \s*(?P<test>[!].*)
         */
        private static String StripComments(String line)
        {
            line = Regex.Replace(line, @"\s*!.*", "");
            return line;
        }

        /**
         * Go through each line adding any labels found to label map
         */
        private void BuildLabelMap()
        {
            Match match;
            List<String> filteredList = new List<String>();
            int offset = 0;
            for (int i = 0; i < instructions.Count; i++)
            {
                String line = instructions.ElementAt(i);
                //Is it a label?
                match = new Regex(@"^\s*(?<label>[A-Za-z0-9]+)\s*:$").Match(line);
                if (match.Success)
                {
                    String label = match.Groups["label"].Value;
                    labelMap.Add(label, i-offset);
                    //Console.WriteLine("Label " + label + " is going to jump to line " + (i - offset) + " because offset is " + offset);
                    offset++;
                }
                else
                {
                    filteredList.Add(line);
                }
            }
            instructions = filteredList;
        }


        /**
         * Assume file has no comments or empty lines
         */
        private void ParseCommands()
        {
            for (int i = 0; i < instructions.Count; i++)
            {
                String line = instructions.ElementAt(i);
                if (! ParseLine(line))
                {
                    MessageBox.Show("Invalid instruction on line " + (i + 1) + "\n[" + line + "]\nHalting assembly..", "Assembler Error");
                    throw new InvalidLineException();
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
            //Is it a command with no arguments?
            match = new Regex(@"^\s*(?<command>\S{2,4})\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                //Console.WriteLine("Found command with no args [" + command + "]");
                encodedInstructions.Add(Translator.Encode(command, "", false)); //Do call to encode here
                return true;
            }

            //Is it a command with an immediate argument?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s+[#][$](?<arg>\d*)\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                String immediate = match.Groups["arg"].Value;
                //Console.WriteLine("Found command with immediate [" + command + "] [" + immediate + "]"); 
                encodedInstructions.Add(Translator.Encode(command, immediate, true)); //Do call to encode here
                return true;
            }

            //Is it a command with a memory argument?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s+[$](?<arg>\d*)\s*$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                String arg = match.Groups["arg"].Value;
                //Console.WriteLine("Found command with memory [" + command + "] [" + arg + "]");
                //Do call to encode here
                encodedInstructions.Add(Translator.Encode(command, arg, false));
                return true;
            }

            //Is it a command in branch command format?
            match = new Regex(@"^\s*(?<command>\S{2,3})\s+(?<label>[A-Za-z0-9]+)$").Match(line);
            if (match.Success)
            {
                String command = match.Groups["command"].Value;
                String label = match.Groups["label"].Value;
                //Console.WriteLine("Found command with branch [" + command + "] " + " [" + label + "]");
                try
                {
                    encodedInstructions.Add(Translator.Encode(command, labelMap[label] + "", false)); //Do call to encode here
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
                return true;
            }
            //Console.WriteLine("Invalid line"); //Should probably throw an exception if this happens
            return false;
        }

        public List<short> GetEncodedInstructions()
        {
            return this.encodedInstructions;
        }
    }
}
