using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Security.Policy;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using MonoFormsLibrary;

namespace MonoGameForms
{
    public class Game1 : Game
    {
        private SpriteFont font;
        private GraphicsDeviceManager graphics;
        private Button knapp;
        private Label label;
        private SpriteBatch spriteBatch;
        private Texture2D bild;
        private List<String> nene,baba;
        private list list;
        private Cursor cursor;
        private KeyboardState _previousKeyboardState;
        private Song meme;
        private RadioButton radio;
        private Texture2D txture;

        public int molested { get; set; }

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
            cursor = new Cursor(this);
            cursor.Texture = Content.Load<Texture2D>("cursorGauntlet_blue");
            font = Content.Load<SpriteFont>("Font");
            baba =new List<string>();
            baba.Add("adolf");
            baba.Add("hadolf");
            baba.Add("adolf");
            baba.Add("adolf");
            baba.Add("adolf");
            baba.Add("adolf1");
            nene =new List<string>();
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            nene.Add("Lots of ppl waving");
            radio=new RadioButton(this,50,"succ","sacc",new Vector2(700,300),baba,font,40 );
            list =new list(this,new Vector2(400,400),"File",nene,30,Color.Cyan );
            knapp = new Button(this, new Vector2(200, 200), "succ", "File", "button", Color.White, Color.Green,Color.Cyan,Color.IndianRed,(sender, args) => Exit() );
            label = new Label(this);
            label.Text = "hey";
            Components.Add(knapp);
            MediaPlayer.IsRepeating = true;
            Components.Add(label);
           
            Components.Add(list);
            Components.Add(radio);
            Components.Add(cursor);
            
            base.Initialize();
        }
        protected override void LoadContent()
        {
            font = Content.Load<SpriteFont>("Font");
            label.Font = font;
            spriteBatch = new SpriteBatch(GraphicsDevice);

            meme = Content.Load<Song>("A");
          



        }

        protected override void UnloadContent()
        {

        }
        
        protected override void Update(GameTime gameTime)
        {
            MediaPlayer.Play(meme);
            var kbState = Keyboard.GetState();

                label.Text = "000000";
          
            if (kbState.IsKeyDown(Keys.Space) && _previousKeyboardState.IsKeyUp(Keys.Space))
                cursor.Texture = Content.Load<Texture2D>("cursorSword_bronze");
            else
            {
                cursor.Texture = Content.Load<Texture2D>("cursorGauntlet_blue");
            }

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