using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoFormsLibrary
{
    public class list:DrawableBaseComponent
    {

        private SpriteFont Font;
        private Vector2 pos;
        private int space;
        private List<string> _labels;
        private Label label;
        private Color Color;
        

        public list(Game game, Vector2 position, string font, List<string> list, int spaceBetweenText,Color color) : base(game)
        {
            Font = Game.Content.Load<SpriteFont>("font");
            pos = position;
            space = spaceBetweenText;
            Color = color;
            _labels = list;

        }

        public override void Update(GameTime gameTime)  
    {  base.Update(gameTime); }


        public override void Draw(GameTime gameTime)
        {
            SpriteBatch.Begin();
            for (int i = 0; i < _labels.Count; i++)
            {
              SpriteBatch.DrawString(Font,_labels[i],new Vector2(pos.X,pos.Y+(space*i)), Color);
                
            }
            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
