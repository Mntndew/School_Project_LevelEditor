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
    class cNewNpcButton : cButton
    {
        public cNewNpcButton(Texture2D texture, Vector2 position)
            : base(texture, position)
        {

        }
        public override void Effect()
        {
            Game1.state = State.PAUSE;
            Forms.NewNpc_Form newNpcForm = new Forms.NewNpc_Form();
            newNpcForm.ShowDialog();

            Game1.state = State.PLAY;
            Game1.hud.LoadNpc();
            base.Effect();
        }
    }
}