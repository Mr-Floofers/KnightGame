using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class ScreenManager
    {
        public ScreenStack screens;
        
        public ScreenManager(ScreenStack screens)
        {
            this.screens = screens;
        }

        public void Update()
        {
            screens.Peek().Update();
            if(screens.Peek().exit.Clicked)
            {
                screens.Pop();
            }
        }

        public void Draw(SpriteBatch sb)
        {
            screens.Peek().Draw(sb);
            //if(screens.Peek().partialScreen)
            //{
            //    screens.BackPeek().Draw(sb);
            //}
        }
    }
}
