using Hydrophobia.Components;
using Hydrophobia.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;

namespace Hydrophobia.Systems
{
    public class RenderSystem
    {
        private readonly GraphicsDevice graphicsDevice;
        private readonly SpriteBatch spriteBatch;
        private readonly List<Entity> entities;

        public RenderSystem(GraphicsDevice graphicsDevice, SpriteBatch spriteBatch, List<Entity> entities)
        {
            this.graphicsDevice = graphicsDevice;
            this.spriteBatch = spriteBatch;
            this.entities = entities;
        }

        public void Draw()
        {
            var entitiesWithSprite = entities
                .Where(e => e.GetComponent<SpriteComponent>() != null)
                .OrderBy(e => e.GetComponent<SpriteComponent>().Level);

            graphicsDevice.Clear(Color.White);
            spriteBatch.Begin();

            foreach (var entity in entitiesWithSprite)
            {
                var position = entity.GetComponent<PositionComponent>();
                var sprite = entity.GetComponent<SpriteComponent>();

                if (position != null && sprite != null)
                {
                    spriteBatch.Draw(sprite.Texture, new Rectangle((int)position.Position.X, (int)position.Position.Y, sprite.Size.Width, sprite.Size.Height), Color.White);
                }
            }

            spriteBatch.End();
        }
    }
}
