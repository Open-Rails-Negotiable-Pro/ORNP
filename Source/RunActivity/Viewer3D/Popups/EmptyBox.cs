using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Orts.Viewer3D.Popups
{
    public class EmptyBox : Control
    {
        public int Counter;
        public LKJ2000Window LKJ;
        public int MaxCounter;
        public int type;

        public EmptyBox(int x, int y, int width, int height, LKJ2000Window lkj, int t) : base(x, y, width, height)
        {
            this.LKJ = lkj;
            this.type = t;
            this.Counter = 0;
            this.MaxCounter = 2;
        }

        public EmptyBox(int x, int y, int width, int height, LKJ2000Window lkj, int t, int max) : base(x, y, width, height)
        {
            this.LKJ = lkj;
            this.type = t;
            this.Counter = 0;
            this.MaxCounter = max;
        }

        internal override void Draw(SpriteBatch spriteBatch, Point offset)
        {
        }

        internal override bool HandleMouseDown(WindowMouseEvent e)
        {
            this.Counter++;
            if (this.Counter >= this.MaxCounter)
            {
                this.Counter = 0;
            }
            this.LKJ.HandleClick(this.type, this.Counter, true);
            return true;
        }

        internal override bool HandleMouseUp(WindowMouseEvent e)
        {
            this.LKJ.HandleClick(this.type, this.Counter, false);
            return true;
        }

        public bool SwitchColor()
        {
            return true;
        }
    }
}

