using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project1
{
    public class Opcode
    {
        const String OPCODE_FILE = "opcodes.config";
        const String RESERVED_FILE = "reserved.config";

        static Dictionary<String, String> opcodeToBinaryMap;
        static Dictionary<String, String> binaryToOpcodeMap;

        public static void readConfig()
        {
            opcodeToBinaryMap = new Dictionary<string, string>();
            binaryToOpcodeMap = new Dictionary<string, string>();
            List<String> mappings = File.ReadAllLines(OPCODE_FILE).ToList();
            foreach (String line in mappings){
                Regex labelStmtFormat = new Regex(@"^(?<cmd>.*)[=](?<code>.*)$");
                Match labelStmtMatch = labelStmtFormat.Match(line);
                if (labelStmtMatch.Success)
                {
                    String cmd = labelStmtMatch.Groups["cmd"].Value;
                    Console.Write(cmd + " = ");
                    String code = labelStmtMatch.Groups["code"].Value;
                    Console.WriteLine(code);
                    opcodeToBinaryMap.Add(cmd, code);
                    binaryToOpcodeMap.Add(code, cmd);
                }
            }
        }

        public static String opcodeToBinary(String code)
        {
            return opcodeToBinaryMap[code];
        }

        public static String binaryToOpcode(String binary)
        {
            return binaryToOpcodeMap[binary];
        }
    }
}
