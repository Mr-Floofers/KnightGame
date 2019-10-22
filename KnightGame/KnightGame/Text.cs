using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    public class Text : GameObject
    {
        string text;
        SpriteFont font;
        public Vector2 origin;

        public Text(string text, SpriteFont font, Vector2 position, Color color, Vector2 scale, float rotation, SpriteEffects effects)
            :base (position, color, scale, rotation, effects)
        {
            this.text = text;
            this.font = font;
            this.position = position;
            this.color = color;
            this.scale = scale;
            this.rotation = rotation;
            this.effects = effects;
            origin = Vector2.Zero;
        }

        public void Draw(SpriteBatch sb)
        {
            sb.DrawString(font, text, position, color, rotation, origin, scale, effects, 0);
        }

        public string GetText()
        {
            return text;
        }

        public SpriteFont GetFont()
        {
            return font;
        }

        public Vector2 TextSize()
        {
            return GetFont().MeasureString(GetText());
        }
    }
}
