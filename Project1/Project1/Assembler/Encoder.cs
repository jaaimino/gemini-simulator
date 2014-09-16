/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Encoder for Assembler
 *  - Maybe stay static? (Probably not)
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
    class Encoder
    {
        public static String EncodeWithImmediate(String command, String immediate)
        {
            //Look up opcode and encode to binary
            //Then encode immediate into hex
            //Return 
            return command;
        }

        public static String EncodeWithMemory(String command, String memoryAddress)
        {
            return command;
        }

        public static String EncodeWithNoArgs(string command)
        {
            return command;
        }
    }
}
