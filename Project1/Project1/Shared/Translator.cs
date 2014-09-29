/**
 * Author: Jacob Aimino
 * 
 * Desc: Utilities for encoding commands
 *
 **/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    static class Translator
    {
        /**
         * 
         */
        public static short Encode(String command, String arg, Boolean immediate)
        {
            short encodedInstruction = 0;
            encodedInstruction = Translator.encodeCommand(encodedInstruction, command.ToUpper());
            encodedInstruction = Translator.encodeImmediateFlag(encodedInstruction, immediate);
            encodedInstruction = Translator.encodeOperand(encodedInstruction, arg);
            //Console.WriteLine(Convert.ToString(encodedInstruction, 2));
            return encodedInstruction;
        }

        /**
         * 
         */
        private static short encodeCommand(short currentEncoding, String command)
        {
            short num = 0;
            try
            {
                num = OpcodeMapper.CodeToShort(command);
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                //Console.WriteLine("Invalid command " + command + " found.");
            }
            return (short)(num << 9);
        }

        /**
         * 
         */
        private static short encodeImmediateFlag(short currentEncoding, Boolean immediate)
        {
            short flag = ((short)(1 << 8));
            if (immediate)
            {
                currentEncoding = (short)(currentEncoding | flag);
            }
            return currentEncoding;
        }

        /**
         * 
         */
        private static short encodeOperand(short currentEncoding, String operand)
        {
            short num = 0;
            try
            {
                num = (short)Convert.ToInt16(operand);
            }
            catch (FormatException) { }
            catch (OverflowException) { }
            currentEncoding = (short)(currentEncoding | num);
            return currentEncoding;
        }

        public static short decodeCommand(short instruction)
        {
            short command = (short)(instruction >> 9);
            Console.Write(OpcodeMapper.ShortToCode(command));
            return command;
        }

        public static Boolean decodeImmediateFlag(short instruction)
        {
            short flag = ((short)(1 << 8));
            Boolean hasFlag = ((instruction & flag) == flag); //Probably isn't right. Should check this
            Console.Write(" " + hasFlag);
            return hasFlag;
        }

        public static short decodeOperand(short instruction)
        {
            int comp = (short)255;
            short operand = (short)(instruction & comp);
            Console.WriteLine(" " + operand);
            return operand;
        }
    }
}
