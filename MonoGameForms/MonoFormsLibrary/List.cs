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
        private List<Label> _labels;

        public list(Game game, Vector2 position, SpriteFont font, string[] list, int spaceBetweenText) : base(game)
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
            _labels = new List<Label>();
            for (int i = 0; i < list.Length; i++)
                _labels.Add(new Label(Game,Font));
        }

       
    }
}
