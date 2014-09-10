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
        public static void AssembleFile(String fileName)
        {
            String filePath = Path.GetDirectoryName(fileName);
            
            if(! Path.GetExtension(fileName).Equals(".s"))
            {
                MessageBox.Show("Assembly file must have extension .s", "File Error");
            }

            //Read all lines in from the file
            List <String> lines = File.ReadAllLines(fileName).ToList<String>(); ;

            //Send parser the contents of the file and get back organized
            //program data
            ProgramData programData = Parser.ParseSource(lines);

            //Send organized data to translator to translate to binary
            //Save our new file contents to data
            String newData = "";
            //newData = Encoder.Encode(programData);

            //Create new file path for writing assembly data and dump data to file
            String newFileName = filePath + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(fileName) + ".a";
            Assembler.Output(newFileName, newData);
        }

        private static void Output(String fileName, String data)
        {
            //Write out all data to given new file and overwrite if it exists
            try
            {
                File.WriteAllText(fileName, data);
            }
            catch (IOException)
            {
                //Console.WriteLine("Failed to write output file: " + fileName);
            }
            //Console.WriteLine("Wrote successfully to " + fileName + "!");
        }
    }
}
