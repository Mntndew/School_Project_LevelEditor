using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Windows.Forms;
using System.IO;

namespace Level_Editor
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    /// 
    public enum State
    {
        PLAY,
        PAUSE,
        START
    }
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        
        public Texture2D debugTexture;

        public static State state = State.PLAY;
        public static GraphicsDeviceManager graphics;
        public SpriteBatch spriteBatch;
        public static GUI.HUD hud;
        public static Map.MapController mapController;

        public static int mapWidth, mapHeight, tileWidth, tileHeight;
        public SpriteFont font;
        public MouseState mouse;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.IsMouseVisible = true;
            //initialize all objects for this class
            hud = new GUI.HUD(1280, 720, Content);
            

            //Form myForm = (Form)Form.FromHandle(this.Window.Handle);
            //myForm.WindowState = FormWindowState.Maximized;
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
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            hud.LoadNpc();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>(@"General\Font");
            hud.LoadTextures(Content);
            mapController = new Map.MapController();
            mapController.entityTexture = Content.Load<Texture2D>("entityTexture");
            mapController.rectangle_texture = Content.Load<Texture2D>(@"General\blank_square");
            debugTexture = Content.Load<Texture2D>(@"General\blank_square");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
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
            mouse = Mouse.GetState();
            if (state == State.START)
            {
                bool textureFailed = false;
                state = State.PAUSE;
                Forms.LoadTileset_Form loadTileset_form = new Forms.LoadTileset_Form();
                loadTileset_form.ShowDialog();
                if (loadTileset_form.DialogResult == DialogResult.OK)
                {
                    try
                    {
                        Texture2D texture;
                        FileStream stream = new FileStream(loadTileset_form.filePath, FileMode.Open, FileAccess.Read);

                        texture = Texture2D.FromStream(graphics.GraphicsDevice, stream);
                        stream.Close();
                        Game1.hud.tilesetManager.SetTilesetTexture(texture, mapController.tileWidth, mapController.tileHeight);
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Error loading texture.");
                        Game1.hud.tilesetManager.tileset_texture = null;
                        textureFailed = true;
                    }
                }
                if (!textureFailed)
                {
                    Forms.NewMap_Form newMap_form = new Forms.NewMap_Form();
                    newMap_form.ShowDialog();

                    if (newMap_form.DialogResult == DialogResult.OK)
                    {
                        mapController.mapWidth = newMap_form.mapWidth;
                        mapController.mapHeight = newMap_form.mapHeight;
                        mapController.NewMap(newMap_form.mapName);
                    }
                }
            }
            if (state == State.PLAY)
            {
                hud.Update(gameTime);
                mapController.Update(gameTime);
                
            }
            // TODO: Add your update logic here
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            mapController.Draw(spriteBatch);
            hud.Draw(spriteBatch);
            spriteBatch.Begin();
            //spriteBatch.DrawString(font, "Mouse Pos: " + mouse.X + ", " + mouse.Y, new Vector2(8, 8), Color.Red);
            spriteBatch.DrawString(font, "Layer: " + mapController.selectedLayer, new Vector2(870, 690), Color.Red);
            spriteBatch.DrawString(font, "Map size: " + mapController.map.mapWidth + ", " + mapController.map.mapHeight, new Vector2(870, 670), Color.Red);
            for (int i = 0; i < hud.npcs.Count; i++)
            {
                spriteBatch.DrawString(font, "" + hud.npcs[i].name, new Vector2(hud.npcs[i].position.X, hud.npcs[i].position.Y - 30), Color.White);
                spriteBatch.Draw(Content.Load<Texture2D>("entityTexture"), hud.npcs[i].position, Color.White);
            }
            spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
