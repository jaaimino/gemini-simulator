namespace Project3
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cacheTypeBox = new System.Windows.Forms.ComboBox();
            this.cacheTypeLabel = new System.Windows.Forms.Label();
            this.cacheSizeSelector = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cacheSizeSelector)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cacheTypeBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cacheTypeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cacheSizeSelector, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cache Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cacheTypeBox
            // 
            this.cacheTypeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cacheTypeBox.FormattingEnabled = true;
            this.cacheTypeBox.Location = new System.Drawing.Point(189, 3);
            this.cacheTypeBox.Margin = new System.Windows.Forms.Padding(2);
            this.cacheTypeBox.Name = "cacheTypeBox";
            this.cacheTypeBox.Size = new System.Drawing.Size(182, 21);
            this.cacheTypeBox.TabIndex = 0;
            // 
            // cacheTypeLabel
            // 
            this.cacheTypeLabel.AutoSize = true;
            this.cacheTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cacheTypeLabel.Location = new System.Drawing.Point(3, 1);
            this.cacheTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cacheTypeLabel.Name = "cacheTypeLabel";
            this.cacheTypeLabel.Size = new System.Drawing.Size(181, 25);
            this.cacheTypeLabel.TabIndex = 1;
            this.cacheTypeLabel.Text = "Cache Type";
            this.cacheTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cacheSizeSelector
            // 
            this.cacheSizeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cacheSizeSelector.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cacheSizeSelector.Location = new System.Drawing.Point(190, 30);
            this.cacheSizeSelector.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.cacheSizeSelector.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cacheSizeSelector.Name = "cacheSizeSelector";
            this.cacheSizeSelector.Size = new System.Drawing.Size(180, 20);
            this.cacheSizeSelector.TabIndex = 3;
            this.cacheSizeSelector.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 36);
            this.panel1.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveButton.Location = new System.Drawing.Point(3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 29);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cancelButton.Location = new System.Drawing.Point(84, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 29);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cacheSizeSelector)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cacheTypeBox;
        private System.Windows.Forms.Label cacheTypeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cacheSizeSelector;
    }
}