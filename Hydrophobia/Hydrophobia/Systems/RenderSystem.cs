using Hydrophobia.Components;
using Hydrophobia.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Hydrophobia.Systems
{
    public class RenderSystem
    {
        private readonly GraphicsDevice graphicsDevice;
        private SpriteBatch spriteBatch;
        private readonly List<Entity> entities;

        public RenderSystem(GraphicsDevice graphicsDevice, SpriteBatch spriteBatch, List<Entity> entities)
        {
            this.graphicsDevice = graphicsDevice;
            this.spriteBatch = spriteBatch;
            this.entities = entities;
        }

        public void Draw()
        {
            foreach (var entity in entities)
            {
                graphicsDevice.Clear(Color.CornflowerBlue);
                spriteBatch.Begin();
                var position = entity.GetComponent<PositionComponent>();
                var sprite = entity.GetComponent<SpriteComponent>();

                if (position != null && sprite != null)
                {
                    spriteBatch.Draw(sprite.Texture, position.Position, Color.White);
                }
                spriteBatch.End();
            }
        }
    }
}
