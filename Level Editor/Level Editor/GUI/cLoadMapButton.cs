using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;

namespace Level_Editor.GUI
{
    public class cLoadMapButton : cButton
    {
        public cLoadMapButton(Texture2D texture, Vector2 position)
            : base(texture, position)
        {
            
        }

        public override void Effect()
        {
            Game1.state = State.PAUSE;
            if (Game1.hud.tilesetManager.tileset_texture != null)
            {
                Forms.LoadMap_Form loadMap_Form = new Forms.LoadMap_Form();
                if (loadMap_Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Game1.mapController.map.LoadMap(loadMap_Form.filePath);
                }
                Game1.mapIsSaved = true;
            }
            else
                MessageBox.Show("Must load tileset first.");
            Game1.state = State.PLAY;
            base.Effect();
        }
    }
}
