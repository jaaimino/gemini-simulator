/**
 * Author: Jacob Aimino
 * 
 * Desc: Basically serves as a mapping between short command codes and 
 *       command strings
 * 
 **/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project3
{
    public class OpcodeMapper
    {
        const String OPCODE_FILE = "opcodes.config";

        //Just use constants for opcodes here

        private static Dictionary<String, short> codeToShortMap;
        private static Dictionary<short, String> shortToCodeMap;

        public static void initialize()
        {
            codeToShortMap = new Dictionary<string, short>();
            shortToCodeMap = new Dictionary<short, string>();
            initMappings();
        }

        private static void initMappings()
        {
            addMapping("LDA", 0);
            addMapping("STA", 1);
            addMapping("ADD", 2);
            addMapping("SUB", 3);
            addMapping("MUL", 4);
            addMapping("DIV", 5);
            addMapping("AND", 6);
            addMapping("OR", 7);
            addMapping("SHL", 8);
            addMapping("NOTA", 9);
            addMapping("BA", 10);
            addMapping("BE", 11);
            addMapping("BL", 12);
            addMapping("BG", 13);
            addMapping("NOP", 14);
            addMapping("HLT", 15);
        }

        private static void addMapping(String command, short value)
        {
            codeToShortMap.Add(command, value);
            shortToCodeMap.Add(value, command);
        }

        public static short CodeToShort(String code)
        {
            code = code.ToUpper();
            return codeToShortMap[code];
        }

        public static String ShortToCode(short number)
        {
            String result = "";
            try 
            { 
                result = shortToCodeMap[number]; 
            }
            catch (Exception)
            {
                Console.WriteLine(number);
            }
            return result;
        }
    }
}
