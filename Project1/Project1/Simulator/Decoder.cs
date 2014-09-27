/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Static class with methods for decoding instructions
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    static class Decoder
    {
        public static short decodeCommand(short instruction)
        {
            short command = (short)(instruction >> 9);
            Console.WriteLine(command);
            return command;
        }

        public static Boolean decodeImmediateFlag(short instruction)
        {
            short flag = ((short)(1 << 8));
            return ((instruction & flag) == flag); //Probably isn't right. Should check this
        }

        public static short decodeOperand(short instruction)
        {
            int comp = (short)255;
            short operand = (short)(instruction & comp);
            return operand;
        }
    }
}
