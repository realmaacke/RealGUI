using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RealGUI
{
    public static class Calculate
    {
        public static Vector2 CenterofButton(Vector2 position, Vector2 size, SpriteFont font, string name)
        {
            float x = (position.X + (size.X / 2)) - (font.MeasureString(name).X) / 2;
            float y = (position.Y + (size.Y / 2)) - (font.MeasureString(name).Y) / 2;

            return new Vector2(x, y);
        }

    }
}
