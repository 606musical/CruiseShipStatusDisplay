using Microsoft.Win32;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Windows.Graphics.Imaging;
using Windows.Media.Ocr;
using WinRT;
namespace CruiseShipStatusDisplay
{
    public partial class Form1 : Form
    {
        Point mousePoint;
        DateTime dat1, datX;
        TimeSpan dat2, dat3, wts, s2t, t2s, datA, ragA;
        DateTime[] sts = new DateTime[481];
        int[] rett = { 0 };
        int[] ccr = { 0 };
        string[] s2 = new string[6];
        string[] mod = { "" };
        string[] rcd = new string[6];
        string[] gcd = new string[6];
        string[] rsd = new string[6];
        string[] gsd = new string[6];
        string[] rsfile = { "rsd.txt", "gsd.txt", "rcd.txt", "gcd.txt" };
        string? now1, fix, fix2, fix3, fix4, scn, tmpx;
        int nv1, nv2, fbpc, chb = 0, fs, cb2ff, tc2, vu, fml, fmt, fmw, fmh, nResult, d2l, tbki, tbki2, tbki3, fmm, tcf, w11f, sss, ts04f;
        Point cms2;
        int[] cspht2s = { 56, 56, 56, 56, 56, 56, 56, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 143, 144, 145, 146, 147, 148, 148, 149, 150, 151, 152, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 177, 178, 179, 180, 181, 181, 183, 184, 184 };
        int[] cspvt2s = { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 37, 39, 40, 41, 42, 43, 44, 45, 45, 46, 47, 47, 46, 45, 44, 43, 42, 41, 40, 40, 39, 38, 37, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 38, 38, 38, 38, 38, 37, 37, 37, 36, 36, 36, 36, 35, 35, 35, 34, 34, 34, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 39, 38, 37, 36, 35, 34, 33, 32, 30, 31, 29, 28, 27, 26, 24, 25, 23, 22, 21, 19, 20, 18, 17, 17, 16, 15, 14, 13, 12, 11, 10, 9, 9, 8, 8, 7, 7, 7, 7, 7, 7, 8, 8, 9, 9, 10, 10, 11, 12, 13, 15, 16, 17 };
        int[] csphs2t = { 184, 184, 183, 181, 181, 180, 179, 178, 177, 175, 174, 173, 172, 171, 170, 169, 168, 167, 166, 165, 164, 163, 162, 161, 160, 159, 158, 157, 156, 155, 154, 153, 152, 152, 151, 150, 149, 148, 148, 147, 146, 145, 144, 143, 143, 142, 141, 140, 139, 138, 137, 136, 135, 134, 133, 132, 131, 130, 129, 128, 127, 126, 125, 124, 123, 122, 121, 120, 119, 118, 117, 116, 115, 114, 113, 112, 111, 110, 109, 108, 107, 106, 105, 104, 103, 102, 101, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 63, 62, 62, 61, 61, 60, 60, 59, 59, 58, 58, 57, 57, 56, 56, 56, 56, 56, 56, 56, 56, 56 };
        int[] cspvs2t = { 17, 16, 15, 13, 12, 11, 10, 10, 9, 9, 8, 8, 7, 7, 7, 7, 7, 7, 8, 8, 9, 9, 10, 11, 12, 13, 14, 15, 16, 17, 17, 18, 20, 19, 21, 22, 23, 25, 24, 26, 27, 28, 29, 31, 30, 32, 33, 34, 35, 36, 37, 38, 39, 39, 38, 38, 37, 37, 36, 36, 35, 35, 34, 34, 34, 34, 34, 35, 35, 35, 36, 36, 36, 36, 37, 37, 37, 38, 38, 38, 38, 38, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 37, 38, 39, 40, 40, 41, 42, 43, 44, 45, 46, 47, 47, 46, 45, 45, 44, 43, 42, 41, 40, 39, 37, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20 };
        Color fcC = Color.FromArgb(200, 200, 200);
        Color bcC = Color.FromArgb(90, 90, 90);
        Color fcD = Color.FromArgb(30, 30, 30);
        Color bcD = Color.FromArgb(240, 240, 240);
        Color tmpy;
        Bitmap mBm = new Bitmap(1, 1);
        DWM_WINDOW_CORNER_PREFERENCE DWMWCP_DONOTROUND;
        DWM_WINDOW_CORNER_PREFERENCE DWMWCP_ROUND;
        [ComImport]
        [Guid("5B0D3235-4DBA-4D44-865E-8F1D0E4FD04D")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        unsafe interface IBmframe
        {
            void GetBuffer(out byte* buffer, out uint capacity);
        }
        public Form1()
        {
            InitializeComponent();
            try
            {
                var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
                var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
                DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
            }
            catch
            {
                w11f = 1;
                ts043.Visible = false;
            }
            this.TransparencyKey = Color.Magenta;
        }
        public System.Diagnostics.ProcessPriorityClass PriorityClass { get; set; }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_NCRBUTTONDOWN = 0xa4;
            const int WM_NCLBUTTONDBLCLK = 0xA3;
            if (m.Msg == WM_NCRBUTTONDOWN)
            {
                var pos = new Point(m.LParam.ToInt32());
                contextMenuStrip1.Show(pos);
                return;
            }
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                fml = this.Left;
                fmt = this.Top;
                fmw = this.Width;
                fmh = this.Height;
                this.WindowState = FormWindowState.Minimized;
                return;
            }
            base.WndProc(ref m);
        }
        const int WM_USER = 0x400;
        const int PBM_SETSTATE = WM_USER + 16;
        const int PBM_GETSTATE = WM_USER + 17;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public enum ProgressBarStateEnum : int { Normal = 1, Error = 2, Paused = 3, }
        public static void SetState(ProgressBar pBar, ProgressBarStateEnum state)
        {
            SendMessage(pBar.Handle, PBM_SETSTATE, (IntPtr)state, IntPtr.Zero);
        }
        [DllImport("user32.dll", SetLastError = false)]
        public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);
        const uint SPI_SETACTIVEWNDTRKTIMEOUT = 0x2003;
        const uint SPI_SETACTIVEWINDOWTRACKING = 0x1001;
        const uint SPI_SETACTIVEWNDTRKZORDER = 0x100D;
        const uint SPIF_UPDATEINIFILE = 1;
        const uint SPIF_SENDCHANGE = 2;
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0, DWMWCP_DONOTROUND = 1, DWMWCP_ROUND = 2, DWMWCP_ROUNDSMALL = 3
        }
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        internal static extern void DwmSetWindowAttribute(IntPtr hwnd,
        DWMWINDOWATTRIBUTE attribute, ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute, uint cbAttribute);
        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Process p = Process.GetCurrentProcess())
                p.PriorityClass = ProcessPriorityClass.BelowNormal;
            string sKeyName = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            string sSubkeyName = "SystemUsesLightTheme";
            RegistryKey? r2Key = Registry.CurrentUser.OpenSubKey(sKeyName);
            if (r2Key != null)
            {
                var testX = (int?)r2Key.GetValue(sSubkeyName);
                if (testX != null) { nResult = (int)testX; }
                r2Key.Close();
            }
            string rKN = @"Control Panel\Desktop";
            string rGVN = "ActiveWndTrkTimeout";
            string rGVN2 = "UserPreferencesMask";
            RegistryKey? rKey = Registry.CurrentUser.OpenSubKey(rKN);
            RegistryKey? rKe2 = Registry.CurrentUser.OpenSubKey(rKN);
            if (rKey != null)
            {
                object? locatio1 = rKey.GetValue(rGVN);
                if (locatio1 != null) { ts51.Text = locatio1.ToString(); }
                rKey.Close();
            }
            if (rKe2 != null)
            {
                System.Byte[] locatio2 = (byte[])rKe2.GetValue(rGVN2, "Bytes");
                string tkg = BitConverter.ToString(locatio2).Substring(0, 2);
                if (tkg == "DF" || tkg == "DE" || tkg == "D9" || tkg == "D1")
                {
                    ts52.Enabled = false;
                    ts53.Enabled = true;
                    ts52.Text = "ONになっています";
                    ts53.Text = "OFF";
                }
                if (tkg == "9F" || tkg == "9E" || tkg == "98" || tkg == "90")
                {
                    ts53.Enabled = false;
                    ts52.Enabled = true;
                    ts52.Text = "ON";
                    ts53.Text = "OFFになっています";
                }
                rKe2.Close();
            }
            label1.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label1.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label2.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label2.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label3.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label3.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label4.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label4.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label5.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label5.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label8.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label8.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label9.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label9.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label10.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label10.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label11.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label11.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label12.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label12.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label13.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label13.MouseMove += new MouseEventHandler(Form1_MouseMove);
            label14.MouseDown += new MouseEventHandler(Form1_MouseDown);
            label14.MouseMove += new MouseEventHandler(Form1_MouseMove);
            pictureBox182.MouseDown += new MouseEventHandler(Form1_MouseDown);
            pictureBox182.MouseMove += new MouseEventHandler(Form1_MouseMove);
            pictureBox2.MouseDown += new MouseEventHandler(Form1_MouseDown);
            pictureBox2.MouseMove += new MouseEventHandler(Form1_MouseMove);
            pictureBox182.Visible = false;
            timer2.Enabled = true;
            label15.Parent = pictureBox182;
            label9.Parent = pictureBox2;
            label1.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;
            label17.Parent = pictureBox2;


            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
            using (StreamReader sr = new StreamReader(@"mode.txt"))
            {
                string s1A = sr.ReadToEnd(); s1A = s1A.Replace(Environment.NewLine, "\r");
                s1A = s1A.Trim('\r'); mod = s1A.Split('\r');
                foreach (string item in mod) { if (item == "end") { break; } }
                this.SetDesktopLocation(int.Parse(mod[1]), int.Parse(mod[2]));
            }
            using (StreamReader sr = new StreamReader(@"rsd.txt"))
            {
                string s1A = sr.ReadToEnd(); s1A = s1A.Replace(Environment.NewLine, "\r");
                s1A = s1A.Trim('\r'); rsd = s1A.Split('\r');
                foreach (string item in rsd) { if (item == "end") { break; } }
            }
            using (StreamReader sr = new StreamReader(@"gsd.txt"))
            {
                string s1A = sr.ReadToEnd(); s1A = s1A.Replace(Environment.NewLine, "\r");
                s1A = s1A.Trim('\r'); gsd = s1A.Split('\r');
                foreach (string item in gsd) { if (item == "end") { break; } }
            }
            using (StreamReader sr = new StreamReader(@"rcd.txt"))
            {
                string s1A = sr.ReadToEnd(); s1A = s1A.Replace(Environment.NewLine, "\r");
                s1A = s1A.Trim('\r'); rcd = s1A.Split('\r');
                foreach (string item in rcd) { if (item == "end") { break; } }
            }
            using (StreamReader sr = new StreamReader(@"gcd.txt"))
            {
                string s1A = sr.ReadToEnd(); s1A = s1A.Replace(Environment.NewLine, "\r");
                s1A = s1A.Trim('\r'); gcd = s1A.Split('\r');
                foreach (string item in gcd) { if (item == "end") { break; } }
            }
            fs = int.Parse(mod[4]);
            if (mod[0] == "0")
            {
                checkBox1.Text = "worldNow"; this.checkBox1.Left = 13; comboBox1.Visible = false;
            }
            if (mod[0] == "1")
            {
                checkBox1.Text = "船"; this.checkBox1.Left = 13; comboBox1.Visible = true;
            }
            if (mod[3] == "R") { label17.Text = "R"; cb2ff = 0; }
            if (mod[3] == "G") { label17.Text = "G"; cb2ff = 1; }
            scn = mod[8];
            Vuc();
            Re_start();
            if (mod[11] == "0") { ts041_Click(null, null); }
            if (mod[11] == "1" || mod[11] == "end") { ts042_Click(null, null); }
            if (mod[11] == "2") { ts043_Click(null, null); }
            SLD();
            Resetvisual();

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(System.IO.File.Exists("backup\\Asystem.cfg")) && (!(System.IO.File.Exists("backup\\Bsystem.cfg"))))
            {
                scn = "N";
            }
            datacopie();
            Writefile();
        }
        private void Form1_MouseDown(object? sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }
        private void Form1_MouseMove(object? sender, System.Windows.Forms.MouseEventArgs e)
        {
            vu = (int)subR.Volume.GetMasterVolume();
            progressBar2.Visible = true;
            //label17.Left = 170;
            Vuc();
            if (ts04f == 1)
            {
                this.TransparencyKey = Color.Magenta;
            }
            if (fmm == 0)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    this.Left += e.X - mousePoint.X;
                    this.Top += e.Y - mousePoint.Y;
                }
            }
        }
        private void Form1_MouseWheel(object? sender, MouseEventArgs e)
        {
            progressBar2.Visible = true;
            //label17.Left = 170;
            if (pictureBox182.Visible == true) { progressBar2.Top = 53; }
            else { progressBar2.Top = 54; }
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.Delta == 120)
            {
                if (vu < 100) { vu = vu + 1; }
                if (vu > 100) { vu = 100; }
            }
            else
            {
                if (e.Delta == 120)
                {
                    if (vu < 100) { vu = vu + 10; }
                    if (vu > 100) { vu = 100; }
                }

            }
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.Delta == -120)
            {
                if (vu > 0) { vu = vu - 1; }
                if (vu < 0) { vu = 0; }
            }
            else
            {
                if (e.Delta == -120)
                {
                    if (vu > 0) { vu = vu - 10; }
                    if (vu < 0) { vu = 0; }
                }
            }
            subR.Volume.SetMasterVolume(vu);
            Vuc();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            progressBar2.Visible = true;
            try
            {
                Microsoft.VisualBasic.Interaction.AppActivate("Too many applications");
            }
            catch
            {
                return;
            }
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            //progressBar2.Visible = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(System.IO.File.Exists("backup\\Asystem.cfg")) && (!(System.IO.File.Exists("backup\\Bsystem.cfg"))))
            {
                scn = "N";
            }
            datacopie();
            Writefile();
        }
        private void Re_start()
        {
            try
            {
                if (mod[0] != null)
                {
                    if (mod[0] == "0" && mod[3] == "R") { s2 = (string[])rsd.Clone(); fs = 0; }
                    if (mod[0] == "0" && mod[3] == "G") { s2 = (string[])gsd.Clone(); fs = 1; }
                    if (mod[0] == "1" && mod[3] == "R") { s2 = (string[])rcd.Clone(); fs = 2; }
                    if (mod[0] == "1" && mod[3] == "G") { s2 = (string[])gcd.Clone(); fs = 3; }
                }
                wts = TimeSpan.Parse(mod[5]);
                s2t = TimeSpan.Parse(mod[6]);
                t2s = TimeSpan.Parse(mod[7]);
                int nud1 = int.Parse(s2[2].Substring(0, 3));
                int nud2 = int.Parse(s2[2].Substring(3, 3));
                if (nud1 > 100) { nud1 = 100 - nud1; }
                if (nud2 > 100) { nud2 = 100 - nud2; }
                dat3 = new TimeSpan(0, nud1, nud2);
                numericUpDown2.Value = nud2;
                numericUpDown1.Value = nud1;
                label17.Text = mod[3];
                string tmpe = (s2[0].Substring(0, 4) + "/" + s2[0].Substring(4, 2) + "/" + s2[0].Substring(6, 2) + " " + s2[0].Substring(8, 2) + ":" + s2[0].Substring(10, 2) + ":" + s2[0].Substring(12, 2));
                tmpx = (s2[0].Substring(0, 4) + s2[0].Substring(4, 2) + s2[0].Substring(6, 2) + s2[0].Substring(8, 2) + s2[0].Substring(10, 2) + s2[0].Substring(12, 2));
                dat1 = DateTime.Parse(tmpe);
                textBox1.Text = tmpx.ToString();
                if (mod[3] == "R")
                {
                    double aq = double.Parse(mod[9]);
                    double aw = 10000;
                    double ae = aq / aw;
                    decimal ar = (decimal)(ae);
                    numericUpDown3.Value = ar;
                    string at = ("00:00:00:00." + mod[9]);
                    TimeSpan sample = new TimeSpan(0, 0, 0, 0, (int.Parse(mod[9]) / 10));
                    ragA = sample;
                }
                if (mod[3] == "G")
                {
                    double aq = double.Parse(mod[10]);
                    double aw = 10000;
                    double ae = aq / aw;
                    decimal ar = (decimal)(ae);
                    numericUpDown3.Value = ar;
                    string at = ("00:00:00:00." + mod[10]);
                    TimeSpan sample = new TimeSpan(0, 0, 0, 0, (int.Parse(mod[10]) / 10));
                    ragA = sample;
                }
                if (mod[0] == "1")
                {
                    if (s2[0].Length < 14 || s2[0].Length > 14)
                    {
                        label1.Text = ("日時が14桁ありません"); label2.Text = ("確認");
                    }
                    if (dat1 < DateTime.Now - new TimeSpan(10, 0, 0, 0) || DateTime.Now + new TimeSpan(10, 0, 0, 0) < dat1)
                    {
                        label1.Text = ("±10日を超過しました"); label2.Text = ("確認");
                    }
                    dat2 = new TimeSpan(00, int.Parse(s2[1].Substring(0, 2)), int.Parse(s2[1].Substring(2, 2)));
                    textBox2.Text = (dat2.ToString().Substring(3, 5)).Replace(":", "");
                    comboBox1.SelectedIndex = int.Parse(s2[3]);
                    if (s2[2] == "000000") { }
                    else { dat2 = dat2 + dat3; }
                    datA = wts - dat2;
                    if (comboBox1.SelectedIndex == 1)
                    {
                        DateTime dat5 = (dat1 - datA) - s2t - wts - t2s;
                        sts[0] = dat5;
                        for (int i = 1; i <= 479; i += 2)
                        {
                            sts[i] = sts[i - 1] + wts + s2t + ragA;
                            datX = sts[i];
                            sts[i + 1] = datX + wts + t2s + ragA;
                        }
                    }
                    if (comboBox1.SelectedIndex == 0)
                    {
                        DateTime dat5 = dat1 - datA - s2t;
                        sts[0] = dat5;
                        for (int i = 1; i <= 479; i += 2)
                        {
                            sts[i] = sts[i - 1] + wts + s2t + ragA;
                            datX = sts[i];
                            sts[i + 1] = datX + wts + t2s + ragA;
                        }
                    }
                }

                if (mod[0] == "0")
                {
                    if (s2[0].Length < 14 || s2[0].Length > 14)
                    {
                        label1.Text = ("日時が14桁ありません"); label2.Text = ("確認");
                    }
                    if (dat1 < DateTime.Now - new TimeSpan(10, 0, 0, 0) || DateTime.Now + new TimeSpan(10, 0, 0, 0) < dat1)
                    {
                        label1.Text = ("±10日を超過しました"); label2.Text = ("確認");
                    }
                    dat2 = new TimeSpan(00, 00, 00, 00, int.Parse(s2[1]));
                    textBox2.Text = double.Parse(s2[1]).ToString();
                    if (s2[2] == "000000") { }
                    else { dat2 = dat2 - dat3; }
                    DateTime datA = dat1 - dat2;
                    {
                        DateTime dat5 = datA + ragA;
                        sts[0] = dat5;
                        for (int i = 1; i <= 479; i += 2)
                        {
                            sts[i] = sts[i - 1] + wts + s2t + ragA;
                            datX = sts[i];
                            sts[i + 1] = datX + wts + t2s + ragA;
                        }
                    }
                }
            }
            catch
            {
                timer1.Enabled = false;
                this.Height = 250;
                label1.Text = "をクリックして下さい";
                label9.Text = "データを再";
                label11.Text = "入力して";
                label12.Text = "[更新]";
                label13.Text = "ボタン";
                label2.Text = "んまい";
                label17.Text = "ど";
                tcf = 1;
                return;
            }
        }
        private void datacopie()
        {
            if (nv1 < 0) { nv1 = 100 + -nv1; }
            if (nv2 < 0) { nv2 = 100 + -nv2; }
            s2[2] = nv1.ToString("D3") + nv2.ToString("D3");
            if (fs == 0) { rsd = (string[])s2.Clone(); }
            if (fs == 1) { gsd = (string[])s2.Clone(); }
            if (fs == 2) { rcd = (string[])s2.Clone(); }
            if (fs == 3) { gcd = (string[])s2.Clone(); }
        }
        private void Writefile()
        {
            using (var writer = new System.IO.StreamWriter(rsfile[fs]))
            {
                writer.WriteLine(s2[0]);
                writer.WriteLine(s2[1]);
                if (nv1 < 0) { nv1 = 100 + -nv1; }
                if (nv2 < 0) { nv2 = 100 + -nv2; }
                s2[2] = nv1.ToString("D3") + nv2.ToString("D3");
                writer.WriteLine(s2[2]);
                if (mod[0] == "1")
                {
                    writer.WriteLine(Convert.ToString(comboBox1.SelectedIndex));
                }
                writer.Write("end");
            }
            using (var writer = new System.IO.StreamWriter(@"mode.txt"))
            {
                writer.WriteLine(mod[0]);
                if (this.WindowState == FormWindowState.Minimized)
                {
                    writer.WriteLine(fml);
                    writer.WriteLine(fmt);
                }
                else
                {
                    writer.WriteLine(this.Left);
                    writer.WriteLine(this.Top);
                }
                writer.WriteLine(mod[3]);
                writer.WriteLine(fs);
                writer.WriteLine(mod[5]);
                writer.WriteLine(mod[6]);
                writer.WriteLine(mod[7]);
                if (scn == "end") { scn = "N"; }
                writer.WriteLine(scn);
                writer.WriteLine(mod[9]);
                writer.WriteLine(mod[10]);
                writer.WriteLine(mod[11]);
                Console.WriteLine(mod[11]);
                writer.Write("end");
            }
        }
        private void Vuc()
        {
            try
            {
                progressBar2.Value = vu;
                label17.Text = vu.ToString();
            }
            catch { }
        }
        private void Resetvisual()
        {
            this.Width = 264; this.Height = 57;
            this.TransparencyKey = Color.Magenta;
            if (sss == 0)
            {
                pictureBox2.Visible = true;
                label1.Parent = pictureBox2;
                label2.Parent = pictureBox2;
                label3.Parent = pictureBox2;
                label9.Parent = pictureBox2;
                label17.Parent = pictureBox2;
            }
            else
            {
                pictureBox2.Visible = false;
                label1.Parent = this;
                label2.Parent = this;
                label3.Parent = this;
                label9.Parent = this;
                label17.Parent = this;
            }
            label17.Enabled = true;
            progressBar1.Visible = true;
            panel1.Visible = true;
            checkBox1.Visible = true;
            label1.Location = new Point(6, 33);
            label2.Location = new Point(211, 33);
            label9.Location = new Point(6, 5);
            label9.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label10.Location = new Point(61, 8);
            label10.Font = new Font("MS UI Gothic", 9);
            label11.Location = new Point(82, 5);
            label11.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label12.Location = new Point(156, 8);
            label13.Location = new Point(189, 5);
            label14.Location = new Point(491, 9);
            //label17.Location = new Point(170, 33);
            ts3.Enabled = true;
            label17.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            pictureBox182.Visible = false;
        }
        private void ApplyFont(object? fd, EventArgs e)
        {
            if (fd != null) { ChangeFont((FontDialog)fd); }
        }
        private void ChangeFont(FontDialog fd)
        {
            label1.Font = fd.Font;
            label1.ForeColor = fd.Color;
            label2.Font = fd.Font;
            label2.ForeColor = fd.Color;
            label9.Font = fd.Font;
            label9.ForeColor = fd.Color;
            label10.ForeColor = fd.Color;
            label11.Font = fd.Font;
            label11.ForeColor = fd.Color;
            label12.ForeColor = fd.Color;
            label13.Font = fd.Font;
            label13.ForeColor = fd.Color;
            label17.Font = fd.Font;
            label17.ForeColor = fd.Color;
        }
        private void clearstop()
        {
            this.label9.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label10.Location = new Point(115, 8);
            label10.Font = new Font("MS UI Gothic", 9);
            label11.Location = new Point(146, 3);
            label11.Font = new Font("MS UI Gothic", 12, FontStyle.Bold);
        }
        private void SLD()
        {
            if (w11f == 1)
            {
                pictureBox2.Visible = false;
                label9.Parent = this;
                label1.Parent = this;
                label2.Parent = this;
                label3.Parent = this;
                label17.Parent = this;
            }
            if (nResult == 0)
            {
                pictureBox2.BackgroundImage = Properties.Resources.c10b_transparentA;
                //label1.Parent = pictureBox2;
                //label2.Parent = pictureBox2;
                //label3.Parent = pictureBox2;
                //label4.Parent = pictureBox2;
                //label5.Parent = pictureBox2;
                //label9.Parent = pictureBox2;
                //label6.Parent = pictureBox2;
                //label17.Parent = pictureBox2;
                //label18.Parent = pictureBox2;
                fcC = Color.FromArgb(200, 200, 200);
                bcC = Color.FromArgb(90, 90, 90);
                this.ForeColor = fcC;
                label1.ForeColor = fcC;
                label2.ForeColor = fcC;
                label9.ForeColor = fcC;
                label10.ForeColor = fcC;
                label11.ForeColor = fcC;
                label12.ForeColor = fcC;
                label13.ForeColor = fcC;
                label17.ForeColor = fcC;
                button1.ForeColor = fcC;
                button2.ForeColor = fcC;
                button3.ForeColor = fcC;
                checkBox1.ForeColor = fcC;
                toolStripMenuItem1.ForeColor = fcC;
                ts1.ForeColor = fcC;
                ts2.ForeColor = fcC;
                ts3.ForeColor = fcC;
                ts4.ForeColor = fcC;
                ts5.ForeColor = fcC;
                ts6.ForeColor = fcC;
                ts7.ForeColor = fcC;
                ts8.ForeColor = fcC;
                ts9.ForeColor = fcC;
                ts10.ForeColor = fcC;
                ts11.ForeColor = fcC;
                ts12.ForeColor = fcC;
                ts13.ForeColor = fcC;
                ts15.ForeColor = fcC;
                ts16.ForeColor = fcC;
                ts18.ForeColor = fcC;
                ts19.ForeColor = fcC;
                ts17.ForeColor = fcC;
                ts17A.ForeColor = fcC;
                ts21.ForeColor = fcC;
                ts50.ForeColor = fcC;
                ts51.ForeColor = fcC;
                ts52.ForeColor = fcC;
                ts53.ForeColor = fcC;
                ts60.ForeColor = fcC;
                ts61.ForeColor = fcC;
                ts62.ForeColor = fcC;
                ts70.ForeColor = fcC;
                ts71.ForeColor = fcC;
                textBox1.ForeColor = fcC;
                textBox2.ForeColor = fcC;
                numericUpDown2.ForeColor = fcC;
                numericUpDown1.ForeColor = fcC;
                numericUpDown3.ForeColor = fcC;
                comboBox1.ForeColor = fcC;
                this.BackColor = bcC;
                if (d2l == 1)
                {
                    this.TransparencyKey = this.BackColor;
                }
                label1.BackColor = bcC;
                label2.BackColor = bcC;
                label9.BackColor = bcC;
                label10.BackColor = bcC;
                label11.BackColor = bcC;
                label12.BackColor = bcC;
                label13.BackColor = bcC;
                label17.BackColor = bcC;
                contextMenuStrip1.BackColor = bcC;
                toolStripMenuItem1.BackColor = bcC;
                ts1.BackColor = bcC;
                ts2.BackColor = bcC;
                ts3.BackColor = bcC;
                ts4.BackColor = bcC;
                ts5.BackColor = bcC;
                ts6.BackColor = bcC;
                ts7.BackColor = bcC;
                ts8.BackColor = bcC;
                ts9.BackColor = bcC;
                ts10.BackColor = bcC;
                ts11.BackColor = bcC;
                ts12.BackColor = bcC;
                ts13.BackColor = bcC;
                ts15.BackColor = bcC;
                ts16.BackColor = bcC;
                ts18.BackColor = bcC;
                ts19.BackColor = bcC;
                ts17.BackColor = bcC;
                ts17A.BackColor = bcC;
                ts21.BackColor = bcC;
                ts50.BackColor = bcC;
                ts51.BackColor = bcC;
                ts52.BackColor = bcC;
                ts53.BackColor = bcC;
                ts60.BackColor = bcC;
                ts61.BackColor = bcC;
                ts62.BackColor = bcC;
                ts70.BackColor = bcC;
                ts71.BackColor = bcC;
                bcC = Color.FromArgb(100, 100, 100);
                checkBox1.BackColor = bcC;
                button1.BackColor = bcC;
                button2.BackColor = bcC;
                button3.BackColor = bcC;
                textBox1.BackColor = bcC;
                textBox2.BackColor = bcC;
                numericUpDown2.BackColor = bcC;
                numericUpDown1.BackColor = bcC;
                numericUpDown3.BackColor = bcC;
                comboBox1.BackColor = bcC;
            }
            else
            {
                pictureBox2.BackgroundImage = Properties.Resources.c10l_transparentA;
                //label1.Parent = pictureBox2;
                //label2.Parent = pictureBox2;
                //label3.Parent = pictureBox2;
                //label4.Parent = pictureBox2;
                //label5.Parent = pictureBox2;
                //label9.Parent = pictureBox2;
                //label6.Parent = pictureBox2;
                //label16.Parent = pictureBox2;
                //label17.Parent = pictureBox2;
                //label18.Parent = pictureBox2;
                fcD = Color.FromArgb(30, 30, 30);
                bcD = Color.FromArgb(240, 240, 240);
                this.ForeColor = fcD;
                this.Refresh();
                label1.ForeColor = fcD;
                label2.ForeColor = fcD;
                label9.ForeColor = fcD;
                label10.ForeColor = fcD;
                label11.ForeColor = fcD;
                label12.ForeColor = fcD;
                label13.ForeColor = fcD;
                label17.ForeColor = fcD;
                button1.ForeColor = fcD;
                button2.ForeColor = fcD;
                button3.ForeColor = fcD;
                toolStripMenuItem1.ForeColor = fcD;
                ts1.ForeColor = fcD;
                ts2.ForeColor = fcD;
                ts3.ForeColor = fcD;
                ts4.ForeColor = fcD;
                ts5.ForeColor = fcD;
                ts6.ForeColor = fcD;
                ts7.ForeColor = fcD;
                ts8.ForeColor = fcD;
                ts9.ForeColor = fcD;
                ts10.ForeColor = fcD;
                ts11.ForeColor = fcD;
                ts12.ForeColor = fcD;
                ts13.ForeColor = fcD;
                ts15.ForeColor = fcD;
                ts16.ForeColor = fcD;
                ts18.ForeColor = fcD;
                ts19.ForeColor = fcD;
                ts17.ForeColor = fcD;
                ts17.ForeColor = fcD;
                ts17A.ForeColor = fcD;
                ts21.ForeColor = fcD;
                ts50.ForeColor = fcD;
                ts51.ForeColor = fcD;
                ts52.ForeColor = fcD;
                ts53.ForeColor = fcD;
                ts60.ForeColor = fcD;
                ts61.ForeColor = fcD;
                ts62.ForeColor = fcD;
                ts70.ForeColor = fcD;
                ts71.ForeColor = fcD;
                checkBox1.ForeColor = fcD;
                textBox1.ForeColor = fcD;
                textBox2.ForeColor = fcD;
                numericUpDown2.ForeColor = fcD;
                numericUpDown1.ForeColor = fcD;
                numericUpDown3.ForeColor = fcD;
                comboBox1.ForeColor = fcD;
                this.BackColor = bcD;
                if (d2l == 1)
                {
                    this.TransparencyKey = this.BackColor;
                }
                label1.BackColor = bcD;
                label2.BackColor = bcD;
                label9.BackColor = bcD;
                label10.BackColor = bcD;
                label11.BackColor = bcD;
                label12.BackColor = bcD;
                label13.BackColor = bcD;
                label17.BackColor = bcD;
                button1.BackColor = bcD;
                button2.BackColor = bcD;
                button3.BackColor = bcD;
                toolStripMenuItem1.BackColor = bcD;
                ts1.BackColor = bcD;
                ts2.BackColor = bcD;
                ts3.BackColor = bcD;
                ts4.BackColor = bcD;
                ts5.BackColor = bcD;
                ts6.BackColor = bcD;
                ts7.BackColor = bcD;
                ts8.BackColor = bcD;
                ts9.BackColor = bcD;
                ts10.BackColor = bcD;
                ts11.BackColor = bcD;
                ts12.BackColor = bcD;
                ts13.BackColor = bcD;
                ts15.BackColor = bcD;
                ts16.BackColor = bcD;
                ts18.BackColor = bcD;
                ts19.BackColor = bcD;
                ts17.BackColor = bcD;
                ts17A.BackColor = bcD;
                ts21.BackColor = bcD;
                ts50.BackColor = bcD;
                ts51.BackColor = bcD;
                ts52.BackColor = bcD;
                ts53.BackColor = bcD;
                ts60.BackColor = bcD;
                ts61.BackColor = bcD;
                ts62.BackColor = bcD;
                ts70.BackColor = bcD;
                ts71.BackColor = bcD;
                checkBox1.BackColor = bcD;
                contextMenuStrip1.BackColor = bcD;
                bcD = Color.FromArgb(250, 250, 250);
                textBox1.BackColor = bcD;
                textBox2.BackColor = bcD;
                numericUpDown2.BackColor = bcD;
                numericUpDown1.BackColor = bcD;
                numericUpDown3.BackColor = bcD;
                comboBox1.BackColor = bcD;
            }
        }
        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            fbpc++;
            if (fbpc == 1)
            {
                this.Height = 250;
                timer5.Enabled = true;
            }
            else
            {
                this.Height = 57;
                timer5.Enabled = false;
            }
            if (fbpc >= 2) { fbpc = 0; }
        }
        private void Label17_Click(object sender, EventArgs e)
        {
            cb2ff ^= 1;
            if (cb2ff == 0) { label17.Text = "R"; mod[3] = "R"; }
            if (cb2ff == 1) { label17.Text = "G"; mod[3] = "G"; }
            datacopie(); Re_start();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2[3] = (comboBox1.SelectedIndex).ToString();
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Text == "worldNow")
            {
                this.checkBox1.Left = 13;
                comboBox1.Visible = true;
                mod[0] = "1";
                checkBox1.Text = "船";
                datacopie(); Re_start();
                return;
            }
            if (checkBox1.Text == "船")
            {
                this.checkBox1.Left = 13;
                comboBox1.Visible = false;
                mod[0] = "0";
                checkBox1.Text = "worldNow";
                datacopie(); Re_start();
            }
        }
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int nuv1 = (int)numericUpDown1.Value;
            if (nuv1 < 59 || nuv1 < -59) { nv1 = nuv1; }
            if (nuv1 >= 59) { numericUpDown1.Value = 59; }
            if (nuv1 <= -59) { numericUpDown1.Value = -59; }
            dat3 = new TimeSpan(0, nv1, nv2);
            datacopie(); Re_start();
        }
        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int nuv2 = (int)numericUpDown2.Value;
            if (nuv2 < 59 || nuv2 < -59) { nv2 = nuv2; }
            if (nuv2 >= 59) { numericUpDown2.Value = 59; }
            if (nuv2 <= -59) { numericUpDown2.Value = -59; }
            dat3 = new TimeSpan(0, nv1, nv2);
            datacopie(); Re_start();
        }
        private async void Button1_Click(object sender, EventArgs e)
        {
            {
                Bitmap bitmap = new Bitmap(140, 42);
                Graphics g = Graphics.FromImage(bitmap);
                Point p = panel1.PointToScreen(new Point(0, 0));
                g.CopyFromScreen(new Point(p.X, p.Y), new Point(0, 0), bitmap.Size);
                Bitmap bmpOrijinal = new Bitmap(bitmap);
                int scale = 2;
                Bitmap bmpResize = new Bitmap(bmpOrijinal, bmpOrijinal.Width * scale, bmpOrijinal.Height * scale);
                SoftwareBitmap y = Framebm(bmpResize);
                OcrResult t = await RcgTx(y);
                string tt = t.Text;

                rett = Regex.Matches(tt, "[0-9]+")
                     .Cast<Match>()
                     .Select(m => int.Parse(m.Value))
                     .ToArray();
                if (mod[0] == "0")
                {
                    string[] dnow = new string[] { "d", "N", "o", "w", "=" };
                    if (dnow.All(tt.Contains))
                    {
                        string? a = Convert.ToString(rett[0]);
                        int b = a.Length;
                        if (b > 3)
                        {
                            textBox2.Text = "dNow=" + a;
                            now1 = DateTime.Now.ToString("yyyyMMddHHmmss");
                            textBox1.Text = now1;
                            chb = 1;
                        }
                    }
                    else
                    {
                        textBox1.Text = "dNow=がありません";
                        textBox2.Text = "-";
                        chb = 0;
                    }
                }
                if (mod[0] == "1")
                {
                    string[] dnow = new string[] { "分", "秒" };
                    if (dnow.All(tt.Contains))
                    {
                        if (rett.Length >= 1 || rett.Length <= 3)
                        {
                            textBox2.Text = rett[0].ToString("D2") + rett[1].ToString("D2");
                            s2[1] = rett[0].ToString("D2") + rett[1].ToString("D2");
                            now1 = DateTime.Now.ToString("yyyyMMddHHmmss");
                            textBox1.Text = now1;
                            chb = 1;
                        }
                    }
                    else
                    {
                        textBox1.Text = "停泊残時間がありません";
                        textBox2.Text = "分と秒が無いと記録不可";
                        chb = 0;
                    }
                }
                g.Dispose();
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (chb == 1)
            {
                now1 = DateTime.Now.ToString("yyyyMMddHHmmss");
                s2[0] = now1;
                if (mod[0] == "1" && chb == 1)
                {
                    s2[1] = rett[0].ToString("D2") + rett[1].ToString("D2");
                }
                if (mod[0] == "0" && chb == 1)
                {
                    s2[1] = rett[0].ToString();
                }
                datacopie();
                Writefile();
                string buf = "backup\\" + rsfile[fs];
                if (!System.IO.Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }
                System.IO.File.Copy(rsfile[fs], buf, true);
                Re_start();
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            decimal ay = numericUpDown3.Value * 10000;
            int au = (int)ay;
            if (mod[3] == "R")
            {
                mod[9] = au.ToString();

            }
            if (mod[3] == "G")
            {
                mod[10] = au.ToString();
            }
            string tmpz = textBox1.Text;
            try
            {
                if (tmpz.Length < 14 || tmpz.Length > 14 || int.Parse(tmpz.Substring(0, 2)) != 20 ||
                        int.Parse(tmpz.Substring(2, 2)) < 23 || int.Parse(tmpz.Substring(4, 2)) > 12 ||
                        int.Parse(tmpz.Substring(6, 2)) > 31 || int.Parse(tmpz.Substring(8, 2)) > 23 ||
                        int.Parse(tmpz.Substring(10, 2)) > 59 || int.Parse(tmpz.Substring(12, 2)) > 59)
                {
                    tbki = tbki + 1;
                    if (tbki == 1)
                    {
                        tmpy = textBox1.ForeColor;
                    }
                    textBox1.ForeColor = Color.Red;
                    textBox1.Text = tmpz;
                    return;
                }
                else
                {
                    s2[0] = textBox1.Text.ToString();
                    textBox1.ForeColor = tmpy;
                    tbki = 0;
                }
            }
            catch { textBox1.Text = "値異常,更新釦2回で復帰"; return; }
            if (mod[0] == "1")
            {
                string tmpx = textBox2.Text;
                try
                {
                    if (tmpx.Length < 4 || tmpx.Length > 4 ||
                        int.Parse(tmpx.Substring(0, 2)) > 19 ||
                        int.Parse(tmpx.Substring(2, 2)) > 59)
                    {
                        tbki2 = tbki2 + 1;
                        if (tbki2 == 1)
                        {
                            tmpy = textBox2.ForeColor;
                        }
                        textBox2.ForeColor = Color.Red;
                        textBox2.Text = tmpx;
                        return;
                    }
                    else
                    {
                        s2[1] = textBox2.Text;
                        textBox2.ForeColor = tmpy;
                        tbki2 = 0;
                    }
                }
                catch { textBox2.Text = "値異常,更新釦2回で復帰"; return; }
            }
            if (mod[0] == "0")
            {
                string tmpo = textBox2.Text;
                try
                {
                    if (tmpo.Length <= 4)
                    {
                        tbki3 = tbki3 + 1;
                        if (tbki3 == 1)
                        {
                            tmpy = textBox2.ForeColor;
                        }
                        textBox2.ForeColor = Color.Red;
                        textBox2.Text = tmpo;
                        return;
                    }
                    else
                    {
                        s2[1] = textBox2.Text;
                        textBox2.ForeColor = tmpy;
                        tbki3 = 0;
                    }
                }
                catch { textBox2.Text = "値異常,更新釦2回で復帰"; return; }
            }
            if (tcf == 1)
            {
                timer1.Enabled = true;
                tcf = 0;
            }
            datacopie();
            Writefile();
            string buf = "backup\\" + rsfile[fs];
            if (!System.IO.Directory.Exists("backup"))
            {
                Directory.CreateDirectory("backup");
            }
            System.IO.File.Copy(rsfile[fs], buf, true);
            chb = 0;
            Re_start();
        }
        private async Task<OcrResult> RcgTx(SoftwareBitmap snap)
        {
            OcrEngine oEng = OcrEngine.TryCreateFromUserProfileLanguages();
            OcrResult oRes = await oEng.RecognizeAsync(snap);
            return oRes;
        }
        private SoftwareBitmap Framebm(System.Drawing.Bitmap bmp)
        {
            unsafe
            {
                var swBm = new SoftwareBitmap(BitmapPixelFormat.Bgra8, bmp.Width, bmp.Height, BitmapAlphaMode.Premultiplied);
                System.Drawing.Imaging.BitmapData bd = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                byte* pSrc = (byte*)bd.Scan0;
                using (BitmapBuffer buffer = swBm.LockBuffer(BitmapBufferAccessMode.Write))
                {
                    using (var reference = buffer.CreateReference())
                    {
                        //((IBmframe)reference).GetBuffer(out byte* pDest, out uint capacity);
                        var Mbuf = reference.As<IBmframe>();
                        Mbuf.GetBuffer(out byte* pDest, out uint capacity);
                        BitmapPlaneDescription bl = buffer.GetPlaneDescription(0);
                        for (int y = 0; y < bl.Height; y++)
                        {
                            int blOffset = bl.StartIndex + y * bl.Stride;
                            int yb = y * bd.Stride;
                            for (int x = 0; x < bl.Width; x++)
                            {
                                pDest[blOffset + 4 * x] = pSrc[yb + 4 * x];
                                pDest[blOffset + 4 * x + 1] = pSrc[yb + 4 * x + 1];
                                pDest[blOffset + 4 * x + 2] = pSrc[yb + 4 * x + 2];
                                pDest[blOffset + 4 * x + 3] = (byte)255;
                            }
                        }
                    }
                }
                bmp.UnlockBits(bd);
                return swBm;
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (fix4 != null)
            {
                this.Text = label1.Text.Substring(0, 1) + fix4.Substring(0, 1) + "  " + fix3;
            }
            label9.Text = now.ToString("MM/dd");
            label10.Text = now.ToString("ddd");
            label11.Text = now.ToString("HH:mm:ss");
            label12.Text = fix4;
            label13.Text = fix3;
            for (int ii = 1; ii <= 480; ii++)
            {
                if (ii % 2 == 0)
                {
                    if (sts[ii] - wts - t2s < now && sts[ii] - wts > now)
                    {
                        label1.Text = ("サンライズ半島へ航行中");
                        SetState(progressBar1, ProgressBarStateEnum.Normal);
                        fix = (sts[ii] - wts - now).ToString();
                        fix2 = fix.Substring(3, 5);
                        fix3 = (sts[ii] - wts).ToString("HH:mm:ss");
                        label2.Text = fix2;
                        string[] charsToRemove = new string[] { ":" };
                        foreach (var c in charsToRemove) { fix2 = fix2.Replace(c, string.Empty); }
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 1047;
                        progressBar1.Value = 1047 - int.Parse(fix2);
                        progressBar1.RightToLeft = RightToLeft.No;
                        progressBar1.RightToLeftLayout = false;
                        fix4 = "入港";
                        label15.Text = ">>";
                        double np = (int)progressBar1.Value * 0.1404011461318052;
                        if (np <= 147)
                        {
                            label15.Location = new System.Drawing.Point(cspht2s[(int)np] - 14, cspvt2s[(int)np] - 5);
                        }
                        break;
                    }
                    if (now > sts[ii] - wts && now < sts[ii])
                    {
                        label1.Text = ("サンライズ半島に停泊中");
                        SetState(progressBar1, ProgressBarStateEnum.Error);
                        fix = (sts[ii] - now).ToString();
                        fix2 = fix.Substring(3, 5);
                        fix3 = (sts[ii + 1] - s2t - wts).ToString("HH:mm:ss");
                        label2.Text = fix2;
                        string[] charsToRemove = new string[] { ":" };
                        foreach (var c in charsToRemove) { fix2 = fix2.Replace(c, string.Empty); }
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 2000;
                        progressBar1.Value = int.Parse(fix2);
                        progressBar1.RightToLeft = RightToLeft.Yes;
                        progressBar1.RightToLeftLayout = true;
                        fix4 = "出航";
                        label15.Text = "停泊中 " + label2.Text;
                        label15.Location = new System.Drawing.Point(170, 32);
                        break;
                    }
                }
                else
                {
                    if (now > sts[ii] - wts - s2t && now < sts[ii] - wts)
                    {
                        label1.Text = ("ツインクラウンへ航行中");
                        SetState(progressBar1, ProgressBarStateEnum.Normal);
                        fix = (sts[ii] - wts - now).ToString();
                        fix2 = fix.Substring(3, 5);
                        fix3 = (sts[ii] - wts).ToString("HH:mm:ss");
                        label2.Text = fix2;
                        string[] charsToRemove = new string[] { ":" };
                        foreach (var c in charsToRemove) { fix2 = fix2.Replace(c, string.Empty); }
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 1021;
                        progressBar1.Value = 1021 - int.Parse(fix2);
                        progressBar1.RightToLeft = RightToLeft.Yes;
                        progressBar1.RightToLeftLayout = true;
                        fix4 = "入港";
                        label15.Text = "<<";
                        double np = (int)progressBar1.Value * 0.1439764936336925;
                        if (np <= 147)
                        {
                            label15.Location = new System.Drawing.Point(csphs2t[(int)np] - 2, cspvs2t[(int)np] - 5);
                        }
                        break;
                    }
                    if (now > sts[ii] - wts && now < sts[ii])
                    {
                        label1.Text = ("ツインクラウンに停泊中");
                        SetState(progressBar1, ProgressBarStateEnum.Error);
                        fix = (sts[ii] - now).ToString();
                        fix2 = fix.Substring(3, 5);
                        fix3 = (sts[ii + 1] - t2s - wts).ToString("HH:mm:ss");
                        label2.Text = fix2;
                        string[] charsToRemove = new string[] { ":" };
                        foreach (var c in charsToRemove) { fix2 = fix2.Replace(c, string.Empty); }
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 2000;
                        progressBar1.Value = int.Parse(fix2);
                        progressBar1.RightToLeft = RightToLeft.No;
                        progressBar1.RightToLeftLayout = false;
                        fix4 = "出航";
                        label15.Text = label2.Text + " 停泊中";
                        label15.Location = new System.Drawing.Point(0, 32);
                        break;
                    }
                }
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            try
            {
                int XI = System.Windows.Forms.Cursor.Position.X;
                int YI = System.Windows.Forms.Cursor.Position.Y;
                Graphics gI = Graphics.FromImage(mBm);
                gI.CopyFromScreen(new Point(XI, YI), new Point(0, 0), new Size(1, 1));
                Color cr = mBm.GetPixel(0, 0);
                byte r = cr.R;
                byte g = cr.G;
                byte b = cr.B;

                label18.Text = "r" + " " + $"{r.ToString(),3:d}" + " " +
                               "g" + " " + $"{g.ToString(),3:d}" + " " +
                               "b" + " " + $"{b.ToString(),3:d}" + " " +
                               "h" + " " + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
                pictureBox1.BackColor = cr;
                gI.Dispose();
            }
            catch
            {

            }

        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            tc2++;
            if (tc2 % 2 == 0) { label15.ForeColor = Color.DarkGray; }
            else { label15.ForeColor = Color.Black; }
            if (tc2 >= 2) { tc2 = 0; }
        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            subR.Monitor.PowerOff();
            contextMenuStrip1.Show();
        }
        private void MTSMIC(object sender, EventArgs e)
        {
            fml = this.Left;
            fmt = this.Top;
            fmw = this.Width;
            fmh = this.Height;
            this.WindowState = FormWindowState.Minimized;
        }

        private void ts70_Click(object sender, EventArgs e)
        {
            timer4.Interval = 60000;
            timer4.Enabled = true;
        }
        private void ts71_Click(object sender, EventArgs e)
        {
            timer4.Interval = 180000;
            timer4.Enabled = true;
        }
        private void ts90_Click()
        {
            pictureBox2.Visible = true;
            label9.Parent = pictureBox2;
            label1.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;
            label4.Parent = pictureBox2;
            label5.Parent = pictureBox2;
            label16.Parent = pictureBox2;
            label17.Parent = pictureBox2;
            label18.Parent = pictureBox2;
            sss = 0;
            mod[11] = "0";
        }
        private void ts91_Click()
        {
            pictureBox2.Visible = false;
            label9.Parent = this;
            label1.Parent = this;
            label2.Parent = this;
            label3.Parent = this;
            label4.Parent = this;
            label5.Parent = this;
            label16.Parent = this;
            label17.Parent = this;
            label18.Parent = this;
            sss = 1;
            mod[11] = "1";

        }
        private void ts92_Click()
        {
            pictureBox2.Visible = false;
            label9.Parent = this;
            label1.Parent = this;
            label2.Parent = this;
            label3.Parent = this;
            label4.Parent = this;
            label5.Parent = this;
            label16.Parent = this;
            label17.Parent = this;
            label18.Parent = this;
            sss = 1;
            mod[11] = "2";
        }

        private void tsmic4(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = panel1.ForeColor;
            cd.CustomColors = ccr;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Color color = cd.Color;
                label1.ForeColor = color;
                label2.ForeColor = color;
                label9.ForeColor = color;
                label10.ForeColor = color;
                label11.ForeColor = color;
                label12.ForeColor = color;
                label13.ForeColor = color;
                label17.ForeColor = color;
                ccr = cd.CustomColors;
            }
        }
        private void tsmic5(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowApply = true;
            fd.ShowColor = true;
            fd.Font = label1.Font;
            fd.Color = label1.ForeColor;
            fd.Apply += new EventHandler(ApplyFont);
            if (fd.ShowDialog() != DialogResult.Cancel) { ChangeFont((FontDialog)fd); }
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            progressBar2.Visible = false;

            //label17.Left = 170;
            label17.Text = mod[3];
        }
        private void tsmic6(object sender, EventArgs e)
        {
            //Process.Start("shell:ControlPanelFolder");
            var start = new ProcessStartInfo("shell:ControlPanelFolder");
            start.UseShellExecute = true;
            Process.Start(start);
        }
        private void tsmic7(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer");
        }
        private void tSMI2C(object sender, EventArgs e)
        {
            fmm ^= 1;
            if (fmm == 0)
            {
                ts17A.Text = "位置固定 on";
            }
            else
            {
                ts17A.Text = "位置固定 off";

            }
        }
        private void tsmic8(object sender, EventArgs e)
        {
        }
        private void tsmic9(object sender, EventArgs e)
        {
            string pathMyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathMyDocuments = pathMyDocuments + "\\ArcheAge\\system.cfg";
            if (System.IO.File.Exists("backup\\Asystem.cfg"))
            {
                System.IO.File.Copy("backup\\Asystem.cfg", pathMyDocuments, true);
                scn = "A";
            }
            else { scn = "N"; }
            datacopie();
            Writefile();
        }
        private void ts62_Click(object sender, EventArgs e)
        {
            Font fd = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label1.Font = fd;
            label1.ForeColor = Color.Black;
            label2.Font = fd;
            label2.ForeColor = Color.Black;
            label9.Font = fd;
            label9.ForeColor = Color.Black;
            label10.Font = new Font("MS UI Gothic", 9);
            label10.ForeColor = Color.Black;
            label11.Font = fd;
            label11.ForeColor = Color.Black;
            label12.Font = new Font("MS UI Gothic", 9);
            label12.ForeColor = Color.Black;
            label13.Font = fd;
            label13.ForeColor = Color.Black;
            label17.Font = fd;
            label17.ForeColor = Color.Black;
        }
        private void tsmic0(object sender, EventArgs e)
        {
            string pathMyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathMyDocuments = pathMyDocuments + "\\ArcheAge\\system.cfg";
            if (System.IO.File.Exists("backup\\Bsystem.cfg"))
            {
                System.IO.File.Copy("backup\\Bsystem.cfg", pathMyDocuments, true);
                scn = "B";
            }
            else { scn = "N"; }
            datacopie();
            Writefile();
        }
        private void tsmicB(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cms2 = System.Windows.Forms.Cursor.Position;
            contextMenuStrip1.Refresh();
            if (scn == "A")
            {
                ts9.Text = "- - 現在 cfg は A - -";
            }
            if (scn == "B")
            {
                ts9.Text = "- - 現在 cfg は B - -";
            }
        }
        private void OTSMIC(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETACTIVEWINDOWTRACKING, 0, (IntPtr)1, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            SystemParametersInfo(SPI_SETACTIVEWNDTRKZORDER, 0, (IntPtr)1, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            ts52.Enabled = false;
            ts53.Enabled = true;
            ts52.Text = "現在 ON";
            ts53.Text = "OFF";
        }
        private void TSMI10C(object sender, EventArgs e)
        {
            fbpc++;
            if (fbpc == 1)
            {
                this.Height = 230;
            }
            else
            {
                this.Height = 59;
            }
            if (fbpc >= 2) { fbpc = 0; }
        }
        private void TSMI11C1(object sender, EventArgs e)
        {
            fml = this.Left;
            fmt = this.Top;
            fmw = this.Width;
            fmh = this.Height;
            this.WindowState = FormWindowState.Minimized;
        }
        private void TSMI7C(object sender, EventArgs e)
        {
            Resetvisual();
            this.Width = 264;
            pictureBox182.Visible = true;
            label15.Visible = true;
        }
        private void TSMI7ML(object sender, EventArgs e)
        {
            string? hbg2 = ((ToolStripMenuItem)sender).Name;
            if (nResult == 0)
            {
                if (hbg2 != null) { ((ToolStripMenuItem)sender).ForeColor = fcC; }
            }
            else
            {
                if (hbg2 != null) { ((ToolStripMenuItem)sender).ForeColor = fcD; }
            }
        }
        private void TSMI7ME1(object sender, EventArgs e)
        {
            string? hbg2 = ((ToolStripMenuItem)sender).Name;
            if (nResult == 0)
            {
                if (hbg2 != null) { ((ToolStripMenuItem)sender).ForeColor = Color.Black; }
            }
            else
            {
                if (hbg2 != null) { ((ToolStripMenuItem)sender).ForeColor = fcD; }
            }
        }
        private void TSMI8C(object sender, EventArgs e)
        {
            clearstop();
            d2l = 0;
            SLD();
            Resetvisual();
        }
        private void OFTSMIC(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETACTIVEWINDOWTRACKING, 0, IntPtr.Zero, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            SystemParametersInfo(SPI_SETACTIVEWNDTRKZORDER, 0, IntPtr.Zero, SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
            ts53.Enabled = false;
            ts52.Enabled = true;
            ts52.Text = "ON";
            ts53.Text = "現在 OFF";
        }
        private void TSCB1SIC(object sender, EventArgs e)
        {
            SystemParametersInfo(SPI_SETACTIVEWNDTRKTIMEOUT, 0, (IntPtr)int.Parse(ts50.Text), SPIF_SENDCHANGE | SPIF_UPDATEINIFILE);
        }
        private void TSMI5C(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
        }
        private void tsmicC(object sender, EventArgs e)
        {
            datacopie();
            Writefile();
            this.Close();
        }
        private void ts12_Click_1(object sender, EventArgs e)
        {
            string pathMyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathMyDocuments = pathMyDocuments + "\\ArcheAge\\system.cfg";
            System.IO.File.Copy(pathMyDocuments, "backup\\Asystem.cfg", true);
        }
        private void ts13_Click(object sender, EventArgs e)
        {
            string pathMyDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            pathMyDocuments = pathMyDocuments + "\\ArcheAge\\system.cfg";
            System.IO.File.Copy(pathMyDocuments, "backup\\Bsystem.cfg", true);
        }
        private void tsmicD(object sender, EventArgs e)
        {
            d2l = 1;
            this.Height = 32;
            this.Width = 500;
            this.TransparencyKey = this.BackColor;
            pictureBox182.Visible = false;
            progressBar1.Visible = false;
            comboBox1.Visible = false;
            panel1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            ts15.Enabled = true;
            ts3.Enabled = false;
            label14.Location = new Point(0, 5);
            //label17.Location = new Point(191, 8);
            label1.Location = new Point(25, 7);
            label2.Location = new Point(210, 8);
            label9.Location = new Point(255, 8);
            label10.Location = new Point(305, 11);
            label11.Location = new Point(321, 8);
            label12.Location = new Point(388, 11);
            label13.Location = new Point(416, 8);
        }
        private void tsmicE(object sender, EventArgs e)
        {
            clearstop();
            d2l = 1;
            this.Height = 32;
            this.Width = 500;
            this.TransparencyKey = this.BackColor;
            label1.Parent = this;
            label2.Parent = this;
            label3.Parent = this;
            label9.Parent = this;
            label17.Parent = this;
            pictureBox2.Visible = false;

            pictureBox182.Visible = false;
            progressBar1.Visible = false;
            comboBox1.Visible = false;
            panel1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            ts15.Enabled = true;
            ts3.Enabled = false;
            label14.Location = new Point(0, 5);
            //label17.Location = new Point(191, 8);
            label1.Location = new Point(25, 7);
            label2.Location = new Point(210, 8);
            label9.Location = new Point(255, 8);
            label10.Location = new Point(305, 11);
            label11.Location = new Point(321, 8);
            label12.Location = new Point(388, 11);
            label13.Location = new Point(416, 8);
        }
        private void tsmicF(object sender, EventArgs e)
        {
            clearstop();
            d2l = 1;
            this.Width = 264;
            this.Height = 50;
            this.TransparencyKey = this.BackColor;
            label1.Parent = this;
            label2.Parent = this;
            label3.Parent = this;
            label9.Parent = this;
            label17.Parent = this;
            label1.Visible = true;
            label2.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            pictureBox2.Visible = false;
            pictureBox182.Visible = false;
            progressBar1.Visible = false;
            comboBox1.Visible = false;
            panel1.Visible = false;
            label14.Location = new Point(0, 5);
            //label17.Location = new Point(191, 8);
            label1.Location = new Point(25, 7);
            label2.Location = new Point(210, 8);
            label9.Location = new Point(25, 25);
            label10.Location = new Point(76, 28);
            label11.Location = new Point(92, 25);
            label12.Location = new Point(160, 28);
            label13.Location = new Point(188, 25);
            ts15.Enabled = true;
            ts3.Enabled = false;
        }
        private void tsmicG(object sender, EventArgs e)
        {
            d2l = 1;
            this.Height = 40;
            this.Width = 280;
            this.TransparencyKey = this.BackColor;
            label1.Parent = this;
            label2.Parent = this;
            label3.Parent = this;
            label9.Parent = this;
            label17.Parent = this;
            pictureBox2.Visible = false;
            pictureBox182.Visible = false;
            progressBar1.Visible = false;
            comboBox1.Visible = false;
            panel1.Visible = false;
            DateTime now = DateTime.Now;
            label9.Location = new Point(35, 3);
            this.label9.Font = new Font("MS UI Gothic", 20);
            label10.Location = new Point(115, 8);
            label10.Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            label11.Location = new Point(146, 3);
            label11.Font = new Font("MS UI Gothic", 20);
            label14.Location = new Point(11, 5);
            label9.Text = now.ToString("MM/dd");
            label10.Text = now.ToString("ddd");
            label11.Text = now.ToString("HH:mm:ss");
            ts15.Enabled = true;
            ts3.Enabled = false;
            label17.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
        }
        private void tsmicH(object sender, EventArgs e)
        {
            Font fd = new Font("MS UI Gothic", 12, FontStyle.Bold);
            label1.Font = fd;
            label1.ForeColor = Color.Black;
            label2.Font = fd;
            label2.ForeColor = Color.Black;
            label9.Font = fd;
            label9.ForeColor = Color.Black;
            label10.Font = new Font("MS UI Gothic", 9, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label11.Font = fd;
            label11.ForeColor = Color.Black;
            label12.Font = new Font("MS UI Gothic", 9, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label13.Font = fd;
            label13.ForeColor = Color.Black;
        }
        private void ts18_Click(object sender, EventArgs e)
        {
            nResult = 0;
            SLD();
        }
        private void ts19_Click(object sender, EventArgs e)
        {
            nResult = 1;
            SLD();
        }
        private void ts15_Click(object sender, EventArgs e)
        {
            //clearstop();
            //d2l = 0;
            //SLD();
            //Resetvisual();
        }

        private void ts041_Click(object? sender, EventArgs? e)
        {
            try
            {
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_DONOTROUND, sizeof(int));
            }
            catch { }
            sss = 0;
            mod[11] = "0";
            Resetvisual();
        }

        private void ts042_Click(object? sender, EventArgs? e)
        {
            try
            {
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_DONOTROUND, sizeof(int));
            }
            catch { }
            label17.Parent = this;
            label18.Parent = this;
            mod[11] = "1";
            sss = 1;
            Resetvisual();
        }

        private void ts043_Click(object? sender, EventArgs? e)
        {
            try
            {
                DWMWCP_ROUND = (DWM_WINDOW_CORNER_PREFERENCE)2;
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_ROUND, sizeof(int));
            }
            catch { }
            label9.Parent = this;
            label17.Parent = this;
            label18.Parent = this;
            mod[11] = "2";
            sss = 1;
            Resetvisual();
        }

        private void 透過表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox2.BackgroundImage=null;
            this.TransparencyKey = this.BackColor;
            ts04f = 1;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (ts04f == 1)
            {
                this.TransparencyKey = this.BackColor;
            }
        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            clearstop();
            d2l = 0;
            SLD();
            Resetvisual();
        }
    }
}

