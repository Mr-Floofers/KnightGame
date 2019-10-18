﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class Sprite
    {
        public Texture2D texture;
        public Vector2 position;
        public Color color;
        public Rectangle sourceRect;
        public Vector2 origin;
        protected Vector2 scale;
        protected float rotation;
        public SpriteEffects effects;

        public Sprite(Texture2D texture, Vector2 position, Color color, Vector2 scale, float rotation, SpriteEffects effects)
        {
            this.texture = texture;
            this.position = position;
            this.color = color;
            this.scale = scale;
            this.rotation = rotation;
            this.effects = effects;

            sourceRect = new Rectangle(0, 0, texture.Width, texture.Height);
            origin = Vector2.Zero; // if the origin is to be changed to the center of the image - new Vector2(sourceRectangle.Width / 2, sourceRectangle.Height / 2);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, sourceRect, color, rotation, origin, scale, effects, 0);
        }
    }
}
