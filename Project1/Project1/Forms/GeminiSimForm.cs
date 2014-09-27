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
            openFileDialog1.DefaultExt = ".s";
            openFileDialog1.FileName = "*.s";
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
            openFileDialog1.DefaultExt = ".out";
            openFileDialog1.FileName = "*.out";
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

        private void RunButton_OnClick(object sender, EventArgs e)
        {
            Simulator.runSimulation();
        }

        private void stepButton_OnClick(object sender, EventArgs e)
        {
            Simulator.stepSimulation();
            //Should update view after this by getting data from Simulation class
        }

        public void updateViewElements(short nextInstruction, short[] registers, int totalInstructions)
        {
            //Base for register value view
            int BASE = 2; //Only supports 2, 8, 10, 16
            String prefix = "0x";
            this.valueA.Text = prefix + Convert.ToString(registers[0], BASE);
            this.valueB.Text = prefix + Convert.ToString(registers[1], BASE);
            this.valueAcc.Text = prefix + Convert.ToString(registers[2], BASE);
            this.valueZero.Text = prefix + Convert.ToString(registers[3], BASE);
            this.valueOne.Text = prefix + Convert.ToString(registers[4], BASE);
            this.valuePC.Text = prefix + Convert.ToString(registers[5], BASE);
            this.valueMAR.Text = prefix + Convert.ToString(registers[6], BASE);
            this.valueMDR.Text = prefix + Convert.ToString(registers[7], BASE);
            this.valueTEMP.Text = prefix + Convert.ToString(registers[8], BASE);
            this.valueIR.Text = prefix + Convert.ToString(registers[9], BASE);
            this.valueCC.Text = prefix + Convert.ToString(registers[10], BASE);

            //Show current instruction index
            updateInstructionIndex(registers[5], totalInstructions);

            //Show next instruction code
            updateNextInstruction(nextInstruction);
        }

        private void updateInstructionIndex(int instruction, int totalInstructions)
        {
            this.instructionIndexLabel.Text = "Instruction Index: " + instruction + " / " + totalInstructions;
        }

        private void updateNextInstruction(short instruction)
        {
            this.nextInstLabel.Text = "Next Instruction: " + ((instruction < 0) ? "---" : "0x"+Convert.ToString(instruction, 2));
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Simulator.reset(this);
        }
    }
}
