using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace CruiseShipStatusDisplay
{
    public partial class Form1 : Form
    {
        Point mousePoint;
        DateTime dat1, datX;
        TimeSpan dat2, dat3, wts, s2t, t2s, ragA;
        DateTime[] sts = new DateTime[481];
        int[] ccr = { 0 };
        string[] mod = { "" };
        string? now1, fix, fix2, fix3, fix4, tmpx;
        int nv1, nv2, fbpc, chb = 0, tc2, vu, fml, fmt, fmw, fmh, nResult, d2l, fmm, w11f, sss, ts04f;
        int[] cspht2s = { 56, 56, 56, 56, 56, 56, 56, 56, 56, 57, 57, 58, 58, 59, 59, 60, 60, 61, 61, 62, 62, 63, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 143, 144, 145, 146, 147, 148, 148, 149, 150, 151, 152, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 177, 178, 179, 180, 181, 181, 183, 184, 184 };
        int[] cspvt2s = { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 37, 39, 40, 41, 42, 43, 44, 45, 45, 46, 47, 47, 46, 45, 44, 43, 42, 41, 40, 40, 39, 38, 37, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 38, 38, 38, 38, 38, 37, 37, 37, 36, 36, 36, 36, 35, 35, 35, 34, 34, 34, 34, 34, 35, 35, 36, 36, 37, 37, 38, 38, 39, 39, 38, 37, 36, 35, 34, 33, 32, 30, 31, 29, 28, 27, 26, 24, 25, 23, 22, 21, 19, 20, 18, 17, 17, 16, 15, 14, 13, 12, 11, 10, 9, 9, 8, 8, 7, 7, 7, 7, 7, 7, 8, 8, 9, 9, 10, 10, 11, 12, 13, 15, 16, 17 };
        int[] csphs2t = { 184, 184, 183, 181, 181, 180, 179, 178, 177, 175, 174, 173, 172, 171, 170, 169, 168, 167, 166, 165, 164, 163, 162, 161, 160, 159, 158, 157, 156, 155, 154, 153, 152, 152, 151, 150, 149, 148, 148, 147, 146, 145, 144, 143, 143, 142, 141, 140, 139, 138, 137, 136, 135, 134, 133, 132, 131, 130, 129, 128, 127, 126, 125, 124, 123, 122, 121, 120, 119, 118, 117, 116, 115, 114, 113, 112, 111, 110, 109, 108, 107, 106, 105, 104, 103, 102, 101, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 63, 62, 62, 61, 61, 60, 60, 59, 59, 58, 58, 57, 57, 56, 56, 56, 56, 56, 56, 56, 56, 56 };
        int[] cspvs2t = { 17, 16, 15, 13, 12, 11, 10, 10, 9, 9, 8, 8, 7, 7, 7, 7, 7, 7, 8, 8, 9, 9, 10, 11, 12, 13, 14, 15, 16, 17, 17, 18, 20, 19, 21, 22, 23, 25, 24, 26, 27, 28, 29, 31, 30, 32, 33, 34, 35, 36, 37, 38, 39, 39, 38, 38, 37, 37, 36, 36, 35, 35, 34, 34, 34, 34, 34, 35, 35, 35, 36, 36, 36, 36, 37, 37, 37, 38, 38, 38, 38, 38, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 37, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 37, 38, 39, 40, 40, 41, 42, 43, 44, 45, 46, 47, 47, 46, 45, 45, 44, 43, 42, 41, 40, 39, 37, 35, 34, 33, 32, 31, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20 };
        Color fcC = Color.FromArgb(200, 200, 200);
        Color bcC = Color.FromArgb(90, 90, 90);
        Color fcD = Color.FromArgb(30, 30, 30);
        Color bcD = Color.FromArgb(240, 240, 240);
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
                    ts52.Text = "ON now";
                    ts53.Text = "OFF";
                }
                if (tkg == "9F" || tkg == "9E" || tkg == "98" || tkg == "90")
                {
                    ts53.Enabled = false;
                    ts52.Enabled = true;
                    ts52.Text = "ON";
                    ts53.Text = "OFF now";
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


            this.MouseWheel += new MouseEventHandler(Form1_MouseWheel);
            using (StreamReader sr = new StreamReader(@"mode.txt"))
            {
                string s1A = sr.ReadToEnd(); s1A = s1A.Replace(Environment.NewLine, "\r");
                s1A = s1A.Trim('\r'); mod = s1A.Split('\r');
                foreach (string item in mod) { if (item == "end") { break; } }
                this.SetDesktopLocation(int.Parse(mod[1]), int.Parse(mod[2]));
            }
            Debug.WriteLine("909" + int.Parse(mod[4].Substring(0, 2)));
            decimal tmp8 = int.Parse(mod[4].Substring(0, 2));
            decimal tmp9 = int.Parse(mod[4].Substring(2, 2));
            numericUpDown1.Value = tmp8;
            nv1 = int.Parse(mod[4].Substring(0, 2));
            nv2 = int.Parse(mod[4].Substring(2, 2));
            numericUpDown2.Value = tmp9;
            comboBox2.SelectedIndex = 0;
            Vuc();
            Re_start();
            if (mod[9] == "0") { ts041_Click(null, null); }
            if (mod[9] == "1" || mod[9] == "end") { ts042_Click(null, null); }
            if (mod[9] == "2") { ts043_Click(null, null); }
            SLD();
            Resetvisual();

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
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
            datacopie();
            Writefile();
        }
        private void Re_start()
        {
            try
            {
                wts = TimeSpan.Parse(mod[5]);
                s2t = TimeSpan.Parse(mod[6]);
                t2s = TimeSpan.Parse(mod[7]);

                string tmpe = (mod[3].Substring(0, 4) + "/" + mod[3].Substring(4, 2) + "/" + mod[3].Substring(6, 2) + " " + mod[3].Substring(8, 2) + ":" + mod[3].Substring(10, 2) + ":" + mod[3].Substring(12, 2));
                tmpx = (mod[3].Substring(0, 4) + mod[3].Substring(4, 2) + mod[3].Substring(6, 2) + mod[3].Substring(8, 2) + mod[3].Substring(10, 2) + mod[3].Substring(12, 2));
                dat1 = DateTime.Parse(tmpe);
                textBox1.Text = tmpx.ToString();
                double aq = double.Parse(mod[8]);
                double aw = 10000;
                double ae = aq / aw;
                decimal ar = (decimal)(ae);
                numericUpDown3.Value = ar;
                string at = ("00:00:00:00." + mod[8]);
                TimeSpan sample = new TimeSpan(0, 0, 0, 0, (int.Parse(mod[8]) / 10));
                ragA = sample;
                comboBox1.SelectedIndex = int.Parse(mod[0]);
                if (mod[3].Length < 14 || mod[3].Length > 14)
                {
                    label1.Text = ("14 digits missing"); label2.Text = ("check");
                }
                if (dat1 < DateTime.Now - new TimeSpan(10, 0, 0, 0) || DateTime.Now + new TimeSpan(10, 0, 0, 0) < dat1)
                {
                    label1.Text = ("±30 days exceeded"); label2.Text = ("check");
                }
                dat2 = new TimeSpan(00, 00, 00, 00, int.Parse(mod[8]));
                if (mod[8] == "0") { }
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
            catch
            {
                timer1.Enabled = false;
                this.Height = 250;
                label1.Text = "";
                label9.Text = "No data";
                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
                label2.Text = "";
                return;
            }
        }
        private void datacopie()
        {
            mod[4] = nv1.ToString("D2") + nv2.ToString("D2");
            //if (nv1 < 0) { nv1 = 100 + -nv1; }
            //if (nv2 < 0) { nv2 = 100 + -nv2; }
            //if (fs == 0) { rsd = (string[])s2.Clone(); }
            //if (fs == 1) { gsd = (string[])s2.Clone(); }
            //if (fs == 2) { rcd = (string[])s2.Clone(); }
            //if (fs == 3) { gcd = (string[])s2.Clone(); }
        }
        private void Writefile()
        {
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
                writer.WriteLine(mod[4]);
                writer.WriteLine(mod[5]);
                writer.WriteLine(mod[6]);
                writer.WriteLine(mod[7]);
                //if (scn == "end") { scn = "N"; }
                writer.WriteLine(mod[8]);
                writer.WriteLine(mod[9]);
                writer.Write("end");
            }
        }
        private void Vuc()
        {
            try
            {
                progressBar2.Value = vu;
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
            }
            else
            {
                pictureBox2.Visible = false;
                label1.Parent = this;
                label2.Parent = this;
                label3.Parent = this;
                label9.Parent = this;
            }
            progressBar1.Visible = true;
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
                button1.ForeColor = fcC;
                toolStripMenuItem1.ForeColor = fcC;
                ts1.ForeColor = fcC;
                ts2.ForeColor = fcC;
                ts3.ForeColor = fcC;
                ts4.ForeColor = fcC;
                ts5.ForeColor = fcC;
                ts6.ForeColor = fcC;
                ts7.ForeColor = fcC;
                ts8.ForeColor = fcC;
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
                button1.BackColor = bcC;
                textBox1.BackColor = bcC;
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
                button1.ForeColor = fcD;
                toolStripMenuItem1.ForeColor = fcD;
                ts1.ForeColor = fcD;
                ts2.ForeColor = fcD;
                ts3.ForeColor = fcD;
                ts4.ForeColor = fcD;
                ts5.ForeColor = fcD;
                ts6.ForeColor = fcD;
                ts7.ForeColor = fcD;
                ts8.ForeColor = fcD;
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
                textBox1.ForeColor = fcD;
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
                button1.BackColor = bcD;
                toolStripMenuItem1.BackColor = bcD;
                ts1.BackColor = bcD;
                ts2.BackColor = bcD;
                ts3.BackColor = bcD;
                ts4.BackColor = bcD;
                ts5.BackColor = bcD;
                ts6.BackColor = bcD;
                ts7.BackColor = bcD;
                ts8.BackColor = bcD;
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
                contextMenuStrip1.BackColor = bcD;
                bcD = Color.FromArgb(250, 250, 250);
                textBox1.BackColor = bcD;
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
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mod[0] = (comboBox1.SelectedIndex).ToString();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nv1 = (int)numericUpDown1.Value;
            dat3 = new TimeSpan(0, nv1, nv2);
            Debug.WriteLine(dat3);

            datacopie(); Writefile(); Re_start();
        }
        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            nv2 = (int)numericUpDown2.Value;
            dat3 = new TimeSpan(0, nv1, nv2);
            datacopie(); Writefile(); Re_start();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //numericUpDown1.Value = int.Parse(mod[4].Substring(0, 2));
            //numericUpDown2.Value = int.Parse(mod[4].Substring(2, 2));
            now1 = DateTime.Now.ToString("yyyyMMddHHmmss");
            textBox1.Text = now1;
            mod[3] = now1;
            chb = 1;
            Writefile(); Re_start();

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (chb == 1)
            {
                //now1 = DateTime.Now.ToString("yyyyMMddHHmmss");
                //mod[3] = now1;
                //mod[4] = rett[0].ToString("D2") + rett[1].ToString("D2");
                datacopie();
                Writefile();
                //string buf = "backup\\" + rsfile[fs];
                //if (!System.IO.Directory.Exists("backup"))
                //{
                //    Directory.CreateDirectory("backup");
                //}
                //System.IO.File.Copy(rsfile[fs], buf, true);
                Re_start();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (fix4 != null)
            {
                this.Text = label1.Text.Substring(0, 1) + fix4.Substring(2, 1) + "  " + fix3;
            }
            label9.Text = now.ToString("MM/dd");
            var culture = new System.Globalization.CultureInfo("en-US");

            label10.Text = now.ToString("ddd", culture);
            label11.Text = now.ToString("HH:mm:ss");
            label12.Text = fix4;
            label13.Text = fix3;
            for (int ii = 1; ii <= 480; ii++)
            {
                if (ii % 2 == 0)
                {
                    if (sts[ii] - wts - t2s < now && sts[ii] - wts > now)
                    {
                        label1.Text = ("Solis H.lands . Sailing");
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
                        fix4 = "ETA";
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
                        label1.Text = ("Solis H.lands . Anchored");
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
                        fix4 = "ETD";
                        label15.Text = "At anchor " + label2.Text;
                        label15.Location = new System.Drawing.Point(152, 32);
                        break;
                    }
                }
                else
                {
                    if (now > sts[ii] - wts - s2t && now < sts[ii] - wts)
                    {
                        label1.Text = ("Two Crowns . Sailing");
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
                        fix4 = "ETA";
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
                        label1.Text = ("Two Crowns . Anchored");
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
                        fix4 = "ETD";
                        label15.Text = " At anchor " + label2.Text;
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
            label16.Parent = pictureBox2;
            label18.Parent = pictureBox2;
            sss = 0;
            mod[9] = "0";
        }
        private void ts91_Click()
        {
            pictureBox2.Visible = false;
            label9.Parent = this;
            label1.Parent = this;
            label2.Parent = this;
            label3.Parent = this;
            label4.Parent = this;
            label16.Parent = this;
            label18.Parent = this;
            sss = 1;
            mod[9] = "1";

        }
        private void ts92_Click()
        {
            pictureBox2.Visible = false;
            label9.Parent = this;
            label1.Parent = this;
            label2.Parent = this;
            label3.Parent = this;
            label4.Parent = this;
            label16.Parent = this;
            label18.Parent = this;
            sss = 1;
            mod[9] = "2";
        }

        private void tsmic4(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
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
        }
        private void tsmic6(object sender, EventArgs e)
        {
            //Process.Start("shell:ControlPanelFolder");WUの関係かこれだとエラー
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
                ts17A.Text = "Fixed app position now - off";
            }
            else
            {
                ts17A.Text = "Fixed app position now - on";

            }
        }
        private void tsmic8(object sender, EventArgs e)
        {
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


        private void ts041_Click(object? sender, EventArgs? e)
        {
            try
            {
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_DONOTROUND, sizeof(int));
            }
            catch { }
            sss = 0;
            mod[9] = "0";
            Resetvisual();
        }

        private void ts042_Click(object? sender, EventArgs? e)
        {
            try
            {
                DwmSetWindowAttribute(this.Handle, DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE, ref DWMWCP_DONOTROUND, sizeof(int));
            }
            catch { }
            label18.Parent = this;
            mod[9] = "1";
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
            label18.Parent = this;
            mod[9] = "2";
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
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            decimal ay = numericUpDown3.Value * 10000;
            int au = (int)ay;
            mod[8] = au.ToString();

            datacopie();
            Writefile();
            chb = 0;
            Re_start();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tmp7 = comboBox2.SelectedIndex;
            if (tmp7 == 1)
            {
                button1.Enabled = Enabled;
            }
            else
            {
                button1.Enabled = false;
            }
            ActiveControl = label9;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void ts16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

