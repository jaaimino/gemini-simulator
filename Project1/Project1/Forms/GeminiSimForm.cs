/**
 * 
 * Author: Jacob Aimino
 * 
 * Desc: Windows Form for Gemini Simulator
 * 
 **/
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
        Boolean fileOK = false;
        public GeminiSimForm()
        {
            InitializeComponent();
        }

        private void assembleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (!fileOK)
            {
                openFileDialog1.ShowDialog();
            }
            String fileName = openFileDialog1.FileName;
            Assembler.AssembleFile(fileName);
            fileOK = false;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileOK = true;
        }

        private void runAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (!fileOK)
            {
                openFileDialog1.ShowDialog();
            }
            fileOK = false;
            String fileName = openFileDialog1.FileName; //Should do another open file dialog
            Simulator.startSimulation(fileName);
        }
    }
}
