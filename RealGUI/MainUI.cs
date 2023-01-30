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

        // instances
        private Game1 game;

        // normals
        private SpriteBatch _spriteBatch;
        private ShapeBatch sb;

        // getters
        private static SpriteBatch SPRITEBATCH;
        private static ShapeBatch SHAPEBATCH;

        // Controllers
        private List<Items> Widgets = new List<Items>();

        
        public MainUI(Game1 Game,SpriteBatch spriteBatch, ShapeBatch sb)
        {
            this.game = Game;
            this._spriteBatch = spriteBatch;
            this.sb = sb;

            // statics
            SPRITEBATCH = spriteBatch;
            SHAPEBATCH = sb;
        }


        #region static getters
        public static SpriteBatch GetSpriteBatch() { return SPRITEBATCH; }
        public static ShapeBatch GetShapeBatch() { return SHAPEBATCH; }
        #endregion

        public void init()
        {
            // creating the widgets
            Widgets.Add(new box("left-panel", new Vector2(10, 10), new Vector2(100, 100), Color.Black));
            Widgets.Add(new box("right-panel", new Vector2(200, 200), new Vector2(100, 100), Color.Black));


            Widgets.Add(new Button("Button-1", new Vector2(300, 300), new Vector2(200, 100), Color.Black, "Button"));


            // initializing them
            Widgets.ForEach(e => e.init());
        }

        public void update()
        {
            // widget Calls
            Widgets.ForEach(e => e.update());
            Widgets.ForEach(e => e.OnHover());

        }


        public void draw()
        {
            Widgets.ForEach(e => e.draw());
        }

    }
}
