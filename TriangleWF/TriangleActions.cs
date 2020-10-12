using System;
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
    public partial class TriangleActions : Form
    {
        Triangle triangle;
        public TriangleActions()
        {
            InitializeComponent();
        }

        public TriangleActions(Triangle triangle)
        {
            InitializeComponent();
            this.triangle = triangle;
            if (triangle is EquilateralTriangle)
            {
                etLabel.Visible = true;
                calcAreaButton.Visible = true;
            }
        }

        private void ChangeSideOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            changedSideBox.Visible = true;

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            resLabel.Text = "";
            labelSuccess.Visible = false;
            double angle = 0;
            switch (calculateAngleOp.Text)
            {
                case "A":
                    angle = triangle.CalculateAngleBetweenBAndC();
                    break;
                case "B":
                    angle = triangle.CalculateAngleBetweenAAndC();
                    break;
                case "C":
                    angle = triangle.CalculateAngleBetweenAAndB();
                    break;
                default:
                    break;
            }
            if (calculateAngleOp.SelectedItem != null)
            {
                resLabel.Text = " Needed angle: " + angle.ToString("F2");
            }
            if (PerimeterCalc.Checked == true)
            {
                double perimeter = triangle.CalculatePerimeter();
                resLabel.Text += " Perimeter: " + perimeter.ToString("F2");
            }
            if (triangle is EquilateralTriangle && calcAreaButton.Checked == true)
            {
                double area = ((EquilateralTriangle)triangle).CalculateArea();
                resLabel.Text += " Area: " + area.ToString("F2");
            }


        }

        private void ChangedSideBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue == 13)
                {
                    labelSuccess.Text = "";
                    calculateAngleOp.Visible = true;
                    PerimeterCalc.Visible = true;
                    applyButton.Visible = true;
                    double changed;
                    changed = Convert.ToDouble(changedSideBox.Text);
                    if(changed < 0)
                    {
                        throw new Exception("Value must be positive");
                    }
                    switch (changeSideOp.Text)
                    {
                        case "a":
                            triangle.ChangeA = changed;
                            break;
                        case "b":
                            triangle.ChangeB = changed;
                            break;
                        case "c":
                            triangle.ChangeC = changed;
                            break;
                        default:
                            break;
                    }
                    if (triangle.ChangeA != triangle.ChangeB || triangle.ChangeC != triangle.ChangeB)
                    {
                        this.triangle = new Triangle(triangle.ChangeA, triangle.ChangeB, triangle.ChangeC);
                        etLabel.Visible = false;
                        calcAreaButton.Visible = false;
                    }
                    if (triangle.ChangeA == triangle.ChangeB && triangle.ChangeC == triangle.ChangeB)
                    {
                        this.triangle = new EquilateralTriangle(triangle.ChangeA);
                        etLabel.Visible = true;
                        calcAreaButton.Visible = true;
                    }

                    changedSideBox.Text = "";
                    changedSideBox.Visible = false;
                    labelSuccess.Text = "Success!";
                }
            }
            catch (Exception ex)
            {
                labelSuccess.Text = ex.Message;
                labelSuccess.Visible = true;
                calcAreaButton.Visible = false;
                calculateAngleOp.Visible = false;
                PerimeterCalc.Visible = false;
                applyButton.Visible = false;
            }
            }
        

            private void DoneButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


