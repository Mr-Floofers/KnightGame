using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class Sprite : GameObject
    {
        public Texture2D texture;
        public Rectangle sourceRect;
        public Vector2 origin;

        public Sprite(Texture2D texture, Vector2 position, Color color, Vector2 scale, float rotation, SpriteEffects effects)
            :base (position, color, scale, rotation, effects)
        {
    
            this.texture = texture;
            this.position = position;
            this.color = color;
            this.scale = scale;
            this.rotation = rotation;
            this.effects = effects;

            sourceRect = new Rectangle(0, 0, texture.Width, texture.Height);
            origin = Vector2.Zero;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, sourceRect, color, rotation, origin, scale, effects, 0);
        }
    }
}
