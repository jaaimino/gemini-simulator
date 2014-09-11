/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Controller for Assembler
 * 
 **/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    static class Assembler
    {
        public const String SOURCE_FILE_TYPE = ".s";

        public static void AssembleFile(String fileName)
        {
            String filePath = Path.GetDirectoryName(fileName);
            
            if(! Path.GetExtension(fileName).Equals(SOURCE_FILE_TYPE))
            {
                MessageBox.Show("Assembly file must have extension " + SOURCE_FILE_TYPE, "File Error");
            }

            //Read all lines in from the file
            List <String> lines = File.ReadAllLines(fileName).ToList<String>(); ;

            //Read in opcode config file
            Opcode.readConfig();

            //Send parser the contents of the file and get back encoded list
            //of lines
            List<String> encodedLines = Parser.ParseSource(lines);

            //Create new file path for writing assembly data and dump data to file
            String newFileName = filePath + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(fileName) + Simulator.OUTPUT_FILE_TYPE;
            Assembler.Output(newFileName, encodedLines);
        }

        private static void Output(String fileName, List<String> lines)
        {
            //Write out all data to given new file and overwrite if it exists
            try
            {
                File.WriteAllLines(fileName, lines);
            }
            catch (IOException)
            {
                //Console.WriteLine("Failed to write output file: " + fileName);
            }
            //Console.WriteLine("Wrote successfully to " + fileName + "!");
        }
    }
}
