using Hydrophobia.Components;
using Hydrophobia.Entities;
using System.Collections.Generic;

namespace Hydrophobia.Systems
{
    public class CollisionSystem
    {
        private readonly List<Entity> entities;

        public CollisionSystem(List<Entity> entities)
        {
            this.entities = entities;
        }

        public void Update()
        {
            var entitiesToRemove = new List<Entity>();

            for (int i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];
                var colliderA = entity.GetComponent<ColliderComponent>();
                var positionA = entity.GetComponent<PositionComponent>();

                if (colliderA == null || positionA == null) continue;

                for (int j = i + 1; j < entities.Count; j++)
                {
                    var otherEntity = entities[j];
                    var colliderB = otherEntity.GetComponent<ColliderComponent>();

                    if (colliderB == null)
                        continue;

                    if (colliderA.Collider.Intersects(colliderB.Collider))
                    {
                        HandleCollision(entity, otherEntity, entitiesToRemove);
                    }
                }
            }

            foreach (var entity in entitiesToRemove)
            {
                entities.Remove(entity);
            }
        }

        private static void HandleCollision(Entity entity, Entity otherEntity, List<Entity> entitiesToRemove)
        {
            if (!entitiesToRemove.Contains(otherEntity))
                entitiesToRemove.Add(otherEntity);
        }

    }
}
