using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace Level_Editor
{
    public class cNpc
    {
        public Texture2D texture;
        public Texture2D portrait;
        public Rectangle position;
        public string name;
        bool up, down, left, right;

        public cNpc(string name, int x, int y, int width, int height, bool up, bool down, bool left, bool right, string sprite, string portrait)
        {
            this.name = name;
            position = new Rectangle(x, y, width, height);
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            if (texture != null)
            {
                spriteBatch.Draw(texture, position, Color.White);
                spriteBatch.DrawString(game.font, "" + name, new Vector2(position.X, position.Y - 20), Color.Red);
            }
        }
    }
}