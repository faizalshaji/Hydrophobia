using Hydrophobia.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Hydrophobia.Entities
{
    public class PondEntity : Entity
    {
        public PondEntity(ContentManager content)
        {
            AddComponent(new PositionComponent(100, 200));
            AddComponent(new SpriteComponent(content.Load<Texture2D>("pond"), 1, new Rectangle(100, 200, 300, 350)));
            AddComponent(new ColliderComponent(new Rectangle(100, 200, 300, 350)));
        }
    }
}
