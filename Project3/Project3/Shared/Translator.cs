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

namespace Project3
{
    static class Translator
    {
        private const int OPCODE_OFFSET = 11;
        private const int IMMEDIATE_FLAG_OFFSET = 10;

        public static short Encode(String command, String arg, Boolean immediate)
        {
            short encodedInstruction = 0;
            encodedInstruction = Translator.encodeCommand(encodedInstruction, command.ToUpper());
            encodedInstruction = Translator.encodeImmediateFlag(encodedInstruction, immediate);
            encodedInstruction = Translator.encodeOperand(encodedInstruction, arg);
            //Console.WriteLine(Convert.ToString(encodedInstruction, 2).PadLeft(16, '0'));
            return encodedInstruction;
        }

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
            return (short)(num << OPCODE_OFFSET);
        }

        private static short encodeImmediateFlag(short currentEncoding, Boolean immediate)
        {
            short flag = ((short)(1 << IMMEDIATE_FLAG_OFFSET));
            if (immediate)
            {
                currentEncoding = (short)(currentEncoding | flag);
            }
            return currentEncoding;
        }

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
            short command = (short)(instruction >> OPCODE_OFFSET);
            //Console.Write(OpcodeMapper.ShortToCode(command));
            return command;
        }

        public static Boolean decodeImmediateFlag(short instruction)
        {
            short flag = ((short)(1 << IMMEDIATE_FLAG_OFFSET));
            Boolean hasFlag = ((instruction & flag) == flag); //Probably isn't right. Should check this
            //Console.Write(" " + hasFlag);
            return hasFlag;
        }

        public static short decodeOperand(short instruction)
        {
            short operand = (short)LowOrderBits(instruction, 10);
            //Console.WriteLine(" " + operand);
            return operand;
        }

        //Thanks stackoverflow
        public static int LowOrderBits(int value, int bits)
        {
            if (bits < 0 || bits > 32) throw new ArgumentOutOfRangeException("bits");
            return (int)(((uint)value) & (0xFFFFFFFF >> (32 - bits)));
        }

        public static String convertToHumanString(short instruction)
        {
            String commandString = "";
            if (instruction < 0)
            {
                return "---";
            }
            commandString += OpcodeMapper.ShortToCode(Translator.decodeCommand(instruction));
            commandString += Translator.decodeImmediateFlag(instruction) ? " #$" : " $";
            commandString += Translator.decodeOperand(instruction);
            return commandString;
        }

        public static Boolean isMemOp(short p)
        {

            return false;
        }
    }
}
