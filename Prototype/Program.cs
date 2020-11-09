using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Triangle(1);
            Figure clone = figure.Clone();
        }
    }

    abstract class Figure
    {
        public int Id { get; protected set; }
        public Figure(int id)
        {
            this.Id = id;
        }

        public abstract Figure Clone();
    }

    class Triangle : Figure
    {
        public Triangle(int id) : base(id) { }
        public override Figure Clone()
        {
            return new Triangle(Id);
        }
    }
}
