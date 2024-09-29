using Hydrophobia.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Hydrophobia.Entities
{
    public class EnviornmentEntity : Entity
    {
        public EnviornmentEntity(ContentManager content)
        {
            AddComponent(new PositionComponent(0, 0));
            AddComponent(new SpriteComponent(content.Load<Texture2D>("enviornment"), 0, new Rectangle(0, 0, 900, 500)));
        }
    }
}
