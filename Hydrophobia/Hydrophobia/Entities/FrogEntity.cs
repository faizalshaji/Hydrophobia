using Hydrophobia.Components;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Hydrophobia.Entities
{
    public class FrogEntity : Entity
    {
        public FrogEntity(ContentManager content)
        {
            AddComponent(new PlayerComponent());
            AddComponent(new PositionComponent(100, 100));
            AddComponent(new VelocityComponent(0, 0));
            AddComponent(new SpriteComponent(content.Load<Texture2D>("ball")));
        }
    }
}
