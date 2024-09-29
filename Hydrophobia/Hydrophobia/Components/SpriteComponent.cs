using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Hydrophobia.Components
{
    public class SpriteComponent : IComponent
    {
        public Texture2D Texture { get; set; }
        public int Level { get; set; }
        public Rectangle Size { get; set; }
        public int FrameCount { get; set; }
        public int CurrentFrame { get; set; }
        public float FrameTime { get; set; }
        public float Timer { get; set; }

        public SpriteComponent(Texture2D texture, int level, Rectangle size, int frameCount = 1, float frameTime = 0.1f)
        {
            Texture = texture;
            Level = level;
            Size = size;
            FrameCount = frameCount;
            FrameTime = frameTime;
            CurrentFrame = 0;
            Timer = 0f;
        }
    }
}
