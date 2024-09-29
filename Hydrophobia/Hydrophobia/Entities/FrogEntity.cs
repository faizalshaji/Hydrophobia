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
            AddComponent(new PositionComponent(100, 100));
            AddComponent(new VelocityComponent(0, 0));
            AddComponent(new SpriteComponent(content.Load<Texture2D>("helicopter"), level: 2, size: new Rectangle(0, 0, 95, 32), frameCount: 8, frameTime: 0.1f));
            AddComponent(new ColliderComponent(new Rectangle(0, 0, 95, 30)));
        }
    }
}
