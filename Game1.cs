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

        //essentials
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public ShapeBatch sb;

        // fonts
        public static SpriteFont default_font;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.GraphicsProfile = GraphicsProfile.HiDef;


            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferHeight = 960;
            _graphics.PreferredBackBufferWidth = 1336;
        }


        public static SpriteFont GetDefaultFont()
        {
            return default_font;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // built in
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            sb = new ShapeBatch(GraphicsDevice, Content);

            // loading content
            default_font = Content.Load<SpriteFont>("Font");

            // 3rd party
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