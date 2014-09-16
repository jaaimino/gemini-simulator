/**
 * Author: Jacob Aimino
 * 
 * Desc: Controller for Assembler
 * - Should be converted instead to an object
 *   with a constructor
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
            //Make sure file has correct extension
            if(! Path.GetExtension(fileName).Equals(SOURCE_FILE_TYPE))
            {
                MessageBox.Show("Assembly file must have extension " + SOURCE_FILE_TYPE, "File Error");
            }

            //Send parser the contents of the file and get back
            Parser parser = new Parser(fileName);
            parser.Parse();
            List<short> encodedInstructions = parser.getEncodedInstructions();

            //Write encoded instructions to new output file
            Output(fileName, encodedInstructions);
        }

        private static void Output(String fileName, List<short> encodedInstructions)
        {
            String filePath = Path.GetDirectoryName(fileName);

            //Create new file path for writing assembly data and dump data to file
            String newFileName = filePath + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(fileName) + Simulator.OUTPUT_FILE_TYPE;

            //Write out all data to given new file and overwrite if it exists
            try
            {
                BinaryWriter writer = new BinaryWriter(File.Open(newFileName, FileMode.Create));
                foreach (short s in encodedInstructions){
                    writer.Write(s);
                }
                writer.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("Failed to write output file: " + fileName);
            }
            //Console.WriteLine("Wrote successfully to " + fileName + "!");
        }
    }
}
