using Microsoft.Xna.Framework;

namespace Hydrophobia.Components
{
    public class PositionComponent : IComponent
    {
        public Vector2 Position { get; set; }

        public PositionComponent(float x, float y)
        {
            Position = new Vector2(x, y);
        }
    }

}
