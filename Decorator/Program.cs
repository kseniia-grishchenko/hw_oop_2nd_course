using System;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            DecoratedChristmasTree c = new DecoratedChristmasTree();
            ChristmasTreeToys d1 = new ChristmasTreeToys();
            ChristmasTreeGarlands d2 = new ChristmasTreeGarlands();

            // Link decorators
            d1.SetChristmasTree(c);
            d2.SetChristmasTree(d1);

            d2.Decorate();

            // Wait for user
            Console.Read();
        }
    }

    abstract class ChristmasTree
    {
        public abstract void Decorate();
    }

    class DecoratedChristmasTree : ChristmasTree
    {
        public override void Decorate()
        {
            Console.WriteLine("DecoratedChristmasTree.Decorate()");
        }
    }

    abstract class ChristmasTreeDecorator : ChristmasTree
    {
        protected ChristmasTree christmasTree;

        public void SetChristmasTree(ChristmasTree christmasTree)
        {
            this.christmasTree = christmasTree;
        }
        public override void Decorate()
        {
            if(christmasTree != null)
            {
                christmasTree.Decorate();
            }
        }
    }

    class ChristmasTreeToys : ChristmasTreeDecorator
    {
        private string addedDecoration;

        public override void Decorate()
        {
            base.Decorate();
            addedDecoration = "Decorated with toys";
            Console.WriteLine("ChristmasTreeToys.Decorate()");
        }
    }

    class ChristmasTreeGarlands : ChristmasTreeDecorator
    {
        public override void Decorate()
        {
            base.Decorate();
            Lighten();
            Console.WriteLine("ChristmasTreeGarlands.Decorate()");
        }

        void Lighten()
        {

        }
    }

}
