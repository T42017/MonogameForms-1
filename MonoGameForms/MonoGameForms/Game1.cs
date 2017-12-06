using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoFormsLibrary;

namespace MonoGameForms
{
    /// <summary>
    ///     This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private SpriteFont font;
        private GraphicsDeviceManager graphics;
        private Button knapp;
        private SpriteFont font;
        private Label label;
        private SpriteBatch spriteBatch;
        private Texture2D bild;
        public Game1()
        {
          
           
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferHeight = 1500,
                PreferredBackBufferWidth = 1000
            };
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            knapp = new Button(this, new Vector2(200, 200), "succ", "File", "button", Color.White, Color.Green,Color.Cyan,Color.IndianRed,(sender, args) => Exit() );
            label = new Label(this);
            label.Text = "hey";
            Components.Add(knapp);
            IsMouseVisible = true;
            
            Components.Add(label);
            base.Initialize();
        }


        protected override void LoadContent()
        {
            font = Content.Load<SpriteFont>("Font");
            label.Font = font;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
           
         
           
            
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                label.Text = "000000"
                    ;
          

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Beige);
            spriteBatch.Begin();
            spriteBatch.End();

        
            base.Draw(gameTime);
        }
    }
}