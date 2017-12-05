using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace MonoFormsLibrary
{
    public class Label : DrawableGameComponent
    {
        private SpriteBatch spriteBatch;

        private SpriteFont _font;

        public SpriteFont Font
        {
            get { return _font; }
            set { _font = value; }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private Vector2 _position = Vector2.Zero;

        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(_font, _text, _position, Color.Black);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            base.LoadContent();
        }

        public Label(Game game) : base(game)
        {
        }

        public Label(Game game, SpriteFont font) : base(game)
        {
            _font = font;
        }

       
    }
}
