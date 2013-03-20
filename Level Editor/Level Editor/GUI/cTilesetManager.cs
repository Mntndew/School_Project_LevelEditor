using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Level_Editor.GUI
{
    public class cTilesetManager
    {
        public Texture2D tileset_texture = null;

        Rectangle selectedTileRectangle; //Rectangle to show the selected tile
        public int selectedTileValue = 0; //value of the selected tile...
        Texture2D selectedTile_texture;
        Rectangle selectedTileRectangleDisplay;
        Rectangle endSelectedTileRectangle;
        Rectangle endSelectedTileRectangleDisplay;
        Color selectionColor = new Color();
        public enum constructionType
        {
            normal,
            room,
            entity
        }
        public constructionType currentConstructionType = constructionType.normal;
        public int widthTiles, heightTiles;
        public int width = 0, height = 0;
        public int amount;
        public Point tile = Point.Zero;
        public Point endTile = Point.Zero;
        public Rectangle entireSelection;
        Rectangle positionRectangle;
        Rectangle sourceRectangle;
        Vector2 position;
        Vector2 offset = Vector2.Zero;
        KeyboardState keyState;

        int viewWidth, viewHeight;

        public int tileWidth, tileHeight, tilesetWidth, tilesetHeight;

        MouseState mouseState;

        public cTilesetManager(Vector2 position)
        {
            this.position = position;
            viewWidth = 336;
            viewHeight = 484;
            positionRectangle = new Rectangle((int)position.X, (int)position.Y, viewWidth, viewHeight);
        }

        public void SetTilesetTexture(Texture2D tileset, int tileWidth, int tileHeight)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            tileset_texture = tileset;
            tilesetWidth = tileset_texture.Width / tileWidth;
            tilesetHeight = tileset_texture.Height / tileHeight;
            Game1.mapController.map.tileset = tileset;
            Console.WriteLine(tilesetWidth);

            if (tileset_texture.Width > viewWidth && tileset_texture.Height > viewHeight)
            {
                sourceRectangle = new Rectangle(0, 0, viewWidth, viewHeight);
            }
            else if (tileset_texture.Width > viewWidth)
            {
                sourceRectangle = new Rectangle(0, 0, viewWidth, tileset_texture.Height);
            }
            else if (tileset_texture.Height > viewHeight)
            {
                sourceRectangle = new Rectangle(0, 0, tileset_texture.Width, viewHeight);
            }
            else
            {
                sourceRectangle = new Rectangle(0, 0, tileset_texture.Width, tileset_texture.Height);
            }
            positionRectangle.Width = sourceRectangle.Width;
            positionRectangle.Height = sourceRectangle.Height;

            endSelectedTileRectangle = new Rectangle((int)position.X, (int)position.Y, tileWidth, tileHeight);
            selectedTileRectangleDisplay = new Rectangle((int)position.X, (int)position.Y, tileWidth, tileHeight);
            selectedTileRectangle = new Rectangle((int)position.X, (int)position.Y, tileWidth, tileHeight);
            selectedTileRectangleDisplay = new Rectangle((int)position.X, (int)position.Y, tileWidth, tileHeight);
            selectedTileValue = 0;
        }

        public void LoadExtraTextures(ContentManager Content)
        {
            selectedTile_texture = Content.Load<Texture2D>(@"General\blank_square");
        }

        public void Update(GameTime gameTime)
        {
            if (tileset_texture != null)
            {
                KeyboardState oldState = keyState;
                keyState = Keyboard.GetState();
                MouseState prevMouseState = mouseState;
                mouseState = Mouse.GetState();

                if (keyState.IsKeyDown(Keys.T) && oldState.IsKeyUp(Keys.T))
                {
                    currentConstructionType = constructionType.entity;
                }
                if (keyState.IsKeyDown(Keys.Up) && sourceRectangle.Y > 0)
                    offset.Y -= 5;
                if (keyState.IsKeyDown(Keys.Down) && sourceRectangle.Bottom < tileset_texture.Height)
                    offset.Y += 5;
                if (keyState.IsKeyDown(Keys.Left) && sourceRectangle.X > 0)
                    offset.X -= 5;
                if (keyState.IsKeyDown(Keys.Right) && sourceRectangle.Right < tileset_texture.Width)
                    offset.X += 5;

                if (mouseState.ScrollWheelValue > prevMouseState.ScrollWheelValue && sourceRectangle.Y > 0)
                    offset.Y -= 5;
                if (mouseState.ScrollWheelValue < prevMouseState.ScrollWheelValue && sourceRectangle.Bottom < tileset_texture.Height)
                    offset.Y += 5;

                sourceRectangle.X = (int)offset.X;
                sourceRectangle.Y = (int)offset.Y;

                Rectangle mouseRect = new Rectangle(mouseState.X, mouseState.Y, 1, 1);
                amount = (width * height) / (tileWidth * tileHeight);

                #region selection
                if (mouseState.LeftButton == ButtonState.Pressed && mouseRect.Intersects(positionRectangle))
                {
                    if (prevMouseState.LeftButton == ButtonState.Released)
                    {
                        tile.Y = ((mouseRect.Y - positionRectangle.Y + (int)offset.Y) / tileHeight);
                        tile.X = ((mouseRect.X - positionRectangle.X + (int)offset.X) / tileWidth);

                        selectedTileValue = 0;
                        selectedTileValue += tile.Y * tilesetWidth;
                        selectedTileValue += tile.X;

                        selectedTileRectangle.X = tile.X * tileWidth + positionRectangle.X;
                        selectedTileRectangle.Y = tile.Y * tileHeight + positionRectangle.Y;
                    }
                    endTile.Y = ((mouseRect.Y - positionRectangle.Y + (int)offset.Y) / tileHeight);
                    endTile.X = ((mouseRect.X - positionRectangle.X + (int)offset.X) / tileWidth);
                    endSelectedTileRectangle.X = (endTile.X * tileWidth + positionRectangle.X);
                    endSelectedTileRectangle.Y = (endTile.Y * tileHeight + positionRectangle.Y);
                }

                selectedTileRectangle.Width = tileWidth;
                selectedTileRectangle.Height = tileHeight;
                selectedTileRectangleDisplay.X = selectedTileRectangle.X - (int)offset.X;
                selectedTileRectangleDisplay.Y = selectedTileRectangle.Y - (int)offset.Y;
                selectedTileRectangleDisplay.Width = tileWidth;
                selectedTileRectangleDisplay.Height = tileHeight;

                endSelectedTileRectangle.Width = tileWidth;
                endSelectedTileRectangle.Height = tileHeight;
                endSelectedTileRectangleDisplay.X = endSelectedTileRectangle.X + (int)offset.X;
                endSelectedTileRectangleDisplay.Y = endSelectedTileRectangle.Y + (int)offset.Y;
                endSelectedTileRectangleDisplay.Width = tileWidth;
                endSelectedTileRectangleDisplay.Height = tileHeight;

                width = endSelectedTileRectangle.X - selectedTileRectangle.X;
                height = endSelectedTileRectangle.Y - selectedTileRectangle.Y;
                int X = selectedTileRectangle.X, Y = selectedTileRectangle.Y;
                #region box
                if (selectedTileRectangle.Y < endSelectedTileRectangle.Y)
                {
                    height += tileHeight;
                    if (selectedTileRectangle.X > endSelectedTileRectangle.X)
                    {
                        X = endSelectedTileRectangle.X;
                        Y = selectedTileRectangle.Y;
                        width = selectedTileRectangle.X - endSelectedTileRectangle.X + tileWidth;
                        height = endSelectedTileRectangle.Y - selectedTileRectangle.Y + tileHeight;
                    }
                    if (selectedTileRectangle.X < endSelectedTileRectangle.X)
                    {
                        width += tileWidth;
                    }
                    if (selectedTileRectangle.X == endSelectedTileRectangle.X)
                    {
                        width = tileWidth;
                    }
                }
                if (selectedTileRectangle.Y > endSelectedTileRectangle.Y)
                {
                    Y += tileHeight;
                    X += tileWidth;
                    width -= tileWidth;
                    height -= tileHeight;
                    if (selectedTileRectangle.X < endSelectedTileRectangle.X)
                    {
                        X = selectedTileRectangle.X;
                        Y = endSelectedTileRectangle.Y;
                        width = endSelectedTileRectangle.X - selectedTileRectangle.X + tileWidth;
                        height = selectedTileRectangle.Y - endSelectedTileRectangle.Y + tileHeight;
                    }
                }
                if (selectedTileRectangle.Y == endSelectedTileRectangle.Y)
                {
                    if (selectedTileRectangle.X < endSelectedTileRectangle.X)
                    {
                        X = selectedTileRectangle.X;
                        width += tileWidth;
                        height = tileHeight;
                    }
                    if (endSelectedTileRectangle.X < selectedTileRectangle.X)
                    {
                        Y += tileHeight;
                        X += tileWidth;
                        width -= tileWidth;
                        height -= tileHeight;
                    }
                }
                #endregion
                entireSelection = new Rectangle(X - (int)offset.X, Y - (int)offset.Y, width, height);
                widthTiles = width / tileWidth;
                heightTiles = height / tileHeight;
                if (amount == 15)
                {
                    if (keyState.IsKeyDown(Keys.LeftShift))
                    {
                        currentConstructionType = constructionType.room;
                    }
                    else
                    {
                        currentConstructionType = constructionType.normal;
                    }
                }
                else
                {
                    currentConstructionType = constructionType.normal;
                }

                if (currentConstructionType == constructionType.room)
                {
                    selectionColor.R = 50;
                    selectionColor.B = 50;
                    selectionColor.A = 100;
                }
                if (currentConstructionType == constructionType.normal)
                {
                    selectionColor.R = 0;
                    selectionColor.A = 50;
                    selectionColor.B = 255;
                }
                #endregion
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (tileset_texture != null)
            {
                spriteBatch.Draw(tileset_texture, positionRectangle, sourceRectangle, Color.White);
                if (amount >= 2)
                {
                    spriteBatch.Draw(selectedTile_texture, entireSelection, selectionColor);

                }
                else
                {
                    spriteBatch.Draw(selectedTile_texture, selectedTileRectangleDisplay, selectionColor);
                }
            }
        }
    }
}
