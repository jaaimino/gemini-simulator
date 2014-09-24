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
    static class Encoder
    {
        /**
         * 
         */
        public static short Encode(String command, String arg, Boolean immediate)
        {
            short encodedInstruction = 0;
            encodedInstruction = Encoder.encodeCommand(encodedInstruction, command);
            encodedInstruction = Encoder.encodeImmediateFlag(encodedInstruction, immediate);
            encodedInstruction = Encoder.encodeOperand(encodedInstruction, arg);
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
                num = OpcodeMapper.CodeToShort(command.ToUpper());
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                Console.WriteLine("Invalid command " + command + " found.");
            }
            return (short)(num << 9);
        }

        /**
         * 
         */
        private static short encodeImmediateFlag(short currentEncoding, Boolean immediate)
        {
            short flag = ((short)(1 << 8));
            if(immediate){
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
            } catch(FormatException){}
            catch(OverflowException){}
            currentEncoding = (short)(currentEncoding | num);
            return currentEncoding;
        }
    }
}
