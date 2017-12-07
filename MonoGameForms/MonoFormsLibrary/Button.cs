using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace MonoFormsLibrary
{
    public class Button : DrawableBaseComponent
    {
        private MouseState state = Mouse.GetState(),lastState;
        private Texture2D texture;
        private Color Texturecolor, TexturecolorHighlight,b,c;
        private bool IsHighlighted = false, GotText;
        private Vector2 pos;
        private EventHandler buttonevent;
        private SpriteFont Font;
        private string Buttontext;
        private int sizex1, sizey1, sizex2, sizey2;
        //private KeyboardState _keyboardState = Keyboard.GetState(), _lastKeyboardState;




        public Button(Game game, Vector2 positon, string buttontext, string fontname,String texturename
            ,Color texturecolor, Color texturecolorhighlight, Color textcolor, Color textbcolor, EventHandler clickEvent) : base(game)
        {
            b = textbcolor;
            c = textbcolor;
            Texturecolor = texturecolor;
            TexturecolorHighlight = texturecolorhighlight;
            Buttontext = buttontext;
            buttonevent = clickEvent;
            pos = positon;
            Font = Game.Content.Load<SpriteFont>(fontname);
            texture = Game.Content.Load<Texture2D>(texturename);
            sizex1 = texture.Width;
            sizey1 = texture.Height;
            GotText = true;
        }
        public Button(Game game, Vector2 positon, string buttontext, string fontname, String texturename, EventHandler clickEvent) : base(game)
        {
            b = Color.Black;
            c = Color.Black;
            Texturecolor = Color.GhostWhite;
            TexturecolorHighlight = Color.White;
            Buttontext = buttontext;
            buttonevent = clickEvent;
            pos = positon;
            Font = Game.Content.Load<SpriteFont>(fontname);
            texture = Game.Content.Load<Texture2D>(texturename);
            sizex1 = texture.Width;
            sizey1 = texture.Height;
            GotText = true;

        }
        public Button(Game game, Vector2 positon, String texturename, EventHandler clickEvent) : base(game)
        {
            b = Color.Black;
            c = Color.Black;
            Texturecolor = Color.GhostWhite;
            TexturecolorHighlight = Color.White;        
            buttonevent = clickEvent;
            pos = positon;
            texture = Game.Content.Load<Texture2D>(texturename);
            sizex1 = texture.Width;
            sizey1 = texture.Height;
            GotText = false;

        }



        public override void Update(GameTime gameTime)
        {
            lastState = state;
            state = Mouse.GetState();

            if (state.X>=pos.X && state.Y >= pos.Y && state.X <= (pos.X+sizex1) && state.Y <= (pos.Y + sizey1))
                IsHighlighted = true;
            else
                IsHighlighted = false;

            if(IsHighlighted==true && state.LeftButton == ButtonState.Released && lastState.LeftButton == ButtonState.Pressed)
              buttonevent.Invoke(null,null);

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            
            Vector2 textSize = Font.MeasureString(Buttontext);
            SpriteBatch.Begin();
            if (IsHighlighted == true)
            {
                SpriteBatch.Draw(texture,pos,TexturecolorHighlight);
                if(GotText==true)
                SpriteBatch.DrawString(Font,Buttontext, pos + new Vector2(texture.Width / 2 - (textSize.X / 2), texture.Height / 2 - (textSize.Y / 2)), b);
            }
            else
            {
              SpriteBatch.Draw(texture,pos,Texturecolor);
                if (GotText == true)
             SpriteBatch.DrawString(Font,Buttontext,pos+new Vector2(texture.Width/2-(textSize.X/2), texture.Height/2-(textSize.Y/2)) ,c) ;
            }
            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
