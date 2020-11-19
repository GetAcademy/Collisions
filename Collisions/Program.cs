using System;

namespace Collisions
{
    class Program
    {
        static void Main(string[] args)
        {
            CollidableSet set = null;

            var checkCollisions = set.CheckCollisions();
            foreach (var collision in checkCollisions)
            {
                collision.Item1.Stop();
                collision.Item2.Stop();
            }
        }
    }
}
