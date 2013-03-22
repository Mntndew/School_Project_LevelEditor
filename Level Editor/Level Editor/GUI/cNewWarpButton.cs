using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Level_Editor.GUI
{
    class cNewWarpButton : cButton
    {
        public cNewWarpButton(Texture2D texture, Vector2 position)
            : base(texture, position)
        {

        }
        public override void Effect()
        {
            Game1.state = State.PAUSE;
            Forms.NewWarp_Form newWarpForm = new Forms.NewWarp_Form();
            newWarpForm.ShowDialog();

            Game1.state = State.PLAY;
            base.Effect();
        }
    }
}
