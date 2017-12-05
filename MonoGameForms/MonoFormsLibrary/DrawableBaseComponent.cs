using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoFormsLibrary
{
    public class DrawableBaseComponent : DrawableGameComponent
    {
        public DrawableBaseComponent(Game game) : base(game)
        {
        }

        public SpriteBatch SpriteBatch { get; private set; }

        public virtual void Remove()
        {
            Game.Components.Remove(this);
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(Game.GraphicsDevice);
            base.LoadContent();
        }

        
    }
}
