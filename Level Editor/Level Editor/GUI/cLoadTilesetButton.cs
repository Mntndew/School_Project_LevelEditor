using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;
using System.IO;

namespace Level_Editor.GUI
{
    public class cLoadTilesetButton : cButton
    {
        public Texture2D tilesetTexture;
        
        public cLoadTilesetButton(Texture2D texture, Vector2 position)
            : base(texture, position)
        {
            
        }

        public override void Effect()
        {
            Game1.state = State.PAUSE;
            Forms.LoadTileset_Form loadTilesetForm = new Forms.LoadTileset_Form();
            loadTilesetForm.ShowDialog();
            if (loadTilesetForm.DialogResult == DialogResult.OK)
            {
                try
                {
                    Texture2D texture;
                    FileStream stream = new FileStream(loadTilesetForm.filePath, FileMode.Open, FileAccess.Read);

                    texture = Texture2D.FromStream(Game1.graphics.GraphicsDevice, stream);
                    stream.Close();
                    Game1.hud.tilesetManager.SetTilesetTexture(texture, loadTilesetForm.tileWidth, loadTilesetForm.tileHeight);
                    Game1.mapController.tileWidth = loadTilesetForm.tileWidth;
                    Game1.mapController.tileHeight = loadTilesetForm.tileHeight;
                    Game1.mapController.map.tileset = texture;
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Error loading texture.");
                    Game1.hud.tilesetManager.tileset_texture = null;
                }
            }

            Game1.state = State.PLAY;

            base.Effect();
        }
    }
}
