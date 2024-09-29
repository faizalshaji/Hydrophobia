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

        public void Draw(GameTime gameTime)
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

                    if (sprite.FrameCount > 1)
                    {
                        sprite.Timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

                        if (sprite.Timer >= sprite.FrameTime)
                        {
                            sprite.CurrentFrame = (sprite.CurrentFrame + 1) % sprite.FrameCount;
                            sprite.Timer = 0f;
                        }
                    }

                    var frameWidth = sprite.Size.Width;
                    var frameHeight = sprite.Size.Height;
                    var sourceRectangle = new Rectangle(
                        sprite.CurrentFrame * frameWidth,
                        0,
                        frameWidth,
                        frameHeight);

                    spriteBatch.Draw(
                        sprite.Texture,
                        new Rectangle((int)position.Position.X, (int)position.Position.Y, frameWidth, frameHeight),
                        sourceRectangle,
                        Color.White);
                }
            }

            spriteBatch.End();
        }

    }
}
