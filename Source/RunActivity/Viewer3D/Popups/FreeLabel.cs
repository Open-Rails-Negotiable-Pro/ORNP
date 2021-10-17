using Microsoft.Xna.Framework;
using System;

namespace Orts.Viewer3D.Popups
{
    public class FreeLabel : Label
    {
        public FreeLabel(int x, int y, int width, int height, string text, LabelAlignment align, WindowManager owner, WindowTextFont f, Color c) : base(x, y, width, height, text, align)
        {
            base.Initialize(owner);
            this.SetFont(f);
            base.Color = c;
        }

        public void SetFont(WindowTextFont f)
        {
            base.Font = f;
        }
    }
}

