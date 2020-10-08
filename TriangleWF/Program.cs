using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleWF
{
    public class Triangle
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double ChangeA
        {
            get { return a; }
            set { a = value; }
        }

        public double ChangeB
        {
            get { return b; }
            set { b = value; }
        }
        public double ChangeC
        {
            get { return c; }
            set { c = value; }
        }
        public double CalculateAngleBetweenAAndB()
        {
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b));
        }
        public double CalculateAngleBetweenBAndC()
        {
            return Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * c * b));
        }
        public double CalculateAngleBetweenAAndC()
        {
            return Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c));
        }
        public double CalculatePerimeter()
        {
            return a + b + c;
        }
    }

    public class EquilateralTriangle : Triangle
    {
        public double area;

        public EquilateralTriangle(double side) : base(side, side, side) { }

        public double CalculateArea()
        {
            return (Math.Pow(this.a, 2) * Math.Pow(3, 0.5)) / 4;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TriangleApp());
        }
    }
}
