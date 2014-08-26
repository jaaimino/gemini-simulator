using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Loaded form");
            Console.ResetColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Strings.GiveMeAString();
            printStuff();
        }

        private void printStuff()
        {
            Console.WriteLine(Strings.GiveMeAString());
        }
    }
}
