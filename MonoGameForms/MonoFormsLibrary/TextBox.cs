using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoFormsLibrary
{
    public class TextBox
    {

        public Texture2D TextBoxArea;
        public StringBuilder StringTyper;
        public SpriteFont font;
        public Vector2 PositionRec;
        public KeyboardState oldState;
        private KeyboardState keyboardState;
        public Rectangle clickArea;
        public int stringCapacity =20; 

        public void TypeInTextBox()
        {
            keyboardState = Keyboard.GetState();
            var keys = keyboardState.GetPressedKeys();
            clickArea = new Rectangle((int)PositionRec.X, (int)PositionRec.Y ,500, 500);
            try
            {
                StringTyper.Capacity = stringCapacity;
            }
            catch (Exception e)
            {

            }

            try
            {
                if (StringTyper.Length == StringTyper.Capacity -1)
                {
                    StringTyper.AppendLine("");
                    stringCapacity += 20;
                }
                else if (oldState.IsKeyDown(keys[0]) != keyboardState.IsKeyDown(keys[0]) && StringTyper.Length < StringTyper.Capacity && !keys.Contains(Keys.Back))
                {

                    if (keys.Length > 0)
                    {
                        if (keys[0] == Keys.Space)
                        {
                            StringTyper.Append(" ");
                            keys = keyboardState.GetPressedKeys();
                        }

                        else
                        {
                            var keyValue = keys[0].ToString();
                           StringTyper.Append(keyValue);
                            keys = keyboardState.GetPressedKeys();
                        }
                        
                    }
                }

                if (oldState.IsKeyDown(keys[0]) != keyboardState.IsKeyDown(keys[0]) && keys[0] == Keys.Back)
                {
                    StringTyper.Remove(StringTyper.Length - 1, 1);
                    keys = keyboardState.GetPressedKeys();
                }
            }
            catch (Exception e)
            {
                
            }
            oldState = keyboardState;
        }



    }

}
  