using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MonoFormsLibrary
{
    public class MouseGrab : Game
    {
        public MouseState _mouseState;
        public object grabbedObject;
        public Vector2 mousePosition;

        


        public void CheckMouseGrabbing()
        {

            if (_mouseState.LeftButton == ButtonState.Pressed)
            {
                

            }
        }

    }
}
