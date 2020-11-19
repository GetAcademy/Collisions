using System;
using System.Collections.Generic;
using System.Text;

namespace Collisions
{
    class Collision : Tuple<Collidable, Collidable>
    {
        public bool AreEqual => Item1 == Item2;
        public bool IsCollision
        {
            get
            {
                return true;
            }
        }

        public Collision(Collidable a, Collidable b) : base(a, b)
        {
        }
    }
}
