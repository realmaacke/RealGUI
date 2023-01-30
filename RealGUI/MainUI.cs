using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Apos.Shapes;
using System;
using System.Linq;

namespace RealGUI
{
    public class MainUI
    {
        private Game1 game;
        private SpriteBatch _spriteBatch;
        private ShapeBatch sb;

        private box box1;

        private List<Items> Widgets = new List<Items>();

        
        public MainUI(Game1 Game,SpriteBatch spriteBatch, ShapeBatch sb)
        {
            this.game = Game;
            this._spriteBatch = spriteBatch;
            this.sb = sb;
        }


        public void add(Items item)
        {
            Widgets.Add(item);
        }

        public void Remove(Items item)
        {
            Widgets.Remove(item);
        }

        public void init()
        {


            Widgets.Add(new box(new Vector2(10, 10), new Vector2(100, 100), Color.Black, _spriteBatch, sb));
            Widgets.Add(new box(new Vector2(200, 200), new Vector2(100, 100), Color.Black, _spriteBatch, sb));
        }

        public void update()
        {
            Widgets.ForEach(e => e.update());

            Widgets.ForEach(e => e.OnHover());

        }


        public void draw()
        {
            Widgets.ForEach(e => e.draw());
        }

    }
}
