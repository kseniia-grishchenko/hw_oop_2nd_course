using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresWF
{
    abstract public class Figure
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter(); 
    }
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if(a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Values must be positive!");
            }
            if(a < b + c && b < a + c && c < a + b)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Triangle with such sides can't be created!");
            }
        }

        public override double CalculatePerimeter()
        {
            return this.a + this.b + this.c;
        }

        public override double CalculateArea()
        {
            double halfPerimeter = CalculatePerimeter() / 2;
            double area = Math.Pow(halfPerimeter * (halfPerimeter - this.a) *
                          (halfPerimeter - this.b) * (halfPerimeter - this.c), 0.5);
            return area;
        }
    }

    public class Circle : Figure
    {
        private double radius;

        public Circle(double r)
        {
            if(r > 0)
            {
                this.radius = r;
            }
            else
            {
                throw new Exception("Value must be positive!");
            }
            
        }

        public override double CalculatePerimeter()
        {
            return this.radius * 2 * Math.PI;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
    }

    public class Rectangle : Figure
    {
        private double a;
        private double b;
        
        public Rectangle(double a, double b)
        {
            if(a > 0 && b > 0)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                throw new Exception("Values must be positive!");
            }
            
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.a + 2 * this.b;
        }

        public override double CalculateArea()
        {
            return this.a * this.b;
        }
    }

    public class Square : Figure
    {
        private double side;
        public Square(double a)
        {
            if(a > 0)
            {
                this.side = a;
            }
            else
            {
                throw new Exception("Value must be positive!");
            }
        }

        public override double CalculatePerimeter()
        {
            return 4 * this.side;
        } 
         

        public override double CalculateArea()
        {
            return this.side * this.side;
        }
    }

    public class Rhombus : Figure
    {
        private double side;
        private double angle;

        public Rhombus(double side, double angle)
        {
            if(side > 0 &&  angle > 0)
            {
                this.side = side;
                this.angle = angle;
            }
            else
            {
                throw new Exception("Values must be positive!");
            }
        }

        public override double CalculatePerimeter()
        {
            return 4 * this.side;
        }

        public override double CalculateArea()
        {
            return Math.Pow(this.side, 2) * Math.Sin(this.angle); 
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
            Application.Run(new Figures());
        }
    }
}
