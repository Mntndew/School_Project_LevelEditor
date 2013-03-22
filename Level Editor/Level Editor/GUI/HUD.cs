using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.IO;

namespace Level_Editor.GUI
{
    public class HUD
    {
        public List<cButton> buttons;
        List<cPanel> panels;
        //Textures for buttons
        Texture2D saveMap_texture;
        Texture2D loadMap_texture;
        Texture2D clearMap_texture;
        Texture2D loadTileset_texture;
        Texture2D newNpc_texture;
        //Textures for panels
        Texture2D panelYellow_texture;
        //Tileset manager
        public cTilesetManager tilesetManager;
        //variables to keep the hud in the same place
        int screenWidth, screenHeight;
        public List<cNpc> npcs = new List<cNpc>();

        public HUD(int screenWidth, int screenHeight, ContentManager content)
        {
            buttons = new List<cButton>();
            panels = new List<cPanel>();
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            tilesetManager = new cTilesetManager(new Vector2(screenWidth - 362, 32));
        }

        public void LoadNpc()
        {
            string npcDir;
            int npcFiles = Directory.GetFiles(@"C:\npc\npc\").Length;
            for (int i = 0; i < npcFiles; i++)
            {
                npcDir = Directory.GetFiles(@"C:\npc\npc\")[i];
                StreamReader reader = new StreamReader(npcDir);
                reader.ReadLine();
                npcs.Add(new cNpc(reader.ReadLine(), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), bool.Parse(reader.ReadLine()), reader.ReadLine(), reader.ReadLine()));
                reader.Close();
            }
        }

        public void LoadTextures(ContentManager content)
        {
            saveMap_texture = content.Load<Texture2D>(@"Buttons\SaveMap_Button");
            loadMap_texture = content.Load<Texture2D>(@"Buttons\LoadMap_Button");
            clearMap_texture = content.Load<Texture2D>(@"Buttons\ClearMap_Button");
            loadTileset_texture = content.Load<Texture2D>(@"Buttons\LoadTileset_Button");
            newNpc_texture = content.Load<Texture2D>(@"General\blank_square");
            panelYellow_texture = content.Load<Texture2D>(@"Panels\PanelYellow");

            buttons.Add(new cSaveMapButton(saveMap_texture, new Vector2(screenWidth - 300, screenHeight - 160)));
            buttons.Add(new cLoadMapButton(loadMap_texture, new Vector2(screenWidth - 300, screenHeight - 80)));
            buttons.Add(new cLoadTilesetButton(loadTileset_texture, new Vector2(screenWidth - 150, screenHeight - 160)));
            buttons.Add(new cNewMapButton(clearMap_texture, new Vector2(screenWidth - 150, screenHeight - 80)));
            buttons.Add(new cNewNpcButton(newNpc_texture, new Vector2(0, 0)));
            panels.Add(new cPanel(panelYellow_texture, new Rectangle(screenWidth-322, screenHeight - 176, 322, 176)));
            panels.Add(new cPanel(panelYellow_texture, new Rectangle(screenWidth - 400, 0, 400, screenHeight - 176)));
            tilesetManager.LoadExtraTextures(content);
        }

        public void Update(GameTime gameTime)
        {
            foreach (cButton b in buttons)
            {
                b.Update();
                if (b.isClicked)
                    b.Effect();
            }
            LoadNpc();
            tilesetManager.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            foreach (cPanel p in panels)
            {
                p.Draw(spriteBatch);
            }
            foreach (cButton b in buttons)
            {
                b.Draw(spriteBatch);
            }
            tilesetManager.Draw(spriteBatch);
            spriteBatch.End();
        }
    }
}
