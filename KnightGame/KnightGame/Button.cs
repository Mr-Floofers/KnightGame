using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class Button
    {
        Text text;
        Rectangle hitBox
        {
            get
            {
                return new Rectangle((int)text.position.X, (int)text.position.Y, (int)text.TextSize().X, (int)text.TextSize().Y);
            }
        }
        MouseState ms;
        


    }
}
