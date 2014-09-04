using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Assembler
    {
        public static void Assemble(String fileName)
        {
            String filePath = Path.GetDirectoryName(fileName);

            //Read all lines in from the file
            String data = File.ReadAllText(fileName);

            //Create new file path for writing assembly data and dump data
            String newFileName = filePath + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(fileName) + ".a";
            Assembler.Output(newFileName, data);
        }

        public static void Output(String fileName, String data)
        {
            try
            {
                File.WriteAllText(fileName, data);
            }
            catch (IOException)
            {
                Console.WriteLine("Failed to write output file: " + fileName);
            }
            Console.WriteLine("Wrote successfully to " + fileName + "!");
        }
    }
}
