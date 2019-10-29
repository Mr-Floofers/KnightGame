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
    class Button : Text
    {
        Color fullButtonColor;
        Color noHoverColor;
        Color currentButtonColor;
        MouseState preMs;
        float notOnColorFactor;
        Texture2D pixel;
        MouseState ms;

        public bool Clicked = false;

        public Button(string text, SpriteFont font, Vector2 position, Color textColor, Vector2 scale, float rotation, SpriteEffects effects, Color buttonColor, float notOnColorFactor, Texture2D pixel)
            : base(text, font, position, textColor, scale, rotation, effects)
        {
            this.fullButtonColor = buttonColor;
            this.notOnColorFactor = notOnColorFactor;
            noHoverColor = buttonColor * notOnColorFactor;
            this.pixel = pixel;
        }
        Rectangle hitBox
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, (int)TextSize().X, (int)TextSize().Y);
            }
        }



        public override void Update()
        {
            ms = Mouse.GetState();
            Clicked = false;
            if (hitBox.Contains((Point)ms.Position))
            {
                currentButtonColor = fullButtonColor;
                if (preMs.LeftButton == ButtonState.Pressed && ms.LeftButton == ButtonState.Released)
                {
                    Clicked = true;
                }
            }
            else
            {
                currentButtonColor = noHoverColor;
            }
            preMs = ms;
        }

        public override void Draw(SpriteBatch sb)
        {
            sb.Draw(pixel, hitBox, currentButtonColor);
            base.Draw(sb);
        }



    }
}
