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

        //Just use constants for opcodes here

        static Dictionary<String, String> opcodeToBinaryMap;
        static Dictionary<String, String> binaryToOpcodeMap;

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
