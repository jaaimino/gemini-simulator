using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Opcode
    {
        const String OPCODE_FILE = "/opcodes.config";
        const String RESERVED_FILE = "/reserved.config";

        Dictionary<String, String> opcodeToBinaryMap;
        Dictionary<String, String> binaryToOpcodeMap;

        public static void readConfig()
        {
            List<String> mappings = File.ReadAllLines(OPCODE_FILE).ToList();
        }

        public static String opcodeToBinary()
        {
            return "";
        }

        public static String binaryToOpcode()
        {
            return "";
        }
    }
}
