using System.Security.AccessControl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoFormsLibrary;


namespace MonoGameForms
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Cursor cursor;
        private KeyboardState _previousKeyboardState;

        private Texture2D txture;

        public int molested { get; set; }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
        }
        protected override void Initialize()
        {
            cursor = new Cursor(this);
            cursor.Texture = Content.Load<Texture2D>("cursorGauntlet_blue");
            Components.Add(cursor);

            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //cursor.Texture = Content.Load<Texture2D>()
        }

        protected override void UnloadContent()
        {

        }
        
        protected override void Update(GameTime gameTime)
        {
            var kbState = Keyboard.GetState();

            if (kbState.IsKeyDown(Keys.Space) && _previousKeyboardState.IsKeyUp(Keys.Space))
                cursor.Texture = Content.Load<Texture2D>("cursorSword_bronze");
            else
            {
                cursor.Texture = Content.Load<Texture2D>("cursorGauntlet_blue");
            }

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            

            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
