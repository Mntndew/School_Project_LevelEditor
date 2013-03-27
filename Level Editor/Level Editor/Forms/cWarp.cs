using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.IO;

namespace Level_Editor.GUI
{
    public class cWarp
    {
        Rectangle position;
        Texture2D texture;
        int x, y;
        string targetName;
        public cWarp(int x, int y, int width, int height, string targetPath)
        {
            this.x = x;
            this.y = y;
            position = new Rectangle(x, y, width, height);
            StreamReader reader = new StreamReader(targetPath);
            targetName = reader.ReadLine();
            reader.Close();
        }

        public void Draw(SpriteBatch spriteBatch, Game1 game)
        {
            texture = game.Content.Load<Texture2D>(@"General\blank_square");
            spriteBatch.Draw(texture, position, new Color(200, 50, 150, 200));
            spriteBatch.DrawString(game.font, "" + targetName, new Vector2(x, y), Color.White);
        }
    }
}
