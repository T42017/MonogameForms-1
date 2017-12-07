using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoFormsLibrary;

namespace MonoGameForms
{
    /// <summary>
    ///     This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        private SpriteFont font;
        private GraphicsDeviceManager graphics;
        private Button knapp;
        private Label label;
        private SpriteBatch spriteBatch;
        private Texture2D bild;
        private List<String> nene;
        private list list;

        public Game1()
        {
          
           
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferHeight = 720,
                PreferredBackBufferWidth = 1280
            };
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            nene=new List<string>();
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");

            list =new list(this,new Vector2(400,400),"File",nene,30,Color.Cyan );
            knapp = new Button(this, new Vector2(200, 200), "succ", "File", "button", Color.White, Color.Green,Color.Cyan,Color.IndianRed,(sender, args) => Exit() );
            label = new Label(this);
            label.Text = "hey";
            Components.Add(knapp);
            IsMouseVisible = true;
            
            Components.Add(label);
            Components.Add(list);
            base.Initialize();
        }


        protected override void LoadContent()
        {
            font = Content.Load<SpriteFont>("Font");
            label.Font = font;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
           
         
           
            
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))

                label.Text = "000000";
          

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Beige);
            spriteBatch.Begin();
            spriteBatch.End();

        
            base.Draw(gameTime);
        }
    }
}