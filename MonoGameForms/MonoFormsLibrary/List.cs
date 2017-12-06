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
    public class List:DrawableBaseComponent
    {

        private SpriteFont Font;
        private Vector2 pos;
        private int space;
        private List _labels;

        public List(Game game, Vector2 position, SpriteFont font, string[] list, int spaceBetweenText) : base(game)
        {
            Font = font;
            pos = position;
            space = spaceBetweenText;

            if (list != null)
            {
                updatelist(list);
            }
        }

        public void updatelist(String[] list)
        {
            _labels = new List<UiLabel>();
            for (int i = 0; i < list.Length; i++)
                _labels.Add(new UiLabel(Game, Position + new Vector2(0, _spaceBetweenLabels * i) - Globals.HalfScreenSize, list[i], _font));
        }

       
    }
}
