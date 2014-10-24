using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class PipelineForm : Form
    {
        public PipelineForm()
        {
            InitializeComponent();
        }

        public void updateViewElements(List<Instruction> queue)
        {
            try
            {
                int count = queue.Count();
                int numberElementsToGet = (count < 4) ? count : 4;
                List<Instruction> last = null;
                if (numberElementsToGet > 0)
                {
                    List<Instruction> reverseList = new List<Instruction>();
                    foreach (Instruction i in queue)
                    {
                        reverseList.Add(i);
                    }
                    reverseList.Reverse();
                    last = reverseList.GetRange(0, numberElementsToGet);
                }
                this.inst1Title.Text = (numberElementsToGet < 1) ? "---" : Translator.convertToHumanString(last[0].inst);
                this.inst2Title.Text = (numberElementsToGet < 2) ? "---" : Translator.convertToHumanString(last[1].inst);
                this.inst3Title.Text = (numberElementsToGet < 3) ? "---" : Translator.convertToHumanString(last[2].inst);
                this.inst4Title.Text = (numberElementsToGet < 4) ? "---" : Translator.convertToHumanString(last[3].inst);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Exception is happening inside here.");
            }
        }
    }
}
