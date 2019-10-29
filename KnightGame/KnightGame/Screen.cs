using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class Screen
    {
        public List<GameObject> parts;
        public bool partialScreen;
        bool activeScreen;
        
        public Button exit;
        string Name;

        public Screen(Vector2 position, Color color, float transparency, List<GameObject> parts, string Name, Button exit)
        {
            this.parts = parts;
            this.Name = Name;
            this.exit = exit;
        }

        public void Update()
        {
            for (int i = 0; i < parts.Count; i++)
            {
                parts[i].Update();
            }
        }
        public void Draw(SpriteBatch sb)
        {
            for (int i = 0; i < parts.Count; i++)
            {
                parts[i].Draw(sb);
            }
        }
    }
}
