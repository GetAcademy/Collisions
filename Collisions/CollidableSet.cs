using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collisions
{
    class CollidableSet
    {
        private readonly List<Collidable> _collidables;

        public CollidableSet()
        {
            _collidables = new List<Collidable>();
        }

        public List<Collision> CheckCollisions()
        {
            var collisions = new List<Collision>();
            var combinationCount = _collidables.Count ^ 2;
            for (var i = 0; i < combinationCount; i++)
            {
                var cIndex1 = i / _collidables.Count;
                var cIndex2 = i % _collidables.Count;
                if (cIndex1 == cIndex2) continue;
                var collision = new Collision(
                    _collidables[cIndex1],
                    _collidables[cIndex2]);
                collisions.Add(collision);
            }
            return collisions;
        }

        public List<Collision> CheckCollisions2()
        {
            return Enumerable.Range(0, _collidables.Count ^ 2)
                .Select(i => new Collision(
                    _collidables[i / _collidables.Count],
                    _collidables[i % _collidables.Count]))
                .Where(c=>!c.AreEqual)
                .Where(c=>c.IsCollision)
                .ToList();
        }
    }
}
