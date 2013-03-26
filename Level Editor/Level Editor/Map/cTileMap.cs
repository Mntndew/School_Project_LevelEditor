using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace Level_Editor.Map
{
    public class cTileMap
    {
        public int tileWidth, tileHeight, mapWidth, mapHeight;
        //Different layers of the map, in the order that they are rendered
        public cCell[,] backgroundLayer;
        public cCell[,] interactiveLayer;
        public cCell[,] foregroundLayer;
        public cCell[,] entityLayer;
        public cCell[,] warpLayer;
        public cCell[,] tempVisualLayer;
        public cCell[,] tempInteractiveVisualLayer;
        public cCell[,] tempForegroundVisualLayer;
        public Texture2D tileset;

        public string mapName = null;
        public string filePath;
        //debugging variables
        //SpriteFont debugFont;
        
        public cTileMap(int mapWidth, int mapHeight)
        {
            NewMap(mapWidth, mapHeight, null, null);
            //debugFont = game.Content.Load<SpriteFont>("Honey Script");
        }

        public bool CheckCellPassable(Vector2 positionCheck)
        {
            int x = (int)positionCheck.X / tileWidth;
            int y = (int)positionCheck.Y / tileHeight;
            if (interactiveLayer[x, y].isPassable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Rectangle GetTileRectangleFromPosition(float x, float y)
        {
            x = (x / tileWidth);
            y = (y / tileHeight);
            return new Rectangle((int)x*tileWidth, (int)y*tileHeight, tileWidth, tileHeight);
        }

        public Rectangle GetTileRectangleFromIndex(int x, int y)
        {
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }

        public Point GetTileIndexFromPosition(int x, int y)
        {
            x = (x / tileWidth);
            y = (y / tileHeight);
            return new Point(x, y);
        }

        public void DrawBackgroundLayer(SpriteBatch spriteBatch, Rectangle viewPortRectangle, Vector2 offset)
        {
            Rectangle tileRect = new Rectangle((int)offset.X, (int)offset.Y, tileWidth, tileHeight);
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    if (Game1.mapController.selectedLayer == 1 || Game1.mapController.selectedLayer == 4)
                    {
                        spriteBatch.Draw(tileset, tileRect, backgroundLayer[x, y].textureRectangle, Color.White);
                    }
                    else
                    {
                        spriteBatch.Draw(tileset, tileRect, backgroundLayer[x, y].textureRectangle, new Color(50, 50, 50, 10));
                    }
                    tileRect.Y += tileHeight;
                }
                tileRect.X += tileWidth;
                tileRect.Y = (int)offset.Y;
            }
        }

        public void DrawInteractiveLayer(SpriteBatch spriteBatch, Rectangle viewPortRectangle, Vector2 offset)
        {
            Rectangle tileRect = new Rectangle((int)offset.X, (int)offset.Y, tileWidth, tileHeight);
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    if (Game1.mapController.selectedLayer == 2 || Game1.mapController.selectedLayer == 4)
                    {
                        spriteBatch.Draw(tileset, tileRect, interactiveLayer[x, y].textureRectangle, Color.White);
                    }
                    else
                    {
                        spriteBatch.Draw(tileset, tileRect, interactiveLayer[x, y].textureRectangle, new Color(50, 50, 50, 10));
                    }
                    tileRect.Y += tileHeight;
                }
                tileRect.X += tileWidth;
                tileRect.Y = (int)offset.Y;
            }
        }

        public void DrawForegroundLayer(SpriteBatch spriteBatch, Rectangle viewPortRectangle, Vector2 offset)//for pillar tops being drawn in front of other stuff
        {
            Rectangle tileRect = new Rectangle((int)offset.X, (int)offset.Y, tileWidth, tileHeight);
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    if (Game1.mapController.selectedLayer == 3 || Game1.mapController.selectedLayer == 4)
                    {
                        spriteBatch.Draw(tileset, tileRect, foregroundLayer[x, y].textureRectangle, Color.White);
                    }
                    else
                    {
                        spriteBatch.Draw(tileset, tileRect, foregroundLayer[x, y].textureRectangle, new Color(50, 50, 50, 10));
                    }
                    tileRect.Y += tileHeight;
                }
                tileRect.X += tileWidth;
                tileRect.Y = (int)offset.Y;
            }
        }

        public void DrawTempVisualLayer(SpriteBatch spriteBatch, Rectangle viewPortRectangle, Vector2 offset)//for pillar tops being drawn in front of other stuff
        {
            Rectangle tileRect = new Rectangle((int)offset.X, (int)offset.Y, tileWidth, tileHeight);
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    spriteBatch.Draw(tileset, tileRect, tempVisualLayer[x, y].textureRectangle, new Color(100, 100, 100, 100));
                    spriteBatch.Draw(tileset, tileRect, tempInteractiveVisualLayer[x, y].textureRectangle, new Color(100, 100, 100, 100));
                    spriteBatch.Draw(tileset, tileRect, tempForegroundVisualLayer[x, y].textureRectangle, new Color(100, 100, 100, 100));
                    tileRect.Y += tileHeight;
                }
                tileRect.X += tileWidth;
                tileRect.Y = (int)offset.Y;
            }
        }

        public void DrawAllLayers(SpriteBatch spriteBatch, Rectangle viewPortRectangle, Vector2 offset)
        {
            Rectangle tileRect = new Rectangle((int)offset.X, (int)offset.Y, tileWidth, tileHeight);
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    if (Game1.mapController.selectedLayer == 4 || Game1.mapController.selectedLayer == 5)
                    {
                        spriteBatch.Draw(tileset, tileRect, backgroundLayer[x, y].textureRectangle, Color.White);
                        spriteBatch.Draw(tileset, tileRect, interactiveLayer[x, y].textureRectangle, Color.White);
                        spriteBatch.Draw(tileset, tileRect, foregroundLayer[x, y].textureRectangle, Color.White);
                        spriteBatch.Draw(tileset, tileRect, entityLayer[x, y].textureRectangle, Color.White);
                        if (entityLayer[x, y].isEntity)
                        {
                            spriteBatch.Draw(Game1.mapController.entityTexture, tileRect, entityLayer[x, y].textureRectangle, Color.White);
                        }
                    }
                    tileRect.Y += tileHeight;
                }

                tileRect.X += tileWidth;
                tileRect.Y = (int)offset.Y;
            }
        }

        public void ClearMap()
        {
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    foregroundLayer[x, y].tileID = 0;
                    interactiveLayer[x, y].tileID = 0;
                    backgroundLayer[x, y].tileID = 0;
                    entityLayer[x, y].isEntity = false;
                    interactiveLayer[x,y].isPassable = false;
                }
            }
        }
        public void NewMap(int mapWidth, int mapHeight, Texture2D tileset, string mapName)
        {
            //set the dimensions
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.mapName = mapName;
            //Create the map
            foregroundLayer = new cCell[mapWidth, mapHeight];
            interactiveLayer = new cCell[mapWidth, mapHeight];
            backgroundLayer = new cCell[mapWidth, mapHeight];
            entityLayer = new cCell[mapWidth, mapHeight];
            tempVisualLayer = new cCell[mapWidth, mapHeight];
            tempInteractiveVisualLayer = new cCell[mapWidth, mapHeight];
            tempForegroundVisualLayer = new cCell[mapWidth, mapHeight];
            //fill the map with cells
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    backgroundLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                    interactiveLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                    foregroundLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                    entityLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                    tempVisualLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                    tempInteractiveVisualLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                    tempForegroundVisualLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                }
            }   
            this.tileset = tileset;
        }

        public void SaveMap(string filePath)
        {
            filePath = ((filePath.Remove(filePath.Length - 3)) + @"\");
            this.filePath = filePath;
            Directory.CreateDirectory(filePath);
            Directory.CreateDirectory(filePath + @"Map\");
            StreamWriter writer = new StreamWriter((filePath + @"Map\") + mapName + ".tm");
            writer.WriteLine(mapName);
            
            writer.WriteLine(mapWidth.ToString());
            writer.WriteLine(mapHeight.ToString());
            writer.WriteLine();

            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    writer.Write(backgroundLayer[j, i].tileID + ",");
                }
                writer.WriteLine();
            }
            writer.WriteLine();
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    writer.Write(interactiveLayer[j, i].tileID + ",");
                }
                writer.WriteLine();
            }
            writer.WriteLine();
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    writer.Write(foregroundLayer[j, i].tileID + ",");
                }
                writer.WriteLine();
            }
            writer.WriteLine();
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    writer.Write(entityLayer[j, i].tileID + ",");
                }
                writer.WriteLine();
            }

            writer.Close();
        }

        public void LoadMap(string filepath)
        {
            this.filePath = filepath;
            StreamReader reader = new StreamReader(filepath);
            //Read the global map data
            try
            {
                // get the tile dimensions from the tileset
                tileWidth = Game1.mapController.tileWidth;
                tileHeight = Game1.mapController.tileHeight;

                mapName = reader.ReadLine();
                //set the map dimensions
                mapWidth = int.Parse(reader.ReadLine());
                mapHeight = int.Parse(reader.ReadLine());
                Game1.mapController.SetEditableArea();
                Game1.mapController.mapWidth = mapWidth;
                Game1.mapController.mapHeight = mapHeight;
                reader.ReadLine();

                //create an empty map based on the data
                backgroundLayer = new cCell[mapWidth, mapHeight];
                interactiveLayer = new cCell[mapWidth, mapHeight];
                foregroundLayer = new cCell[mapWidth, mapHeight];
                entityLayer = new cCell[mapWidth, mapHeight];
                tempVisualLayer = new cCell[mapWidth, mapHeight];
                tempInteractiveVisualLayer = new cCell[mapWidth, mapHeight];
                tempForegroundVisualLayer = new cCell[mapWidth, mapHeight];
                
                for (int x = 0; x < mapWidth; x++)
                {
                    for (int y = 0; y < mapHeight; y++)
                    {
                        backgroundLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                        interactiveLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                        foregroundLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                        entityLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                        tempVisualLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                        tempInteractiveVisualLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                        tempForegroundVisualLayer[x, y] = new cCell(tileWidth, tileHeight, 0, Game1.hud.tilesetManager.tilesetWidth);
                    }
                }
                //fill the map with data from the 3 arrays in the map file
                for (int y = 0; y < mapHeight; y++)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    for (int i = 0; i < values.Length-1; i++)
                    {
                        backgroundLayer[i, y].tileID = int.Parse(values[i]);
                        Console.Write(values[i] + " .");
                    }
                }
                reader.ReadLine();
                for (int y = 0; y < mapHeight; y++)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        interactiveLayer[i, y].tileID = int.Parse(values[i]);
                        Console.Write(values[i] + " .");
                    }
                }
                reader.ReadLine();
                for (int y = 0; y < mapHeight; y++)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        foregroundLayer[i, y].tileID = int.Parse(values[i]);
                        Console.Write(values[i] + " .");
                    }
                }
                reader.ReadLine();
                for (int y = 0; y < mapHeight; y++)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    for (int i = 0; i < values.Length - 1; i++)
                    {
                        entityLayer[i, y].tileID = int.Parse(values[i]);
                        Console.Write(values[i] + " .");
                    }
                }
                reader.Close();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Failed to load map, possibly incorrect file format.");
                reader.Close();
            }
        }
    }
}