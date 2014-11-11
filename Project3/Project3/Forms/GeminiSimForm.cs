
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

namespace Project3
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

        public void updateViewElements(short nextInstructionPreview, CPU cpu, Memory memory)
        {
            //Base for register value view
            int BASE = 16; //Only supports 2, 8, 10, 16
            String prefix = "0x";
            this.valueA.Text = prefix + (Convert.ToString(cpu.getRegisterValue(0), BASE).PadLeft(8, '0'));
            this.valueB.Text = prefix + (Convert.ToString(cpu.getRegisterValue(1), BASE).PadLeft(8, '0'));
            this.valueAcc.Text = prefix + (Convert.ToString(cpu.getRegisterValue(2), BASE).PadLeft(8, '0'));
            this.valueZero.Text = prefix + (Convert.ToString(cpu.getRegisterValue(3), BASE).PadLeft(8, '0'));
            this.valueOne.Text = prefix + (Convert.ToString(cpu.getRegisterValue(4), BASE).PadLeft(8, '0'));
            this.valuePC.Text = prefix + (Convert.ToString(cpu.getRegisterValue(5), BASE).PadLeft(8, '0'));
            this.valueMAR.Text = prefix + (Convert.ToString(cpu.getRegisterValue(6), BASE).PadLeft(8, '0'));
            this.valueMDR.Text = prefix + (Convert.ToString(cpu.getRegisterValue(7), BASE).PadLeft(8, '0'));
            this.valueTEMP.Text = prefix + (Convert.ToString(cpu.getRegisterValue(8), BASE).PadLeft(8, '0'));
            this.valueIR.Text = prefix + (Convert.ToString(cpu.getRegisterValue(9), BASE).PadLeft(8, '0'));
            this.valueCC.Text = prefix + (Convert.ToString(cpu.getRegisterValue(10), BASE).PadLeft(8, '0'));

            //Show current instruction index
            updateInstructionIndex(cpu.getRegisterValue(5), memory.getInstructions().Count);

            //Show current instruction code
            updateNextInstruction(nextInstructionPreview, cpu.isDone());

            int total = memory.hitCount + memory.missCount;
            this.hitsValue.Text = memory.hitCount + "";
            this.missesValue.Text = memory.missCount + "";
            this.missrateValue.Text = ((float)memory.missCount / total) + "";
            this.hitrateValue.Text = ((float)memory.hitCount / total) + "";

            //Show instructions in pipeline
            InstructionData[] queue = cpu.getQueue();
            this.inst1Title.Text = (null == queue[0]) ? "---" : Translator.convertToHumanString(queue[0].inst);
            this.inst2Title.Text = (null == queue[1]) ? "---" : Translator.convertToHumanString(queue[1].inst);
            this.inst3Title.Text = (null == queue[2]) ? "---" : Translator.convertToHumanString(queue[2].inst);
            this.inst4Title.Text = (null == queue[3]) ? "---" : Translator.convertToHumanString(queue[3].inst);
        }

        private void updateInstructionIndex(int linenumber, int totalInstructions)
        {
            this.instructionIndexLabel.Text = "Line Number: " + ((linenumber + 1 > totalInstructions) ? " --- / " + totalInstructions : (linenumber + 1) + " / " + totalInstructions);
        }

        private void updateNextInstruction(short nextInstructionPreview, Boolean isDone)
        {
            this.nextInstLabel.Text = "Instruction: " + Translator.convertToHumanString(nextInstructionPreview);
            Translator.convertToHumanString(nextInstructionPreview);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Simulator.resetSimulation(this);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private void StepButton_Click(object sender, EventArgs e)
        {
            Simulator.stepSimulation();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Simulator.runSimulation();
        }

        private void ResetButton_Click_1(object sender, EventArgs e)
        {
            Simulator.resetSimulation(this);
        }
    }
}
