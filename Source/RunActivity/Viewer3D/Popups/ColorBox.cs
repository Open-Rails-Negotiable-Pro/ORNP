using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Orts.Viewer3D.Popups
{
    public class ColorBox : Control
    {
        public Color BackGroundColor;
        public int Counter;
        public Color ForeGroundColor;
        public LKJ2000Window LKJ;
        public int MaxCounter;
        public Rectangle Source;
        public Texture2D Texture;
        public int type;

        public ColorBox(int x, int y, int width, int height, LKJ2000Window lkj, int t) : base(x, y, width, height)
        {
            this.Source = Rectangle.Empty;
            this.ForeGroundColor = Color.White;
            this.BackGroundColor = Color.Green;
            this.LKJ = lkj;
            this.type = t;
            this.Counter = 0;
            this.MaxCounter = 2;
        }

        internal override void Draw(SpriteBatch spriteBatch, Point offset)
        {
            Rectangle destinationRectangle = new Rectangle(offset.X + this.Position.X, offset.Y + this.Position.Y, this.Position.Width, this.Position.Height);
            spriteBatch.Draw(WindowManager.WhiteTexture, destinationRectangle, this.ForeGroundColor);
        }

        internal override bool HandleMouseDown(WindowMouseEvent e)
        {
            Color foreGroundColor = this.ForeGroundColor;
            this.ForeGroundColor = this.BackGroundColor;
            this.BackGroundColor = foreGroundColor;
            this.Counter++;
            if (this.Counter >= this.MaxCounter)
            {
                this.Counter = 0;
            }
            this.LKJ.HandleClick(this.type, this.Counter, true);
            return true;
        }

        public bool SwitchColor()
        {
            Color foreGroundColor = this.ForeGroundColor;
            this.ForeGroundColor = this.BackGroundColor;
            this.BackGroundColor = foreGroundColor;
            this.Counter++;
            if (this.Counter >= this.MaxCounter)
            {
                this.Counter = 0;
            }
            return true;
        }
    }
}

