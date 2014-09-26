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
            //Base for register value view
            int BASE = 16; //Only supports 2, 8, 10, 16
            this.valueA.Text = Convert.ToString(registers[0], BASE);
            this.valueB.Text = Convert.ToString(registers[1], BASE);
            this.valueAcc.Text = Convert.ToString(registers[2], BASE);
            this.valueZero.Text = Convert.ToString(registers[3], BASE);
            this.valueOne.Text = Convert.ToString(registers[4], BASE);
            this.valuePC.Text = Convert.ToString(registers[5], BASE);
            this.valueMAR.Text = Convert.ToString(registers[6], BASE);
            this.valueMDR.Text = Convert.ToString(registers[7], BASE);
            this.valueTEMP.Text = Convert.ToString(registers[8], BASE);
            this.valueIR.Text = Convert.ToString(registers[9], BASE);
            this.valueCC.Text = Convert.ToString(registers[10], BASE);

            //Show current instruction index
            updateInstructionIndex(registers[5]);

            //Show next instruction code
            updateNextInstruction(nextInstruction);
        }

        private void updateInstructionIndex(int instruction)
        {

        }

        private void updateNextInstruction(short instruction)
        {
            this.nextInstLabel.Text = "Next Instruction: " + Convert.ToString(instruction, 2);
        }
    }
}
