using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Level_Editor.Map
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class MapController
    {
        //class level variables
        SpriteBatch spriteBatch;

        public int mapWidth, mapHeight, tileWidth, tileHeight;

        public cTileMap map;

        MouseState mouseState;
        KeyboardState keyState;
        Point index = Point.Zero;
        Point end = Point.Zero;
        Rectangle mousePos;

        Vector2 viewOffset; //so the user can scroll around the map
        float scrollSpeed = 5;

        Rectangle editableArea;

        public Rectangle GetEditableArea
        {
            get { return editableArea; }
        }

        public Vector2 ViewOffset
        {
            get { return viewOffset; }
        }

        public Texture2D rectangle_texture;
        public Texture2D entityTexture;

        public int selectedLayer = 1;

        public MapController()
        {
            // TODO: Construct any child components here
            map = new cTileMap(mapWidth, mapHeight);
            spriteBatch = new SpriteBatch(Game1.graphics.GraphicsDevice);
            SetEditableArea();
            
        }
        
        public void Update(GameTime gameTime)
        {
            KeyboardState oldState = keyState;
            keyState = Keyboard.GetState();
            MouseState prevMouseState = mouseState;
            mouseState = Mouse.GetState();
            
            if (Game1.state == State.PLAY)
            {
                
                mousePos = new Rectangle(mouseState.X-(int)viewOffset.X, mouseState.Y-(int)viewOffset.Y, 1, 1);
                Rectangle origMousePos = new Rectangle(mouseState.X, mouseState.Y, 1, 1);


                //Check to update the selected layer
                if (keyState.IsKeyDown(Keys.D1) && oldState.IsKeyUp(Keys.D1))
                {
                    selectedLayer = 1;
                }
                if (keyState.IsKeyDown(Keys.D2) && oldState.IsKeyUp(Keys.D2))
                {
                    selectedLayer = 2;
                }
                if (keyState.IsKeyDown(Keys.D3) && oldState.IsKeyUp(Keys.D3))
                {
                    selectedLayer = 3;
                }
                if (keyState.IsKeyDown(Keys.D4) && oldState.IsKeyUp(Keys.D4))
                {
                    selectedLayer = 4;
                }
                if (keyState.IsKeyDown(Keys.D5) && oldState.IsKeyUp(Keys.D5))
                {
                    selectedLayer = 5;
                }

                #region normal construction
                if (Game1.hud.tilesetManager.currentConstructionType == GUI.cTilesetManager.constructionType.normal)
                {
                    if (mouseState.LeftButton == ButtonState.Pressed && origMousePos.Intersects(editableArea))
                    {
                        Point index = Point.Zero;
                        index.X = (int)(mousePos.X) / tileWidth;
                        index.Y = (int)(mousePos.Y) / tileHeight;
                        if (Game1.hud.tilesetManager.amount > 1)
                        {
                            for (int x = 0; x < Game1.hud.tilesetManager.widthTiles; x++)
                            {
                                for (int y = 0; y < Game1.hud.tilesetManager.heightTiles; y++)
                                {
                                    Game1.hud.tilesetManager.selectedTileValue = 0;

                                    if (Game1.hud.tilesetManager.tile.X < Game1.hud.tilesetManager.endTile.X || Game1.hud.tilesetManager.tile.X == Game1.hud.tilesetManager.endTile.X)
                                    {
                                        Game1.hud.tilesetManager.selectedTileValue += (Game1.hud.tilesetManager.tile.X + x);
                                    }
                                    else if (Game1.hud.tilesetManager.tile.X > Game1.hud.tilesetManager.endTile.X)
                                    {
                                        Game1.hud.tilesetManager.selectedTileValue += (Game1.hud.tilesetManager.endTile.X + x);
                                    }

                                    if (Game1.hud.tilesetManager.tile.Y < Game1.hud.tilesetManager.endTile.Y || Game1.hud.tilesetManager.tile.Y == Game1.hud.tilesetManager.endTile.Y)
                                    {
                                        Game1.hud.tilesetManager.selectedTileValue += (Game1.hud.tilesetManager.tile.Y + y) * Game1.hud.tilesetManager.tilesetWidth;
                                    }
                                    else if (Game1.hud.tilesetManager.tile.Y > Game1.hud.tilesetManager.endTile.Y)
                                    {
                                        Game1.hud.tilesetManager.selectedTileValue += (Game1.hud.tilesetManager.endTile.Y + y) * Game1.hud.tilesetManager.tilesetWidth;
                                    }
                                    if (selectedLayer == 1)
                                    {
                                        map.backgroundLayer[index.X + x, index.Y + y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                                    }
                                    if (selectedLayer == 3)
                                    {
                                        map.foregroundLayer[index.X + x, index.Y + y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                                    }
                                    if (selectedLayer == 2)
                                    {
                                        map.interactiveLayer[index.X + x, index.Y + y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                                    }
                                    if (selectedLayer == 4)
                                    {
                                        map.backgroundLayer[index.X + x, index.Y + y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                                        map.interactiveLayer[index.X + x, index.Y + y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                                        map.foregroundLayer[index.X + x, index.Y + y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (selectedLayer == 1)
                            {
                                map.backgroundLayer[index.X, index.Y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                            }
                            if (selectedLayer == 2)
                            {
                                map.interactiveLayer[index.X, index.Y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                            }
                            if (selectedLayer == 3)
                            {
                                map.foregroundLayer[index.X, index.Y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                            }
                            if (selectedLayer == 4)
                            {
                                map.backgroundLayer[index.X, index.Y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                                map.interactiveLayer[index.X, index.Y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                                map.foregroundLayer[index.X, index.Y].tileID = Game1.hud.tilesetManager.selectedTileValue;
                            }
                        }
                    }
                }
                #endregion

                #region room construction
                if (Game1.hud.tilesetManager.currentConstructionType == GUI.cTilesetManager.constructionType.room)
                {
                    bool leftToRight;
                    bool upToDown;
                    if (end.Y > index.Y)
                    {
                        upToDown = true;
                    }
                    else
                    {
                        upToDown = false;
                    }

                    if (end.X < index.X)
                    {
                        leftToRight = false;
                    }
                    else
                    {
                        leftToRight = true;
                    }

                    //ints for the tile values
                    int cornerUpLeft = 0, wallUp = 0, cornerUpRight = 0, wallLeft = 0, floor = 0, wallRight = 0, cornerDownLeft = 0, wallDown = 0, cornerDownRight = 0;
                    int wallUpFore = 0, wallDownFore = 0, cornerDownLeft2 = 0, cornerDownRight2 = 0;
                    #region set tile values
                    if (Game1.hud.tilesetManager.tile.X <  Game1.hud.tilesetManager.endTile.X)//left - right
                    {
                        if (Game1.hud.tilesetManager.tile.Y < Game1.hud.tilesetManager.endTile.Y)//up - down
                        {
                            cornerUpLeft = Game1.hud.tilesetManager.selectedTileValue + (Game1.hud.tilesetManager.tile.X / tileWidth);
                            wallUpFore = cornerUpLeft + 1;
                            cornerUpRight = wallUpFore + 1;
                            wallLeft = cornerUpLeft + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            wallUp = wallLeft + 1;
                            wallRight = wallUp + 1;
                            floor = wallUp + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            cornerDownLeft = floor + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth) - 1;
                            wallDownFore = cornerDownLeft + 1;
                            cornerDownRight = wallDownFore + 1;
                            cornerDownLeft2 = cornerDownLeft + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            wallDown = cornerDownLeft2 + 1;
                            cornerDownRight2 = wallDown + 1;
                        }
                        if (Game1.hud.tilesetManager.tile.Y > Game1.hud.tilesetManager.endTile.Y)//down - up
                        {
                            Game1.hud.tilesetManager.selectedTileValue = -2;
                            Game1.hud.tilesetManager.selectedTileValue += Game1.hud.tilesetManager.endTile.Y * Game1.hud.tilesetManager.tilesetWidth;
                            Game1.hud.tilesetManager.selectedTileValue += Game1.hud.tilesetManager.endTile.X;
                            cornerUpLeft = Game1.hud.tilesetManager.selectedTileValue;
                            wallUpFore = cornerUpLeft + 1;
                            cornerUpRight = wallUpFore + 1;
                            wallLeft = cornerUpLeft + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            wallUp = wallLeft + 1;
                            wallRight = wallUp + 1;
                            floor = wallUp + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            cornerDownLeft = floor + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth) - 1;
                            wallDownFore = cornerDownLeft + 1;
                            cornerDownRight = wallDownFore + 1;
                            cornerDownLeft2 = cornerDownLeft + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            wallDown = cornerDownLeft2 + 1;
                            cornerDownRight2 = wallDown + 1;
                        }
                    }
                    if (Game1.hud.tilesetManager.tile.X > Game1.hud.tilesetManager.endTile.X)//right - left
                    {
                        if (Game1.hud.tilesetManager.tile.Y > Game1.hud.tilesetManager.endTile.Y)//down - up
                        {
                            Game1.hud.tilesetManager.selectedTileValue = -2;
                            Game1.hud.tilesetManager.selectedTileValue += Game1.hud.tilesetManager.endTile.Y * Game1.hud.tilesetManager.tilesetWidth;
                            Game1.hud.tilesetManager.selectedTileValue += Game1.hud.tilesetManager.tile.X;
                            cornerUpLeft = Game1.hud.tilesetManager.selectedTileValue;
                            wallUpFore = cornerUpLeft + 1;
                            cornerUpRight = wallUpFore + 1;
                            wallLeft = cornerUpLeft + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            wallUp = wallLeft + 1;
                            wallRight = wallUp + 1;
                            floor = wallUp + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            cornerDownLeft = floor + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth) - 1;
                            wallDownFore = cornerDownLeft + 1;
                            cornerDownRight = wallDownFore + 1;
                            cornerDownLeft2 = cornerDownLeft + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            wallDown = cornerDownLeft2 + 1;
                            cornerDownRight2 = wallDown + 1;
                        }

                        if (Game1.hud.tilesetManager.tile.Y < Game1.hud.tilesetManager.endTile.Y)//up - down
                        {
                            Game1.hud.tilesetManager.selectedTileValue = -2;
                            Game1.hud.tilesetManager.selectedTileValue += Game1.hud.tilesetManager.tile.Y * Game1.hud.tilesetManager.tilesetWidth;
                            Game1.hud.tilesetManager.selectedTileValue += Game1.hud.tilesetManager.tile.X;
                            cornerUpLeft = Game1.hud.tilesetManager.selectedTileValue;
                            wallUpFore = cornerUpLeft + 1;
                            cornerUpRight = wallUpFore + 1;
                            wallLeft = cornerUpLeft + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            wallUp = wallLeft + 1;
                            wallRight = wallUp + 1;
                            floor = wallUp + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            cornerDownLeft = floor + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth) - 1;
                            wallDownFore = cornerDownLeft + 1;
                            cornerDownRight = wallDownFore + 1;
                            cornerDownLeft2 = cornerDownLeft + (Game1.hud.tilesetManager.tileset_texture.Width / tileWidth);
                            wallDown = cornerDownLeft2 + 1;
                            cornerDownRight2 = wallDown + 1;
                        }
                    }
                    #endregion

                    if (mouseState.LeftButton == ButtonState.Pressed && prevMouseState.LeftButton == ButtonState.Released)
                    {
                        index.X = ((mousePos.X / tileWidth));
                        index.Y = ((mousePos.Y / tileHeight));
                    }
                    if (mouseState.LeftButton == ButtonState.Pressed && origMousePos.Intersects(editableArea))
                    {
                        end.X = ((mousePos.X / tileWidth));
                        end.Y = ((mousePos.Y / tileHeight));

                        if (end.Y > index.Y)
                        {
                            upToDown = true;
                        }
                        else
                        {
                            upToDown = false;
                        }
                        if (end.X < index.X)
                        {
                            leftToRight = false;
                        }
                        else
                        {
                            leftToRight = true;
                        }

                        for (int x = 0; x < mapWidth; x++)
                        {
                            for (int y = 0; y < mapHeight; y++)
                            {
                                map.tempVisualLayer[x, y].isTemp = false;
                                map.tempInteractiveVisualLayer[x, y].isTemp = false;
                                map.tempForegroundVisualLayer[x, y].isTemp = false;
                            }
                        }

                        #region left - right
                        if (leftToRight)
                        {
                            for (int x = index.X; x < end.X + 1; x++)
                            {
                                if (upToDown)
                                {
                                    for (int y = index.Y; y < end.Y + 2; y++)
                                    {
                                        map.tempInteractiveVisualLayer[x, y].isTemp = true;
                                        map.tempForegroundVisualLayer[x, y].isTemp = true;
                                    }
                                }
                                else
                                {
                                    for (int y = end.Y; y < index.Y + 1; y++)
                                    {
                                        map.tempInteractiveVisualLayer[x, y].isTemp = true;
                                        map.tempForegroundVisualLayer[x, y].isTemp = true;
                                    }
                                }
                            }
                            for (int x = index.X + 1; x < end.X; x++)
                            {
                                if (upToDown)
                                {
                                    for (int y = index.Y + 1; y < end.Y; y++)
                                    {
                                        map.tempVisualLayer[x, y].isTemp = true;
                                    }
                                }
                                else
                                {
                                    for (int y = end.Y + 1; y < index.Y; y++)
                                    {
                                        map.tempVisualLayer[x, y].isTemp = true;
                                    }
                                }
                            }
                            for (int x = index.X; x < mapWidth; x++)
                            {
                                if (upToDown)
                                {
                                    for (int y = index.Y; y < mapHeight; y++)
                                    {
                                        if (map.tempVisualLayer[x, y].isTemp)
                                        {
                                            map.tempVisualLayer[x, y].tileID = floor;
                                        }
                                        else
                                        {
                                            map.tempVisualLayer[x, y].tileID = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int y = end.Y; y < mapHeight; y++)
                                    {
                                        if (map.tempVisualLayer[x, y].isTemp)
                                        {
                                            map.tempVisualLayer[x, y].tileID = floor;
                                        }
                                        else
                                        {
                                            map.tempVisualLayer[x, y].tileID = 0;
                                        }
                                    }
                                }
                            }
                        }
                        #endregion

                        #region right - left
                        if (!leftToRight)
                        {
                            for (int x = end.X; x < index.X + 1; x++)
                            {
                                if (!upToDown)
                                {
                                    for (int y = end.Y; y < index.Y + 1; y++)
                                    {
                                        map.tempInteractiveVisualLayer[x, y].isTemp = true;
                                    }
                                }
                                else
                                {
                                    for (int y = index.Y; y < end.Y + 1; y++)
                                    {
                                        map.tempInteractiveVisualLayer[x, y].isTemp = true;
                                    }
                                }
                            }
                            for (int x = end.X + 1; x < index.X; x++)
                            {
                                if (!upToDown)
                                {
                                    for (int y = end.Y + 1; y < index.Y; y++)
                                    {
                                        map.tempVisualLayer[x, y].isTemp = true;
                                    }
                                }
                                else
                                {
                                    for (int y = index.Y + 1; y < end.Y; y++)
                                    {
                                        map.tempVisualLayer[x, y].isTemp = true;
                                    }
                                }
                            }
                            for (int x = 0; x < mapWidth; x++)
                            {
                                for (int y = 0; y < mapHeight; y++)
                                {
                                    if (map.tempVisualLayer[x, y].isTemp)
                                    {
                                        map.tempVisualLayer[x, y].tileID = floor;
                                    }
                                    else
                                    {
                                        map.tempVisualLayer[x, y].tileID = 0;
                                    }
                                }
                            }
                        }
                        #endregion

                        #region adds tiles to temp layers
                        for (int x = 0; x < mapWidth; x++)
                        {
                            for (int y = 0; y < mapHeight; y++)
                            {
                                if (map.tempInteractiveVisualLayer[x, y].isTemp && map.tempVisualLayer[x, y].tileID == 0)
                                {
                                    if (leftToRight)
                                    {
                                        #region leftToRight, upToDown
                                        if (upToDown)
                                        {
                                            map.tempForegroundVisualLayer[x, index.Y].tileID = wallUpFore;
                                            map.tempInteractiveVisualLayer[x, index.Y + 1].tileID = wallUp;
                                            if (map.tempInteractiveVisualLayer[end.X, index.Y + 1].tileID == wallUp)
                                            {
                                                map.tempInteractiveVisualLayer[end.X, index.Y + 1].tileID = 0;
                                            }
                                            map.tempInteractiveVisualLayer[index.X, index.Y + 1].tileID = 0;
                                            map.tempForegroundVisualLayer[index.X, index.Y].tileID = cornerUpLeft;
                                            map.tempForegroundVisualLayer[end.X, index.Y].tileID = cornerUpRight;
                                            if (map.tempForegroundVisualLayer[x, y].tileID == 0)
                                            {
                                                map.tempInteractiveVisualLayer[end.X, index.Y + 1].tileID = wallRight;
                                                map.tempInteractiveVisualLayer[end.X, y].tileID = wallRight;
                                                map.tempInteractiveVisualLayer[end.X, end.Y].tileID = cornerDownRight;

                                                map.tempInteractiveVisualLayer[index.X, index.Y + 1].tileID = wallLeft;
                                                map.tempInteractiveVisualLayer[index.X, y].tileID = wallLeft;
                                                map.tempInteractiveVisualLayer[index.X, end.Y].tileID = cornerDownLeft;

                                                for (int xx = 0; xx < mapWidth; xx++)
                                                {
                                                    for (int yy = 0; yy < mapHeight; yy++)
                                                    {
                                                        if (map.tempInteractiveVisualLayer[xx, yy].tileID == cornerDownLeft)
                                                        {
                                                            map.tempInteractiveVisualLayer[xx, yy + 1].tileID = cornerDownLeft2;
                                                        }
                                                        if (map.tempInteractiveVisualLayer[xx, yy].tileID == cornerDownRight)
                                                        {
                                                            map.tempInteractiveVisualLayer[xx, yy + 1].tileID = cornerDownRight2;
                                                        }
                                                    }
                                                }
                                            }
                                            map.tempForegroundVisualLayer[x, end.Y].tileID = wallDownFore;
                                            if (map.tempForegroundVisualLayer[index.X, end.Y].tileID == wallDownFore)
                                            {
                                                map.tempForegroundVisualLayer[index.X, end.Y].tileID = 0;
                                                map.tempInteractiveVisualLayer[index.X, index.Y].tileID = 0;
                                            }
                                            if (map.tempForegroundVisualLayer[end.X, end.Y].tileID == wallDownFore)
                                            {
                                                map.tempForegroundVisualLayer[end.X, end.Y].tileID = 0;
                                                map.tempInteractiveVisualLayer[index.X, index.Y].tileID = 0;
                                            }

                                            for (int xx = 0; xx < mapWidth; xx++)
                                            {
                                                for (int yy = 0; yy < mapHeight; yy++)
                                                {
                                                    if (map.tempForegroundVisualLayer[xx, yy].tileID == wallDownFore)
                                                    {
                                                        map.tempInteractiveVisualLayer[xx, yy].tileID = 0;
                                                        map.tempInteractiveVisualLayer[xx, yy + 1].tileID = wallDown;
                                                    }
                                                }
                                            }
                                        }
                                        #endregion

                                        #region leftToRight, !upToDown
                                        if (!upToDown)
                                        {
                                            map.tempForegroundVisualLayer[x, end.Y].tileID = wallUpFore;
                                            map.tempInteractiveVisualLayer[end.X, y].tileID = wallRight;
                                            map.tempInteractiveVisualLayer[end.X, end.Y].tileID = 0;
                                            map.tempInteractiveVisualLayer[x, index.Y].tileID = 0;
                                            map.tempInteractiveVisualLayer[x, end.Y].tileID = 0;
                                            map.tempInteractiveVisualLayer[end.X, index.Y].tileID = wallRight;

                                            map.tempInteractiveVisualLayer[index.X, y].tileID = wallLeft;
                                            map.tempInteractiveVisualLayer[index.X, end.Y].tileID = 0;

                                            if (map.tempInteractiveVisualLayer[x, y].tileID == 0)
                                            {
                                                map.tempInteractiveVisualLayer[x, end.Y + 1].tileID = wallUp;
                                            }
                                            
                                            if (map.tempInteractiveVisualLayer[end.X, end.Y + 1].tileID == wallUp || map.tempInteractiveVisualLayer[index.X, y].tileID == wallUp)
                                            {
                                                map.tempInteractiveVisualLayer[x, y].tileID = 0;
                                            }
                                            if (map.tempForegroundVisualLayer[index.X, y].tileID == wallUpFore)
                                            {
                                                map.tempForegroundVisualLayer[x, y].tileID = 0;
                                            }
                                            map.tempForegroundVisualLayer[end.X, end.Y].tileID = cornerUpRight;
                                            if (map.tempForegroundVisualLayer[x, y].tileID == cornerUpRight)
                                            {
                                                if (map.tempForegroundVisualLayer[x, y].tileID != wallUpFore)
                                                {
                                                    map.tempForegroundVisualLayer[x , y].tileID = 0;
                                                }
                                            }
                                            map.tempForegroundVisualLayer[index.X, end.Y].tileID = cornerUpLeft;
                                            if (map.tempForegroundVisualLayer[x, y].tileID == cornerUpLeft)
                                            {
                                                if (map.tempForegroundVisualLayer[x + 1, y].tileID != wallUpFore)
                                                {
                                                    map.tempForegroundVisualLayer[x, y].tileID = 0;
                                                }
                                            }
                                            map.tempForegroundVisualLayer[x, index.Y].tileID = wallDownFore;
                                            map.tempInteractiveVisualLayer[end.X, index.Y].tileID = cornerDownRight;
                                            map.tempForegroundVisualLayer[end.X, index.Y].tileID = 0;
                                            map.tempInteractiveVisualLayer[index.X, index.Y].tileID = cornerDownLeft;
                                            map.tempForegroundVisualLayer[index.X, index.Y].tileID = 0;
                                            map.tempInteractiveVisualLayer[index.X, index.Y + 1].tileID = cornerDownLeft2;
                                            map.tempInteractiveVisualLayer[end.X, index.Y + 1].isTemp = true;
                                            map.tempInteractiveVisualLayer[end.X, index.Y + 1].tileID = cornerDownRight2;
                                            if (map.tempForegroundVisualLayer[x, y].tileID == wallDownFore)
                                            {
                                                map.tempInteractiveVisualLayer[x, y + 1].isTemp = true;
                                                map.tempInteractiveVisualLayer[x, y + 1].tileID = wallDown;
                                            }
                                        }
                                        #endregion
                                    }

                                    if (!leftToRight)
                                    {
                                        #region !leftToRight, upToDown
                                        if (upToDown)
                                        {
                                            map.tempForegroundVisualLayer[x, index.Y].tileID = wallUpFore;
                                            if (map.tempForegroundVisualLayer[x, y].tileID == wallUpFore)
                                            {
                                                map.tempVisualLayer[x, y + 1].tileID = 0;
                                                map.tempInteractiveVisualLayer[x, y + 1].tileID = wallUp;
                                            }
                                            map.tempForegroundVisualLayer[index.X, index.Y].tileID = cornerUpRight;
                                            map.tempForegroundVisualLayer[end.X, index.Y].tileID = cornerUpLeft;
                                            map.tempInteractiveVisualLayer[index.X, y].tileID = wallRight;
                                            map.tempInteractiveVisualLayer[end.X, y].tileID = wallLeft;
                                            map.tempInteractiveVisualLayer[end.X, end.Y + 1].tileID = cornerDownLeft2;
                                            map.tempInteractiveVisualLayer[x, index.Y].tileID = 0;
                                            map.tempInteractiveVisualLayer[end.X, index.Y].tileID = 0;
                                            map.tempInteractiveVisualLayer[end.X, end.Y].tileID = cornerDownLeft;
                                            map.tempInteractiveVisualLayer[index.X, end.Y].tileID = cornerDownRight;
                                            map.tempForegroundVisualLayer[x, end.Y].isTemp = true;
                                            map.tempForegroundVisualLayer[x, end.Y].tileID = wallDownFore;
                                            map.tempForegroundVisualLayer[index.X, end.Y].tileID = 0;
                                            map.tempForegroundVisualLayer[end.X, end.Y].tileID = 0;
                                            if (map.tempForegroundVisualLayer[x, y].tileID == wallDownFore)
                                            {
                                                map.tempInteractiveVisualLayer[x, y + 1].isTemp = true;
                                                map.tempInteractiveVisualLayer[x, y + 1].tileID = wallDown;
                                            }
                                            map.tempInteractiveVisualLayer[index.X, end.Y + 1].isTemp = true;
                                            map.tempInteractiveVisualLayer[index.X, end.Y + 1].tileID = cornerDownRight2;
                                        }
                                        #endregion
                                        #region !leftToRight, !upToDown
                                        if (!upToDown)
                                        {

                                        }
                                        #endregion
                                    }
                                    if (map.tempForegroundVisualLayer[x, y].tileID == wallDownFore)
                                    {
                                        map.tempVisualLayer[x, y].isTemp = true;
                                        map.tempVisualLayer[x, y].tileID = floor;
                                    }
                                    if (map.tempInteractiveVisualLayer[x, y].tileID != 0)
                                    {
                                        map.tempVisualLayer[x, y].isTemp = false;
                                    }
                                }
                                else
                                {
                                    map.tempInteractiveVisualLayer[x, y].tileID = 0;
                                }
                                if (!map.tempForegroundVisualLayer[x, y].isTemp || map.tempVisualLayer[x, y].tileID != 0)
                                {
                                    map.tempForegroundVisualLayer[x, y].tileID = 0;
                                }
                            }
                        }
                        #endregion
                    }

                    if (mouseState.LeftButton == ButtonState.Released || keyState.IsKeyUp(Keys.LeftShift))
                    {
                        if (leftToRight)
                        {
                            for (int x = index.X; x < mapWidth; x++)
                            {
                                if (upToDown)
                                {
                                    for (int y = index.Y; y < mapHeight; y++)
                                    {
                                        if (map.tempVisualLayer[x, y].tileID != 0)
                                        {
                                            map.backgroundLayer[x, y].tileID = map.tempVisualLayer[x, y].tileID;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int y = end.Y; y < mapHeight; y++)
                                    {
                                        if (map.tempVisualLayer[x, y].tileID != 0)
                                        {
                                            map.backgroundLayer[x, y].tileID = map.tempVisualLayer[x, y].tileID;
                                        }
                                    }
                                }
                            }

                            for (int x = 0; x < mapWidth; x++)
                            {
                                for (int y = 0; y < mapHeight; y++)
                                {
                                    if (map.tempInteractiveVisualLayer[x, y].tileID != 0)
                                    {
                                        map.interactiveLayer[x, y].tileID = map.tempInteractiveVisualLayer[x, y].tileID;
                                    }
                                    if (map.tempForegroundVisualLayer[x, y].tileID != 0)
                                    {
                                        map.foregroundLayer[x, y].tileID = map.tempForegroundVisualLayer[x, y].tileID;
                                    }
                                }
                            }
                        }
                        if (!leftToRight)
                        {
                            for (int x = end.X; x < mapWidth; x++)
                            {
                                if (!upToDown)
                                {
                                    for (int y = end.Y; y < mapHeight; y++)
                                    {
                                        if (map.tempVisualLayer[x, y].tileID != 0)
                                        {
                                            map.backgroundLayer[x, y].tileID = map.tempVisualLayer[x, y].tileID;
                                        }
                                    }
                                }
                                if (upToDown)
                                {
                                    for (int y = index.Y; y < mapHeight; y++)
                                    {
                                        if (map.tempVisualLayer[x, y].tileID != 0)
                                        {
                                            map.backgroundLayer[x, y].tileID = map.tempVisualLayer[x, y].tileID;
                                        }
                                    }
                                }
                            }

                            for (int x = 0; x < mapWidth; x++)
                            {
                                for (int y = 0; y < mapHeight; y++)
                                {
                                    if (map.tempInteractiveVisualLayer[x, y].tileID != 0)
                                    {
                                        map.interactiveLayer[x, y].tileID = map.tempInteractiveVisualLayer[x, y].tileID;
                                    }
                                    if (map.tempForegroundVisualLayer[x, y].tileID != 0)
                                    {
                                        map.foregroundLayer[x, y].tileID = map.tempForegroundVisualLayer[x, y].tileID;
                                    }
                                }
                            }
                        }

                        for (int x = 0; x < mapWidth; x++)
                        {
                            for (int y = 0; y < mapHeight; y++)
                            {
                                map.tempVisualLayer[x, y].tileID = 0;
                                map.tempInteractiveVisualLayer[x, y].tileID = 0;
                                map.tempForegroundVisualLayer[x, y].tileID = 0;
                            }
                        }
                    }
                }
                #endregion
                
                #region remove tiles
                if (mouseState.RightButton == ButtonState.Pressed && origMousePos.Intersects(editableArea))
                {
                    Point index = Point.Zero;
                    index.X = (int)(mousePos.X) / tileWidth;
                    index.Y = (int)(mousePos.Y) / tileHeight;

                    if (Game1.hud.tilesetManager.amount > 1)
                    {
                        for (int x = 0; x < Game1.hud.tilesetManager.widthTiles; x++)
                        {
                            for (int y = 0; y < Game1.hud.tilesetManager.heightTiles; y++)
                            {
                                if (selectedLayer == 1)
                                {
                                    map.backgroundLayer[index.X + x, index.Y + y].tileID = 0;
                                    map.backgroundLayer[index.X + x, index.Y + y].SetTextureRectangle();
                                }
                                else if (selectedLayer == 2)
                                {
                                    map.interactiveLayer[index.X + x, index.Y + y].tileID = 0;
                                    map.interactiveLayer[index.X + x, index.Y + y].SetTextureRectangle();
                                }
                                else if (selectedLayer == 3)
                                {
                                    map.foregroundLayer[index.X + x, index.Y + y].tileID = 0;
                                    map.foregroundLayer[index.X + x, index.Y + y].SetTextureRectangle();
                                }
                                else if (selectedLayer == 4)
                                {
                                    map.backgroundLayer[index.X + x, index.Y + y].tileID = 0;
                                    map.backgroundLayer[index.X + x, index.Y + y].SetTextureRectangle();
                                    map.interactiveLayer[index.X + x, index.Y + y].tileID = 0;
                                    map.interactiveLayer[index.X + x, index.Y + y].SetTextureRectangle();
                                    map.foregroundLayer[index.X + x, index.Y + y].tileID = 0;
                                    map.foregroundLayer[index.X + x, index.Y + y].SetTextureRectangle();
                                }
                            }
                        }
                    }
                    else
                    {
                        if (selectedLayer == 1)
                        {
                            map.backgroundLayer[index.X, index.Y].tileID = 0;
                            map.backgroundLayer[index.X, index.Y].SetTextureRectangle();
                        }
                        else if (selectedLayer == 2)
                        {
                            map.interactiveLayer[index.X, index.Y].tileID = 0;
                            map.interactiveLayer[index.X, index.Y].SetTextureRectangle();
                        }
                        else if (selectedLayer == 3)
                        {
                            map.foregroundLayer[index.X, index.Y].tileID = 0;
                            map.foregroundLayer[index.X, index.Y].SetTextureRectangle();
                        }
                        else if (selectedLayer == 4)
                        {
                            map.backgroundLayer[index.X, index.Y].tileID = 0;
                            map.backgroundLayer[index.X, index.Y].SetTextureRectangle();
                            map.interactiveLayer[index.X, index.Y].tileID = 0;
                            map.interactiveLayer[index.X, index.Y].SetTextureRectangle();
                            map.foregroundLayer[index.X, index.Y].tileID = 0;
                            map.foregroundLayer[index.X, index.Y].SetTextureRectangle();
                        }
                    }
                }
                #endregion
                
                #region scrolling around map
                if (keyState.IsKeyDown(Keys.A))
                    viewOffset.X += scrollSpeed;
                if (keyState.IsKeyDown(Keys.D))
                    viewOffset.X -= scrollSpeed;
                if (keyState.IsKeyDown(Keys.W))
                    viewOffset.Y += scrollSpeed;
                if (keyState.IsKeyDown(Keys.S))
                    viewOffset.Y -= scrollSpeed;

                viewOffset = Vector2.Clamp(viewOffset, new Vector2(-(mapWidth * tileWidth) + editableArea.Width, -(mapHeight * tileHeight) + editableArea.Height), new Vector2(1, 1));
                #endregion
            }

            //remove npc
            if (keyState.IsKeyDown(Keys.LeftAlt))
            {
                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    if (prevMouseState.LeftButton == ButtonState.Released)
                    {
                        Game1.state = State.PAUSE;
                        for (int i = 0; i < Game1.hud.npcs.Count; i++)
                        {
                            if (mousePos.Intersects(Game1.hud.npcs[i].position))
                            {
                                string name = Game1.hud.npcs[i].name;
                                Game1.hud.npcs.Remove(Game1.hud.npcs[i]);
                                MntnNpc.Npc.RemoveNpc(name);
                                i--;
                            }
                        }
                    }
                }
                    Game1.state = State.PLAY;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (map.tileset != null)
            {
                spriteBatch.Begin();
                map.DrawBackgroundLayer(spriteBatch, editableArea, viewOffset);
                map.DrawInteractiveLayer(spriteBatch, editableArea, viewOffset);
                map.DrawForegroundLayer(spriteBatch, editableArea, viewOffset);
                map.DrawTempVisualLayer(spriteBatch, editableArea, viewOffset);
                spriteBatch.End();
            }
        }

        public void NewMap(string mapName)
        {
            map.NewMap(mapWidth, mapHeight, Game1.hud.tilesetManager.tileset_texture, mapName);
            SetEditableArea();
        }

        public void SetEditableArea()
        {
            editableArea = new Rectangle(0, 0, map.mapWidth * tileWidth, map.mapHeight * tileHeight);
            if (editableArea.Width > 880)
                editableArea.Width = 880;
            if (editableArea.Height > 720)
                editableArea.Height = 720;
        }
    }
}
