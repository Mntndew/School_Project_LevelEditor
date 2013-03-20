using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Level_Editor.GUI
{
    //For now just for visuals :P <3
    class cPanel
    {
        Rectangle position;
        Texture2D texture;

        public cPanel(Texture2D texture, Rectangle position)
        {
            this.position = position;
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
