namespace TriangleWF
{
    partial class TriangleApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.sideATextBox = new System.Windows.Forms.TextBox();
            this.sideBTextBox = new System.Windows.Forms.TextBox();
            this.sideCTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 100);
            this.panel1.TabIndex = 0;
            // 
            // label
            // 
            this.label.Cursor = System.Windows.Forms.Cursors.Default;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.Sienna;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(408, 100);
            this.label.TabIndex = 0;
            this.label.Text = "Enter values of  triangle sides";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sideATextBox
            // 
            this.sideATextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sideATextBox.Location = new System.Drawing.Point(142, 121);
            this.sideATextBox.Multiline = true;
            this.sideATextBox.Name = "sideATextBox";
            this.sideATextBox.Size = new System.Drawing.Size(121, 30);
            this.sideATextBox.TabIndex = 2;
            this.sideATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sideBTextBox
            // 
            this.sideBTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sideBTextBox.Location = new System.Drawing.Point(142, 173);
            this.sideBTextBox.Multiline = true;
            this.sideBTextBox.Name = "sideBTextBox";
            this.sideBTextBox.Size = new System.Drawing.Size(121, 30);
            this.sideBTextBox.TabIndex = 4;
            this.sideBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sideCTextBox
            // 
            this.sideCTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sideCTextBox.Location = new System.Drawing.Point(142, 226);
            this.sideCTextBox.Multiline = true;
            this.sideCTextBox.Name = "sideCTextBox";
            this.sideCTextBox.Size = new System.Drawing.Size(121, 33);
            this.sideCTextBox.TabIndex = 6;
            this.sideCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.okButton.Location = new System.Drawing.Point(153, 278);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 38);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK!";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(34, 121);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(102, 33);
            this.labelA.TabIndex = 8;
            this.labelA.Text = "Enter a:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(34, 173);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(104, 33);
            this.labelB.TabIndex = 9;
            this.labelB.Text = "Enter b:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelC.Location = new System.Drawing.Point(34, 222);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(102, 33);
            this.labelC.TabIndex = 10;
            this.labelC.Text = "Enter c:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.LightBlue;
            this.labelError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelError.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Maroon;
            this.labelError.Location = new System.Drawing.Point(15, 338);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(383, 35);
            this.labelError.TabIndex = 11;
            this.labelError.Text = "Error! Triangle can\'t be created!";
            this.labelError.Visible = false;
            // 
            // TriangleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(408, 403);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sideCTextBox);
            this.Controls.Add(this.sideBTextBox);
            this.Controls.Add(this.sideATextBox);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TriangleApp";
            this.Text = "Triangle";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox sideATextBox;
        private System.Windows.Forms.TextBox sideBTextBox;
        private System.Windows.Forms.TextBox sideCTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelError;
    }
}

