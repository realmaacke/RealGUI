using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGUI
{
    public class Items
    {
        public Vector2 position;
        public Vector2 size;
        public Color BackgroundColor = Color.Black;
        public bool show = true;


        public virtual void draw()
        {

        }

        public virtual void update()
        {

        }


    }
}
