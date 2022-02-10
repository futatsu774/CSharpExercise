using System;

namespace Chicken
{
    public interface IBird
    {
        Egg Lay();
    }

    // Should implement IBird
    public class Chicken
    {
        public Chicken()
        {
        }
    }

    public class Egg
    {
        public Egg(Func<IBird> createBird)
        {
            throw new NotImplementedException("Waiting to be implemented.");
        }

        public IBird Hatch()
        {
            throw new NotImplementedException("Waiting to be implemented.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //      var chicken1 = new Chicken();
            //      var egg = chicken1.Lay();
            //      var childChicken = egg.Hatch();
        }
    }
}
