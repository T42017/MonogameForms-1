using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoFormsLibrary
{
    public class Cursor : DrawableBaseComponent
    {
        public Texture2D Texture { get; set; }
        public Vector2 pos;
        private MouseState _mouseState;


        public Cursor(Game game) : base(game)
        {
        }

        protected override void LoadContent()
        {
            Texture = Game.Content.Load<Texture2D>("cursorGauntlet_blue");
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            SpriteBatch.Begin();

            SpriteBatch.Draw(Texture, pos, Color.White);

            SpriteBatch.End();

            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            _mouseState = Mouse.GetState();

            pos = new Vector2(_mouseState.X, _mouseState.Y);
            base.Update(gameTime);
        }
    }
}
