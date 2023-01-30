using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Color = Microsoft.Xna.Framework.Color;

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

        public static Vector2 AlignButtonCenter(Vector2 size)
        {
            float x = size.X / 2;
            float y = size.Y / 2;

            return new Vector2(x, y);
        }
    }

    public static class Retrive
    {
        static Items item;

        public static Items RetriveItem(List<Items> list, string name)
        {
            item = (Items)list.Where(i => i.Name == name);

            return item;
        }
    }
}
