using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        public string Name;
        public bool show = true;
        public bool isHovered = false;
        public bool isClicked = false;

        //Transforms
        Point Pointsize;

        public Items(string name, Vector2 pos, Vector2 sze, Color Background)
        {
            this.Name = name;
            this.position = pos;
            this.size = sze;
            this.BackgroundColor = Background;
        }

        public virtual void init()
        {
            Pointsize = new Point((int)size.X, (int)size.Y);

            drawShapeBatch = MainUI.GetShapeBatch();
            drawGraphics = MainUI.GetSpriteBatch();
            font = Game1.GetDefaultFont();
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
