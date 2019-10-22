using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class Player : Character
    {

        KeyboardState prevKs;

        //bool ifSpace = false;
        List<Rectangle> currentFrames;

        Viewport vp;
        //bool isDoubleJump = false;

        //int jumpCount = 0;
        public Player(Texture2D texture, Vector2 position, Color tint, Vector2 speed, Viewport vp)
            : base(speed)
        {
            currentAnimation = new Animation(TimeSpan.Zero, currentFrames, texture, position, tint, new Vector2(3), 0, SpriteEffects.None);
            AddAnimations(PlayerStates.idle, getFrames(@"D:\FOR DENNIS\KnightPack\valiant_knight\style_B\spritesheet \spritesheet.txt", "idle"), TimeSpan.FromMilliseconds(66));
            //ChangeState(PlayerStates.idle);

            playerState = PlayerStates.idle;
            currentFrames = getFrames(@"D:\FOR DENNIS\KnightPack\valiant_knight\style_B\spritesheet \spritesheet.txt", "idle");
        }

        public void Update(GameTime gameTime, Viewport vp, KeyboardState ks)
        {
            //if (ks.IsKeyDown(Keys.D))
            //{
            //    ChangeState(PlayerStates.run);
            //    runningState = RunningStates.Right;
            //}

            ////running left
            //else if (ks.IsKeyDown(Keys.A))
            //{
            //    ChangeState(PlayerStates.run);
            //    runningState = RunningStates.Left;
            //}


            base.Update(gameTime, vp);
            prevKs = ks;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        List<Rectangle> getFrames(string fileLocation, string stateName)
        {
            string[] lines = File.ReadAllLines(fileLocation);
            List<Rectangle> frames = new List<Rectangle>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] items = lines[i].Split('/', '=');

                string state = items[0];

                int index = int.Parse(items[1].Replace("frame", "").TrimEnd());

                string[] stringRectangle = items[2].TrimStart().Split(' ');
                int[] intRectagle = new int[stringRectangle.Length];

                if (state == stateName)
                {
                    for (int j = 0; j < stringRectangle.Length; j++)
                    {
                        intRectagle[j] = int.Parse(stringRectangle[j]);
                    }
                    frames.Add(new Rectangle(intRectagle[0], intRectagle[1], intRectagle[2], intRectagle[3]));
                }
            }
            return frames;
        }





    }
}
