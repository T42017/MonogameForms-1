using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Security.Policy;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoFormsLibrary;
using Microsoft.Xna.Framework.Media;
using MonoFormsLibrary;

namespace MonoGameForms
{
    public class Game1 : Game
    {
        private SpriteFont font;
        private GraphicsDeviceManager graphics;
        private Button knapp;
       
        public TextBox _textBox;
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
        private CheckBox boxen;
        public int molested { get; set; }
        
        public Game1()
        {
            _textBox = new TextBox();
           
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
            radio=new RadioButton(this,50,"succ","sacc",new Vector2(700,300),baba,font,40 ,0.5f);
            list =new list(this,new Vector2(400,400),"File",nene,30,Color.Cyan );
            knapp = new Button(this, new Vector2(200, 200), "succ", "File", "button", Color.White, Color.WhiteSmoke,Color.Cyan,Color.IndianRed,(sender, args) => Exit(),0.5f );
            label = new Label(this);
            label.Text = "hey";
            boxen=new CheckBox(this,"Checkbox","CheckboxChecked",new Vector2(500,100),"Kazza",font,30,0.2f );
            Components.Add(boxen);
            Components.Add(knapp);
            MediaPlayer.IsRepeating = true;
            Components.Add(label);
           
            Components.Add(list);
            Components.Add(radio);
            Components.Add(cursor);
            
            base.Initialize();
            _textBox.PositionRec = new Vector2(0,400);
            _textBox.StringTyper = new StringBuilder("");
            _textBox.TextBoxArea = new Texture2D(GraphicsDevice, 1, 1);
            _textBox.TextBoxArea.SetData(new[] { Color.White });

        }
        protected override void LoadContent()
        {
            font = Content.Load<SpriteFont>("Font");
            label.Font = font;
            spriteBatch = new SpriteBatch(GraphicsDevice);
            _textBox.font = Content.Load<SpriteFont>("Font");
            // Create a 1px square rectangle texture that will be scaled to the
            // desired size and tinted the desired color at draw time

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
            _textBox.TypeInTextBox();
            _textBox.clickArea = _textBox.TextBoxArea.Bounds;
           
            base.Update(gameTime);
        }
        

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Beige);

            spriteBatch.Begin();
            

            spriteBatch.End();

        
            spriteBatch.Begin();
            

            spriteBatch.Draw(_textBox.TextBoxArea, new Rectangle((int)_textBox.PositionRec.X, (int)_textBox.PositionRec.Y, (int)_textBox.font.MeasureString(_textBox.StringTyper).X, (int)_textBox.font.MeasureString(_textBox.StringTyper).Y), Color.Bisque);
            spriteBatch.DrawString(_textBox.font, _textBox.StringTyper.ToString(), _textBox.PositionRec , Color.Black);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
    
}