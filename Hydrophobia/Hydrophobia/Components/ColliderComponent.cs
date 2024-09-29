using Microsoft.Xna.Framework;

namespace Hydrophobia.Components
{
    public class ColliderComponent : IComponent
    {
        public Rectangle Collider { get; set; }

        public ColliderComponent(Rectangle bounds)
        {
            Collider = bounds;
        }
    }
}
