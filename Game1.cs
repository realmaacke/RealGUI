using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Apos.Shapes;
using Microsoft.Xna.Framework.Content;

namespace RealGUI
{
    public class Game1 : Game
    {
        // ui
        private MainUI UI;

        private GraphicsDeviceManager _graphics;

        private SpriteBatch _spriteBatch;
        public ShapeBatch sb;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.GraphicsProfile = GraphicsProfile.HiDef;


            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            sb = new ShapeBatch(GraphicsDevice, Content);


            UI = new MainUI(this, _spriteBatch, sb);

            UI.init();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            UI.update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            var mouseState = Mouse.GetState();
            var mousePoint = new Point(mouseState.X, mouseState.Y);

            _spriteBatch.Begin();

            UI.draw();

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}