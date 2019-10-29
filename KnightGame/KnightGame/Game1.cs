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
        MouseState ms;
        //Texture2D purpleKnightSheet;
        //List<Rectangle> IdleFrame;
        //List<Rectangle> CurrentFrames;
        //TimeSpan idleTime;
        //TimeSpan runningTime;
        //TimeSpan goalTime;
        //TimeSpan elapsedTime;
        //int currentFrame;
        //Vector2 PlayerPosition;
        //PlayerStates playerState;
        SpriteEffects effects;
        //Player player1;
        SpriteFont font;

        Button testButton1;
        Text testText1;
        Screen testScreen1;
        List<GameObject> testParts1;

        Button testButton2;
        Text testText2;
        Screen testScreen2;
        List<GameObject> testParts2;

        Screen menuScreen;
        Text titleText;
        Button enterSettings;
        Button enterGame;
        List<GameObject> menuParts;

        ScreenManager screenManager;
        ScreenStack screens;

        Texture2D pixel;
        

        Dictionary<PlayerStates, List<Rectangle>> frames;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1600;
            graphics.PreferredBackBufferHeight = 900;
            //frames = new Dictionary<PlayerStates, List<Rectangle>>();
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

            //purpleKnightSheet = Content.Load<Texture2D>("spritesheet");

            //PlayerPosition = Vector2.Zero;// new Vector2(0, Window.ClientBounds.Height - 120);
            font = Content.Load<SpriteFont>("mainFont");
            pixel = GameObject.CreateTexture(graphics.GraphicsDevice, 1, 1, Color.White);

            //currentFrame = 0;
            //elapsedTime = new TimeSpan();
            //idleTime = TimeSpan.FromMilliseconds(100);
            //runningTime = TimeSpan.FromMilliseconds(75);
            //playerState = PlayerStates.idle;
            //goalTime = idleTime;
            effects = SpriteEffects.None;

            testParts1 = new List<GameObject>();
            testButton1 = new Button("This is a test button", font, Vector2.Zero, Color.Black, Vector2.One, 0f, effects, Color.White, .5f, pixel);
            testText1 = new Text("This is screen 1", font, new Vector2(100), Color.Green, Vector2.One, 0f, effects);
            testParts1.Add(testButton1);
            testParts1.Add(testText1);
            testScreen1 = new Screen(Vector2.Zero, Color.White, 1, testParts1, "1", testButton1);

            testParts2 = new List<GameObject>();
            testButton2 = new Button("This is a test button", font, Vector2.Zero, Color.Black, Vector2.One, 0f, effects, Color.White, .5f, pixel);
            testText2 = new Text("This is screen 2", font, new Vector2(100), Color.Yellow, Vector2.One, 0f, effects);
            testParts2.Add(testButton2);
            testParts2.Add(testText2);
            testScreen2 = new Screen(Vector2.Zero, Color.White, 1, testParts2, "2", testButton2);

            //titleText = new 

            screens = new ScreenStack(2);
            screens.Push(testScreen2);
            screens.Push(testScreen1);
            screenManager = new ScreenManager(screens);

            //player1 = new Player(purpleKnightSheet, new Vector2(PlayerPosition.X + 100, PlayerPosition.Y), Color.White, new Vector2(5, 10), GraphicsDevice.Viewport);

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
            ms = Mouse.GetState();

            if (ks.IsKeyDown(Keys.Escape))
                Exit();

            //player1.Update(gameTime, GraphicsDevice.Viewport, ks);

            //testButton.Update(ms);
            screenManager.Update();

            

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
            //spriteBatch.DrawString(font, testButton.Clicked.ToString(), new Vector2(100, 100), Color.White);
            //testButton.Draw(spriteBatch);
            screenManager.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);

            // TODO: Add your drawing code here
        }
    }
}
