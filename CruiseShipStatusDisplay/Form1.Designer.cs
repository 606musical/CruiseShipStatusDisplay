namespace CruiseShipStatusDisplay
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ts1 = new ToolStripMenuItem();
            ts2 = new ToolStripMenuItem();
            ts3 = new ToolStripMenuItem();
            ts4 = new ToolStripMenuItem();
            ts5 = new ToolStripMenuItem();
            ts6 = new ToolStripMenuItem();
            ts70 = new ToolStripMenuItem();
            ts71 = new ToolStripMenuItem();
            ts7 = new ToolStripMenuItem();
            ts8 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            ts17 = new ToolStripMenuItem();
            ts50 = new ToolStripComboBox();
            ts51 = new ToolStripMenuItem();
            ts52 = new ToolStripMenuItem();
            ts53 = new ToolStripMenuItem();
            ts17A = new ToolStripMenuItem();
            ts18 = new ToolStripMenuItem();
            ts19 = new ToolStripMenuItem();
            ts15 = new ToolStripMenuItem();
            ts16 = new ToolStripMenuItem();
            ts60 = new ToolStripMenuItem();
            ts61 = new ToolStripMenuItem();
            ts62 = new ToolStripMenuItem();
            本体表示切替ToolStripMenuItem = new ToolStripMenuItem();
            ts041 = new ToolStripMenuItem();
            ts042 = new ToolStripMenuItem();
            ts043 = new ToolStripMenuItem();
            透過表示ToolStripMenuItem = new ToolStripMenuItem();
            ts13 = new ToolStripMenuItem();
            ts12 = new ToolStripMenuItem();
            ts9 = new ToolStripMenuItem();
            ts10 = new ToolStripMenuItem();
            ts11 = new ToolStripMenuItem();
            ts21 = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            progressBar1 = new ProgressBar();
            label8 = new Label();
            numericUpDown3 = new NumericUpDown();
            button3 = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            colorDialog1 = new ColorDialog();
            label15 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label17 = new Label();
            fontDialog = new FontDialog();
            label16 = new Label();
            progressBar2 = new ProgressBar();
            timer4 = new System.Windows.Forms.Timer(components);
            label10 = new Label();
            toolStripMenuItem3 = new ToolStripMenuItem();
            label18 = new Label();
            label19 = new Label();
            timer5 = new System.Windows.Forms.Timer(components);
            pictureBox182 = new PictureBox();
            pictureBox1 = new PictureBox();
            label14 = new Label();
            pictureBox2 = new PictureBox();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox182).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(240, 240, 240);
            numericUpDown1.Location = new Point(185, 174);
            numericUpDown1.Margin = new Padding(4, 2, 4, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 59, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 19);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.FromArgb(240, 240, 240);
            numericUpDown2.Location = new Point(110, 174);
            numericUpDown2.Margin = new Padding(4, 2, 4, 2);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 59, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(40, 19);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.ValueChanged += NumericUpDown2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ContextMenuStrip = contextMenuStrip1;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 33);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.ContextMenuStripChanged += MTSMIC;
            label1.DoubleClick += Label1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.Control;
            contextMenuStrip1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ts1, ts2, ts3, ts4, ts5, ts6, ts7, ts8, toolStripMenuItem1, ts9, ts10, ts11, ts21 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(201, 290);
            contextMenuStrip1.Text = "選択";
            contextMenuStrip1.Opening += tsmicB;
            // 
            // ts1
            // 
            ts1.Name = "ts1";
            ts1.Size = new Size(200, 22);
            ts1.Text = "グラフィック表示";
            ts1.ToolTipText = "306";
            ts1.Click += TSMI7C;
            ts1.MouseEnter += TSMI7ME1;
            ts1.MouseLeave += TSMI7ML;
            // 
            // ts2
            // 
            ts2.Name = "ts2";
            ts2.Size = new Size(200, 22);
            ts2.Text = "テキスト表示";
            ts2.Click += TSMI8C;
            ts2.MouseEnter += TSMI7ME1;
            ts2.MouseLeave += TSMI7ML;
            // 
            // ts3
            // 
            ts3.Name = "ts3";
            ts3.Size = new Size(200, 22);
            ts3.Text = "作業領域表示";
            ts3.Click += Label1_DoubleClick;
            ts3.MouseEnter += TSMI7ME1;
            ts3.MouseLeave += TSMI7ML;
            // 
            // ts4
            // 
            ts4.Name = "ts4";
            ts4.ShortcutKeys = Keys.Alt | Keys.C;
            ts4.Size = new Size(200, 22);
            ts4.Text = "コントロールパネル (win)";
            ts4.Click += tsmic6;
            ts4.MouseEnter += TSMI7ME1;
            ts4.MouseLeave += TSMI7ML;
            // 
            // ts5
            // 
            ts5.Name = "ts5";
            ts5.ShortcutKeys = Keys.Alt | Keys.E;
            ts5.Size = new Size(200, 22);
            ts5.Text = "エクスプローラ (フォルダ)";
            ts5.Click += tsmic7;
            ts5.MouseEnter += TSMI7ME1;
            ts5.MouseLeave += TSMI7ML;
            // 
            // ts6
            // 
            ts6.DropDownItems.AddRange(new ToolStripItem[] { ts70, ts71 });
            ts6.Name = "ts6";
            ts6.ShortcutKeys = Keys.Alt | Keys.O;
            ts6.Size = new Size(200, 22);
            ts6.Text = "画面消灯";
            ts6.Click += tsmic8;
            ts6.MouseEnter += TSMI7ME1;
            ts6.MouseLeave += TSMI7ML;
            // 
            // ts70
            // 
            ts70.Name = "ts70";
            ts70.Size = new Size(92, 22);
            ts70.Text = "1分";
            ts70.Click += ts70_Click;
            ts70.MouseEnter += TSMI7ME1;
            ts70.MouseLeave += TSMI7ML;
            // 
            // ts71
            // 
            ts71.Name = "ts71";
            ts71.Size = new Size(92, 22);
            ts71.Text = "3分";
            ts71.Click += ts71_Click;
            ts71.MouseEnter += TSMI7ME1;
            ts71.MouseLeave += TSMI7ML;
            // 
            // ts7
            // 
            ts7.Name = "ts7";
            ts7.Size = new Size(200, 22);
            ts7.Text = "最小化";
            ts7.Click += TSMI11C1;
            ts7.MouseEnter += TSMI7ME1;
            ts7.MouseLeave += TSMI7ML;
            // 
            // ts8
            // 
            ts8.Name = "ts8";
            ts8.ShortcutKeys = Keys.Control | Keys.Alt | Keys.Space;
            ts8.Size = new Size(200, 22);
            ts8.Text = "終了";
            ts8.Click += tsmicC;
            ts8.MouseEnter += TSMI7ME1;
            ts8.MouseLeave += TSMI7ML;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.CheckOnClick = true;
            toolStripMenuItem1.DropDown = contextMenuStrip2;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(200, 22);
            toolStripMenuItem1.Text = "他の機能";
            toolStripMenuItem1.MouseEnter += TSMI7ME1;
            toolStripMenuItem1.MouseLeave += TSMI7ML;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { ts17, ts17A, ts18, ts19, ts15, ts16, 本体表示切替ToolStripMenuItem, ts13, ts12 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.ShowImageMargin = false;
            contextMenuStrip2.Size = new Size(174, 224);
            contextMenuStrip2.Text = "cms2";
            contextMenuStrip2.Opening += contextMenuStrip2_Opening;
            // 
            // ts17
            // 
            ts17.DropDownItems.AddRange(new ToolStripItem[] { ts50, ts51, ts52, ts53 });
            ts17.Name = "ts17";
            ts17.Size = new Size(173, 22);
            ts17.Text = "マウスでウィンドウを最前面";
            ts17.MouseEnter += TSMI7ME1;
            ts17.MouseLeave += TSMI7ML;
            // 
            // ts50
            // 
            ts50.AutoCompleteCustomSource.AddRange(new string[] { "500", "400", "300", "200", "100", "50", "0" });
            ts50.Items.AddRange(new object[] { "500", "400", "300", "200", "100", "50", "0" });
            ts50.Name = "ts50";
            ts50.Size = new Size(121, 23);
            ts50.SelectedIndexChanged += TSCB1SIC;
            // 
            // ts51
            // 
            ts51.Name = "ts51";
            ts51.Size = new Size(181, 22);
            ts51.Text = "応答速度 500 - 0";
            ts51.MouseEnter += TSMI7ME1;
            ts51.MouseLeave += TSMI7ML;
            // 
            // ts52
            // 
            ts52.Name = "ts52";
            ts52.Size = new Size(181, 22);
            ts52.Text = "ON";
            ts52.Click += OTSMIC;
            ts52.MouseEnter += TSMI7ME1;
            ts52.MouseLeave += TSMI7ML;
            // 
            // ts53
            // 
            ts53.Name = "ts53";
            ts53.Size = new Size(181, 22);
            ts53.Text = "OFF";
            ts53.Click += OFTSMIC;
            ts53.MouseEnter += TSMI7ME1;
            ts53.MouseLeave += TSMI7ML;
            // 
            // ts17A
            // 
            ts17A.Name = "ts17A";
            ts17A.Size = new Size(173, 22);
            ts17A.Text = "位置固定";
            ts17A.Click += tSMI2C;
            ts17A.MouseEnter += TSMI7ME1;
            ts17A.MouseLeave += TSMI7ML;
            // 
            // ts18
            // 
            ts18.Name = "ts18";
            ts18.Size = new Size(173, 22);
            ts18.Text = "ダークモード";
            ts18.Click += ts18_Click;
            ts18.MouseEnter += TSMI7ME1;
            ts18.MouseLeave += TSMI7ML;
            // 
            // ts19
            // 
            ts19.Name = "ts19";
            ts19.Size = new Size(173, 22);
            ts19.Text = "ライトモード";
            ts19.Click += ts19_Click;
            ts19.MouseEnter += TSMI7ME1;
            ts19.MouseLeave += TSMI7ML;
            // 
            // ts15
            // 
            ts15.Enabled = false;
            ts15.Name = "ts15";
            ts15.Size = new Size(173, 22);
            ts15.Text = "通常表示(透過終了)";
            ts15.Click += ts15_Click;
            ts15.MouseEnter += TSMI7ME1;
            ts15.MouseLeave += TSMI7ML;
            // 
            // ts16
            // 
            ts16.DropDownItems.AddRange(new ToolStripItem[] { ts60, ts61, ts62 });
            ts16.Name = "ts16";
            ts16.Size = new Size(173, 22);
            ts16.Text = "文字";
            ts16.MouseEnter += TSMI7ME1;
            ts16.MouseLeave += TSMI7ML;
            // 
            // ts60
            // 
            ts60.Name = "ts60";
            ts60.Size = new Size(122, 22);
            ts60.Text = "色選択";
            ts60.Click += tsmic4;
            ts60.MouseEnter += TSMI7ME1;
            ts60.MouseLeave += TSMI7ML;
            // 
            // ts61
            // 
            ts61.Name = "ts61";
            ts61.Size = new Size(122, 22);
            ts61.Text = "フォント";
            ts61.Click += tsmic5;
            ts61.MouseEnter += TSMI7ME1;
            ts61.MouseLeave += TSMI7ML;
            // 
            // ts62
            // 
            ts62.Name = "ts62";
            ts62.Size = new Size(122, 22);
            ts62.Text = "初期設定";
            ts62.Click += ts62_Click;
            ts62.MouseEnter += TSMI7ME1;
            ts62.MouseLeave += TSMI7ML;
            // 
            // 本体表示切替ToolStripMenuItem
            // 
            本体表示切替ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ts041, ts042, ts043, 透過表示ToolStripMenuItem, toolStripMenuItem2 });
            本体表示切替ToolStripMenuItem.Name = "本体表示切替ToolStripMenuItem";
            本体表示切替ToolStripMenuItem.Size = new Size(173, 22);
            本体表示切替ToolStripMenuItem.Text = "本体表示切替";
            // 
            // ts041
            // 
            ts041.Name = "ts041";
            ts041.Size = new Size(188, 22);
            ts041.Text = "オリジナルスキン";
            ts041.Click += ts041_Click;
            // 
            // ts042
            // 
            ts042.Name = "ts042";
            ts042.Size = new Size(188, 22);
            ts042.Text = "本体真四角(win10,11)";
            ts042.Click += ts042_Click;
            // 
            // ts043
            // 
            ts043.Name = "ts043";
            ts043.Size = new Size(188, 22);
            ts043.Text = "本体角丸 (win11) ";
            ts043.Click += ts043_Click;
            // 
            // 透過表示ToolStripMenuItem
            // 
            透過表示ToolStripMenuItem.Name = "透過表示ToolStripMenuItem";
            透過表示ToolStripMenuItem.Size = new Size(188, 22);
            透過表示ToolStripMenuItem.Text = "透過表示";
            透過表示ToolStripMenuItem.Click += 透過表示ToolStripMenuItem_Click;
            // 
            // ts13
            // 
            ts13.Name = "ts13";
            ts13.Size = new Size(173, 22);
            ts13.Text = "cfg を B として保存";
            ts13.Click += ts13_Click;
            ts13.MouseEnter += TSMI7ME1;
            ts13.MouseLeave += TSMI7ML;
            // 
            // ts12
            // 
            ts12.Name = "ts12";
            ts12.Size = new Size(173, 22);
            ts12.Text = "cfg を A として保存";
            ts12.Click += ts12_Click_1;
            ts12.MouseEnter += TSMI7ME1;
            ts12.MouseLeave += TSMI7ML;
            // 
            // ts9
            // 
            ts9.Name = "ts9";
            ts9.Size = new Size(200, 22);
            ts9.Text = "現在cfgのコピーはありません";
            // 
            // ts10
            // 
            ts10.Name = "ts10";
            ts10.ShortcutKeys = Keys.Alt | Keys.A;
            ts10.Size = new Size(200, 22);
            ts10.Text = "cfg に A を上書き";
            ts10.Click += tsmic9;
            ts10.MouseEnter += TSMI7ME1;
            ts10.MouseLeave += TSMI7ML;
            // 
            // ts11
            // 
            ts11.Name = "ts11";
            ts11.ShortcutKeys = Keys.Alt | Keys.B;
            ts11.Size = new Size(200, 22);
            ts11.Text = "cfg に B を上書き";
            ts11.Click += tsmic0;
            ts11.MouseEnter += TSMI7ME1;
            ts11.MouseLeave += TSMI7ML;
            // 
            // ts21
            // 
            ts21.Name = "ts21";
            ts21.ShortcutKeyDisplayString = "";
            ts21.ShortcutKeys = Keys.Alt | Keys.Space;
            ts21.Size = new Size(200, 22);
            ts21.Text = "このメニューを閉じる";
            ts21.Click += TSMI5C;
            ts21.MouseEnter += TSMI7ME1;
            ts21.MouseLeave += TSMI7ML;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ContextMenuStrip = contextMenuStrip1;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label2.Location = new Point(211, 33);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(51, 16);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.DoubleClick += Label1_DoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(14, 149);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 12);
            label3.TabIndex = 5;
            label3.Text = "対象残時間";
            label3.DoubleClick += Label1_DoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(14, 124);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 12);
            label4.TabIndex = 4;
            label4.Text = "計測日時";
            label4.Click += Label1_DoubleClick;
            // 
            // label5
            // 
            label5.AccessibleDescription = "";
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(14, 176);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 12);
            label5.TabIndex = 7;
            label5.Text = "記録値調整";
            label5.DoubleClick += Label1_DoubleClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(59, 90);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(2, 2, 0, 0);
            button1.Size = new Size(42, 23);
            button1.TabIndex = 4;
            button1.Text = "確認";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(12, 90);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(2, 2, 0, 0);
            button2.Size = new Size(43, 23);
            button2.TabIndex = 3;
            button2.Text = "記録";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 240, 240);
            textBox1.Location = new Point(109, 121);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 19);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(240, 240, 240);
            textBox2.Location = new Point(109, 146);
            textBox2.Margin = new Padding(4, 2, 4, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 19);
            textBox2.TabIndex = 6;
            textBox2.Text = ".";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Magenta;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(109, 68);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 41);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(160, 178);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(17, 12);
            label6.TabIndex = 18;
            label6.Text = "秒";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(233, 178);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(17, 12);
            label7.TabIndex = 17;
            label7.Text = "分";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Control;
            progressBar1.Location = new Point(8, 26);
            progressBar1.Margin = new Padding(0);
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.Yes;
            progressBar1.RightToLeftLayout = true;
            progressBar1.Size = new Size(248, 2);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 20;
            progressBar1.Value = 100;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 206);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 12);
            label8.TabIndex = 21;
            label8.DoubleClick += Label1_DoubleClick;
            // 
            // numericUpDown3
            // 
            numericUpDown3.BackColor = Color.FromArgb(240, 240, 240);
            numericUpDown3.DecimalPlaces = 3;
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown3.Location = new Point(110, 202);
            numericUpDown3.Margin = new Padding(4, 2, 4, 2);
            numericUpDown3.Maximum = new decimal(new int[] { 9999, 0, 0, 196608 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(64, 19);
            numericUpDown3.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(184, 200);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(0, 2, 0, 0);
            button3.Size = new Size(41, 22);
            button3.TabIndex = 10;
            button3.Text = "更新";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.Control;
            checkBox1.CheckAlign = ContentAlignment.TopLeft;
            checkBox1.Location = new Point(16, 64);
            checkBox1.Margin = new Padding(0);
            checkBox1.Name = "checkBox1";
            checkBox1.Padding = new Padding(2, 2, 0, 0);
            checkBox1.Size = new Size(35, 22);
            checkBox1.TabIndex = 1;
            checkBox1.Text = " 荷 ";
            checkBox1.TextAlign = ContentAlignment.TopLeft;
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ツイン", "サン" });
            comboBox1.Location = new Point(47, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(54, 20);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label9.Location = new Point(6, 5);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(51, 16);
            label9.TabIndex = 28;
            label9.Text = "label9";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label11.Location = new Point(82, 5);
            label11.Name = "label11";
            label11.Size = new Size(60, 16);
            label11.TabIndex = 30;
            label11.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label12.Location = new Point(156, 8);
            label12.Name = "label12";
            label12.Size = new Size(41, 12);
            label12.TabIndex = 31;
            label12.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label13.Location = new Point(189, 5);
            label13.Name = "label13";
            label13.Size = new Size(60, 16);
            label13.TabIndex = 32;
            label13.Text = "label13";
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.FullOpen = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("MS UI Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.ImageAlign = ContentAlignment.TopLeft;
            label15.Location = new Point(110, 25);
            label15.Margin = new Padding(0);
            label15.Name = "label15";
            label15.Size = new Size(42, 17);
            label15.TabIndex = 35;
            label15.Text = "label15";
            label15.UseCompatibleTextRendering = true;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += Timer2_Tick;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label17.ImageAlign = ContentAlignment.MiddleRight;
            label17.Location = new Point(175, 33);
            label17.MaximumSize = new Size(50, 0);
            label17.MinimumSize = new Size(30, 0);
            label17.Name = "label17";
            label17.Size = new Size(30, 16);
            label17.TabIndex = 38;
            label17.Text = "R";
            label17.TextAlign = ContentAlignment.TopRight;
            label17.Click += Label17_Click;
            // 
            // fontDialog
            // 
            fontDialog.ShowApply = true;
            // 
            // label16
            // 
            label16.AccessibleDescription = "";
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(14, 204);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(65, 12);
            label16.TabIndex = 39;
            label16.Text = "遅延系調整";
            // 
            // progressBar2
            // 
            progressBar2.BackColor = SystemColors.Control;
            progressBar2.ForeColor = Color.Transparent;
            progressBar2.Location = new Point(8, 54);
            progressBar2.Margin = new Padding(0);
            progressBar2.Name = "progressBar2";
            progressBar2.RightToLeft = RightToLeft.Yes;
            progressBar2.RightToLeftLayout = true;
            progressBar2.Size = new Size(248, 1);
            progressBar2.Step = 1;
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.TabIndex = 40;
            progressBar2.Value = 100;
            progressBar2.Visible = false;
            // 
            // timer4
            // 
            timer4.Interval = 1000;
            timer4.Tick += Timer4_Tick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.Location = new Point(61, 8);
            label10.Name = "label10";
            label10.Size = new Size(0, 12);
            label10.TabIndex = 29;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(32, 19);
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Location = new Point(14, 231);
            label18.Name = "label18";
            label18.Size = new Size(41, 12);
            label18.TabIndex = 42;
            label18.Text = "label18";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(196, 231);
            label19.Name = "label19";
            label19.Size = new Size(62, 12);
            label19.TabIndex = 43;
            label19.Text = "606musical";
            // 
            // timer5
            // 
            timer5.Tick += timer5_Tick;
            // 
            // pictureBox182
            // 
            pictureBox182.BorderStyle = BorderStyle.FixedSingle;
            pictureBox182.Image = Properties.Resources.map2;
            pictureBox182.Location = new Point(8, 2);
            pictureBox182.Name = "pictureBox182";
            pictureBox182.Size = new Size(248, 53);
            pictureBox182.TabIndex = 34;
            pictureBox182.TabStop = false;
            pictureBox182.DoubleClick += Label1_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(174, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 10);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ContextMenuStrip = contextMenuStrip1;
            label14.FlatStyle = FlatStyle.Popup;
            label14.Font = new Font("MS UI Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label14.Location = new Point(511, 9);
            label14.Margin = new Padding(0);
            label14.Name = "label14";
            label14.Size = new Size(27, 16);
            label14.TabIndex = 33;
            label14.Text = "    ";
            label14.DoubleClick += Label17_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Magenta;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 250);
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(188, 22);
            toolStripMenuItem2.Text = "透過表示終了";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(264, 250);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(label15);
            Controls.Add(pictureBox182);
            Controls.Add(progressBar1);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar2);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(numericUpDown3);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(label10);
            Controls.Add(pictureBox2);
            Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MaximumSize = new Size(560, 250);
            MinimizeBox = false;
            MinimumSize = new Size(240, 50);
            Name = "Form1";
            Text = "巡航船状況表示";
            TopMost = true;
            Activated += Form1_Activated;
            Deactivate += Form1_Deactivate;
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            DoubleClick += Label1_DoubleClick;
            MouseDown += Form1_MouseDown;
            MouseLeave += Form1_MouseLeave;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox182).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox182;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem ts8;
        private System.Windows.Forms.FontDialog fontDialog;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ts4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem ts5;
        private System.Windows.Forms.ToolStripMenuItem ts21;
        private System.Windows.Forms.ToolStripMenuItem ts6;
        private System.Windows.Forms.ToolStripMenuItem ts10;
        private System.Windows.Forms.ToolStripMenuItem ts11;
        private System.Windows.Forms.ToolStripMenuItem ts9;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ToolStripMenuItem ts1;
        private System.Windows.Forms.ToolStripMenuItem ts2;
        private System.Windows.Forms.ToolStripMenuItem ts3;
        private System.Windows.Forms.ToolStripMenuItem ts7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ts12;
        private System.Windows.Forms.ToolStripMenuItem ts13;
        private System.Windows.Forms.ToolStripMenuItem ts18;
        private System.Windows.Forms.ToolStripMenuItem ts19;
        private System.Windows.Forms.ToolStripMenuItem ts16;
        private System.Windows.Forms.ToolStripMenuItem ts60;
        private System.Windows.Forms.ToolStripMenuItem ts61;
        private System.Windows.Forms.ToolStripMenuItem ts62;
        private System.Windows.Forms.ToolStripMenuItem ts15;
        private System.Windows.Forms.ToolStripMenuItem ts17;
        internal System.Windows.Forms.ToolStripComboBox ts50;
        private System.Windows.Forms.ToolStripMenuItem ts51;
        private System.Windows.Forms.ToolStripMenuItem ts52;
        private System.Windows.Forms.ToolStripMenuItem ts53;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.ToolStripMenuItem ts17A;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        public System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem ts70;
        private System.Windows.Forms.ToolStripMenuItem ts71;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ToolStripMenuItem 本体表示切替ToolStripMenuItem;
        private ToolStripMenuItem ts041;
        private ToolStripMenuItem ts042;
        private ToolStripMenuItem ts043;
        private ToolStripMenuItem 透過表示ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}

