using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace KnightGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        KeyboardState ks;
        Texture2D purpleKnightSheet;
        List<Rectangle> IdleFrames;
        //public List<int> IdleOffSets;
        //List<Rectangle> RunningFrames;
        List<Rectangle> CurrentFrames;
        TimeSpan idleTime;
        //TimeSpan runningTime;
        TimeSpan goalTime;
        TimeSpan elapsedTime;
        int currentFrame;
        Vector2 PlayerPosition;
        PlayerStates playerState;
        SpriteEffects effects;
        Player player1;
        SpriteFont font;
        

        Dictionary<PlayerStates, List<Rectangle>> frames;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1600;
            graphics.PreferredBackBufferHeight = 900;
            frames = new Dictionary<PlayerStates, List<Rectangle>>();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            IsMouseVisible = true;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            purpleKnightSheet = Content.Load<Texture2D>("spritesheet");

            PlayerPosition = Vector2.Zero;// new Vector2(0, Window.ClientBounds.Height - 120);
            font = Content.Load<SpriteFont>("font");

            currentFrame = 0;
            elapsedTime = new TimeSpan();
            idleTime = TimeSpan.FromMilliseconds(100);
            //runningTime = TimeSpan.FromMilliseconds(75);
            playerState = PlayerStates.idle;
            goalTime = idleTime;
            effects = SpriteEffects.None;

            player1 = new Player(purpleKnightSheet, new Vector2(PlayerPosition.X + 100, PlayerPosition.Y), Color.White, new Vector2(5, 10), GraphicsDevice.Viewport);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            ks = Keyboard.GetState();

            if (ks.IsKeyDown(Keys.Escape))
                Exit();

            player1.Update(gameTime, GraphicsDevice.Viewport, ks);
            //ironMan.Update(gameTime, GraphicsDevice.Viewport);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            player1.Draw(spriteBatch);
            //spriteBatch.DrawString(font, player1.playerState.ToString(), Vector2.Zero, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);

            // TODO: Add your drawing code here
        }
    }
}
