using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    public class GameObject
    {
        public Vector2 position;
        public Color color;
        public Vector2 scale;
        public float rotation;
        public SpriteEffects effects;

        public GameObject(Vector2 position, Color color, Vector2 scale, float rotation, SpriteEffects effects)
        {
            this.position = position;
            this.color = color;
            this.scale = scale;
            this.rotation = rotation;
            this.effects = effects;
        }
        public static Texture2D CreateTexture(GraphicsDevice device, int width, int height, Color color)
        {
            Texture2D texture = new Texture2D(device, width, height);

            Color[] data = new Color[width * height];
            for (int pixel = 0; pixel < data.Count(); pixel++)
            {
                data[pixel] = color;
            }

            texture.SetData(data);

            return texture;
        }

        public virtual void Update() { }
        public virtual void Draw(SpriteBatch sb) { }
    }
}
