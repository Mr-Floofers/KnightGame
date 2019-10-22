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

        protected Animation currentAnimation;

        protected enum RunningStates
        {
            Left,
            Right
        }

        protected enum JumpingStates
        {
            jumpStart,//jump_start
            jumpLoop,//jump_loop
            fallingLoop//fall_loop
        }

        public PlayerStates playerState;
        protected RunningStates runningState;
        //protected JumpingStates jumpingState;

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
            //if (StateEquals(PlayerStates.idle))
            //{
                
            //}
            currentAnimation.position.Y = vp.Height - (currentAnimation.sourceRect.Height + 80);
            isJumping = false;
            //if (StateEquals(PlayerStates.run))
            //{
            //    if (runningState == RunningStates.Left)
            //    {
            //        currentAnimation.effects = SpriteEffects.FlipHorizontally;
            //        currentAnimation.position = new Vector2(currentAnimation.position.X - speed.X, currentAnimation.position.Y);
            //    }
            //    if (runningState == RunningStates.Right)
            //    {
            //        currentAnimation.effects = SpriteEffects.None;
            //        currentAnimation.position = new Vector2(currentAnimation.position.X + speed.X, currentAnimation.position.Y);
            //    }
            //}
            //if (StateEquals(PlayerStates.jump) || isJumping)
            //{
            //    velocity -= gravity;
            //    currentAnimation.position = new Vector2(currentAnimation.position.X, currentAnimation.position.Y - velocity);
            //    if (currentAnimation.position.Y > vp.Height - 120)
            //    {
            //        currentAnimation.position.Y = vp.Height - 120;
            //        velocity = speed.Y;
            //        ChangeState(PlayerStates.idle);
            //    }
            //}
        }

        protected bool StateEquals(PlayerStates State)
        {
            return State == playerState;
        }
        protected void ChangeState(PlayerStates State)
        {
            if (!StateEquals(State))
            {
                currentAnimation.frames = animations[State].Key;
                currentAnimation.goalTime = animations[State].Value;
                currentAnimation.currentFrame = 0;
                playerState = State;
            }
        }

        protected void AddAnimations(PlayerStates playerState, List<Rectangle> frames, TimeSpan animationTime)
        {

            animations.Add(playerState, new KeyValuePair<List<Rectangle>, TimeSpan>(frames, animationTime));
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            currentAnimation.Draw(spriteBatch);
        }
    }
}
