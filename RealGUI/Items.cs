using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apos.Shapes;
using Microsoft.Xna.Framework.Input;

namespace RealGUI
{
    public abstract class Items
    {
        public SpriteBatch drawGraphics;
        public ShapeBatch drawShapeBatch;

        public SpriteFont font;


        // ahstetics 
        public Vector2 position;
        public Vector2 size;
        public Color BackgroundColor;

        // functionality
        public bool show = true;
        public bool isHovered = false;
        public bool isClicked = false;


        //Transforms
        Point Pointsize;



        public virtual void init()
        {
            Pointsize = new Point((int)size.X, (int)size.Y);
        }

        public abstract void draw();

        public abstract void update();


        public virtual void OnHover()
        {
            var mouseState = Mouse.GetState();
            var mousePoint = new Point(mouseState.X, mouseState.Y);

            var CollisionBox = new Rectangle((int)position.X, (int)position.Y, (int)this.size.X, (int)this.size.Y);


            if (CollisionBox.Contains(mousePoint))
            {
                isHovered = true;
                isClicked = mouseState.LeftButton == ButtonState.Pressed;

            }
            else
            {
                isHovered = false;
                isClicked = false;
            }

        }


    }
}
