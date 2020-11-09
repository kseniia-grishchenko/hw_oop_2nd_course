using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Triceratops triceratops = new Triceratops();
            var child = ChildCreator.CreateChild(new TriceratopsToMammalAdapter(triceratops));

            child.Cry();
        }

        public abstract class Mammal
        {
            public abstract Child GiveBirth();
        }

        public abstract class Child
        {
            public abstract void Cry();
        }
        public static class ChildCreator
        {
            public static Child CreateChild(Mammal mammal)
            {
                return mammal.GiveBirth();
            }
        }

        public class Triceratops
        {
            public TriceratopsEgg LayEgg()
            {
                return new TriceratopsEgg();
            }
        }

        public class TriceratopsEgg
        {
            public Child Hatch()
            {
                return new TriceratopsChild();
            }
        }
        internal class TriceratopsChild : Child
        {
            public override void Cry()
            {
                Console.WriteLine("TRICERATOPS IS CRYING");
            }
        }
        public class TriceratopsToMammalAdapter : Mammal
        {
            private readonly Triceratops triceratops;

            public TriceratopsToMammalAdapter(Triceratops triceratops)
            {
                this.triceratops = triceratops;
            }

            public override Child GiveBirth()
            {
                TriceratopsEgg egg = triceratops.LayEgg();

                Child child = egg.Hatch();

                return child;
            }
        }

    }
}
