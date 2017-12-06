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

        private SpriteEffects _textOrientation = SpriteEffects.None;

        public SpriteEffects TextOrientation
        {
            get { return _textOrientation; }
            set { _textOrientation = value; }
        }

        private float _layerDepth = 0;

        public float LayerDepth
        {
            get { return _layerDepth; }
            set { _layerDepth = value; }
        }


        private float _rotation = 0;

        public float Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }

        private float _scale = 1;

        public float Scale
        {
            get { return _scale; }
            set { _scale = value; }
        }


        private Color _textColor = Color.Black;

        public Color TextColor
        {
            get { return _textColor; }
            set { _textColor = value; }
        }


        private SpriteFont _font;

        public SpriteFont Font
        {
            get { return _font; }
            set { _font = value; }
        }

        private string _text = string.Empty;

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

        private Vector2 _origin = Vector2.Zero;

        public Vector2 Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }


        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(); 
            if(_font != null)
            spriteBatch.DrawString(_font, _text, _position, _textColor, _rotation, _origin, _scale, _textOrientation, _layerDepth);
            else
            {
                throw new Exception("Must define a font for the label");
            }
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
