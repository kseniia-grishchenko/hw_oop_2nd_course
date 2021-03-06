﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleWF
{
    public partial class TriangleApp : Form
    {
        public TriangleApp()
        {
            InitializeComponent();
            Text = "Triangle";
            this.Size = new Size(500, 375);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Lavender;
            this.ForeColor = Color.Black;
        }

      

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                a = Convert.ToDouble(sideATextBox.Text);
                double b;
                b = Convert.ToDouble(sideBTextBox.Text);
                double c;
                c = Convert.ToDouble(sideCTextBox.Text);
                Triangle newTriangle;
                labelError.Visible = false;
                if (a == b && b == c)
                {
                    newTriangle = new EquilateralTriangle(a);
                }
                else
                {
                    newTriangle = new Triangle(a, b, c);
                }
                TriangleActions newForm = new TriangleActions(newTriangle);
                newForm.Show();
            }
            catch(Exception ex)
            {
                labelError.Visible = true;
                labelError.Text = ex.Message;
            } 
        }
    }
}
