using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresWF
{
    public partial class Figures : Form
    {
        Triangle newTriangle;
        Circle newCircle;
        Rectangle newRect;
        Square newSquare;
        Rhombus newRhombus;
        public Figures()
        {
            InitializeComponent();
        }

        private void OkTriangle_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            try
            {
                a = Convert.ToDouble(trSideA.Text);
                b = Convert.ToDouble(trSideB.Text);
                c = Convert.ToDouble(trSideC.Text);
                newTriangle = new Triangle(a, b, c);
                resTriangle.Text = "";
                resTriangle.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                resTriangle.Visible = true;
                resTriangle.ForeColor = Color.Red;
                resTriangle.Text = ex.Message;
            }
        }

        private void TrianglePerimeter_Click(object sender, EventArgs e)
        {
            double perimeter = newTriangle.CalculatePerimeter();
            resTriangle.Visible = true;
            resTriangle.Text += " Perimeter : " + perimeter;
        }

        private void TriangleArea_Click(object sender, EventArgs e)
        {
            double area = newTriangle.CalculateArea();
            resTriangle.Visible = true;
            resTriangle.Text += " Area : " + area.ToString("F2");
        }

        private void OkCircle_Click(object sender, EventArgs e)
        {
            double radius;
            try
            {
                radius = Convert.ToDouble(circleR.Text);
                newCircle = new Circle(radius);
                resCircle.Text = "";
                resCircle.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                resCircle.Visible = true;
                resCircle.ForeColor = Color.Red;
                resCircle.Text = ex.Message;
            }
        }

        private void CirclePerimeter_Click(object sender, EventArgs e)
        {
            double perimeter = newCircle.CalculatePerimeter();
            resCircle.Visible = true;
            resCircle.Text += " Perimeter : " + perimeter.ToString("F2");
        }

        private void CircleArea_Click(object sender, EventArgs e)
        {
            double area = newCircle.CalculateArea();
            resCircle.Visible = true;
            resCircle.Text += " Area : " + area.ToString("F2");
        }

        private void OkRect_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            try
            {
                a = Convert.ToDouble(rectSideA.Text);
                b = Convert.ToDouble(rectSideB.Text);
                newRect = new Rectangle(a, b);
                resRect.Text = "";
                resRect.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                resRect.Visible = true;
                resRect.ForeColor = Color.Red;
                resRect.Text = ex.Message;
            }
        }

        private void RectPerimeter_Click(object sender, EventArgs e)
        {
            double perimeter = newRect.CalculatePerimeter();
            resRect.Visible = true;
            resRect.Text += " Perimeter : " + perimeter.ToString();
        }

        private void RectArea_Click(object sender, EventArgs e)
        {
            double area = newRect.CalculateArea();
            resRect.Visible = true;
            resRect.Text += " Area : " + area.ToString("F2");
        }

        private void OkSquare_Click(object sender, EventArgs e)
        {
            double side;
            try
            {
                side = Convert.ToDouble(squareSide.Text);
                newSquare = new Square(side);
                resSquare.Text = "";
                resSquare.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                resSquare.Visible = true;
                resSquare.ForeColor = Color.Red;
                resSquare.Text = ex.Message;
            }
        }

        private void SquarePerimeter_Click(object sender, EventArgs e)
        {
            double perimeter = newSquare.CalculatePerimeter();
            resSquare.Visible = true;
            resSquare.Text += " Perimeter : " + perimeter.ToString();
        }

        private void SquareArea_Click(object sender, EventArgs e)
        {
            double area = newSquare.CalculateArea();
            resSquare.Visible = true;
            resSquare.Text += " Area : " + area.ToString("F2");
        }

        private void OkRhombus_Click(object sender, EventArgs e)
        {
            double side;
            double angle;
            try
            {
                side = Convert.ToDouble(rhSide.Text);
                angle = Convert.ToDouble(rhAngle.Text);
                newRhombus = new Rhombus(side, angle);
                resRhombus.Text = "";
                resRhombus.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                resRhombus.Visible = true;
                resRhombus.ForeColor = Color.Red;
                resRhombus.Text = ex.Message;
            }
        }

        private void RhombusPerimeter_Click(object sender, EventArgs e)
        {
            double perimeter = newRhombus.CalculatePerimeter();
            resRhombus.Visible = true;
            resRhombus.Text += " Perimeter : " + perimeter.ToString();
        }

        private void RhombusArea_Click(object sender, EventArgs e)
        {
            double area = newRhombus.CalculateArea();
            resRhombus.Visible = true;
            resRhombus.Text += " Area : " + area.ToString("F2");
        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
