using System;

// This is a program containing base class Triangle and derived class EquilateralTriangle
/* Class triangle contains 3 protected fields, constructor, methods
that allows to calculate angles between sides as well as perimeter, and also get and set methods*/
/* Class EquilateralTrinagle derives all methods and fields of the base class
 and also allows to calculate the area, it also contains constructor */
 //Let`s demonstrate the result of this program on our determined data set //

namespace Triangle
{
    class Triangle
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
        public double Perimeter()
        {
            return a + b + c;
        }
    }

    class EquilateralTriangle : Triangle
    {
        public double area;

        public EquilateralTriangle(double side) : base(side, side, side) {}
       
        public double CalculateArea()
        {
            return (Math.Pow(this.a, 2) * Math.Pow(3, 0.5)) / 4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Triangle tr = new Triangle(1, 2, 3);
            Console.WriteLine("Let triangle sides be: " + tr.ChangeA + ", " + tr.ChangeB + "," + tr.ChangeC);
            Console.WriteLine("Angle between side a and b in this triangle is " + tr.CalculateAngleBetweenAAndB());
            Console.WriteLine("Perimeter of triangle with sides " + tr.ChangeA + ", " + tr.ChangeB + ", " + tr.ChangeC + " is " + tr.Perimeter());
            Console.WriteLine("Let now change value of a = " + tr.ChangeA + " into a = 2");
            tr.ChangeA = 2;

            Console.WriteLine("Now angle between side a and b in this triangle is " + tr.CalculateAngleBetweenAAndB());
            Console.WriteLine("Now perimeter of triangle is " + tr.Perimeter());

            EquilateralTriangle et = new EquilateralTriangle(3);
            Console.WriteLine("Area of the equilateral triangle with side = " + et.ChangeA + " is " + et.CalculateArea());

        }
    }
}
