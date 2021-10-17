using System;
using System.Media;

namespace Orts.Viewer3D.Popups
{
    public class LKJSoundInfo
    {
        public float Interval;
        public float LastPlayTime;
        public string Name;
        public SoundPlayer Sound;

        public LKJSoundInfo(string name, float last, SoundPlayer s, float interval)
        {
            this.Name = name;
            this.LastPlayTime = last;
            this.Sound = s;
            this.Interval = interval;
        }
    }
}

