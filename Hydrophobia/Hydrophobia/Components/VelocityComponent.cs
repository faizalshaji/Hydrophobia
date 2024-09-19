using Microsoft.Xna.Framework;

namespace Hydrophobia.Components
{
    public class VelocityComponent : IComponent
    {
        public Vector2 Velocity { get; set; }

        public VelocityComponent(float x, float y)
        {
            Velocity = new Vector2(x, y);
        }
    }
}
