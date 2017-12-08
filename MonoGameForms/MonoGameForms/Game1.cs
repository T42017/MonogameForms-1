using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoFormsLibrary;


namespace MonoGameForms
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private MouseGrab _mouseGrab;
        public TextBox _textBox;
        
        public Game1()
        {
            _textBox = new TextBox();
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
            _textBox.PositionRec = new Vector2(0,0);
            _textBox.StringTyper = new StringBuilder("");
            IsMouseVisible = true;
            _mouseGrab = new MouseGrab();
            _textBox.TextBoxArea = new Texture2D(GraphicsDevice, 1, 1);
            _textBox.TextBoxArea.SetData(new[] { Color.White });

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            _textBox.font = Content.Load<SpriteFont>("Font");
            // Create a 1px square rectangle texture that will be scaled to the
            // desired size and tinted the desired color at draw time

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here

            _textBox.TypeInTextBox();
            _textBox.clickArea = _textBox.TextBoxArea.Bounds;
            _mouseGrab.mousePosition = new Vector2(_mouseGrab._mouseState.Position.X, _mouseGrab._mouseState.Position.Y);
            if (_textBox.clickArea.Contains(_mouseGrab.mousePosition))
            {
                _textBox.PositionRec = _mouseGrab.mousePosition;
            }
            base.Update(gameTime);
        }


        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            

            spriteBatch.Draw(_textBox.TextBoxArea, new Rectangle((int)_textBox.PositionRec.X, (int)_textBox.PositionRec.Y, (int)_textBox.font.MeasureString(_textBox.StringTyper).X, (int)_textBox.font.MeasureString(_textBox.StringTyper).Y), Color.Bisque);
            spriteBatch.DrawString(_textBox.font, _textBox.StringTyper.ToString(), _textBox.PositionRec , Color.Black);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
    
}
