using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            String contents = "";
            if (result == DialogResult.OK) // Test result.
            {
                String file = openFileDialog1.FileName;
                try
                {
                    contents = File.ReadAllText(file);
                }
                catch (IOException)
                {
                    Console.WriteLine("Failed to open file :(");
                }
            }
            //Console.WriteLine(contents); // <-- Shows file size in debugging mode.
            textBox1.Text = contents;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
            String contents = "";
            if (result == DialogResult.OK) // Test result.
            {
                String file = openFileDialog1.FileName;
                try
                {
                    File.WriteAllText(file, textBox1.Text);
                }
                catch (IOException)
                {
                    Console.WriteLine("Failed to save file :(");
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
