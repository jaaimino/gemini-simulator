using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public static class Logger
    {
        public const String LOG_FILE_TYPE = ".txt";
        private static StreamWriter writer;

        public static void initialize(String fileName)
        {
            if (null != writer)
            {
                writer.Close();
            }
            String filePath = Path.GetDirectoryName(fileName);
            String newFileName = filePath + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(fileName) + "_output" + Logger.LOG_FILE_TYPE;
            writer = new StreamWriter(newFileName, false);
        }

        public static void writeLine(String line)
        {
            writer.WriteLine(line);
            writer.Flush();
        }

        public static void write(String line)
        {
            writer.Write(line);
            writer.Flush();
        }

        public static void dispose()
        {
            writer.Dispose();
        }
    }
}
