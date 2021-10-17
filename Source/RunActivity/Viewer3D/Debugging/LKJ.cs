using Microsoft.Xna.Framework.Graphics;
using Orts;
using Orts.Simulation;
using Orts.Viewer3D;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Orts.Viewer3D.Debugging
{
    public partial class LKJ : Form
    {
        private bool bool_0;
        private bool bool_1;
        private double double_0;
        private Font font_0;
        private Font font_1;
        private IContainer icontainer_0;
        private int int_0;
        private int int_1;
        private PictureBox pictureBox_0;
        public int RedrawCount;
        private readonly Simulator simulator_0;
        private SolidBrush solidBrush_0;
        private SolidBrush solidBrush_1;
        private Timer timer_0;
        private Viewer viewer_0;

        public LKJ()
        {
            this.int_0 = 800;
            this.int_1 = 600;
            this.InitializeComponent();
        }

        public LKJ(Simulator simulator, Viewer viewer)
        {
            this.int_0 = 800;
            this.int_1 = 600;
            this.InitializeComponent();
            if (simulator == null)
            {
                throw new ArgumentNullException("simulator", "Simulator object cannot be null.");
            }
            this.simulator_0 = simulator;
            this.viewer_0 = viewer;
            this.timer_0 = new Timer();
            this.timer_0.Interval = 100;
            this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
            this.timer_0.Start();
            this.InitImage();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        public void GenerateView()
        {
            if (this.bool_1)
            {
                if (this.pictureBox_0.Image == null)
                {
                    this.InitImage();
                }
                Texture2D shadowMap = this.viewer_0.LKJ2000.shadowMap;
                byte[] data = new byte[(4 * shadowMap.Width) * shadowMap.Height];
                shadowMap.GetData<byte>(data);
                using (Graphics.FromImage(this.pictureBox_0.Image))
                {
                }
                this.pictureBox_0.Invalidate();
            }
        }
        private void InitializeComponent()
        {
            this.pictureBox_0 = new PictureBox();
            ((ISupportInitialize)this.pictureBox_0).BeginInit();
            base.SuspendLayout();
            this.pictureBox_0.Location = new Point(0, 0);
            this.pictureBox_0.Name = "LKJPicture";
            this.pictureBox_0.Size = new Size(800, 600);
            this.pictureBox_0.TabIndex = 0;
            this.pictureBox_0.TabStop = false;
            base.AutoScaleDimensions = new SizeF(8f, 16f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x321, 0x257);
            base.Controls.Add(this.pictureBox_0);
            base.Name = "LKJ";
            this.Text = "LKJ";
            ((ISupportInitialize)this.pictureBox_0).EndInit();
            base.ResumeLayout(false);
        }

        public void InitImage()
        {
            this.pictureBox_0.Width = this.int_0;
            this.pictureBox_0.Height = this.int_1;
            if (this.pictureBox_0.Image != null)
            {
                this.pictureBox_0.Image.Dispose();
            }
            this.bool_1 = true;
            this.pictureBox_0.Image = new Bitmap(this.pictureBox_0.Width, this.pictureBox_0.Height);
        }

        private void timer_0_Tick(object sender, EventArgs e)
        {
            if (!this.viewer_0.LKJViewerEnabled)
            {
                base.Visible = false;
            }
            else
            {
                base.Visible = true;
                if ((Program.Simulator.GameTime - this.double_0) >= 1.0)
                {
                    this.double_0 = Program.Simulator.GameTime;
                    this.GenerateView();
                }
            }
        }
    }
}

