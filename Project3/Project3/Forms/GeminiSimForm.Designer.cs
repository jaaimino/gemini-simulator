namespace Project3
{
    partial class GeminiSimForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeminiSimForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.StepButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.valueCC = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.valueIR = new System.Windows.Forms.Label();
            this.labelIR = new System.Windows.Forms.Label();
            this.valueTEMP = new System.Windows.Forms.Label();
            this.labelTEMP = new System.Windows.Forms.Label();
            this.valueMDR = new System.Windows.Forms.Label();
            this.labelMDR = new System.Windows.Forms.Label();
            this.valueMAR = new System.Windows.Forms.Label();
            this.labelMAR = new System.Windows.Forms.Label();
            this.valuePC = new System.Windows.Forms.Label();
            this.labelPC = new System.Windows.Forms.Label();
            this.valueOne = new System.Windows.Forms.Label();
            this.labelOne = new System.Windows.Forms.Label();
            this.valueZero = new System.Windows.Forms.Label();
            this.labelZero = new System.Windows.Forms.Label();
            this.valueAcc = new System.Windows.Forms.Label();
            this.labelAcc = new System.Windows.Forms.Label();
            this.valueB = new System.Windows.Forms.Label();
            this.valueA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.missrateValue = new System.Windows.Forms.Label();
            this.cacheValueLabel = new System.Windows.Forms.Label();
            this.cacheDataLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hitrateValue = new System.Windows.Forms.Label();
            this.missesValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hitsValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.nextInstLabel = new System.Windows.Forms.Label();
            this.instructionIndexLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.assembleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAssemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ResetButton);
            this.panel4.Controls.Add(this.StepButton);
            this.panel4.Controls.Add(this.RunButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 81);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 29);
            this.panel4.TabIndex = 5;
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSize = true;
            this.ResetButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResetButton.Location = new System.Drawing.Point(161, 0);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(79, 29);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StepButton
            // 
            this.StepButton.AutoSize = true;
            this.StepButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.StepButton.Location = new System.Drawing.Point(82, 0);
            this.StepButton.Margin = new System.Windows.Forms.Padding(4);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(79, 29);
            this.StepButton.TabIndex = 3;
            this.StepButton.Text = "Step";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.stepButton_OnClick);
            // 
            // RunButton
            // 
            this.RunButton.AutoSize = true;
            this.RunButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.RunButton.Location = new System.Drawing.Point(0, 0);
            this.RunButton.Margin = new System.Windows.Forms.Padding(4);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(82, 29);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_OnClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 414);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 389);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(515, 268);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.valueCC, 1, 11);
            this.tableLayoutPanel3.Controls.Add(this.labelCC, 0, 11);
            this.tableLayoutPanel3.Controls.Add(this.valueIR, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.labelIR, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.valueTEMP, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.labelTEMP, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.valueMDR, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.labelMDR, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.valueMAR, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.labelMAR, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.valuePC, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.labelPC, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.valueOne, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.labelOne, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.valueZero, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelZero, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.valueAcc, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelAcc, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.valueB, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.valueA, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelB, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.valueLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.registerLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelA, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 13;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(252, 262);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // valueCC
            // 
            this.valueCC.AutoSize = true;
            this.valueCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueCC.Location = new System.Drawing.Point(128, 228);
            this.valueCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueCC.Name = "valueCC";
            this.valueCC.Size = new System.Drawing.Size(121, 19);
            this.valueCC.TabIndex = 24;
            this.valueCC.Text = "------";
            this.valueCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCC.Location = new System.Drawing.Point(3, 228);
            this.labelCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(120, 19);
            this.labelCC.TabIndex = 23;
            this.labelCC.Text = "CC";
            this.labelCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueIR
            // 
            this.valueIR.AutoSize = true;
            this.valueIR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueIR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueIR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueIR.Location = new System.Drawing.Point(128, 208);
            this.valueIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueIR.Name = "valueIR";
            this.valueIR.Size = new System.Drawing.Size(121, 19);
            this.valueIR.TabIndex = 22;
            this.valueIR.Text = "------";
            this.valueIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIR
            // 
            this.labelIR.AutoSize = true;
            this.labelIR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIR.Location = new System.Drawing.Point(3, 208);
            this.labelIR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIR.Name = "labelIR";
            this.labelIR.Size = new System.Drawing.Size(120, 19);
            this.labelIR.TabIndex = 21;
            this.labelIR.Text = "IR";
            this.labelIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueTEMP
            // 
            this.valueTEMP.AutoSize = true;
            this.valueTEMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTEMP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTEMP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueTEMP.Location = new System.Drawing.Point(128, 188);
            this.valueTEMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueTEMP.Name = "valueTEMP";
            this.valueTEMP.Size = new System.Drawing.Size(121, 19);
            this.valueTEMP.TabIndex = 20;
            this.valueTEMP.Text = "------";
            this.valueTEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTEMP
            // 
            this.labelTEMP.AutoSize = true;
            this.labelTEMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTEMP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTEMP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTEMP.Location = new System.Drawing.Point(3, 188);
            this.labelTEMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTEMP.Name = "labelTEMP";
            this.labelTEMP.Size = new System.Drawing.Size(120, 19);
            this.labelTEMP.TabIndex = 19;
            this.labelTEMP.Text = "TEMP";
            this.labelTEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueMDR
            // 
            this.valueMDR.AutoSize = true;
            this.valueMDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueMDR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueMDR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueMDR.Location = new System.Drawing.Point(128, 168);
            this.valueMDR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueMDR.Name = "valueMDR";
            this.valueMDR.Size = new System.Drawing.Size(121, 19);
            this.valueMDR.TabIndex = 18;
            this.valueMDR.Text = "------";
            this.valueMDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMDR
            // 
            this.labelMDR.AutoSize = true;
            this.labelMDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMDR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMDR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMDR.Location = new System.Drawing.Point(3, 168);
            this.labelMDR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMDR.Name = "labelMDR";
            this.labelMDR.Size = new System.Drawing.Size(120, 19);
            this.labelMDR.TabIndex = 17;
            this.labelMDR.Text = "MDR";
            this.labelMDR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueMAR
            // 
            this.valueMAR.AutoSize = true;
            this.valueMAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueMAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueMAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueMAR.Location = new System.Drawing.Point(128, 148);
            this.valueMAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueMAR.Name = "valueMAR";
            this.valueMAR.Size = new System.Drawing.Size(121, 19);
            this.valueMAR.TabIndex = 16;
            this.valueMAR.Text = "------";
            this.valueMAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMAR
            // 
            this.labelMAR.AutoSize = true;
            this.labelMAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMAR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMAR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMAR.Location = new System.Drawing.Point(3, 148);
            this.labelMAR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMAR.Name = "labelMAR";
            this.labelMAR.Size = new System.Drawing.Size(120, 19);
            this.labelMAR.TabIndex = 15;
            this.labelMAR.Text = "MAR";
            this.labelMAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valuePC
            // 
            this.valuePC.AutoSize = true;
            this.valuePC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuePC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuePC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valuePC.Location = new System.Drawing.Point(128, 128);
            this.valuePC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valuePC.Name = "valuePC";
            this.valuePC.Size = new System.Drawing.Size(121, 19);
            this.valuePC.TabIndex = 14;
            this.valuePC.Text = "------";
            this.valuePC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPC
            // 
            this.labelPC.AutoSize = true;
            this.labelPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPC.Location = new System.Drawing.Point(3, 128);
            this.labelPC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPC.Name = "labelPC";
            this.labelPC.Size = new System.Drawing.Size(120, 19);
            this.labelPC.TabIndex = 13;
            this.labelPC.Text = "PC";
            this.labelPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueOne
            // 
            this.valueOne.AutoSize = true;
            this.valueOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueOne.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueOne.Location = new System.Drawing.Point(128, 108);
            this.valueOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueOne.Name = "valueOne";
            this.valueOne.Size = new System.Drawing.Size(121, 19);
            this.valueOne.TabIndex = 12;
            this.valueOne.Text = "------";
            this.valueOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOne.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelOne.Location = new System.Drawing.Point(3, 108);
            this.labelOne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(120, 19);
            this.labelOne.TabIndex = 11;
            this.labelOne.Text = "One";
            this.labelOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueZero
            // 
            this.valueZero.AutoSize = true;
            this.valueZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueZero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueZero.Location = new System.Drawing.Point(128, 88);
            this.valueZero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueZero.Name = "valueZero";
            this.valueZero.Size = new System.Drawing.Size(121, 19);
            this.valueZero.TabIndex = 10;
            this.valueZero.Text = "------";
            this.valueZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZero
            // 
            this.labelZero.AutoSize = true;
            this.labelZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelZero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelZero.Location = new System.Drawing.Point(3, 88);
            this.labelZero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelZero.Name = "labelZero";
            this.labelZero.Size = new System.Drawing.Size(120, 19);
            this.labelZero.TabIndex = 9;
            this.labelZero.Text = "Zero";
            this.labelZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueAcc
            // 
            this.valueAcc.AutoSize = true;
            this.valueAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueAcc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueAcc.Location = new System.Drawing.Point(128, 68);
            this.valueAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueAcc.Name = "valueAcc";
            this.valueAcc.Size = new System.Drawing.Size(121, 19);
            this.valueAcc.TabIndex = 8;
            this.valueAcc.Text = "------";
            this.valueAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAcc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAcc.Location = new System.Drawing.Point(3, 68);
            this.labelAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(120, 19);
            this.labelAcc.TabIndex = 7;
            this.labelAcc.Text = "Acc";
            this.labelAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueB
            // 
            this.valueB.AutoSize = true;
            this.valueB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueB.Location = new System.Drawing.Point(128, 48);
            this.valueB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueB.Name = "valueB";
            this.valueB.Size = new System.Drawing.Size(121, 19);
            this.valueB.TabIndex = 6;
            this.valueB.Text = "------";
            this.valueB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueA
            // 
            this.valueA.AutoSize = true;
            this.valueA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueA.Location = new System.Drawing.Point(128, 28);
            this.valueA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueA.Name = "valueA";
            this.valueA.Size = new System.Drawing.Size(121, 19);
            this.valueA.TabIndex = 5;
            this.valueA.Text = "------";
            this.valueA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelB.Location = new System.Drawing.Point(3, 48);
            this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(120, 19);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valueLabel.Location = new System.Drawing.Point(128, 1);
            this.valueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(121, 26);
            this.valueLabel.TabIndex = 1;
            this.valueLabel.Text = "Value (Hex)";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registerLabel.Location = new System.Drawing.Point(3, 1);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(120, 26);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "Register";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelA.Location = new System.Drawing.Point(3, 28);
            this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(120, 19);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "A";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.missrateValue, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.cacheValueLabel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cacheDataLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.hitrateValue, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.missesValue, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.hitsValue, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(261, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(250, 260);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Miss Rate";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // missrateValue
            // 
            this.missrateValue.AutoSize = true;
            this.missrateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missrateValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missrateValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.missrateValue.Location = new System.Drawing.Point(127, 88);
            this.missrateValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.missrateValue.Name = "missrateValue";
            this.missrateValue.Size = new System.Drawing.Size(120, 19);
            this.missrateValue.TabIndex = 10;
            this.missrateValue.Text = "0";
            this.missrateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cacheValueLabel
            // 
            this.cacheValueLabel.AutoSize = true;
            this.cacheValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cacheValueLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cacheValueLabel.Location = new System.Drawing.Point(127, 1);
            this.cacheValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cacheValueLabel.Name = "cacheValueLabel";
            this.cacheValueLabel.Size = new System.Drawing.Size(120, 26);
            this.cacheValueLabel.TabIndex = 3;
            this.cacheValueLabel.Text = "Value (int)";
            this.cacheValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cacheDataLabel
            // 
            this.cacheDataLabel.AutoSize = true;
            this.cacheDataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cacheDataLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheDataLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cacheDataLabel.Location = new System.Drawing.Point(3, 1);
            this.cacheDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cacheDataLabel.Name = "cacheDataLabel";
            this.cacheDataLabel.Size = new System.Drawing.Size(119, 26);
            this.cacheDataLabel.TabIndex = 2;
            this.cacheDataLabel.Text = "Cache Stats";
            this.cacheDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(3, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hit Rate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hitrateValue
            // 
            this.hitrateValue.AutoSize = true;
            this.hitrateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hitrateValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitrateValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hitrateValue.Location = new System.Drawing.Point(127, 68);
            this.hitrateValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hitrateValue.Name = "hitrateValue";
            this.hitrateValue.Size = new System.Drawing.Size(120, 19);
            this.hitrateValue.TabIndex = 8;
            this.hitrateValue.Text = "0";
            this.hitrateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // missesValue
            // 
            this.missesValue.AutoSize = true;
            this.missesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missesValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missesValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.missesValue.Location = new System.Drawing.Point(127, 48);
            this.missesValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.missesValue.Name = "missesValue";
            this.missesValue.Size = new System.Drawing.Size(120, 19);
            this.missesValue.TabIndex = 7;
            this.missesValue.Text = "0";
            this.missesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Misses";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hitsValue
            // 
            this.hitsValue.AutoSize = true;
            this.hitsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hitsValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitsValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hitsValue.Location = new System.Drawing.Point(127, 28);
            this.hitsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hitsValue.Name = "hitsValue";
            this.hitsValue.Size = new System.Drawing.Size(120, 19);
            this.hitsValue.TabIndex = 5;
            this.hitsValue.Text = "0";
            this.hitsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hits";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.nextInstLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.instructionIndexLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 274);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(515, 113);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // nextInstLabel
            // 
            this.nextInstLabel.AutoSize = true;
            this.nextInstLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nextInstLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextInstLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextInstLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextInstLabel.Location = new System.Drawing.Point(3, 40);
            this.nextInstLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nextInstLabel.Name = "nextInstLabel";
            this.nextInstLabel.Size = new System.Drawing.Size(509, 38);
            this.nextInstLabel.TabIndex = 1;
            this.nextInstLabel.Text = "Instruction (Binary): ---------";
            this.nextInstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // instructionIndexLabel
            // 
            this.instructionIndexLabel.AutoSize = true;
            this.instructionIndexLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.instructionIndexLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionIndexLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionIndexLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.instructionIndexLabel.Location = new System.Drawing.Point(3, 1);
            this.instructionIndexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionIndexLabel.Name = "instructionIndexLabel";
            this.instructionIndexLabel.Size = new System.Drawing.Size(509, 38);
            this.instructionIndexLabel.TabIndex = 0;
            this.instructionIndexLabel.Text = "Line Number - / 0";
            this.instructionIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(519, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assembleToolStripMenuItem,
            this.runAssemblyToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // assembleToolStripMenuItem
            // 
            this.assembleToolStripMenuItem.Name = "assembleToolStripMenuItem";
            this.assembleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.assembleToolStripMenuItem.Text = "Assemble";
            this.assembleToolStripMenuItem.Click += new System.EventHandler(this.assembleToolStripMenuItem_Click);
            // 
            // runAssemblyToolStripMenuItem
            // 
            this.runAssemblyToolStripMenuItem.Name = "runAssemblyToolStripMenuItem";
            this.runAssemblyToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.runAssemblyToolStripMenuItem.Text = "Run";
            this.runAssemblyToolStripMenuItem.Click += new System.EventHandler(this.runAssemblyToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // GeminiSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 414);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GeminiSimForm";
            this.Text = "Gemini Simulator";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem assembleToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label nextInstLabel;
        private System.Windows.Forms.Label instructionIndexLabel;
        private System.Windows.Forms.ToolStripMenuItem runAssemblyToolStripMenuItem;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label valueCC;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label valueIR;
        private System.Windows.Forms.Label labelIR;
        private System.Windows.Forms.Label valueTEMP;
        private System.Windows.Forms.Label labelTEMP;
        private System.Windows.Forms.Label valueMDR;
        private System.Windows.Forms.Label labelMDR;
        private System.Windows.Forms.Label valueMAR;
        private System.Windows.Forms.Label labelMAR;
        private System.Windows.Forms.Label valuePC;
        private System.Windows.Forms.Label labelPC;
        private System.Windows.Forms.Label valueOne;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label valueZero;
        private System.Windows.Forms.Label labelZero;
        private System.Windows.Forms.Label valueAcc;
        private System.Windows.Forms.Label labelAcc;
        private System.Windows.Forms.Label valueB;
        private System.Windows.Forms.Label valueA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label cacheValueLabel;
        private System.Windows.Forms.Label cacheDataLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hitrateValue;
        private System.Windows.Forms.Label missesValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hitsValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label missrateValue;
    }
}

