using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class ScreenManager : GameObject
    {
        Stack<Screen> screens;
        
        public ScreenManager(Vector2 position, Color color, Vector2 scale, float rotation, SpriteEffects effects)
            :base(position, color, scale, rotation, effects)
        {
            
        }

        public override void Update()
        {
            screens.Peek().Update();
        }

        public override void Draw(SpriteBatch sb)
        {
            screens.Peek().Draw(sb);
        }
    }
}
