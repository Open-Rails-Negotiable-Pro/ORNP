using Orts;
using Orts.MultiPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Orts.Viewer3D.Debugging
{
    public partial class xingchesijianshow : Form
    {
        private ComboBox checixuan;
        private Label EcZajbClv5;
        private IContainer icontainer_0;
        private Label label2;
        private RichTextBox richTextBox1;
        private ComboBox xuanshijian;

        public xingchesijianshow()
        {
            this.InitializeComponent();
        }

        private void checixuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mpEqugcHxd();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(xingchesijianshow));
            this.richTextBox1 = new RichTextBox();
            this.checixuan = new ComboBox();
            this.xuanshijian = new ComboBox();
            this.EcZajbClv5 = new Label();
            this.label2 = new Label();
            base.SuspendLayout();
            this.richTextBox1.BackColor = Color.White;
            this.richTextBox1.Location = new Point(0, 0x1b);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new Size(370, 0x1d2);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.checixuan.FormattingEnabled = true;
            this.checixuan.Items.AddRange(new object[] { "全部" });
            this.checixuan.Location = new Point(0x35, 2);
            this.checixuan.Name = "checixuan";
            this.checixuan.Size = new Size(0x58, 20);
            this.checixuan.TabIndex = 1;
            this.checixuan.SelectedIndexChanged += new EventHandler(this.checixuan_SelectedIndexChanged);
            this.xuanshijian.FormattingEnabled = true;
            this.xuanshijian.Items.AddRange(new object[] { "全部", "事故", "超速", "冒进", "紧急", "办理" });
            this.xuanshijian.Location = new Point(0xc2, 2);
            this.xuanshijian.Name = "xuanshijian";
            this.xuanshijian.Size = new Size(0x58, 20);
            this.xuanshijian.TabIndex = 2;
            this.xuanshijian.SelectedIndexChanged += new EventHandler(this.xuanshijian_SelectedIndexChanged);
            this.EcZajbClv5.AutoSize = true;
            this.EcZajbClv5.Location = new Point(12, 6);
            this.EcZajbClv5.Name = "label1";
            this.EcZajbClv5.Size = new Size(0x1d, 12);
            this.EcZajbClv5.TabIndex = 3;
            this.EcZajbClv5.Text = "车次";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x99, 6);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x1d, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "事件";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            base.ClientSize = new Size(0x171, 0x1eb);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.EcZajbClv5);
            base.Controls.Add(this.xuanshijian);
            base.Controls.Add(this.checixuan);
            base.Controls.Add(this.richTextBox1);
            base.Icon = (Icon)manager.GetObject("$this.Icon");
            base.Name = "xingchesijianshow";
            this.Text = "行车事件提取";
            base.Load += new EventHandler(this.xingchesijianshow_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void mpEqugcHxd()
        {
            string str;
            string text;
            this.richTextBox1.Text = "";
            if (this.checixuan.Text == "全部")
            {
                text = "";
            }
            else
            {
                text = this.checixuan.Text;
            }
            if (this.xuanshijian.Text == "全部")
            {
                str = "";
            }
            else
            {
                str = this.xuanshijian.Text;
            }
            StringBuilder builder = new StringBuilder();
            foreach (string str2 in MPManager.Instance().shijiansave)
            {
                if (str2.Contains(text) && str2.Contains(str))
                {
                    builder.Append(str2 + "\n");
                }
            }
            this.richTextBox1.Text = builder.ToString();
        }

        private void xingchesijianshow_Load(object sender, EventArgs e)
        {
            string name = Program.Viewer.PlayerLocomotive.Train.Name;
            string trainchangename = Program.Viewer.PlayerLocomotive.Train.trainchangename;
            this.checixuan.Items.Add(trainchangename.Equals("") ? name : trainchangename);
            foreach (KeyValuePair<string, OnlinePlayer> pair in MPManager.OnlineTrains.Players)
            {
                this.checixuan.Items.Add(pair.Value.Train.trainchangename.Equals("") ? pair.Key : pair.Value.Train.trainchangename);
            }
            StringBuilder builder = new StringBuilder();
            foreach (string str3 in MPManager.Instance().shijiansave)
            {
                builder.Append(str3 + "\n");
            }
            this.richTextBox1.Text = builder.ToString();
        }

        private void xuanshijian_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mpEqugcHxd();
        }
    }
}

