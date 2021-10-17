using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Orts.Viewer3D.Popups
{
    public class PopUpLine : Control
    {
        public Microsoft.Xna.Framework.Color Color;
        public int Padding;

        public PopUpLine(int x, int y, int width, int height, int padding, Microsoft.Xna.Framework.Color c) : base(x, y, width, height)
        {
            this.Padding = padding;
            this.Color = c;
        }

        internal override void Draw(SpriteBatch spriteBatch, Point offset)
        {
            spriteBatch.Draw(WindowManager.WhiteTexture, new Rectangle((offset.X + this.Position.X) + this.Padding, (offset.Y + this.Position.Y) + this.Padding, this.Position.Width - (2 * this.Padding), this.Position.Height - (2 * this.Padding)), this.Color);
        }
    }
}

