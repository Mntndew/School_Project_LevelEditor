using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Level_Editor.Map
{
    public class cCell
    {
        public bool isPassable = true;
        public bool isDoor = false;
        public bool isSpawnable = false;
        public bool isEntity;
        public bool isTemp;
        public bool spawnNode;
        public bool isCharSpawn;
        public bool halfCol;
        public int TileID;
        public Rectangle textureRectangle;
        public Rectangle collisionRectangle;
        int tileWidth, tileHeight;
        int tilesetWidth;

        public cCell(int tileWidth, int tileHeight, int TileID, int tilesetWidth)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.TileID = TileID;
            this.tilesetWidth = tilesetWidth;
            SetTextureRectangle();
        }

        public void SetTextureRectangle()
        {
            int tileYPos = 0;
            int t = TileID;
            while (t > tilesetWidth-1)
            {
                t-=tilesetWidth;
                tileYPos++;
            }
            textureRectangle = new Rectangle(t * tileWidth, tileYPos * tileHeight, tileWidth, tileHeight); 
        }

        public int tileID
        {
            get { return TileID; }
            set 
            { 
                TileID = value;
                SetTextureRectangle(); 
            }
        }
    }
}
