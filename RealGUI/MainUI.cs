using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGUI
{
    public class MainUI
    {
        private Game1 game;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        
        public MainUI(Game1 Game, GraphicsDeviceManager graphics, SpriteBatch spriteBatch)
        {
            this.game = Game;
            this._graphics = graphics;
            this._spriteBatch = spriteBatch;
        }

        public void init()
        {
            
        }

        public void Unload()
        {

        }

        public void update()
        {

        }

        public void draw()
        {

        }
    }
}
