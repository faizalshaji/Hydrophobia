using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Hydrophobia.Components
{
    public class SpriteComponent : IComponent
    {
        public Texture2D Texture { get; set; }
        public int Level { get; set; }
        public Rectangle Size { get; set; }

        public SpriteComponent(Texture2D texture, int level, Rectangle size)
        {
            Texture = texture;
            Level = level;
            Size = size;
        }
    }
}
