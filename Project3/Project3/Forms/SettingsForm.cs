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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            foreach(String s in Settings.cacheOptions)
            {
                cacheTypeBox.Items.Add(s);
            }
            cacheTypeBox.SelectedIndex = Convert.ToInt32(Settings.getValue("cachetype"));
            cacheSizeSelector.Value = Convert.ToInt32(Settings.getValue("cachesize"));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (validData())
            {
                Settings.setValue("cachetype", cacheTypeBox.SelectedIndex);
                Settings.setValue("cachesize", cacheSizeSelector.Value);
                Settings.save();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Cache type must be valid, and cache size must be valid.", "Error");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Boolean validData()
        {
            return (cacheSizeSelector.Value % 2 == 0 && 
                (cacheTypeBox.Text.Equals(Settings.cacheOptions[0]) || cacheTypeBox.Text.Equals(Settings.cacheOptions[1])));
        }
    }
}
