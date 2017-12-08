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
    public class CheckBox: DrawableBaseComponent
    { 
        private string  Text;
        private MouseState mus=Mouse.GetState(), premus;
        private bool choosen=false;
        private Texture2D Texture, TexturePicked;
        private SpriteFont Font;
        private int Space,Spacebutton;
        private float Scale;
        private Vector2 pos;
        private Rectangle rekt;
       

        public CheckBox(Game game, string texture, string texturepicked, Vector2 position, string text, SpriteFont font,
            int SpaceTextAndbutton, float scale) : base(game)
        {
            Texture = Game.Content.Load<Texture2D>(texture);
            TexturePicked = Game.Content.Load<Texture2D>(texturepicked);
            Text = text;
            Font = font;
            Space = SpaceTextAndbutton;
            Scale = scale;
            pos = position;
        }

        protected override void LoadContent()
        {
           
                rekt=(new Rectangle((int)pos.X, (int)pos.Y , (int)(Texture.Width * Scale), (int)(Texture.Height * Scale)));
            

            base.LoadContent();
        }

        public string Information()
        {
            if (choosen==true)
            {
                return Text;
            }
            else
            {
                return null;
            }
           
        }
        public override void Update(GameTime gameTime)
        {
            mus = Mouse.GetState();

            
                if (rekt.Contains((new Vector2(mus.X, mus.Y))))
                {


                    if (premus.LeftButton == ButtonState.Released
                        && mus.LeftButton == ButtonState.Pressed)
                    {
                        if (choosen == false)
                            choosen = true;

                        else if(choosen==true)
                            choosen = false;
                    }

                }
            premus = mus;
            base.Update(gameTime);
        }
           
        
        public override void Draw(GameTime gameTime)
        {
            SpriteBatch.Begin();

           
                if (choosen == true)
                {
                    SpriteBatch.Draw(TexturePicked, new Vector2(pos.X, pos.Y ), null, Color.WhiteSmoke, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
                    SpriteBatch.DrawString(Font, Text, new Vector2(pos.X + (Texture.Width * Scale) + Space, pos.Y ),
                        Color.Black);
                }
                else
                {
                    SpriteBatch.Draw(Texture, new Vector2(pos.X, pos.Y ), null, Color.WhiteSmoke, 0f, Vector2.Zero, Scale, SpriteEffects.None, 0f);
                    SpriteBatch.DrawString(Font, Text, new Vector2(pos.X + (Texture.Width * Scale) + Space, pos.Y ), Color.Black);
                }
            
            SpriteBatch.End();
            base.Draw(gameTime);

        }
    }
    }
    


