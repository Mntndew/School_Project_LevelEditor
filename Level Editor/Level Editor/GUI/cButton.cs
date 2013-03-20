using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Level_Editor.GUI
{
    public class cButton
    {
        Texture2D texture;
        Rectangle position;

        Color hoverColor = new Color(255, 0, 0, 255);
        public bool isClicked = false;
        bool hover = false;
        MouseState mouse;

        public cButton(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }

        public void Update()
        {
            MouseState prevMouse = mouse;
            mouse = Mouse.GetState();
            Rectangle mousePosition = new Rectangle((int)mouse.X, (int)mouse.Y, 1, 1);
            if (position.Intersects(mousePosition))
                hover = true;
            else 
                hover = false;

            if (position.Intersects(mousePosition) && mouse.LeftButton == ButtonState.Pressed && prevMouse.LeftButton == ButtonState.Released)
                isClicked = true;
            else
                isClicked = false;
        }

        public virtual void Effect()
        {
            Console.WriteLine("Pressed");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (hover)
                spriteBatch.Draw(texture, position, hoverColor);
            else
                spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
