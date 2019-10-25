using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class Screen : GameObject
    {

        List<GameObject> parts;

        public Screen(Vector2 position, Color color, Vector2 scale, float rotation, SpriteEffects effects)
            :base(position, color, scale, rotation, effects)
        {
            parts = new List<GameObject>();
        }

        public override void Update()
        {
            for (int i = 0; i < parts.Count; i++)
            {
                parts[i].Update();
            }
        }
        public override void Draw(SpriteBatch sb)
        {
            for (int i = 0; i < parts.Count; i++)
            {
                parts[i].Draw(sb);
            }
        }
    }
}
