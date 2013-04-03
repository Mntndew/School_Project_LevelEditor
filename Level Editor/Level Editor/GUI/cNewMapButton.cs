using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;
namespace Level_Editor.GUI
{
    class cNewMapButton : cButton
    {
        public cNewMapButton(Texture2D texture, Vector2 position)
            : base(texture, position)
        {

        }

        public override void Effect()
        {
            Game1.state = State.PAUSE;
            if (Game1.hud.tilesetManager.tileset_texture != null)
            {
                Forms.NewMap_Form newMap_form = new Forms.NewMap_Form();
                newMap_form.ShowDialog();

                if (newMap_form.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        Game1.mapController.mapWidth = newMap_form.mapWidth;
                        Game1.mapController.mapHeight = newMap_form.mapHeight;
                        Game1.mapController.map.tileWidth = Game1.hud.tilesetManager.tileWidth;
                        Game1.mapController.map.tileHeight = Game1.hud.tilesetManager.tileHeight;
                        Game1.mapController.NewMap(newMap_form.mapName);
                    }
                    catch
                    {
                        MessageBox.Show("Failed to create map for some retarded reason");
                    }
                }

                Game1.mapIsSaved = false;
            }
            else
                MessageBox.Show("Must load tileset first.");
            Game1.state = State.PLAY;
            base.Effect();
        }
    }
}
