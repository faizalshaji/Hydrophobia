using Microsoft.Xna.Framework.Graphics;

namespace Hydrophobia.Components
{
    public class SpriteComponent : IComponent
    {
        public Texture2D Texture { get; set; }

        public SpriteComponent(Texture2D texture)
        {
            Texture = texture;
        }
    }
}
