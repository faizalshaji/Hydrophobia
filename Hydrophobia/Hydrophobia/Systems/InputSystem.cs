using Hydrophobia.Components;
using Hydrophobia.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Hydrophobia.Systems
{
    public class InputSystem
    {
        private readonly List<Entity> entities;

        public InputSystem(List<Entity> entities)
        {
            this.entities = entities;
        }

        public void Update()
        {
            foreach (var entity in entities)
            {
                HandleKeyboardEvents(Keyboard.GetState(), entity);
            }
        }

        private static void HandleKeyboardEvents(KeyboardState keyboardState, Entity entity)
        {
            if (entity.GetComponent<PlayerComponent>() == null) return;

            if (keyboardState.IsKeyDown(Keys.Escape))
            {
                ExitGame();
            }

            var velocity = entity.GetComponent<VelocityComponent>();
            if (velocity == null) return;

            velocity.Velocity = keyboardState switch
            {
                var state when state.IsKeyDown(Keys.Up) => new Vector2(velocity.Velocity.X, -100),
                var state when state.IsKeyDown(Keys.Down) => new Vector2(velocity.Velocity.X, 100),
                var state when state.IsKeyDown(Keys.Left) => new Vector2(-100, velocity.Velocity.Y),
                var state when state.IsKeyDown(Keys.Right) => new Vector2(100, velocity.Velocity.Y),
                _ => new Vector2(0, 0),
            };
        }

        private static void ExitGame()
        {
            System.Environment.Exit(0);
        }
    }
}
