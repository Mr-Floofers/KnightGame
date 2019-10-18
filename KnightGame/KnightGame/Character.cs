using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class Character
    {
        Dictionary<PlayerStates, KeyValuePair<List<Rectangle>, TimeSpan>> animations;

        Animation currentAnimation;

        enum RunningStates
        {
            Left,
            Right
        }

        enum JumpingStates
        {
            jumpStart,//jump_start
            jumpLoop,//jump_loop
            fallingLoop//fall_loop
        }

        PlayerStates playerState;
        RunningStates runningState;
        JumpingStates jumpingState;

        Vector2 speed;
        float gravity = .5f;
        float velocity;
        bool isJumping = false;

        public Character(Vector2 speed)
        {
            animations = new Dictionary<PlayerStates, KeyValuePair<List<Rectangle>, TimeSpan>>();
            currentAnimation = null;
            this.speed = speed;
            velocity = speed.Y;
        }

        public void Update(GameTime gameTime, Viewport vp)
        {
            
        }
    }
}
