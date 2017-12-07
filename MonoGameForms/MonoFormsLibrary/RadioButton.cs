using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoFormsLibrary
{
    public class RadioButton: DrawableBaseComponent
    {
        private int numberofb, spacebetweenb,spacetext,choosen=1;
        private Texture2D Texture, Texturep;
        private Vector2 pos;
        private SpriteFont Font;
        private List<string> Text;
        private List<Rectangle> rekt;
        private MouseState mus,premus;

        public RadioButton(Game game,int spaceBetweenButton,string texture,string texturepicked,Vector2 position,List<string> text,SpriteFont font,
            int SpaceTextAndbutton) : base(game)
        {
            Texture=Game.Content.Load<Texture2D>(texture);
            Texturep = Game.Content.Load<Texture2D>(texturepicked);
            spacebetweenb = spaceBetweenButton;
            pos = position;
            spacetext = SpaceTextAndbutton;
            Text = text;
            Font = font;
            choosen = 2;
            rekt = new List<Rectangle>();
        }

        protected override void LoadContent()
        {
            for (int i = 0; i < Text.Count; i++)
            {
               rekt.Add(new Rectangle((int)pos.X, (int)pos.Y+(spacebetweenb*i), (int)Texture.Width, (int)Texture.Height));
            }
           
            base.LoadContent();
        }

        public string Information()
        {
            return Text[choosen];
        }

        public override void Update(GameTime gameTime)
        {
            mus = Mouse.GetState();

            for (int i = 0; i < Text.Count; i++)
            {
                if (rekt[i].Contains((new Vector2(mus.X, mus.Y))))
                {
                   

                    if (premus.LeftButton == ButtonState.Released
                        && mus.LeftButton == ButtonState.Pressed)
                    {
                        choosen = i;
                    }
                       
                }
               
            }
            premus = mus;
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            SpriteBatch.Begin();

            for (int i = 0; i < Text.Count; i++)
            {
                if (choosen == i)
                {
                    SpriteBatch.Draw(Texturep, new Vector2(pos.X, pos.Y + (spacebetweenb*i)), Color.WhiteSmoke);
                    SpriteBatch.DrawString(Font, Text[i], new Vector2(pos.X + Texture.Width + spacetext, pos.Y+(spacebetweenb * i)),
                        Color.Black);
                }
                else
                {
                    SpriteBatch.Draw(Texture, new Vector2(pos.X, pos.Y + (spacebetweenb * i)), Color.WhiteSmoke);
                    SpriteBatch.DrawString(Font, Text[i], new Vector2(pos.X + Texture.Width + spacetext, pos.Y+(spacebetweenb * i)), Color.Black);                    
                }
            }
            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
