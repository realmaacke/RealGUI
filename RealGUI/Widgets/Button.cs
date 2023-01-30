using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apos.Shapes;
using Microsoft.Xna.Framework.Content;

namespace RealGUI
{
    public class Button : Items
    {
        string ButtonName;
        SpriteFont default_font;
        public Button(string name, Vector2 pos, Vector2 sze, Color Background, string ButtonName) : base(name, pos, sze, Background)
        {
            this.ButtonName = ButtonName;
            this.default_font = font;
        }
        public override void init()
        {
            base.init();
        }


        public override void draw()
        {
            if (show)
            {
                drawShapeBatch.Begin();


                drawShapeBatch.DrawRectangle(position, size, BackgroundColor, BackgroundColor, 1);
                drawGraphics.DrawString(font, ButtonName, Calculate.CenterofButton(position, size, font, ButtonName), Color.White);

                drawShapeBatch.End();
            }
        }

        public override void update()
        {
            if (isHovered)
                BackgroundColor = Color.Red;
            else
                BackgroundColor = Color.Black;


            if (isClicked)
                show = false;
        }
    }
}
