﻿using Hydrophobia.Components;
using Hydrophobia.Entities;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Hydrophobia.Systems
{
    public class MovementSystem
    {
        private readonly List<Entity> entities;

        public MovementSystem(List<Entity> entities)
        {
            this.entities = entities;
        }

        public void Update(GameTime gameTime)
        {
            foreach (var entity in entities)
            {
                var position = entity.GetComponent<PositionComponent>();
                var velocity = entity.GetComponent<VelocityComponent>();
                var collider = entity.GetComponent<ColliderComponent>();

                if (position != null && velocity != null)
                {
                    position.Position += velocity.Velocity * (float)gameTime.ElapsedGameTime.TotalSeconds;

                    if (collider != null)
                    {
                        collider.Collider = new Rectangle(
                            (int)position.Position.X,
                            (int)position.Position.Y,
                            collider.Collider.Width,
                            collider.Collider.Height);
                    }
                }
            };
        }
    }
}
