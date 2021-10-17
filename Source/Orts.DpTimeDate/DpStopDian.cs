using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Orts.DpTimeDate
{
    public class DpStopDian
    {
        public Dictionary<string, double> DateTingZhan;
        public List<DpStopList> DpStoplis;
        public ArrayList jiaoluming;
        public ArrayList zhanming;

        public DpStopDian()
        {
            this.DateTingZhan = new Dictionary<string, double>();
            this.zhanming = new ArrayList();
            this.jiaoluming = new ArrayList();
            this.DpStoplis = new List<DpStopList>();
        }

        public void DpGetDateForDateBase(string zhan)
        {
            this.DateTingZhan.Clear();
            string connectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + @"\DpTimeDate\\yxt.mdb";
            string cmdText = "SELECT * FROM " + zhan + " Order By id";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();
            OleDbDataReader reader = new OleDbCommand(cmdText, connection).ExecuteReader();
            while (reader.Read())
            {
                this.DateTingZhan.Add(reader.GetString(1), reader.GetDouble(2));
                this.zhanming.Add(reader.GetString(1));
            }
            reader.Close();
            connection.Close();
        }

        public double jialuaddtime(string zhanming, double dou)
        {
            foreach (object obj2 in this.jiaoluming)
            {
                if (obj2.Equals(zhanming))
                {
                    return (dou + (new Random().Next(12, 20) * 60));
                }
            }
            return dou;
        }

        public void jisuanzhanjianlicheng(bool xuanze, double xiansu, string checi, bool zhidongsudu, double double_0)
        {
            if (xiansu < 1.0)
            {
                MessageBox.Show("列车限速为零，图定失效");
            }
            else
            {
                int num;
                int num2;
                if (xuanze)
                {
                    if (this.zhanming.Count == 0)
                    {
                        this.DpStoplis.Clear();
                        return;
                    }
                    this.DpStoplis.Clear();
                    num = 0;
                    num2 = 0;
                    DpStopList item = new DpStopList
                    {
                        DpZhanName = this.zhanming[0].ToString(),
                        DpDaoTime = "--:--:--",
                        FaCheTime = this.secondstotime(this.jialuaddtime(this.zhanming[0].ToString(), double_0 + (new Random().Next(2, 4) * 60))),
                        ZhanJuLi = "0"
                    };
                    this.DpStoplis.Add(item);
                    num2 = 1;
                    num = 1;
                }
                else
                {
                    num2 = 0;
                    if (this.DpStoplis.Count <= 0)
                    {
                        MessageBox.Show("没有时刻表，无法执行修改操作，只能新建");
                        return;
                    }
                    num = this.DpStoplis.Count<DpStopList>() - 1;
                    if (this.zhanming[num2].ToString() != this.DpStoplis[num].DpZhanName)
                    {
                        MessageBox.Show("前后车站名称不一致，请选择相同车站修改");
                        return;
                    }
                    this.DpStoplis[num].FaCheTime = this.secondstotime(this.jialuaddtime(this.zhanming[num2].ToString(), this.timetoseconds(this.DpStoplis[num].DpDaoTime) + (new Random().Next(3, 7) * 60)));
                    num2++;
                    num++;
                }
                int num7 = 0;
                int num9 = 0;
                while (num2 < this.zhanming.Count)
                {
                    if (this.DpStoplis.Count >= 15)
                    {
                        MessageBox.Show("停站数超过15，自动截断，可重新安排停站");
                        break;
                    }
                    string dpZhanName = this.DpStoplis[num - 1].DpZhanName;
                    string zhanming = this.zhanming[num2].ToString();
                    double num3 = this.timetoseconds(this.DpStoplis[num - 1].FaCheTime);
                    double num4 = this.DateTingZhan[dpZhanName];
                    double num5 = this.DateTingZhan[zhanming];
                    double num6 = (Math.Abs((double)(num5 - num4)) / (xiansu - 5.0)) * 3600.0;
                    double clockTimeSeconds = (num3 + (num6 * ((1f + this.method_0(checi)) + (zhidongsudu ? 0.1f : 0f)))) + 300.0;
                    while (num7 == num9)
                    {
                        num7 = new Random().Next(3, 7);
                    }
                    num9 = num7;
                    double dou = clockTimeSeconds + (num7 * 60);
                    dou = this.jialuaddtime(zhanming, dou);
                    DpStopList list2 = new DpStopList
                    {
                        DpZhanName = this.zhanming[num2].ToString(),
                        DpDaoTime = this.secondstotime(clockTimeSeconds),
                        FaCheTime = this.secondstotime(dou),
                        ZhanJuLi = Math.Abs((double)(num5 - num4)).ToString()
                    };
                    this.DpStoplis.Add(list2);
                    num2++;
                    num++;
                }
                this.DpStoplis[num - 1].FaCheTime = "--:--:--";
            }
        }

        private float method_0(string string_0)
        {
            switch (string_0.Substring(0, 1))
            {
                case "G":
                    return 0.04f;

                case "D":
                    return 0.06f;

                case "C":
                    return 0.08f;

                case "Z":
                case "Q":
                    return 0.1f;

                case "T":
                    return 0.14f;

                case "K":
                    return 0.16f;

                case "L":
                case "Y":
                    return 0.2f;

                case "X":
                    return ((int.Parse(string_0.Substring(1, string_0.Length - 1)) <= 300) ? 0.12f : 0.18f);
            }
            return ((string_0.Length == 4) ? 0.18f : 0.24f);
        }

        public string secondstotime(double clockTimeSeconds)
        {
            int num = (int)(clockTimeSeconds / 3600.0);
            clockTimeSeconds -= (num * 60.0) * 60.0;
            int num2 = (int)(clockTimeSeconds / 60.0);
            clockTimeSeconds -= num2 * 60.0;
            int num3 = (int)clockTimeSeconds;
            if (num >= 0x18)
            {
                num = num % 0x18;
            }
            if (num < 0)
            {
                num += 0x18;
            }
            if (num2 < 0)
            {
                num2 += 60;
            }
            if (num3 < 0)
            {
                num3 += 60;
            }
            return string.Format("{0:D2}:{1:D2}:{2:D2}", num, num2, num3);
        }

        public double timetoseconds(string start)
        {
            string[] strArray = start.Split(new char[] { ':' });
            TimeSpan span = new TimeSpan(int.Parse(strArray[0]), (strArray.Length > 1) ? int.Parse(strArray[1]) : 0, (strArray.Length > 2) ? int.Parse(strArray[2]) : 0);
            return span.TotalSeconds;
        }
    }
}

