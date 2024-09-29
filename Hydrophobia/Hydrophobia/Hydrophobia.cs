using Hydrophobia.Entities;
using Hydrophobia.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Hydrophobia
{
    public class Hydrophobia : Game
    {
        readonly GraphicsDeviceManager graphics;
        readonly List<Entity> entities;
        SpriteBatch spriteBatch;
        InputSystem inputSystem;
        MovementSystem movementSystem;
        RenderSystem renderSystem;
        CollisionSystem collisionSystem;

        public Hydrophobia()
        {
            graphics = new GraphicsDeviceManager(this);
            entities = new List<Entity>();
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            entities.Add(new EnviornmentEntity(Content));
            entities.Add(new PondEntity(Content));
            entities.Add(new FrogEntity(Content));
            inputSystem = new InputSystem(entities);
            collisionSystem = new CollisionSystem(entities);
            movementSystem = new MovementSystem(entities);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            renderSystem = new RenderSystem(GraphicsDevice, spriteBatch, entities);
        }

        protected override void Update(GameTime gameTime)
        {
            inputSystem.Update();
            movementSystem.Update(gameTime);
            collisionSystem.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            renderSystem.Draw(gameTime);
            base.Draw(gameTime);
        }
    }
}
