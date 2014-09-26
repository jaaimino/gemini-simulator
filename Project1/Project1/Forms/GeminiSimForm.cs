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
        Boolean fileOK;

        public GeminiSimForm()
        {
            InitializeComponent();
            fileOK = false;
        }

        private void assembleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (fileOK)
            {
                String fileName = openFileDialog1.FileName;
                Assembler.AssembleFile(fileName);
                fileOK = false;
            }
        }

        private void runAssemblyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (fileOK)
            {
                String fileName = openFileDialog1.FileName; //Should do another open file dialog
                Simulator.startSimulation(fileName, this);
                fileOK = false;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileOK = true;
        }

        private void stepButton_OnClick(object sender, EventArgs e)
        {
            Simulator.stepSimulation();
            //Should update view after this by getting data from Simulation class
        }

        public void updateViewElements(short nextInstruction, int[] registers)
        {
            this.valueA.Text = registers[0]+"";
        }

        private void updateInstructionIndex()
        {

        }
    }
}
