using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apos.Shapes;
using Microsoft.Xna.Framework.Content;
using System.Windows.Forms;

namespace RealGUI
{
    public class box : Items
    {
        public box(string name, Vector2 pos, Vector2 sze, Color Background) : base(name, pos, sze, Background) { }

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

                drawShapeBatch.End();
            }
        }

        public override void update()
        {
            
        }

        public override void OnHover()
        {
            base.OnHover();
        }

    }
}
