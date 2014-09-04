///
/// 
///
///
///
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Project1;

namespace Project1
{
    public partial class GeminiSimForm : Form
    {
        public GeminiSimForm()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            String fileName = openFileDialog1.FileName;
            Console.WriteLine("Opened " + openFileDialog1.FileName + " successfully!");
            //Console.WriteLine("File type was " + Path.GetExtension(fileName));
            Assembler.Assemble(fileName);
        }
    }
}
