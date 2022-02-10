using System;

namespace Chicken
{
    public interface IBird
    {
        Egg Lay();
    }

    // Should implement IBird
    public class Chicken : IBird
    {
        public Chicken()
        {
            Console.WriteLine("A Chicken exists.");
        }

        public Egg Lay()
        {
            return new Egg(new Func<Chicken>(() => new Chicken()));
        }
    }

    public class Egg
    {
        bool born = false;
        Func<IBird> create;

        public Egg(Func<IBird> createBird)
        {
            create = createBird;
        }

        public IBird Hatch()
        {
            if (!born)
            {
                Console.WriteLine("Egg has been hatched!");
                born = true;
                return create();
            }
            else
            {
                throw new InvalidOperationException("Egg already hatched");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var chicken1 = new Chicken();
            var egg = chicken1.Lay();
            egg.Hatch();
            
        }
    }
}