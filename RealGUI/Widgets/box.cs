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
    public class box : Items
    {
        public box(Vector2 pos, Vector2 sze, Color backround, SpriteBatch draw, ShapeBatch _sb)
        {
            this.position = pos;
            this.size = sze;
            this.BackgroundColor = backround;

            this.drawGraphics = draw;
            this.drawShapeBatch = _sb;
        }

        public override void draw()
        {
            if (show)
            {
                drawShapeBatch.Begin();


                drawShapeBatch.DrawRectangle(position,size, BackgroundColor, BackgroundColor, 1);

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

        public override void OnHover()
        {
            base.OnHover();
        }

    }
}
