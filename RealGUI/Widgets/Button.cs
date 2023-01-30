using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using RealGUI.RealGUI;

namespace RealGUI
{
    public class Button : Items
    {
        string ButtonName;
        SpriteFont default_font;
        public Color btnColor { get; set; }

        public Button(string name, Vector2 pos, Vector2 sze, Color Background, string ButtonName) : base(name, pos, sze, Background)
        {
            this.ButtonName = ButtonName;
            this.default_font = font;
            btnColor = Color.White;
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

                
                drawGraphics.DrawString(font, ButtonName, Calculate.CenterofButton(position, size, font, ButtonName), btnColor);

                drawShapeBatch.End();
            }
        }

        public override void OnHover()
        {
            base.OnHover();
        }

        public override void update()
        {
            if (isHovered)
            {
                BackgroundColor = Config.GreyHover;

                btnColor = Color.Red;
            }
            else
            {
                BackgroundColor = Config.NavColor;
                btnColor = Color.White;
            }

        }
    }
}
