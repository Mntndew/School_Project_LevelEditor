using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Xml;
using System.Xml.Serialization;

namespace Level_Editor.GUI
{
    class cSaveMapButton : cButton
    {
        public cSaveMapButton(Texture2D texture, Vector2 position)
            : base(texture, position)
        {

        }

        public override void Effect()
        {
            Game1.state = State.PAUSE;
            Forms.SaveMap_Form saveMap_form = new Forms.SaveMap_Form();
            if (saveMap_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Game1.mapController.map.SaveMap(saveMap_form.filePath);
            }
            Game1.state = State.PLAY;
            base.Effect();
        }
    }
}