/**
 * 
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

namespace Project1
{
    public static class Parser
    {
        public static ProgramData Parse(String text)
        {
            ProgramData data = new ProgramData();
            var lines = File.ReadAllLines(text).ToList<string>();
            String translatedText = "";

            foreach (var line in lines)
            {
                Regex labelStmtFormat = new Regex(@"^(?<label>.*?)\s*:$");
                var labelStmtMatch = labelStmtFormat.Match(line);
                if (labelStmtMatch.Success)
                {
                    var label = labelStmtMatch.Groups["label"].Value;
                    translatedText += label;
                }
            }
            return data;
        }
    }
}
