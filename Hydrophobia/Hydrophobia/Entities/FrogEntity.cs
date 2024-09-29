using Hydrophobia.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Hydrophobia.Entities
{
    public class FrogEntity : Entity
    {
        public FrogEntity(ContentManager content)
        {
            AddComponent(new PlayerComponent());
            AddComponent(new PositionComponent(0, 0));
            AddComponent(new VelocityComponent(0, 0));
            AddComponent(new SpriteComponent(content.Load<Texture2D>("ball"), 2, new Rectangle(0, 0, 50, 50)));
            AddComponent(new ColliderComponent(new Rectangle(0, 0, 50, 50)));
        }
    }
}
