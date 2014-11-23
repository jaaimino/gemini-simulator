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
            foreach (String s in Settings.cacheOptions)
            {
                cacheTypeBox.Items.Add(s);
            }
            cacheTypeBox.SelectedIndex = Convert.ToInt32(Settings.getValue("cachetype"));
            cacheSizeSelector.Value = Convert.ToInt32(Settings.getValue("cachesize"));
            checkBox1.Checked = Boolean.Parse(Settings.getValue("branchpredict"));
            checkBox2.Checked = Boolean.Parse(Settings.getValue("bypassing"));
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

        //Branch Prediction
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Acquire the state of the CheckBox.
            CheckState state = checkBox1.CheckState;

            // Demonstrate how the CheckBox can be switched upon.
            switch (state)
            {
                case CheckState.Checked:
                    Settings.setValue("branchpredict", true);
                    break;
                case CheckState.Indeterminate:
                    Settings.setValue("branchpredict", false);
                    break;
                case CheckState.Unchecked:
                    Settings.setValue("branchpredict", false);
                    break;
            }
        }

        //Bypassing
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Acquire the state of the CheckBox.
            CheckState state = checkBox2.CheckState;

            // Demonstrate how the CheckBox can be switched upon.
            switch (state)
            {
                case CheckState.Checked:
                    Settings.setValue("bypassing", true);
                    break;
                case CheckState.Indeterminate:
                    Settings.setValue("bypassing", false);
                    break;
                case CheckState.Unchecked:
                    Settings.setValue("bypassing", false);
                    break;
            }
        }
    }
}
