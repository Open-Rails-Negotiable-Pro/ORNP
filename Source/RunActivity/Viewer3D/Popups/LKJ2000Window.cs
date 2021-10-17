using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ORTS.Common;
using Orts.Common;
using Orts.Formats.Msts;
using Orts.MultiPlayer;
using Orts.Simulation;
using Orts.Simulation.Physics;
using Orts.Simulation.RollingStocks;
using Orts.Viewer3D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;


namespace Orts.Viewer3D.Popups
{
    public class LKJ2000Window : Window
    {
        private bool bool_1;
        private bool bool_2;
        private ColorBox colorBox_0;
        private ColorBox colorBox_1;
        private ColorBox colorBox_2;
        private ColorBox colorBox_3;
        private int cqZvnkPvum;
        private Dictionary<int, string> dictionary_0;
        private Dictionary<Enum2, LKJSoundInfo> dictionary_1;
        private Dictionary<TrackMonitorSignalAspect, Microsoft.Xna.Framework.Rectangle> dictionary_2;
        private EmptyBox emptyBox_0;
        private EmptyBox emptyBox_1;
        private EmptyBox emptyBox_2;
        private EmptyBox emptyBox_3;
        private EmptyBox emptyBox_4;
        private EmptyBox emptyBox_5;
        private EmptyBox emptyBox_6;
        private EmptyBox emptyBox_7;
        private float float_0;
        private float float_1;
        private float float_2;
        private float float_3;
        private float float_4;
        private float float_5;
        private float float_6;
        private FreeLabel freeLabel_0;
        private FreeLabel freeLabel_1;
        private FreeLabel freeLabel_2;
        private FreeLabel freeLabel_3;
        private FreeLabel freeLabel_4;
        private FreeLabel freeLabel_5;
        private FreeLabel freeLabel_6;
        private Microsoft.Xna.Framework.Rectangle iktvWpoiXH;
        private Orts.Viewer3D.Popups.Image image_0;
        private static int int_0;
        private int int_1;
        private int[] int_2;
        private int[] int_3;
        private int int_4;
        private int int_5;
        private int int_6;
        private int int_7;
        private List<Control> list_0;
        private List<Control> list_1;
        private List<Enum2> list_2;
        private List<Enum2> list_3;
        private List<Vector2> list_4;
        private Thread oyMlyLoGpO;
        public RenderTarget2D renderTarget;
        private bool scovxkRuRD;
        public Texture2D shadowMap;
        private SortedDictionary<int, int> sortedDictionary_0;
        private SortedDictionary<int, Train.TrainObjectItem> sortedDictionary_1;
        private SortedDictionary<int, int> sortedDictionary_2;
        private SortedDictionary<int, int> sortedDictionary_3;
        private string string_1;
        private string string_2;
        private string string_3;
        private string string_4;
        private string string_5;
        private string string_6;
        private string string_7;
        private Texture2D texture2D_0;
        private Texture2D texture2D_1;
        private TrackMonitorSignalAspect trackMonitorSignalAspect_0;
        private Train.TrainObjectItem trainObjectItem_0;
        private WindowTextFont windowTextFont_0;
        private WindowTextFont windowTextFont_1;
        private WindowTextFont windowTextFont_2;

        static LKJ2000Window()
        {
            int_0 = 200;
        }

        public LKJ2000Window(WindowManager owner) : base(owner, ((int)(int_0 * 1.33)) - 5, int_0 - 5, Viewer.Catalog.GetString("LKJ2000"))
        {
            this.float_0 = 6f;
            this.float_1 = 4f;
            this.int_5 = -1;
            this.bool_1 = true;
            this.string_3 = "";
            this.float_4 = -1f;
            this.string_4 = "";
            this.string_5 = "";
            this.string_6 = "";
            this.string_7 = "";
            Dictionary<Enum2, LKJSoundInfo> dictionary = new Dictionary<Enum2, LKJSoundInfo>();
            dictionary.Add((Enum2)0, new LKJSoundInfo(" ", -11f, null, 1f));
            dictionary.Add((Enum2)1, new LKJSoundInfo("停车", -11f, null, 3f));
            dictionary.Add((Enum2)2, new LKJSoundInfo("启动", -11f, null, 1f));
            dictionary.Add((Enum2)3, new LKJSoundInfo("绿灯", -11f, null, 1f));
            dictionary.Add((Enum2)4, new LKJSoundInfo("绿黄灯", -11f, null, 1f));
            dictionary.Add((Enum2)5, new LKJSoundInfo("黄灯", -11f, null, 1f));
            dictionary.Add((Enum2)6, new LKJSoundInfo("黄二灯", -11f, null, 1f));
            dictionary.Add((Enum2)7, new LKJSoundInfo("红黄灯", -11f, null, 1f));
            dictionary.Add((Enum2)8, new LKJSoundInfo("双黄灯", -11f, null, 1f));
            dictionary.Add((Enum2)9, new LKJSoundInfo("注意限速", -11f, null, 10f));
            dictionary.Add((Enum2)10, new LKJSoundInfo("白灯", -11f, null, 1f));
            dictionary.Add((Enum2)11, new LKJSoundInfo("启动", -11f, null, 2f));
            dictionary.Add((Enum2)12, new LKJSoundInfo("进入调车", -11f, null, 1f));
            dictionary.Add((Enum2)13, new LKJSoundInfo("退出调车", -11f, null, 1f));
            dictionary.Add((Enum2)14, new LKJSoundInfo("停车", -11f, null, 3f));
            dictionary.Add((Enum2)15, new LKJSoundInfo("注意道岔限速", -11f, null, 5f));
            dictionary.Add((Enum2)0x10, new LKJSoundInfo("监控按键音", -11f, null, 0.3f));
            dictionary.Add((Enum2)0x11, new LKJSoundInfo("注意管压防溜", -11f, null, 15f));
            dictionary.Add((Enum2)0x12, new LKJSoundInfo("注意前方限速", -11f, null, 15f));
            this.dictionary_1 = dictionary;
            Dictionary<TrackMonitorSignalAspect, Microsoft.Xna.Framework.Rectangle> dictionary2 = new Dictionary<TrackMonitorSignalAspect, Microsoft.Xna.Framework.Rectangle>();
            dictionary2.Add(TrackMonitorSignalAspect.Clear_2, new Microsoft.Xna.Framework.Rectangle(0, 0, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.Clear_1, new Microsoft.Xna.Framework.Rectangle(0x10, 0, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.Approach_3, new Microsoft.Xna.Framework.Rectangle(0, 0x10, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.Approach_2, new Microsoft.Xna.Framework.Rectangle(0x10, 0x10, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.Approach_1, new Microsoft.Xna.Framework.Rectangle(0, 0x20, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.Restricted, new Microsoft.Xna.Framework.Rectangle(0x10, 0x20, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.StopAndProceed, new Microsoft.Xna.Framework.Rectangle(0, 0x30, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.Stop, new Microsoft.Xna.Framework.Rectangle(0x10, 0x30, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.Permission, new Microsoft.Xna.Framework.Rectangle(0, 0x40, 0x10, 0x10));
            dictionary2.Add(TrackMonitorSignalAspect.None, new Microsoft.Xna.Framework.Rectangle(0x10, 0x40, 0x10, 0x10));
            this.dictionary_2 = dictionary2;
            this.float_6 = 1.1f;
            this.windowTextFont_0 = owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 25f)), FontStyle.Bold);
            this.windowTextFont_1 = owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 45f)), FontStyle.Bold);
            this.windowTextFont_2 = owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 60f)), FontStyle.Bold);
            this.int_1 = 20;
            Simulator simulator = base.Owner.Viewer.Simulator;
            Train playerTrain = base.Owner.Viewer.PlayerTrain;
            float dispatcherMaxSpeedMpS = playerTrain.DispatcherMaxSpeedMpS;
            if (MPManager.IsMultiPlayer())
            {
                if (MPManager.Instance().CheckSpad)
                {
                    dispatcherMaxSpeedMpS = (int)Math.Min(Math.Min(simulator.TRK.Tr_RouteFile.SpeedLimit, (double)playerTrain.TrainMaxSpeedMpS), (double)playerTrain.DispatcherMaxSpeedMpS);
                }
            }
            else
            {
                dispatcherMaxSpeedMpS = (int)Math.Min(simulator.TRK.Tr_RouteFile.SpeedLimit, (double)playerTrain.TrainMaxSpeedMpS);
            }
            if (dispatcherMaxSpeedMpS > 50f)
            {
                this.int_1 = 40;
            }
            if (dispatcherMaxSpeedMpS < 25f)
            {
                this.int_1 = 10;
            }
            this.int_2 = new int[11];
            this.int_3 = new int[11];
            for (int i = 0; i < 11; i++)
            {
                this.int_3[i] = 0;
                this.int_2[i] = 0;
            }
            if (this.texture2D_1 == null)
            {
                this.texture2D_1 = SharedTextureManager.Get(owner.Viewer.RenderProcess.GraphicsDevice, Path.Combine(owner.Viewer.ContentPath + @"\LKJ2000", "SignalAspects.png"));
            }
            this.list_2 = new List<Enum2>();
            this.list_2.Add((Enum2)0);
            this.int_4 = (int)Math.Min(950f, base.Owner.Viewer.PlayerTrain.Length);
            GraphicsDevice graphicsDevice = base.Owner.Viewer.GraphicsDevice;
            this.renderTarget = new RenderTarget2D(graphicsDevice, graphicsDevice.PresentationParameters.BackBufferWidth, graphicsDevice.PresentationParameters.BackBufferHeight);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            SortedDictionary<int, int> dictionary;
            this.image_0.Draw(spriteBatch, base.Location.Location);
            Microsoft.Xna.Framework.Point location = base.Location.Location;
            foreach (Control control in this.list_0)
            {
                control.Draw(spriteBatch, location);
            }
            Microsoft.Xna.Framework.Rectangle iktvWpoiXH = this.iktvWpoiXH;
            spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle(((int)(int_0 * 0.205)) + location.X, location.Y + ((int)(int_0 * 0.12)), (12 * int_0) / 200, (12 * int_0) / 200), new Microsoft.Xna.Framework.Rectangle?(iktvWpoiXH), Microsoft.Xna.Framework.Color.White);
            int index = 0;
            float num6 = 0.0125f;
            int num13 = ((int)(int_0 * 0.198)) + location.Y;
            int num4 = (this.int_1 * 9) - 2;
            for (index = 0; index < (this.int_2.Count<int>() - 1); index++)
            {
                float num7;
                float num8;
                int num2 = this.int_2[index];
                int num3 = this.int_2[index + 1];
                if (num2 > num4)
                {
                    num2 = num4;
                }
                if (num3 > num4)
                {
                    num3 = num4;
                }
                Vector2 position = new Vector2((float)(((int)(int_0 * (0.28 + (index * num6)))) + location.X), (float)(((int)((int_0 * 0.55f) - (((int_0 * num2) / this.int_1) * 0.04f))) + location.Y));
                if (position.Y > num13)
                {
                    num7 = (float)Math.Atan2((double)(((int_0 * (num2 - num3)) / this.int_1) * 0.04f), (double)(int_0 * num6));
                    num8 = (float)Math.Abs((double)(((double)(int_0 * num6)) / Math.Cos((double)num7)));
                    Microsoft.Xna.Framework.Rectangle? nullable = null;
                    spriteBatch.Draw(WindowManager.WhiteTexture, position, nullable, Microsoft.Xna.Framework.Color.DarkGreen, num7, Vector2.Zero, new Vector2(num8, 2f), SpriteEffects.None, 0f);
                }
                num2 = this.int_3[index];
                num3 = this.int_3[index + 1];
                if (num2 > num4)
                {
                    num2 = num4;
                }
                if (num3 > num4)
                {
                    num3 = num4;
                }
                position = new Vector2((float)(((int)(int_0 * (0.28 + (index * num6)))) + location.X), (float)(((int)((int_0 * 0.55f) - (((int_0 * num2) / this.int_1) * 0.04f))) + location.Y));
                num7 = (float)Math.Atan2((double)(((int_0 * (num2 - num3)) / this.int_1) * 0.04f), (double)(int_0 * num6));
                num8 = (float)Math.Abs((double)(((double)(int_0 * num6)) / Math.Cos((double)num7)));
                Microsoft.Xna.Framework.Rectangle? sourceRectangle = null;
                spriteBatch.Draw(WindowManager.WhiteTexture, position, sourceRectangle, Microsoft.Xna.Framework.Color.Red, num7, Vector2.Zero, new Vector2(num8, 2f), SpriteEffects.None, 0f);
            }
            this.DrawElevation(spriteBatch, location);
            this.DrawCurves(spriteBatch, location);
            this.DrawTunnels(spriteBatch, location);
            if (this.sortedDictionary_0 == null)
            {
                dictionary = new SortedDictionary<int, int>();
            }
            else
            {
                dictionary = this.sortedDictionary_0;
            }
            float num9 = (int_0 * 0.63f) / 5000f;
            for (index = 0; index < (dictionary.Count - 1); index++)
            {
                int num10 = (int)((int_0 * 0.405) + (((float)dictionary.ElementAt<KeyValuePair<int, int>>(index).Key) * num9));
                int num11 = (int)((int_0 * 0.55f) - (((int_0 * dictionary.ElementAt<KeyValuePair<int, int>>(index).Value) / this.int_1) * 0.04f));
                int width = (int)(((float)(dictionary.ElementAt<KeyValuePair<int, int>>((index + 1)).Key - dictionary.ElementAt<KeyValuePair<int, int>>(index).Key)) * num9);
                Microsoft.Xna.Framework.Rectangle destinationRectangle = new Microsoft.Xna.Framework.Rectangle(location.X + num10, location.Y + num11, width, 2);
                spriteBatch.Draw(WindowManager.WhiteTexture, destinationRectangle, Microsoft.Xna.Framework.Color.Red);
                Microsoft.Xna.Framework.Rectangle rectangle3 = new Microsoft.Xna.Framework.Rectangle(location.X + ((int)((int_0 * 0.405) + (((float)dictionary.ElementAt<KeyValuePair<int, int>>((index + 1)).Key) * num9))), location.Y + ((int)((int_0 * 0.55f) - (((int_0 * dictionary.ElementAt<KeyValuePair<int, int>>(index).Value) / this.int_1) * 0.04f))), 2, (int)((((float)((dictionary.ElementAt<KeyValuePair<int, int>>(index).Value - dictionary.ElementAt<KeyValuePair<int, int>>((index + 1)).Value) * int_0)) * 0.04f) / ((float)this.int_1)));
                if (rectangle3.Height < 0)
                {
                    rectangle3.Y = location.Y + ((int)((int_0 * 0.55f) - (((int_0 * dictionary.ElementAt<KeyValuePair<int, int>>((index + 1)).Value) / this.int_1) * 0.04f)));
                    rectangle3.Height = -rectangle3.Height + 2;
                }
                else
                {
                    rectangle3.Height += 2;
                }
                spriteBatch.Draw(WindowManager.WhiteTexture, rectangle3, Microsoft.Xna.Framework.Color.Red);
            }
            this.DrawTrain(spriteBatch, location);
            this.DrawPlatforms(spriteBatch, location);
            this.DrawSignals(spriteBatch, location);
            this.method_0();
            switch (this.cqZvnkPvum)
            {
                case 1:
                    this.DrawLeftInfo(spriteBatch, location);
                    return;

                case 2:
                    this.DrawRightInfo(spriteBatch, location);
                    return;

                case 3:
                    this.DrawLeftInfo(spriteBatch, location);
                    this.DrawRightInfo(spriteBatch, location);
                    return;
            }
        }

        public static void DrawCircle(SpriteBatch spritbatch, Vector2 center, float radius, Microsoft.Xna.Framework.Color color, int lineWidth, int segments = 0x10)
        {
            Vector2[] vertex = new Vector2[segments];
            double num = 6.2831853071795862 / ((double)segments);
            double d = 0.0;
            for (int i = 0; i < segments; i++)
            {
                vertex[i] = center + ((Vector2)(radius * new Vector2((float)Math.Cos(d), (float)Math.Sin(d))));
                d += num;
            }
            DrawPolygon(spritbatch, vertex, segments, color, lineWidth);
        }

        public void DrawCurves(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Point offset)
        {
            if (this.sortedDictionary_2 != null)
            {
                SortedDictionary<int, int> source = this.sortedDictionary_2;
                float num2 = (int_0 * 0.63f) / 5000f;
                float num4 = int_0 * 0.004f;
                if (source.Count == 0)
                {
                    int num7 = (int)(int_0 * 0.28);
                    int num8 = (int)(int_0 * 0.64f);
                    int num9 = (int)(5000f * num2);
                    Microsoft.Xna.Framework.Rectangle destinationRectangle = new Microsoft.Xna.Framework.Rectangle(offset.X + num7, offset.Y + num8, num9 + 1, 1);
                    spriteBatch.Draw(WindowManager.WhiteTexture, destinationRectangle, Microsoft.Xna.Framework.Color.Silver);
                }
                else
                {
                    for (int i = 0; i < (source.Count - 1); i++)
                    {
                        int num3 = (int)((int_0 * 0.405) + (((float)source.ElementAt<KeyValuePair<int, int>>(i).Key) * num2));
                        int num5 = (int)((int_0 * 0.64f) - (((float)source.ElementAt<KeyValuePair<int, int>>(i).Value) * num4));
                        int num6 = (int)(((float)(source.ElementAt<KeyValuePair<int, int>>((i + 1)).Key - source.ElementAt<KeyValuePair<int, int>>(i).Key)) * num2);
                        Microsoft.Xna.Framework.Rectangle rectangle = new Microsoft.Xna.Framework.Rectangle(offset.X + num3, offset.Y + num5, num6 + 1, 1);
                        spriteBatch.Draw(WindowManager.WhiteTexture, rectangle, Microsoft.Xna.Framework.Color.Silver);
                        Microsoft.Xna.Framework.Rectangle rectangle2 = new Microsoft.Xna.Framework.Rectangle(offset.X + ((int)((int_0 * 0.405) + (((float)source.ElementAt<KeyValuePair<int, int>>((i + 1)).Key) * num2))), offset.Y + ((int)((int_0 * 0.64f) - (((float)source.ElementAt<KeyValuePair<int, int>>(i).Value) * num4))), 2, (int)(((float)(source.ElementAt<KeyValuePair<int, int>>(i).Value - source.ElementAt<KeyValuePair<int, int>>((i + 1)).Value)) * num4));
                        if (rectangle2.Height < 0)
                        {
                            rectangle2.Y = offset.Y + ((int)((int_0 * 0.64f) - (((float)source.ElementAt<KeyValuePair<int, int>>((i + 1)).Value) * num4)));
                            rectangle2.Height = -rectangle2.Height + 1;
                        }
                        else
                        {
                            rectangle2.Height++;
                        }
                        spriteBatch.Draw(WindowManager.WhiteTexture, rectangle2, Microsoft.Xna.Framework.Color.Silver);
                    }
                }
            }
        }

        public void DrawElevation(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Point offset)
        {
            if (this.sortedDictionary_3 != null)
            {
                SortedDictionary<int, int> source = this.sortedDictionary_3;
                int index = 0;
                float x = (0.05f * int_0) - 1f;
                float num7 = 0.126f;
                float num2 = 0.000126f;
                for (index = 0; index < (source.Count<KeyValuePair<int, int>>() - 1); index++)
                {
                    Vector2 vector;
                    int num6 = source.ElementAt<KeyValuePair<int, int>>((index + 1)).Key - source.ElementAt<KeyValuePair<int, int>>(index).Key;
                    float rotation = (float)Math.Atan2(50.0, (double)(num6 * num7));
                    float num4 = (float)Math.Sqrt(Math.Pow((double)(num6 * num2), 2.0) + 0.0025);
                    num4 *= int_0;
                    if (source.ElementAt<KeyValuePair<int, int>>((index + 1)).Value < 0)
                    {
                        vector = new Vector2((float)(((int)(int_0 * (0.405 + (((float)source.ElementAt<KeyValuePair<int, int>>(index).Key) * num2)))) + offset.X), (float)(((int)(int_0 * 0.55f)) + offset.Y));
                        Microsoft.Xna.Framework.Rectangle? sourceRectangle = null;
                        spriteBatch.Draw(WindowManager.WhiteTexture, vector, sourceRectangle, Microsoft.Xna.Framework.Color.Silver, rotation, Vector2.Zero, new Vector2(num4, 1f), SpriteEffects.None, 0f);
                        Microsoft.Xna.Framework.Rectangle? nullable5 = null;
                        spriteBatch.Draw(WindowManager.WhiteTexture, vector, nullable5, Microsoft.Xna.Framework.Color.Silver, 1.57f, Vector2.Zero, new Vector2(x + 1f, 1f), SpriteEffects.None, 0f);
                        this.windowTextFont_2.Draw(spriteBatch, new Microsoft.Xna.Framework.Point((int)(vector.X + (((num2 * int_0) / 2f) * num6)), (int)vector.Y), source.ElementAt<KeyValuePair<int, int>>((index + 1)).Value, Microsoft.Xna.Framework.Color.Silver);
                    }
                    else if (source.ElementAt<KeyValuePair<int, int>>((index + 1)).Value > 0)
                    {
                        vector = new Vector2((float)(((int)(int_0 * (0.405 + (((float)source.ElementAt<KeyValuePair<int, int>>(index).Key) * num2)))) + offset.X), (float)(((int)(int_0 * 0.6f)) + offset.Y));
                        Microsoft.Xna.Framework.Rectangle? nullable = null;
                        spriteBatch.Draw(WindowManager.WhiteTexture, vector, nullable, Microsoft.Xna.Framework.Color.Silver, -rotation, Vector2.Zero, new Vector2(num4, 1f), SpriteEffects.None, 0f);
                        Microsoft.Xna.Framework.Rectangle? nullable2 = null;
                        spriteBatch.Draw(WindowManager.WhiteTexture, vector, nullable2, Microsoft.Xna.Framework.Color.Silver, -1.57f, Vector2.Zero, new Vector2(x, 1f), SpriteEffects.None, 0f);
                        this.windowTextFont_2.Draw(spriteBatch, new Microsoft.Xna.Framework.Point((int)(vector.X + (((num2 * int_0) / 3f) * num6)), (int)((vector.Y - x) - 1f)), source.ElementAt<KeyValuePair<int, int>>((index + 1)).Value, Microsoft.Xna.Framework.Color.Silver);
                    }
                    else
                    {
                        vector = new Vector2((float)(((int)(int_0 * (0.405 + (num2 * ((float)source.ElementAt<KeyValuePair<int, int>>(index).Key))))) + offset.X), (float)(((int)(int_0 * 0.6f)) + offset.Y));
                        Microsoft.Xna.Framework.Rectangle? nullable3 = null;
                        spriteBatch.Draw(WindowManager.WhiteTexture, vector, nullable3, Microsoft.Xna.Framework.Color.Silver, -1.57f, Vector2.Zero, new Vector2(x, 1f), SpriteEffects.None, 0f);
                    }
                }
            }
        }

        public void DrawLeftInfo(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Point offset)
        {
            int num = (int)(int_0 * 0.407);
            int num2 = (int)(int_0 * 0.192f);
            Microsoft.Xna.Framework.Rectangle destinationRectangle = new Microsoft.Xna.Framework.Rectangle((offset.X + num) + 2, offset.Y + num2, (int)(int_0 * 0.35f), (int)(int_0 * 0.125f));
            int num3 = (int)(int_0 * 0.03f);
            spriteBatch.Draw(WindowManager.WhiteTexture, destinationRectangle, Microsoft.Xna.Framework.Color.DarkBlue);
            Microsoft.Xna.Framework.Point point = new Microsoft.Xna.Framework.Point((offset.X + num) + 2, offset.Y + num2);
            this.windowTextFont_2.Draw(spriteBatch, point, "司机号: " + this.string_2, Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "总重　: " + this.int_6, Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "计长　: " + string.Format("{0:0.#}", this.float_2), Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, this.string_3, Microsoft.Xna.Framework.Color.Red);
            point.X = (offset.X + num) + ((int)(int_0 * 0.2));
            point.Y = offset.Y + num2;
            this.windowTextFont_2.Draw(spriteBatch, point, "车次　: " + this.string_1, Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "辆数　: " + this.int_7, Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "主轮径: " + string.Format("{0:0.#}", this.float_3), Microsoft.Xna.Framework.Color.White);
        }

        public static void DrawLineSegment(SpriteBatch spriteBatch, Vector2 point1, Vector2 point2, Microsoft.Xna.Framework.Color color, int lineWidth)
        {
            float rotation = (float)Math.Atan2((double)(point2.Y - point1.Y), (double)(point2.X - point1.X));
            float x = Vector2.Distance(point1, point2);
            spriteBatch.Draw(WindowManager.WhiteTexture, point1, null, color, rotation, Vector2.Zero, new Vector2(x, (float)lineWidth), SpriteEffects.None, 0f);
        }

        public void DrawPlatforms(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Point offset)
        {
            if (this.dictionary_0 != null)
            {
                Dictionary<int, string> source = this.dictionary_0;
                int index = 0;
                float y = 0.3f * int_0;
                float num5 = 0.000126f * int_0;
                int num4 = (int)(int_0 * 0.25);
                if (this.cqZvnkPvum > 0)
                {
                    y = 0.13f * int_0;
                    num4 = (int)(int_0 * 0.42);
                }
                float radius = 0.01f * int_0;
                string text = "";
                for (index = 0; index < source.Count<KeyValuePair<int, string>>(); index++)
                {
                    if (source.ElementAt<KeyValuePair<int, string>>(index).Key <= 0x1388)
                    {
                        Vector2 position = new Vector2((float)(((int)((int_0 * 0.405) + (((float)source.ElementAt<KeyValuePair<int, string>>(index).Key) * num5))) + offset.X), (float)(num4 + offset.Y));
                        text = Regex.Replace(source.ElementAt<KeyValuePair<int, string>>(index).Value, @"[\d-]", string.Empty);
                        Microsoft.Xna.Framework.Rectangle? sourceRectangle = null;
                        spriteBatch.Draw(WindowManager.WhiteTexture, position, sourceRectangle, Microsoft.Xna.Framework.Color.LightBlue, 0f, Vector2.Zero, new Vector2(1f, y), SpriteEffects.None, 0f);
                        position.Y -= radius;
                        DrawCircle(spriteBatch, position, radius, Microsoft.Xna.Framework.Color.LightBlue, 1, 6);
                        if (source.ElementAt<KeyValuePair<int, string>>(index).Key < -200)
                        {
                            this.windowTextFont_2.Draw(spriteBatch, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)(position.Y - (4f * radius)), 4, 4), new Microsoft.Xna.Framework.Point(0, 0), text, LabelAlignment.Left, Microsoft.Xna.Framework.Color.LightBlue);
                        }
                        else if (source.ElementAt<KeyValuePair<int, string>>(index).Key < 0xfa0)
                        {
                            this.windowTextFont_2.Draw(spriteBatch, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)(position.Y - (4f * radius)), 4, 4), new Microsoft.Xna.Framework.Point(0, 0), text, LabelAlignment.Center, Microsoft.Xna.Framework.Color.LightBlue);
                        }
                        else
                        {
                            this.windowTextFont_2.Draw(spriteBatch, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)(position.Y - (4f * radius)), 4, 4), new Microsoft.Xna.Framework.Point(0, 0), text, LabelAlignment.Right, Microsoft.Xna.Framework.Color.LightBlue);
                        }
                    }
                }
            }
        }

        public static void DrawPolygon(SpriteBatch spriteBatch, Vector2[] vertex, int count, Microsoft.Xna.Framework.Color color, int lineWidth)
        {
            if (count > 0)
            {
                for (int i = 0; i < (count - 1); i++)
                {
                    DrawLineSegment(spriteBatch, vertex[i], vertex[i + 1], color, lineWidth);
                }
                DrawLineSegment(spriteBatch, vertex[count - 1], vertex[0], color, lineWidth);
            }
        }

        public void DrawRightInfo(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Point offset)
        {
            int num = (int)(int_0 * 0.76);
            int num2 = (int)(int_0 * 0.192f);
            Microsoft.Xna.Framework.Rectangle destinationRectangle = new Microsoft.Xna.Framework.Rectangle((offset.X + num) + 2, offset.Y + num2, (int)(int_0 * 0.27f), (int)(int_0 * 0.18f));
            int num3 = (int)(int_0 * 0.03f);
            spriteBatch.Draw(WindowManager.WhiteTexture, destinationRectangle, Microsoft.Xna.Framework.Color.DarkBlue);
            Microsoft.Xna.Framework.Point point = new Microsoft.Xna.Framework.Point((offset.X + num) + 2, offset.Y + num2);
            if (this.bool_2)
            {
                this.windowTextFont_2.Draw(spriteBatch, point, "电力系统" + (this.scovxkRuRD ? "开" : "关"), Microsoft.Xna.Framework.Color.White);
            }
            else
            {
                this.windowTextFont_2.Draw(spriteBatch, point, "柴油机转速" + ((int)this.float_4), Microsoft.Xna.Framework.Color.White);
            }
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "列车管压力" + this.string_5, Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "制动缸压力" + this.string_7, Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "均衡风缸１" + this.string_6, Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "均衡风缸２" + this.string_6, Microsoft.Xna.Framework.Color.White);
            point.Y += num3;
            this.windowTextFont_2.Draw(spriteBatch, point, "工况 " + this.string_4, Microsoft.Xna.Framework.Color.White);
        }

        public void DrawSignals(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Point offset)
        {
            if (this.sortedDictionary_1 != null)
            {
                SortedDictionary<int, Train.TrainObjectItem> source = this.sortedDictionary_1;
                int index = 0;
                float y = 0.05f * int_0;
                float num2 = 0.000126f * int_0;
                int num3 = (int)(int_0 * 0.5);
                int num5 = (int)(0.01f * int_0);
                int width = num5 * 2;
                for (index = 0; index < source.Count<KeyValuePair<int, Train.TrainObjectItem>>(); index++)
                {
                    if (source.ElementAt<KeyValuePair<int, Train.TrainObjectItem>>(index).Key <= 0x1388)
                    {
                        Microsoft.Xna.Framework.Rectangle rectangle;
                        Train.TrainObjectItem local1 = source.ElementAt<KeyValuePair<int, Train.TrainObjectItem>>(index).Value;
                        Vector2 position = new Vector2((float)(((int)((int_0 * 0.405) + (((float)source.ElementAt<KeyValuePair<int, Train.TrainObjectItem>>(index).Key) * num2))) + offset.X), (float)(num3 + offset.Y));
                        Microsoft.Xna.Framework.Rectangle? sourceRectangle = null;
                        spriteBatch.Draw(WindowManager.WhiteTexture, position, sourceRectangle, Microsoft.Xna.Framework.Color.LightBlue, 0f, Vector2.Zero, new Vector2(1f, y), SpriteEffects.None, 0f);
                        switch (source.ElementAt<KeyValuePair<int, Train.TrainObjectItem>>(index).Value.SignalState)
                        {
                            case TrackMonitorSignalAspect.None:
                                rectangle = this.dictionary_2[TrackMonitorSignalAspect.None];
                                position.Y -= num5;
                                position.X -= num5;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                break;

                            case TrackMonitorSignalAspect.Clear_2:
                                rectangle = this.dictionary_2[TrackMonitorSignalAspect.Clear_2];
                                position.Y -= num5;
                                position.X -= num5;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                break;

                            case TrackMonitorSignalAspect.Clear_1:
                                rectangle = this.dictionary_2[TrackMonitorSignalAspect.Approach_3];
                                position.Y -= num5;
                                position.X -= num5;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                rectangle = this.dictionary_2[TrackMonitorSignalAspect.Clear_2];
                                position.Y -= width;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                break;

                            case TrackMonitorSignalAspect.Approach_3:
                                rectangle = this.dictionary_2[TrackMonitorSignalAspect.Approach_3];
                                position.Y -= num5;
                                position.X -= num5;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                break;

                            case TrackMonitorSignalAspect.Approach_2:
                                rectangle = this.dictionary_2[TrackMonitorSignalAspect.Approach_2];
                                position.Y -= num5;
                                position.X -= num5;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                break;

                            case TrackMonitorSignalAspect.Approach_1:
                                rectangle = this.dictionary_2[TrackMonitorSignalAspect.Approach_3];
                                position.Y -= num5;
                                position.X -= num5;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                position.Y -= width;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                break;

                            case TrackMonitorSignalAspect.Restricted:
                            case TrackMonitorSignalAspect.StopAndProceed:
                            case TrackMonitorSignalAspect.Stop:
                                rectangle = this.dictionary_2[TrackMonitorSignalAspect.Stop];
                                position.Y -= num5;
                                position.X -= num5;
                                spriteBatch.Draw(this.texture2D_1, new Microsoft.Xna.Framework.Rectangle((int)position.X, (int)position.Y, width, width), new Microsoft.Xna.Framework.Rectangle?(rectangle), Microsoft.Xna.Framework.Color.White);
                                break;
                        }
                    }
                }
            }
        }

        public void DrawTrain(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Point offset)
        {
            float y = (0.01f * int_0) - 1f;
            float x = ((this.int_4 * 0.63f) / 5000f) * int_0;
            float num3 = ((int)(int_0 * 0.55f)) - y;
            Vector2 position = new Vector2((float)(((int)((int_0 * 0.405) - x)) + offset.X), num3 + offset.Y);
            spriteBatch.Draw(WindowManager.WhiteTexture, position, null, Microsoft.Xna.Framework.Color.Violet, 0f, Vector2.Zero, new Vector2(x, y), SpriteEffects.None, 0f);
        }

        public void DrawTunnels(SpriteBatch spriteBatch, Microsoft.Xna.Framework.Point offset)
        {
            if (this.list_4 != null)
            {
                List<Vector2> source = this.list_4;
                int index = 0;
                float y = (0.02f * int_0) - 1f;
                float num3 = 0.000126f * int_0;
                float num5 = ((int)(int_0 * 0.69f)) - y;
                for (index = 0; index < source.Count<Vector2>(); index++)
                {
                    float x = source.ElementAt<Vector2>(index).Y * num3;
                    Vector2 position = new Vector2((float)(((int)((int_0 * 0.405) + (source.ElementAt<Vector2>(index).X * num3))) + offset.X), num5 + offset.Y);
                    Microsoft.Xna.Framework.Rectangle? sourceRectangle = null;
                    spriteBatch.Draw(WindowManager.WhiteTexture, position, sourceRectangle, Microsoft.Xna.Framework.Color.Silver, 0f, Vector2.Zero, new Vector2(x, y), SpriteEffects.None, 0f);
                }
            }
        }

        public void HandleClick(int type, int counter, bool Down)
        {
            List<Enum2> list = new List<Enum2>();
            Enum2 item = (Enum2)0;
            TrainCar playerLocomotive = base.Owner.Viewer.PlayerLocomotive;
            if (!Down)
            {
                if (type == 0x11)
                {
                    list.Add((Enum2)0x10);
                    new AlerterCommand(base.Owner.Viewer.Log, false);
                }
            }
            else
            {
                switch (type)
                {
                    case 0:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10:
                        goto Label_0258;

                    case 1:
                        if (counter != 0)
                        {
                            item = (Enum2)12;
                            this.bool_1 = false;
                        }
                        else
                        {
                            item = (Enum2)13;
                            this.bool_1 = true;
                        }
                        goto Label_0258;

                    case 2:
                        if (counter == 1)
                        {
                            item = (Enum2)11;
                        }
                        goto Label_0258;

                    case 11:
                        list.Add((Enum2)0x10);
                        if (this.colorBox_1.Counter != 1)
                        {
                            item = (Enum2)12;
                            this.bool_1 = false;
                            break;
                        }
                        item = (Enum2)13;
                        this.bool_1 = true;
                        break;

                    case 12:
                        list.Add((Enum2)0x10);
                        if (this.colorBox_2.Counter == 0)
                        {
                            item = (Enum2)11;
                        }
                        this.colorBox_2.SwitchColor();
                        goto Label_0258;

                    case 13:
                        list.Add((Enum2)0x10);
                        if ((playerLocomotive.Direction == Direction.Forward) || ((playerLocomotive.ThrottlePercent < 1f) && (Math.Abs(playerLocomotive.SpeedMpS) <= 1f)))
                        {
                            new ReverserCommand(base.Owner.Viewer.Log, true);
                        }
                        goto Label_0258;

                    case 14:
                        list.Add((Enum2)0x10);
                        if ((playerLocomotive.Direction == Direction.Reverse) || ((playerLocomotive.ThrottlePercent < 1f) && (Math.Abs(playerLocomotive.SpeedMpS) <= 1f)))
                        {
                            new ReverserCommand(base.Owner.Viewer.Log, false);
                        }
                        goto Label_0258;

                    case 15:
                        list.Add((Enum2)0x10);
                        new InitializeBrakesCommand(base.Owner.Viewer.Log);
                        goto Label_0258;

                    case 0x10:
                        list.Add((Enum2)0x10);
                        base.Owner.Viewer.PlayerTrain.RequestSignalPermission(Direction.Forward);
                        goto Label_0258;

                    case 0x11:
                        list.Add((Enum2)0x10);
                        new AlerterCommand(base.Owner.Viewer.Log, true);
                        goto Label_0258;

                    case 0x12:
                        list.Add((Enum2)0x10);
                        this.cqZvnkPvum = this.emptyBox_7.Counter;
                        goto Label_0258;

                    default:
                        goto Label_0258;
                }
                this.colorBox_1.SwitchColor();
            }
        Label_0258:
            if (item != ((Enum2)0))
            {
                list.Add(item);
            }
            this.list_3 = list;
        }

        protected internal override void Initialize()
        {
            base.Initialize();
            try
            {
                this.texture2D_0 = SharedTextureManager.Get(base.Owner.Viewer.RenderProcess.GraphicsDevice, Path.Combine(base.Owner.Viewer.ContentPath + @"\LKJ2000", "LKJ2000.png"));
            }
            catch
            {
                this.texture2D_0 = new Texture2D(base.Owner.Viewer.RenderProcess.GraphicsDevice, (int)(int_0 * 1.33), int_0);
            }
        }

        protected override ControlLayout Layout(ControlLayout layout)
        {
            List<Control> list = new List<Control>();
            new List<Control>();
            List<Control> list2 = new List<Control>();
            int height = base.Owner.TextFontDefault.Height;
            this.freeLabel_0 = new FreeLabel((int)(int_0 * 0.35), (int)(int_0 * 0.12), (int)(int_0 * 0.06), (int)(int_0 * 0.1), "0", LabelAlignment.Right, base.Owner, this.windowTextFont_0, Microsoft.Xna.Framework.Color.DarkGreen);
            list.Add(this.freeLabel_0);
            this.freeLabel_1 = new FreeLabel((int)(int_0 * 0.49), (int)(int_0 * 0.12), (int)(int_0 * 0.06), (int)(int_0 * 0.1), "0", LabelAlignment.Right, base.Owner, this.windowTextFont_0, Microsoft.Xna.Framework.Color.DarkRed);
            list.Add(this.freeLabel_1);
            this.freeLabel_2 = new FreeLabel((int)(int_0 * 0.69), (int)(int_0 * 0.12), (int)(int_0 * 0.06), (int)(int_0 * 0.1), "0", LabelAlignment.Right, base.Owner, this.windowTextFont_0, Microsoft.Xna.Framework.Color.Yellow);
            list.Add(this.freeLabel_2);
            this.freeLabel_3 = new FreeLabel((int)(int_0 * 0.9), (int)(int_0 * 0.115), (int)(int_0 * 0.06), (int)(int_0 * 0.05), "", LabelAlignment.Right, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.DarkOrange);
            list.Add(this.freeLabel_3);
            this.freeLabel_4 = new FreeLabel((int)(int_0 * 0.9), (int)(int_0 * 0.148), (int)(int_0 * 0.06), (int)(int_0 * 0.05), "", LabelAlignment.Right, base.Owner, this.windowTextFont_1, Microsoft.Xna.Framework.Color.Yellow);
            list.Add(this.freeLabel_4);
            this.freeLabel_5 = new FreeLabel((int)(int_0 * 1.01), (int)(int_0 * 0.117), (int)(int_0 * 0.06), (int)(int_0 * 0.05), "", LabelAlignment.Center, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.Silver);
            list.Add(this.freeLabel_5);
            this.freeLabel_6 = new FreeLabel((int)(int_0 * 1.01), (int)(int_0 * 0.142), (int)(int_0 * 0.06), (int)(int_0 * 0.05), "", LabelAlignment.Center, base.Owner, this.windowTextFont_1, Microsoft.Xna.Framework.Color.White);
            list.Add(this.freeLabel_6);
            Microsoft.Xna.Framework.Color color = new Microsoft.Xna.Framework.Color(0.2422f, 0.2617f, 0.2734f);
            ColorBox item = new ColorBox((int)(int_0 * 1.037f), (int)(int_0 * 0.518f), (int)(int_0 * 0.066), (int)(int_0 * 0.035), this, 10)
            {
                ForeGroundColor = color
            };
            if (!base.Owner.Viewer.Simulator.PlayerLocomotive.Train.IsFreight)
            {
                item.BackGroundColor = item.ForeGroundColor;
                item.ForeGroundColor = Microsoft.Xna.Framework.Color.Green;
            }
            list.Add(item);
            FreeLabel label = new FreeLabel((int)(int_0 * 1.045f), (int)(int_0 * 0.52f), (int)(int_0 * 0.03), (int)(int_0 * 0.03), "客车", LabelAlignment.Left, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.Black);
            list.Add(label);
            item = new ColorBox((int)(int_0 * 1.037f), (int)(int_0 * 0.5558f), (int)(int_0 * 0.066), (int)(int_0 * 0.035), this, 10)
            {
                BackGroundColor = color,
                ForeGroundColor = Microsoft.Xna.Framework.Color.Green
            };
            list.Add(item);
            label = new FreeLabel((int)(int_0 * 1.045f), (int)(int_0 * 0.5578f), (int)(int_0 * 0.03), (int)(int_0 * 0.03), "IC卡", LabelAlignment.Left, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.Black);
            list.Add(label);
            ControlLayoutHorizontal horizontal = base.Layout(layout).AddLayoutHorizontal();
            item = new ColorBox(0, 0, (int)(int_0 * 0.066), (int)(int_0 * 0.035), this, 0);
            horizontal.Add(item);
            item.Position.X = (int)(int_0 * 1.037f);
            item.Position.Y = (int)(int_0 * 0.48f);
            item.ForeGroundColor = color;
            if (this.colorBox_0 != null)
            {
                item.ForeGroundColor = this.colorBox_0.ForeGroundColor;
                item.BackGroundColor = this.colorBox_0.BackGroundColor;
                item.Counter = this.colorBox_0.Counter;
            }
            this.colorBox_0 = item;
            label = new FreeLabel((int)(int_0 * 1.045f), (int)(int_0 * 0.482), (int)(int_0 * 0.03), (int)(int_0 * 0.03), "有权", LabelAlignment.Left, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.Black);
            list.Add(item);
            list.Add(label);
            item = new ColorBox(0, 0, (int)(int_0 * 0.066), (int)(int_0 * 0.035), this, 1);
            horizontal.Add(item);
            item.Position.X = (int)(int_0 * 1.037f);
            item.Position.Y = (int)(int_0 * 0.443f);
            item.ForeGroundColor = color;
            if (this.colorBox_1 != null)
            {
                item.ForeGroundColor = this.colorBox_1.ForeGroundColor;
                item.BackGroundColor = this.colorBox_1.BackGroundColor;
                item.Counter = this.colorBox_1.Counter;
            }
            this.colorBox_1 = item;
            label = new FreeLabel((int)(int_0 * 1.045f), (int)(int_0 * 0.445f), (int)(int_0 * 0.03), (int)(int_0 * 0.03), "调车", LabelAlignment.Left, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.Black);
            list.Add(item);
            list.Add(label);
            item = new ColorBox(0, 0, (int)(int_0 * 0.066), (int)(int_0 * 0.035), this, 2);
            horizontal.Add(item);
            item.Position.X = (int)(int_0 * 1.037f);
            item.Position.Y = (int)(int_0 * 0.405f);
            item.ForeGroundColor = color;
            if (this.colorBox_2 != null)
            {
                item.ForeGroundColor = this.colorBox_2.ForeGroundColor;
                item.BackGroundColor = this.colorBox_2.BackGroundColor;
                item.Counter = this.colorBox_2.Counter;
            }
            this.colorBox_2 = item;
            label = new FreeLabel((int)(int_0 * 1.045f), (int)(int_0 * 0.407f), (int)(int_0 * 0.03), (int)(int_0 * 0.03), "开车", LabelAlignment.Left, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.Black);
            list.Add(item);
            list.Add(label);
            item = new ColorBox(0, 0, (int)(int_0 * 0.066), (int)(int_0 * 0.035), this, 10);
            horizontal.Add(item);
            item.Position.X = (int)(int_0 * 1.037f);
            item.Position.Y = (int)(int_0 * 0.595f);
            item.ForeGroundColor = color;
            if (this.colorBox_3 != null)
            {
                item.ForeGroundColor = this.colorBox_3.ForeGroundColor;
                item.BackGroundColor = this.colorBox_3.BackGroundColor;
                item.Counter = this.colorBox_3.Counter;
            }
            this.colorBox_3 = item;
            label = new FreeLabel((int)(int_0 * 1.045f), (int)(int_0 * 0.597f), (int)(int_0 * 0.03), (int)(int_0 * 0.03), "支线", LabelAlignment.Left, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.Black);
            list.Add(item);
            list.Add(label);
            EmptyBox control = new EmptyBox(0, 0, (int)(int_0 * 0.068), (int)(int_0 * 0.046), this, 11);
            horizontal.Add(control);
            control.Position.X = (int)(int_0 * 0.488f);
            control.Position.Y = (int)(int_0 * 0.855f);
            this.emptyBox_0 = control;
            list.Add(control);
            control = new EmptyBox(0, 0, (int)(int_0 * 0.068), (int)(int_0 * 0.046), this, 12);
            horizontal.Add(control);
            control.Position.X = (int)(int_0 * 0.488f);
            control.Position.Y = (int)(int_0 * 0.927f);
            this.emptyBox_1 = control;
            list.Add(control);
            control = new EmptyBox(0, 0, (int)(int_0 * 0.068), (int)(int_0 * 0.046), this, 13);
            horizontal.Add(control);
            control.Position.X = (int)(int_0 * 0.408f);
            control.Position.Y = (int)(int_0 * 0.855f);
            this.emptyBox_2 = control;
            list.Add(control);
            control = new EmptyBox(0, 0, (int)(int_0 * 0.068), (int)(int_0 * 0.046), this, 14);
            horizontal.Add(control);
            control.Position.X = (int)(int_0 * 0.408f);
            control.Position.Y = (int)(int_0 * 0.927f);
            this.emptyBox_3 = control;
            list.Add(control);
            control = new EmptyBox(0, 0, (int)(int_0 * 0.068), (int)(int_0 * 0.046), this, 15);
            horizontal.Add(control);
            control.Position.X = (int)(int_0 * 0.326f);
            control.Position.Y = (int)(int_0 * 0.927f);
            this.emptyBox_4 = control;
            list.Add(control);
            control = new EmptyBox(0, 0, (int)(int_0 * 0.068), (int)(int_0 * 0.046), this, 0x10);
            horizontal.Add(control);
            control.Position.X = (int)(int_0 * 0.326f);
            control.Position.Y = (int)(int_0 * 0.855f);
            this.emptyBox_5 = control;
            list.Add(control);
            control = new EmptyBox(0, 0, (int)(int_0 * 0.068), (int)(int_0 * 0.06), this, 0x11);
            horizontal.Add(control);
            control.Position.X = (int)(int_0 * 0.233f);
            control.Position.Y = (int)(int_0 * 0.895f);
            this.emptyBox_6 = control;
            list.Add(control);
            control = new EmptyBox(0, 0, (int)(int_0 * 0.068), (int)(int_0 * 0.046), this, 0x12, 4);
            horizontal.Add(control);
            control.Position.X = (int)(int_0 * 0.833f);
            control.Position.Y = (int)(int_0 * 0.855f);
            this.emptyBox_7 = control;
            list.Add(control);
            PopUpLine line = new PopUpLine((int)(int_0 * 0.28), (int)(int_0 * 0.55), (int)(int_0 * 0.755), 2, 0, Microsoft.Xna.Framework.Color.Silver);
            list.Add(line);
            line = new PopUpLine((int)(int_0 * 0.405), (int)(int_0 * 0.19), 2, (int)(int_0 * 0.527), 0, Microsoft.Xna.Framework.Color.Yellow);
            list.Add(line);
            line = new PopUpLine((int)(int_0 * 0.28), (int)(int_0 * 0.6), (int)(int_0 * 0.755), 2, 0, Microsoft.Xna.Framework.Color.Silver);
            list.Add(line);
            line = new PopUpLine((int)(int_0 * 0.28), (int)(int_0 * 0.61), (int)(int_0 * 0.755), 1, 0, Microsoft.Xna.Framework.Color.Indigo);
            list.Add(line);
            line = new PopUpLine((int)(int_0 * 0.28), (int)(int_0 * 0.69), (int)(int_0 * 0.755), 2, 0, Microsoft.Xna.Framework.Color.Silver);
            list.Add(line);
            line = new PopUpLine((int)(int_0 * 0.28), (int)(int_0 * 0.67), (int)(int_0 * 0.755), 1, 0, Microsoft.Xna.Framework.Color.Indigo);
            list.Add(line);
            for (int i = 1; i < 10; i++)
            {
                line = new PopUpLine((int)(int_0 * 0.28), (int)(int_0 * (0.55f - (i * 0.04f))), (int)(int_0 * 0.755), 1, 0, Microsoft.Xna.Framework.Color.Silver);
                label = new FreeLabel((int)(int_0 * 0.24), (int)(int_0 * (0.57f - (i * 0.04f))), (int)(int_0 * 0.03), (int)(int_0 * 0.06), ((i - 1) * int_1), LabelAlignment.Right, base.Owner, this.windowTextFont_2, Microsoft.Xna.Framework.Color.DarkSlateGray);
                list.Add(line);
                list.Add(label);
            }
            this.image_0 = new Orts.Viewer3D.Popups.Image(0, 0, (int)(int_0 * 1.333), int_0);
            this.image_0.Texture = this.texture2D_0;
            if (this.texture2D_0 != null)
            {
                this.image_0.Source = new Microsoft.Xna.Framework.Rectangle(0, 2, this.texture2D_0.Width, this.texture2D_0.Height);
            }
            this.list_0 = list;
            this.list_1 = list2;
            return horizontal;
        }

        private void method_0()
        {
            float interval = 5f;
            List<Enum2> list = new List<Enum2>();
            if (this.list_2 != null)
            {
                list.AddRange(this.list_2);
                this.list_2.Clear();
            }
            if (this.list_3 != null)
            {
                list.AddRange(this.list_3);
                this.list_3.Clear();
            }
            while (list.Count > 0)
            {
                Enum2 enum2 = list[0];
                list.RemoveAt(0);
                try
                {
                    LKJSoundInfo info = this.dictionary_1[enum2];
                    interval = info.Interval;
                    if (info.LastPlayTime < (this.float_5 - interval))
                    {
                        SoundPlayer sound = null;
                        if (info.Sound != null)
                        {
                            sound = info.Sound;
                        }
                        else
                        {
                            sound = new SoundPlayer(Path.Combine(base.Owner.Viewer.ContentPath + @"\LKJ2000", info.Name + ".wav"));
                        }
                        sound.Play();
                        info.LastPlayTime = this.float_5;
                        info.Sound = sound;
                    }
                    continue;
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private float method_1(float float_7)
        {
            if (!MPManager.IsMultiPlayer())
            {
                return float_7;
            }
            float num = base.Owner.Viewer.PlayerTrain.IsFreight ? (float_7 - 14.5f) : float_7;
            if (num >= 0f)
            {
                return num;
            }
            return 0f;
        }

        private void method_2(List<Enum2> zLaKpjrdkty5aSX6qt)
        {
            Train playerTrain = base.Owner.Viewer.PlayerTrain;
            Traveller traveller = (playerTrain.MUDirection == Direction.Reverse) ? playerTrain.RearTDBTraveller : playerTrain.FrontTDBTraveller;
            Traveller traveller2 = (playerTrain.MUDirection == Direction.Reverse) ? new Traveller(playerTrain.RearTDBTraveller, Traveller.TravellerDirection.Backward) : new Traveller(playerTrain.FrontTDBTraveller, Traveller.TravellerDirection.Forward);
            traveller2.Move(-1000f);
            traveller2.NextSection();
            float x = 0f;
            x = -traveller2.DistanceTo(traveller.TileX, traveller.TileZ, traveller.X, traveller.Y, traveller.Z, (float)1200f);
            if (x > 0f)
            {
                x = -WorldLocation.GetDistance2D(traveller2.WorldLocation, traveller.WorldLocation).Length();
            }
            float y = 0f;
            int radius = 0;
            int num4 = 6;
            float num5 = 100000f;
            SortedDictionary<int, int> source = new SortedDictionary<int, int>();
            SortedDictionary<int, float> dictionary2 = new SortedDictionary<int, float>();
            List<Vector2> list = new List<Vector2>();
            Orts.Formats.Msts.TrackSection section = null;
            float num6 = traveller2.Y;
            dictionary2.Add((int)x, num6);
            TrVectorSection currentSection = traveller2.GetCurrentSection();
            if (currentSection != null)
            {
                section = base.Owner.Viewer.Simulator.TSectionDat.TrackSections.Get(currentSection.SectionIndex);
                if (section == null)
                {
                    y = 0f;
                }
                else
                {
                    y = (section.SectionCurve != null) ? (section.SectionCurve.Radius * Math.Abs(MathHelper.ToRadians(section.SectionCurve.Angle))) : ((section.SectionSize != null) ? section.SectionSize.Length : 0f);
                }
                if ((section != null) && (section.SectionCurve != null))
                {
                    radius = (int)section.SectionCurve.Radius;
                    if (radius >= 0xfa0)
                    {
                        num4 = 1;
                    }
                    else if (radius >= 0x7d0)
                    {
                        num4 = 2;
                    }
                    else if (radius >= 0x3e8)
                    {
                        num4 = 3;
                    }
                    else if (radius >= 500)
                    {
                        num4 = 4;
                    }
                    else if (radius >= 250)
                    {
                        num4 = 5;
                    }
                    if ((((traveller2.Direction == Traveller.TravellerDirection.Forward) ? 1 : -1) * -Math.Sign(section.SectionCurve.Angle)) < 0)
                    {
                        radius = -radius;
                        num4 = -num4;
                    }
                    source.Add((int)x, num4);
                }
            }
            try
            {
                if (base.Owner.Viewer.Simulator.TSectionDat.TrackShapes.Get(currentSection.ShapeIndex).TunnelShape)
                {
                    list.Add(new Vector2(x, y));
                }
            }
            catch
            {
            }
            Dictionary<int, string> dictionary3 = new Dictionary<int, string>();
            int trackNodeIndex = traveller2.TrackNodeIndex;
            x += y;
            TrJunctionNode trJunctionNode = null;
        Label_027E:
            if (!traveller2.NextSection() || traveller2.IsEnd)
            {
                goto Label_04CE;
            }
            if ((traveller2.IsJunction && (x > 0f)) && (x < num5))
            {
                num5 = x;
                trJunctionNode = base.Owner.Viewer.Simulator.TDB.TrackDB.TrackNodes[traveller2.TrackNodeIndex].TrJunctionNode;
            }
            currentSection = traveller2.GetCurrentSection();
            if (currentSection == null)
            {
                goto Label_027E;
            }
            section = base.Owner.Viewer.Simulator.TSectionDat.TrackSections.Get(currentSection.SectionIndex);
            if (section == null)
            {
                goto Label_027E;
            }
            y = (section.SectionCurve != null) ? (section.SectionCurve.Radius * Math.Abs(MathHelper.ToRadians(section.SectionCurve.Angle))) : ((section.SectionSize != null) ? section.SectionSize.Length : 0f);
            if (section.SectionSize == null)
            {
                goto Label_027E;
            }
            if (trackNodeIndex != traveller2.TrackNodeIndex)
            {
                trackNodeIndex = traveller2.TrackNodeIndex;
                this.method_3(trackNodeIndex, dictionary3, (int)x, traveller2);
            }
            if (!dictionary2.ContainsKey((int)x))
            {
                dictionary2.Add((int)x, currentSection.Y);
            }
            if (section.SectionCurve != null)
            {
                int num8 = -Math.Sign(section.SectionCurve.Angle);
                int num9 = (int)section.SectionCurve.Radius;
                num4 = 6;
                if (num9 >= 0xfa0)
                {
                    num4 = 1;
                }
                else if (num9 >= 0x7d0)
                {
                    num4 = 2;
                }
                else if (num9 >= 0x3e8)
                {
                    num4 = 3;
                }
                else if (num9 >= 500)
                {
                    num4 = 4;
                }
                else if (num9 >= 250)
                {
                    num4 = 5;
                }
                if ((((traveller2.Direction == Traveller.TravellerDirection.Forward) ? 1 : -1) * num8) < 0)
                {
                    num9 = -num9;
                    num4 = -num4;
                }
                if (radius != num9)
                {
                    radius = num9;
                    if (!source.ContainsKey((int)x))
                    {
                        source.Add((int)x, num4);
                    }
                }
            }
            else
            {
                if ((radius != 0) && !source.ContainsKey((int)x))
                {
                    source.Add((int)x, 0);
                }
                radius = 0;
            }
            try
            {
                if (base.Owner.Viewer.Simulator.TSectionDat.TrackShapes.Get(currentSection.ShapeIndex).TunnelShape)
                {
                    list.Add(new Vector2(x, y));
                }
                goto Label_04C6;
            }
            catch
            {
                goto Label_04C6;
            }
        Label_04BC:
            x += y;
            goto Label_027E;
        Label_04C6:
            if (x <= 5000f)
            {
                goto Label_04BC;
            }
        Label_04CE:
            if (source.Count > 0)
            {
                int local1 = source.First<KeyValuePair<int, int>>().Value;
                int num10 = source.Last<KeyValuePair<int, int>>().Value;
                if (!source.ContainsKey(-1000))
                {
                    source.Add(-1000, 0);
                }
                if (!source.ContainsKey(0x1388))
                {
                    source.Add(0x1388, num10);
                }
            }
            this.sortedDictionary_2 = source;
            SortedDictionary<int, int> dictionary4 = new SortedDictionary<int, int>();
            x = 0f;
            int index = 0;
            for (int i = 0; i < (dictionary2.Count - 1); i++)
            {
                x += (float)(dictionary2.ElementAt<KeyValuePair<int, float>>((i + 1)).Key - dictionary2.ElementAt<KeyValuePair<int, float>>(i).Key);
                if (x > 150f)
                {
                    float num13 = dictionary2.ElementAt<KeyValuePair<int, float>>((i + 1)).Value - dictionary2.ElementAt<KeyValuePair<int, float>>(index).Value;
                    if (num13 < 0f)
                    {
                        num13 = (float)Math.Floor((double)(((num13 / x) * 100f) - 0.7));
                    }
                    else
                    {
                        num13 = (float)Math.Floor((double)(((num13 / x) * 100f) + 0.7));
                    }
                    dictionary4.Add(dictionary2.ElementAt<KeyValuePair<int, float>>((i + 1)).Key, (int)num13);
                    index = i;
                    x = 0f;
                }
            }
            SortedDictionary<int, int> dictionary5 = new SortedDictionary<int, int>();
            index = 0;
            for (int j = 0; j < (dictionary4.Count - 1); j++)
            {
                if (dictionary4.ElementAt<KeyValuePair<int, int>>(index).Value == 0)
                {
                    if (dictionary4.ElementAt<KeyValuePair<int, int>>((j + 1)).Value != dictionary4.ElementAt<KeyValuePair<int, int>>(index).Value)
                    {
                        dictionary5.Add(dictionary4.ElementAt<KeyValuePair<int, int>>(j).Key, dictionary4.ElementAt<KeyValuePair<int, int>>(index).Value);
                        index = j + 1;
                    }
                }
                else if (dictionary4.ElementAt<KeyValuePair<int, int>>(index).Value < 0)
                {
                    if (dictionary4.ElementAt<KeyValuePair<int, int>>((j + 1)).Value >= 0)
                    {
                        dictionary5.Add(dictionary4.ElementAt<KeyValuePair<int, int>>(j).Key, dictionary4.ElementAt<KeyValuePair<int, int>>(index).Value);
                        index = j + 1;
                    }
                }
                else if (dictionary4.ElementAt<KeyValuePair<int, int>>((j + 1)).Value <= 0)
                {
                    dictionary5.Add(dictionary4.ElementAt<KeyValuePair<int, int>>(j).Key, dictionary4.ElementAt<KeyValuePair<int, int>>(index).Value);
                    index = j + 1;
                }
            }
            if (!dictionary5.ContainsKey(-1000))
            {
                dictionary5.Add(-1000, 0);
            }
            this.sortedDictionary_3 = dictionary5;
            List<Vector2> list2 = null;
            if (list.Count > 0)
            {
                list2 = new List<Vector2>();
                index = -1;
                foreach (Vector2 vector in list)
                {
                    if (index == -1)
                    {
                        list2.Add(vector);
                        index = 0;
                    }
                    else
                    {
                        float num15 = list2.ElementAt<Vector2>(index).X;
                        float num16 = list2.ElementAt<Vector2>(index).Y;
                        if (vector.X <= ((num15 + num16) + 1f))
                        {
                            list2.RemoveAt(index);
                            list2.Add(new Vector2(num15, num16 + vector.Y));
                        }
                        else
                        {
                            list2.Add(vector);
                            index++;
                        }
                    }
                }
            }
            this.list_4 = list2;
            this.dictionary_0 = dictionary3;
            if (((num5 < 500f) && ((Math.Abs(playerTrain.SpeedMpS) * 10f) > num5)) && (trJunctionNode != null))
            {
                TrackShape shape2 = base.Owner.Viewer.Simulator.TSectionDat.TrackShapes.Get(trJunctionNode.ShapeIndex);
                if ((shape2 != null) && (trJunctionNode.SelectedRoute != shape2.MainRoute))
                {
                    zLaKpjrdkty5aSX6qt.Add((Enum2)15);
                }
            }
        }

        private void method_3(int int_8, Dictionary<int, string> YXAawhAID7G3YHfQQJ, int int_9, Traveller traveller_0)
        {
            TrItem[] trItemTable = base.Owner.Viewer.Simulator.TDB.TrackDB.TrItemTable;
            TrackNode[] trackNodes = base.Owner.Viewer.Simulator.TDB.TrackDB.TrackNodes;
            TrackSectionsFile tSectionDat = base.Owner.Viewer.Simulator.TSectionDat;
            TrackDatabaseFile tDB = base.Owner.Viewer.Simulator.TDB;
            if (!trackNodes[int_8].TrEndNode && ((trackNodes[int_8].TrVectorNode != null) && (trackNodes[int_8].TrVectorNode.NoItemRefs > 0)))
            {
                for (int i = 0; i < trackNodes[int_8].TrVectorNode.NoItemRefs; i++)
                {
                    if (trItemTable[trackNodes[int_8].TrVectorNode.TrItemRefs[i]] != null)
                    {
                        int index = trackNodes[int_8].TrVectorNode.TrItemRefs[i];
                        if ((trItemTable[index].ItemType == TrItem.trItemType.trSIDING) || (trItemTable[index].ItemType == TrItem.trItemType.const_4))
                        {
                            int key = int_9 + ((int)traveller_0.DistanceTo(trItemTable[index].TileX, trItemTable[index].TileZ, trItemTable[index].X, trItemTable[index].Y, trItemTable[index].Z, (float)1000f));
                            string itemName = trItemTable[index].ItemName;
                            PlatformItem item = trItemTable[index] as PlatformItem;
                            if (item != null)
                            {
                                itemName = item.Station;
                            }
                            if (!YXAawhAID7G3YHfQQJ.ContainsKey(key) && !YXAawhAID7G3YHfQQJ.ContainsValue(itemName))
                            {
                                YXAawhAID7G3YHfQQJ.Add(key, itemName);
                            }
                        }
                    }
                }
            }
        }

        public void ORDPTabAction(bool XY)
        {
            Simulator simulator = base.Owner.Viewer.Simulator;
            this.int_1 = 20;
            Train playerTrain = base.Owner.Viewer.PlayerTrain;
            float dispatcherMaxSpeedMpS = playerTrain.DispatcherMaxSpeedMpS;
            if (MPManager.IsMultiPlayer())
            {
                if (MPManager.Instance().CheckSpad)
                {
                    dispatcherMaxSpeedMpS = (int)Math.Min(Math.Min(simulator.TRK.Tr_RouteFile.SpeedLimit, (double)playerTrain.TrainMaxSpeedMpS), (double)playerTrain.DispatcherMaxSpeedMpS);
                }
            }
            else
            {
                dispatcherMaxSpeedMpS = (int)Math.Min(simulator.TRK.Tr_RouteFile.SpeedLimit, (double)playerTrain.TrainMaxSpeedMpS);
            }
            if (dispatcherMaxSpeedMpS > 50f)
            {
                this.int_1 = 40;
            }
            if (dispatcherMaxSpeedMpS < 25f)
            {
                this.int_1 = 10;
            }
            if (XY)
            {
                this.float_6 = 1.1f;
            }
            else
            {
                this.float_6 = 0.9090909f;
            }
            int_0 = (int)(int_0 * this.float_6);
            if (int_0 < 200)
            {
                int_0 = 200;
            }
            if (int_0 > base.Owner.ScreenSize.Y)
            {
                int_0 = base.Owner.ScreenSize.Y;
            }
            base.SizeTo(((int)(int_0 * 1.33)) - 5, int_0 - 5);
            this.windowTextFont_0 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 25f)), FontStyle.Bold);
            this.windowTextFont_1 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 45f)), FontStyle.Bold);
            this.windowTextFont_2 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 60f)), FontStyle.Bold);
            this.SizeChanged();
        }

        public override void PrepareFrame(ElapsedTime elapsedTime, bool updateFull)
        {
            this.float_0 += elapsedTime.ClockSeconds;
            this.float_5 += elapsedTime.ClockSeconds;
            Train playerTrain = base.Owner.Viewer.PlayerTrain;
            Train.TrainInfo trainInfo = playerTrain.GetTrainInfo();
            float speed = Math.Abs(trainInfo.speedMpS);
            bool flag = false;
            float allowedSpeedMpS = trainInfo.allowedSpeedMpS;
            if (MPManager.IsMultiPlayer())
            {
                allowedSpeedMpS = MPManager.Instance().CheckSpad ? Math.Min(allowedSpeedMpS, playerTrain.DispatcherMaxSpeedMpS) : playerTrain.DispatcherMaxSpeedMpS;
            }
            float num5 = MpS.FromMpS(allowedSpeedMpS, true);
            if (this.float_0 > 5f)
            {
                this.float_0 = 0f;
                for (int i = 0; i < 10; i++)
                {
                    this.int_2[i] = this.int_2[i + 1];
                    this.int_3[i] = this.int_3[i + 1];
                }
                this.int_2[10] = (int)MpS.FromMpS(speed, true);
                this.int_3[10] = (int)MpS.FromMpS(allowedSpeedMpS, true);
            }
            if (base.Visible)
            {
                if (this.int_5 != ((int)playerTrain.DispatcherMaxSpeedMpS))
                {
                    this.int_5 = (int)playerTrain.DispatcherMaxSpeedMpS;
                    this.Redraw();
                }
                base.PrepareFrame(elapsedTime, updateFull);
                this.float_1 += elapsedTime.ClockSeconds;
                if (this.float_1 > 2f)
                {
                    this.float_1 = 0f;
                    flag = true;
                }
                this.int_4 = (int)Math.Min(950f, playerTrain.Length);
                List<Enum2> list = new List<Enum2>();
                this.freeLabel_0.Text = string.Format("{0,3:###}", MpS.FromMpS(speed, true));
                if (this.freeLabel_0.Text == "   ")
                {
                    this.freeLabel_0.Text = "  0";
                }
                this.freeLabel_1.Text = string.Format("{0,3:###}", num5);
                if (this.freeLabel_1.Text == "   ")
                {
                    this.freeLabel_1.Text = "  0";
                }
                if (speed > Math.Abs((double)(allowedSpeedMpS * 1.01)))
                {
                    list.Add((Enum2)9);
                }
                float num3 = 100001f;
                int num4 = 3;
                SortedDictionary<int, int> source = new SortedDictionary<int, int>();
                source.Add(0, (int)num5);
                Microsoft.Xna.Framework.Rectangle rectangle = this.dictionary_2[TrackMonitorSignalAspect.None];
                List<Train.TrainObjectItem> objectInfoForward = trainInfo.ObjectInfoForward;
                if (trainInfo.direction == 1)
                {
                    objectInfoForward = trainInfo.ObjectInfoBackward;
                }
                TrackMonitorSignalAspect none = TrackMonitorSignalAspect.None;
                Train.TrainObjectItem item = null;
                SortedDictionary<int, Train.TrainObjectItem> dictionary2 = new SortedDictionary<int, Train.TrainObjectItem>();
                foreach (Train.TrainObjectItem item2 in objectInfoForward)
                {
                    int distanceToTrainM = (int)item2.DistanceToTrainM;
                    if (item2.ItemType == Train.TrainObjectItem.TRAINOBJECTTYPE.SIGNAL)
                    {
                        if (distanceToTrainM < num3)
                        {
                            item = item2;
                            num3 = distanceToTrainM;
                            none = item2.SignalState;
                            if ((item2.SignalState != TrackMonitorSignalAspect.Clear_1) && (item2.SignalState != TrackMonitorSignalAspect.Clear_2))
                            {
                                if (((item2.SignalState != TrackMonitorSignalAspect.Approach_1) && (item2.SignalState != TrackMonitorSignalAspect.Approach_2)) && (item2.SignalState != TrackMonitorSignalAspect.Approach_3))
                                {
                                    num4 = 2;
                                }
                                else
                                {
                                    num4 = 1;
                                }
                            }
                            else
                            {
                                num4 = 0;
                            }
                            rectangle = this.dictionary_2[item2.SignalState];
                        }
                        if (!dictionary2.ContainsKey(distanceToTrainM))
                        {
                            dictionary2.Add(distanceToTrainM, item2);
                        }
                        if (((item2.SignalState == TrackMonitorSignalAspect.Stop) && !source.ContainsKey(distanceToTrainM)) && (distanceToTrainM < 0x1388))
                        {
                            source.Add(distanceToTrainM, 0);
                        }
                        if (item2.AllowedSpeedMpS >= 0f)
                        {
                            allowedSpeedMpS = (float)base.Owner.Viewer.Simulator.TRK.Tr_RouteFile.SpeedLimit;
                            if (MPManager.IsMultiPlayer())
                            {
                                allowedSpeedMpS = MPManager.Instance().CheckSpad ? Math.Min(allowedSpeedMpS, playerTrain.DispatcherMaxSpeedMpS) : playerTrain.DispatcherMaxSpeedMpS;
                            }
                            else
                            {
                                allowedSpeedMpS = Math.Min(allowedSpeedMpS, playerTrain.AllowedMaxSpeedMpS);
                            }
                            if (item2.AllowedSpeedMpS < allowedSpeedMpS)
                            {
                                if (MPManager.Instance().CheckSpad && MPManager.IsMultiPlayer())
                                {
                                    allowedSpeedMpS = item2.AllowedSpeedMpS;
                                }
                                else if (!MPManager.IsMultiPlayer())
                                {
                                    allowedSpeedMpS = item2.AllowedSpeedMpS;
                                }
                            }
                            if (!source.ContainsKey(distanceToTrainM) && (distanceToTrainM < 0x1388))
                            {
                                source.Add(distanceToTrainM, (int)MpS.FromMpS(allowedSpeedMpS, true));
                            }
                        }
                    }
                    else if ((item2.ItemType == Train.TrainObjectItem.TRAINOBJECTTYPE.SPEEDPOST) && (item2.AllowedSpeedMpS >= 0f))
                    {
                        allowedSpeedMpS = (float)base.Owner.Viewer.Simulator.TRK.Tr_RouteFile.SpeedLimit;
                        if (MPManager.IsMultiPlayer())
                        {
                            allowedSpeedMpS = MPManager.Instance().CheckSpad ? Math.Min(allowedSpeedMpS, playerTrain.DispatcherMaxSpeedMpS) : playerTrain.DispatcherMaxSpeedMpS;
                        }
                        else
                        {
                            allowedSpeedMpS = Math.Min(allowedSpeedMpS, playerTrain.AllowedMaxSpeedMpS);
                        }
                        if (item2.AllowedSpeedMpS < allowedSpeedMpS)
                        {
                            if (MPManager.Instance().CheckSpad && MPManager.IsMultiPlayer())
                            {
                                allowedSpeedMpS = item2.AllowedSpeedMpS;
                            }
                            else if (!MPManager.IsMultiPlayer())
                            {
                                allowedSpeedMpS = item2.AllowedSpeedMpS;
                            }
                        }
                        if (!source.ContainsKey(distanceToTrainM) && (distanceToTrainM < 0x1388))
                        {
                            source.Add(distanceToTrainM, (int)MpS.FromMpS(allowedSpeedMpS, true));
                        }
                    }
                }
                this.freeLabel_4.Text = string.Format("{0:#,0.000}", playerTrain.DistanceTravelledM / 1000f);
                double clockTime = base.Owner.Viewer.Simulator.ClockTime;
                this.freeLabel_5.Text = DateTime.Now.ToString("yyyy-MM-dd");
                this.freeLabel_6.Text = FormatStrings.FormatTime(clockTime);
                int num9 = source.Last<KeyValuePair<int, int>>().Value;
                source.Add(0x1388, num9);
                this.freeLabel_2.Text = string.Format("{0}", num3);
                if (this.freeLabel_2.Text == "  ")
                {
                    this.freeLabel_2.Text = " 0";
                }
                if (num3 >= 100000f)
                {
                    this.freeLabel_2.Text = "  ";
                }
                switch (num4)
                {
                    case 0:
                        this.freeLabel_2.Color = Microsoft.Xna.Framework.Color.Yellow;
                        this.freeLabel_3.Text = "通过";
                        this.freeLabel_3.Color = Microsoft.Xna.Framework.Color.DarkGreen;
                        break;

                    case 1:
                        this.freeLabel_2.Color = Microsoft.Xna.Framework.Color.Yellow;
                        this.freeLabel_3.Text = "进出站";
                        this.freeLabel_3.Color = Microsoft.Xna.Framework.Color.DarkOrange;
                        break;

                    case 2:
                        this.freeLabel_2.Color = Microsoft.Xna.Framework.Color.Yellow;
                        this.freeLabel_3.Text = "停车";
                        this.freeLabel_3.Color = Microsoft.Xna.Framework.Color.DarkRed;
                        break;

                    default:
                        this.freeLabel_2.Color = Microsoft.Xna.Framework.Color.Yellow;
                        this.freeLabel_3.Text = "白码";
                        this.freeLabel_3.Color = Microsoft.Xna.Framework.Color.Silver;
                        break;
                }
                if (((source.Count > 1) && (((float)source.ElementAt<KeyValuePair<int, int>>(1).Value) < num5)) && (((float)source.ElementAt<KeyValuePair<int, int>>(1).Key) < (speed * 100f)))
                {
                    list.Add((Enum2)0x12);
                }
                if ((none != this.trackMonitorSignalAspect_0) || (((this.trainObjectItem_0 != null) && (item != null)) && (Math.Abs((float)(this.trainObjectItem_0.DistanceToTrainM - item.DistanceToTrainM)) > 100f)))
                {
                    switch (none)
                    {
                        case TrackMonitorSignalAspect.None:
                            list.Add((Enum2)10);
                            break;

                        case TrackMonitorSignalAspect.Clear_2:
                            list.Add((Enum2)3);
                            break;

                        case TrackMonitorSignalAspect.Clear_1:
                            list.Add((Enum2)4);
                            break;

                        case TrackMonitorSignalAspect.Approach_3:
                            list.Add((Enum2)5);
                            break;

                        case TrackMonitorSignalAspect.Approach_2:
                            list.Add((Enum2)6);
                            break;

                        case TrackMonitorSignalAspect.Approach_1:
                            list.Add((Enum2)8);
                            break;

                        case TrackMonitorSignalAspect.Restricted:
                        case TrackMonitorSignalAspect.StopAndProceed:
                        case TrackMonitorSignalAspect.Stop:
                            list.Add((Enum2)7);
                            break;
                    }
                }
                this.trainObjectItem_0 = item;
                try
                {
                    this.QsvlTrcbyT();
                    if (flag)
                    {
                        this.method_2(list);
                        this.sortedDictionary_1 = dictionary2;
                        this.sortedDictionary_0 = source;
                        this.iktvWpoiXH = rectangle;
                        if (MPManager.IsMultiPlayer() && (this.bool_1 != MPManager.diaoche))
                        {
                            this.bool_1 = MPManager.diaoche;
                            if (this.bool_1)
                            {
                                if (this.colorBox_1.Counter == 1)
                                {
                                    this.colorBox_1.SwitchColor();
                                    list.Add((Enum2)13);
                                }
                            }
                            else if (this.colorBox_1.Counter == 0)
                            {
                                this.colorBox_1.SwitchColor();
                                list.Add((Enum2)12);
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    string stackTrace = exception.StackTrace;
                    base.Owner.Viewer.Simulator.Confirmer.Information(exception.StackTrace);
                }
                MSTSLocomotive playerLocomotive = (MSTSLocomotive)base.Owner.Viewer.PlayerLocomotive;
                if (((((playerLocomotive != null) && (num3 > 20f)) && ((speed > 5f) && (num3 < (speed * 10f)))) && ((none == TrackMonitorSignalAspect.Stop) || (none == TrackMonitorSignalAspect.Restricted))) && !playerLocomotive.Train.tubian)
                {
                    list.Add((Enum2)14);
                }
                if ((((speed > 0.1) && (speed < 1f)) && ((playerLocomotive != null) && (playerLocomotive.ThrottlePercent < 1f))) && ((playerLocomotive.CurrentElevationPercent > 0.4) || (playerLocomotive.CurrentElevationPercent < -0.4)))
                {
                    list.Add((Enum2)0x11);
                }
                this.list_2 = list;
                this.trackMonitorSignalAspect_0 = none;
            }
        }

        private void QsvlTrcbyT()
        {
            Train playerTrain = base.Owner.Viewer.PlayerTrain;
            TrainCar playerLocomotive = base.Owner.Viewer.PlayerLocomotive;
            if (MPManager.IsMultiPlayer())
            {
                this.string_1 = playerTrain.trainchangename;
                this.string_2 = MPManager.GetUserName();
            }
            else
            {
                this.string_2 = "001";
                if (playerTrain.IsFreight)
                {
                    this.string_1 = "50011";
                }
                else
                {
                    this.string_1 = "T1";
                }
            }
            this.int_6 = (int)(playerTrain.MassKg / 1000f);
            List<TrainCar> cars = playerTrain.Cars;
            if (cars != null)
            {
                this.int_7 = cars.Count;
            }
            else
            {
                this.int_7 = 1;
            }
            this.float_2 = ((float)this.int_4) / 11f;
            if (playerTrain.IsFreight)
            {
                this.string_3 = "货车";
            }
            else
            {
                this.string_3 = "客车";
            }
            if (playerLocomotive == playerTrain.FirstCar)
            {
                this.string_3 = this.string_3 + "本务机";
            }
            else
            {
                this.string_3 = this.string_3 + "补机";
            }
            this.float_3 = playerLocomotive.DriverWheelRadiusM * 2000f;
            MSTSDieselLocomotive locomotive = playerLocomotive as MSTSDieselLocomotive;
            if ((locomotive != null) && (locomotive.DieselEngines[0] != null))
            {
                this.bool_2 = false;
                this.float_4 = locomotive.DieselEngines[0].RealRPM;
            }
            MSTSElectricLocomotive locomotive3 = playerLocomotive as MSTSElectricLocomotive;
            if (locomotive3 != null)
            {
                this.bool_2 = true;
                this.scovxkRuRD = locomotive3.LocomotivePowerSupply.ElectricTrainSupplyOn;
            }
            if (playerTrain.MUDirection == Direction.Forward)
            {
                this.string_4 = "向前 ";
            }
            else if (playerTrain.MUDirection == Direction.Reverse)
            {
                this.string_4 = "向后 ";
            }
            else
            {
                this.string_4 = "中位 ";
            }
            MSTSLocomotive locomotive2 = playerLocomotive as MSTSLocomotive;
            if (locomotive2 != null)
            {
                this.string_6 = FormatStrings.FormatPressure(this.method_1(playerTrain.EqualReservoirPressurePSIorInHg), PressureUnit.PSI, locomotive2.MainPressureUnit, true);
                this.string_5 = FormatStrings.FormatPressure(this.method_1(locomotive2.BrakeSystem.BrakeLine1PressurePSI), PressureUnit.PSI, locomotive2.MainPressureUnit, true);
                this.string_7 = FormatStrings.FormatPressure(this.method_1(locomotive2.BrakeSystem.GetCylPressurePSI()), PressureUnit.PSI, locomotive2.MainPressureUnit, true);
                this.string_4 = this.string_4 + ((int)locomotive2.ThrottlePercent);
                this.string_4 = this.string_4 + "%";
            }
        }

        public void Redraw()
        {
            Simulator simulator = base.Owner.Viewer.Simulator;
            Train playerTrain = base.Owner.Viewer.PlayerTrain;
            this.int_1 = 20;
            float dispatcherMaxSpeedMpS = playerTrain.DispatcherMaxSpeedMpS;
            if (MPManager.IsMultiPlayer())
            {
                if (MPManager.Instance().CheckSpad)
                {
                    dispatcherMaxSpeedMpS = (int)Math.Min(Math.Min(simulator.TRK.Tr_RouteFile.SpeedLimit, (double)playerTrain.TrainMaxSpeedMpS), (double)playerTrain.DispatcherMaxSpeedMpS);
                }
            }
            else
            {
                dispatcherMaxSpeedMpS = (int)Math.Min(simulator.TRK.Tr_RouteFile.SpeedLimit, (double)playerTrain.TrainMaxSpeedMpS);
            }
            if (dispatcherMaxSpeedMpS > 50f)
            {
                this.int_1 = 40;
            }
            if (dispatcherMaxSpeedMpS < 25f)
            {
                this.int_1 = 10;
            }
            base.SizeTo(((int)(int_0 * 1.33)) - 5, int_0 - 5);
            this.windowTextFont_0 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 25f)), FontStyle.Bold);
            this.windowTextFont_1 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 45f)), FontStyle.Bold);
            this.windowTextFont_2 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 60f)), FontStyle.Bold);
            this.SizeChanged();
        }

        public override void TabAction()
        {
            Simulator simulator = base.Owner.Viewer.Simulator;
            this.int_1 = 20;
            Train playerTrain = base.Owner.Viewer.PlayerTrain;
            float dispatcherMaxSpeedMpS = playerTrain.DispatcherMaxSpeedMpS;
            if (MPManager.IsMultiPlayer())
            {
                if (MPManager.Instance().CheckSpad)
                {
                    dispatcherMaxSpeedMpS = (int)Math.Min(Math.Min(simulator.TRK.Tr_RouteFile.SpeedLimit, (double)playerTrain.TrainMaxSpeedMpS), (double)playerTrain.DispatcherMaxSpeedMpS);
                }
            }
            else
            {
                dispatcherMaxSpeedMpS = (int)Math.Min(simulator.TRK.Tr_RouteFile.SpeedLimit, (double)playerTrain.TrainMaxSpeedMpS);
            }
            if (dispatcherMaxSpeedMpS > 50f)
            {
                this.int_1 = 40;
            }
            if (dispatcherMaxSpeedMpS < 25f)
            {
                this.int_1 = 10;
            }
            int_0 = (int)(int_0 * this.float_6);
            if (int_0 > base.Owner.ScreenSize.Y)
            {
                this.float_6 = 0.9090909f;
                int_0 = base.Owner.ScreenSize.Y;
            }
            if (int_0 < 200)
            {
                this.float_6 = 1.1f;
                int_0 = 200;
            }
            base.SizeTo(((int)(int_0 * 1.33)) - 5, int_0 - 5);
            this.windowTextFont_0 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 25f)), FontStyle.Bold);
            this.windowTextFont_1 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 45f)), FontStyle.Bold);
            this.windowTextFont_2 = base.Owner.TextManager.GetExact("Arial", (float)((int)(((float)int_0) / 60f)), FontStyle.Bold);
            this.SizeChanged();
        }

        private enum Enum2
        {
        }
    }
}

