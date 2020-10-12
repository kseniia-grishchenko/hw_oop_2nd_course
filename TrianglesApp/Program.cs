using System;

namespace TrianglesApp
{
    class Program
    {
        public abstract class Triangle
        {
            private double a;
            private double b;
            private double angle;

            public Triangle(double a, double b, double angle)
            {
                if (a < 0 || b < 0 || angle < 0)
                {
                    throw new Exception("Values must be positive");
                }
                double c = Math.Round(Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angle)), 2);
                if (a < b + c && b < a + c && c < a + b)
                {
                    this.a = a;
                    this.b = b;
                    this.angle = angle;
                }
                else
                {
                    throw new Exception("Triangle can't be created");
                }
            }

            protected static double ConvertDegreesToRadians(int degrees)
            {
                return Math.Round((degrees * Math.PI) / 180, 2);
            }
            public virtual double CalculatePerimeter()
            {
                double c = Math.Round(Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angle)), 2);
                double perimeter = a + b + c;
                return perimeter;
            }

            public virtual double CalculateArea()
            {
                double area = 0.5 * a * b * Math.Sin(angle);
                return area;
            }
        }
        public class RectangularTriangle : Triangle
        {
            private double a;
            private double b;
            public RectangularTriangle(double a, double b) : base(a, b, ConvertDegreesToRadians(90))
            {
                this.a = a;
                this.b = b;
            }

            public override double CalculatePerimeter()
            {
                double c = Math.Round(Math.Sqrt(a * a + b * b), 2);
                double perimeter = a + b + c;
                return perimeter;
            }

            public override double CalculateArea()
            {
                double area = Math.Round(0.5 * a * b, 2);
                return area;
            }
        }

        public class IsoscelesTriangle : Triangle
        {
            private double side;
            private double angle;

            public IsoscelesTriangle(double side, int angle) : base(side, side, ConvertDegreesToRadians(angle))
            {
                this.side = side;
                this.angle = ConvertDegreesToRadians(angle);
            }

            public override double CalculateArea()
            {
                double area = Math.Round(side * side * 0.5 * Math.Cos(angle), 2);
                return Math.Round(area, 2);
            }

        }



        static void Main(string[] args)
        {
            try
            {
                RectangularTriangle rectTriangle1 = new RectangularTriangle(4, 5);
                RectangularTriangle rectTriangle2 = new RectangularTriangle(3, 4);
                 //Calculate area and perimeter of rectTriangle1
                Console.WriteLine($"rectTriangle1`s area: {rectTriangle1.CalculateArea()}");
                Console.WriteLine($"rectTriangle1`s perimeter: {rectTriangle1.CalculatePerimeter()}");
                //Calculate area and perimeter of rectTriangle2
                Console.WriteLine($"rectTriangle2`s area: {rectTriangle2.CalculateArea()}");
                Console.WriteLine($"rectTriangle2`s perimeter: {rectTriangle2.CalculatePerimeter()}");

                IsoscelesTriangle isoscTriangle1 = new IsoscelesTriangle(3, 60);
                IsoscelesTriangle isoscTriangle2 = new IsoscelesTriangle(6, 60);
                // Calculate area and perimeter of isoscTriangle1
                Console.WriteLine($"isoscTriangle1`s area: {isoscTriangle1.CalculateArea()}");
                Console.WriteLine($"isoscTriangle1`s perimeter: {isoscTriangle1.CalculatePerimeter()}");
                // Calculate area and perimeter of isoscTriangle2
                Console.WriteLine($"isoscTriangle2`s area: {isoscTriangle2.CalculateArea()}");
                Console.WriteLine($"isoscTriangle2`s perimeter: {isoscTriangle2.CalculatePerimeter()}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
