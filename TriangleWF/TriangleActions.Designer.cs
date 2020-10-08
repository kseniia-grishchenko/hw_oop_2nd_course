namespace TriangleWF
{
    partial class TriangleActions
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
            this.operationLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeSideOp = new System.Windows.Forms.ComboBox();
            this.calculateAngleOp = new System.Windows.Forms.ComboBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.changedSideBox = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.Label();
            this.resLabel = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.etLabel = new System.Windows.Forms.Label();
            this.PerimeterCalc = new System.Windows.Forms.CheckBox();
            this.calcAreaButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.BackColor = System.Drawing.Color.LightCoral;
            this.operationLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.operationLabel.Location = new System.Drawing.Point(169, 27);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(236, 35);
            this.operationLabel.TabIndex = 0;
            this.operationLabel.Text = "Choose operation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 86);
            this.panel1.TabIndex = 1;
            // 
            // changeSideOp
            // 
            this.changeSideOp.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "b",
            "c"});
            this.changeSideOp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeSideOp.FormattingEnabled = true;
            this.changeSideOp.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.changeSideOp.Location = new System.Drawing.Point(45, 105);
            this.changeSideOp.Name = "changeSideOp";
            this.changeSideOp.Size = new System.Drawing.Size(150, 30);
            this.changeSideOp.TabIndex = 3;
            this.changeSideOp.Text = "Change side";
            this.changeSideOp.SelectedIndexChanged += new System.EventHandler(this.ChangeSideOp_SelectedIndexChanged);
            // 
            // calculateAngleOp
            // 
            this.calculateAngleOp.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C"});
            this.calculateAngleOp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateAngleOp.FormattingEnabled = true;
            this.calculateAngleOp.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.calculateAngleOp.Location = new System.Drawing.Point(46, 182);
            this.calculateAngleOp.Name = "calculateAngleOp";
            this.calculateAngleOp.Size = new System.Drawing.Size(150, 30);
            this.calculateAngleOp.TabIndex = 4;
            this.calculateAngleOp.Text = "Calculate angle";
            this.calculateAngleOp.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.Brown;
            this.applyButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.applyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.applyButton.Location = new System.Drawing.Point(45, 361);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(129, 41);
            this.applyButton.TabIndex = 6;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Brown;
            this.doneButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doneButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doneButton.Location = new System.Drawing.Point(298, 361);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(129, 41);
            this.doneButton.TabIndex = 8;
            this.doneButton.Text = "Done!";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // changedSideBox
            // 
            this.changedSideBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changedSideBox.Location = new System.Drawing.Point(270, 105);
            this.changedSideBox.Name = "changedSideBox";
            this.changedSideBox.Size = new System.Drawing.Size(135, 30);
            this.changedSideBox.TabIndex = 9;
            this.changedSideBox.Visible = false;
            this.changedSideBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangedSideBox_KeyDown);
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.BackColor = System.Drawing.Color.IndianRed;
            this.resultText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultText.Location = new System.Drawing.Point(42, 295);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(66, 22);
            this.resultText.TabIndex = 10;
            this.resultText.Text = "Result:";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resLabel.Location = new System.Drawing.Point(144, 295);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(0, 22);
            this.resLabel.TabIndex = 11;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.BackColor = System.Drawing.Color.White;
            this.labelSuccess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuccess.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSuccess.Location = new System.Drawing.Point(79, 147);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(79, 22);
            this.labelSuccess.TabIndex = 12;
            this.labelSuccess.Text = "Success!";
            this.labelSuccess.Visible = false;
            // 
            // etLabel
            // 
            this.etLabel.AutoSize = true;
            this.etLabel.BackColor = System.Drawing.Color.LightCoral;
            this.etLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.etLabel.Location = new System.Drawing.Point(228, 156);
            this.etLabel.Name = "etLabel";
            this.etLabel.Size = new System.Drawing.Size(261, 23);
            this.etLabel.TabIndex = 13;
            this.etLabel.Text = "This is an equilateral triangle!";
            this.etLabel.Visible = false;
            // 
            // PerimeterCalc
            // 
            this.PerimeterCalc.AutoSize = true;
            this.PerimeterCalc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PerimeterCalc.Location = new System.Drawing.Point(45, 234);
            this.PerimeterCalc.Name = "PerimeterCalc";
            this.PerimeterCalc.Size = new System.Drawing.Size(188, 26);
            this.PerimeterCalc.TabIndex = 15;
            this.PerimeterCalc.Text = "Calculate perimeter";
            this.PerimeterCalc.UseVisualStyleBackColor = true;
            // 
            // calcAreaButton
            // 
            this.calcAreaButton.AutoSize = true;
            this.calcAreaButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcAreaButton.Location = new System.Drawing.Point(281, 198);
            this.calcAreaButton.Name = "calcAreaButton";
            this.calcAreaButton.Size = new System.Drawing.Size(146, 26);
            this.calcAreaButton.TabIndex = 16;
            this.calcAreaButton.Text = "Calculate area";
            this.calcAreaButton.UseVisualStyleBackColor = true;
            this.calcAreaButton.Visible = false;
            // 
            // TriangleActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(510, 468);
            this.Controls.Add(this.calcAreaButton);
            this.Controls.Add(this.PerimeterCalc);
            this.Controls.Add(this.etLabel);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.changedSideBox);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.calculateAngleOp);
            this.Controls.Add(this.changeSideOp);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriangleActions";
            this.Text = "TriangleActions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox changeSideOp;
        private System.Windows.Forms.ComboBox calculateAngleOp;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox changedSideBox;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Label etLabel;
        private System.Windows.Forms.CheckBox PerimeterCalc;
        private System.Windows.Forms.CheckBox calcAreaButton;
    }
}