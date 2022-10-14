namespace Telemetry
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TextBoxDataIN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxParityBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBoxStopBits = new System.Windows.Forms.ComboBox();
            this.CBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.CBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBMSEleven33 = new System.Windows.Forms.Label();
            this.lblBMSEleven31 = new System.Windows.Forms.Label();
            this.lblBMSEleven32 = new System.Windows.Forms.Label();
            this.lblBMSEleven30 = new System.Windows.Forms.Label();
            this.lblBMSEleven28 = new System.Windows.Forms.Label();
            this.lblBMSEleven27 = new System.Windows.Forms.Label();
            this.lblBMSEleven29 = new System.Windows.Forms.Label();
            this.lblBMSEleven26 = new System.Windows.Forms.Label();
            this.lblBMSEleven25 = new System.Windows.Forms.Label();
            this.lblBMSEleven24 = new System.Windows.Forms.Label();
            this.lblBMSEleven23 = new System.Windows.Forms.Label();
            this.lblBMSEleven22 = new System.Windows.Forms.Label();
            this.lblBMSEleven20 = new System.Windows.Forms.Label();
            this.lblBMSEleven21 = new System.Windows.Forms.Label();
            this.lblBMSEleven19 = new System.Windows.Forms.Label();
            this.lblBMSEleven17 = new System.Windows.Forms.Label();
            this.lblBMSEleven16 = new System.Windows.Forms.Label();
            this.lblBMSEleven18 = new System.Windows.Forms.Label();
            this.lblBMSEleven15 = new System.Windows.Forms.Label();
            this.lblBMSEleven14 = new System.Windows.Forms.Label();
            this.lblBMSEleven13 = new System.Windows.Forms.Label();
            this.lblBMSEleven12 = new System.Windows.Forms.Label();
            this.lblBMSEleven11 = new System.Windows.Forms.Label();
            this.lblBMSEleven9 = new System.Windows.Forms.Label();
            this.lblBMSEleven10 = new System.Windows.Forms.Label();
            this.lblBMSEleven8 = new System.Windows.Forms.Label();
            this.lblBMSEleven6 = new System.Windows.Forms.Label();
            this.lblBMSEleven5 = new System.Windows.Forms.Label();
            this.lblBMSEleven7 = new System.Windows.Forms.Label();
            this.lblBMSEleven4 = new System.Windows.Forms.Label();
            this.lblBMSEleven3 = new System.Windows.Forms.Label();
            this.lblBMSEleven2 = new System.Windows.Forms.Label();
            this.lblBMSEleven1 = new System.Windows.Forms.Label();
            this.lblBMSTop3 = new System.Windows.Forms.Label();
            this.lblBMSTop2 = new System.Windows.Forms.Label();
            this.lblBMSTop1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // TextBoxDataIN
            // 
            this.TextBoxDataIN.Location = new System.Drawing.Point(15, 21);
            this.TextBoxDataIN.Multiline = true;
            this.TextBoxDataIN.Name = "TextBoxDataIN";
            this.TextBoxDataIN.Size = new System.Drawing.Size(384, 159);
            this.TextBoxDataIN.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataShow);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.TextBoxDataIN);
            this.groupBox2.Location = new System.Drawing.Point(233, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 228);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receiver Control";
            // 
            // DataShow
            // 
            this.DataShow.Location = new System.Drawing.Point(171, 186);
            this.DataShow.Name = "DataShow";
            this.DataShow.Size = new System.Drawing.Size(109, 31);
            this.DataShow.TabIndex = 3;
            this.DataShow.Text = "Show Data";
            this.DataShow.UseVisualStyleBackColor = true;
            this.DataShow.Click += new System.EventHandler(this.DataShow_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(45, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(970, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1651, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.menu1ToolStripMenuItem.Text = "Folder";
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.menu2ToolStripMenuItem.Text = "Reset";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnClose);
            this.groupBox1.Controls.Add(this.BtnOpen);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CBoxParityBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBoxStopBits);
            this.groupBox1.Controls.Add(this.CBoxDataBits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBoxBaudRate);
            this.groupBox1.Controls.Add(this.CBoxCOMPort);
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Control";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(111, 196);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(87, 32);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "Close Port";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(15, 196);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(90, 32);
            this.BtnOpen.TabIndex = 11;
            this.BtnOpen.Text = "Open Port";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 234);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity Bits";
            // 
            // CBoxParityBits
            // 
            this.CBoxParityBits.FormattingEnabled = true;
            this.CBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CBoxParityBits.Location = new System.Drawing.Point(87, 156);
            this.CBoxParityBits.Name = "CBoxParityBits";
            this.CBoxParityBits.Size = new System.Drawing.Size(121, 24);
            this.CBoxParityBits.TabIndex = 8;
            this.CBoxParityBits.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data Bits";
            // 
            // CBoxStopBits
            // 
            this.CBoxStopBits.FormattingEnabled = true;
            this.CBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CBoxStopBits.Location = new System.Drawing.Point(87, 126);
            this.CBoxStopBits.Name = "CBoxStopBits";
            this.CBoxStopBits.Size = new System.Drawing.Size(121, 24);
            this.CBoxStopBits.TabIndex = 5;
            this.CBoxStopBits.Text = "One";
            // 
            // CBoxDataBits
            // 
            this.CBoxDataBits.FormattingEnabled = true;
            this.CBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CBoxDataBits.Location = new System.Drawing.Point(87, 96);
            this.CBoxDataBits.Name = "CBoxDataBits";
            this.CBoxDataBits.Size = new System.Drawing.Size(121, 24);
            this.CBoxDataBits.TabIndex = 4;
            this.CBoxDataBits.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM Port";
            // 
            // CBoxBaudRate
            // 
            this.CBoxBaudRate.FormattingEnabled = true;
            this.CBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.CBoxBaudRate.Location = new System.Drawing.Point(87, 66);
            this.CBoxBaudRate.Name = "CBoxBaudRate";
            this.CBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.CBoxBaudRate.TabIndex = 1;
            this.CBoxBaudRate.Text = " 9600";
            // 
            // CBoxCOMPort
            // 
            this.CBoxCOMPort.FormattingEnabled = true;
            this.CBoxCOMPort.Location = new System.Drawing.Point(87, 36);
            this.CBoxCOMPort.Name = "CBoxCOMPort";
            this.CBoxCOMPort.Size = new System.Drawing.Size(121, 24);
            this.CBoxCOMPort.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 304);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1539, 688);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1531, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel Veriler";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Lime;
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Location = new System.Drawing.Point(569, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(482, 281);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Enerji Verileri";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox5.Location = new System.Drawing.Point(1057, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 196);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motor Verileri";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 162);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Genel Batarya Verileri";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1701, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Araç Üzeri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(185, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1058, 475);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblBMSEleven33);
            this.groupBox4.Controls.Add(this.lblBMSEleven31);
            this.groupBox4.Controls.Add(this.lblBMSEleven32);
            this.groupBox4.Controls.Add(this.lblBMSEleven30);
            this.groupBox4.Controls.Add(this.lblBMSEleven28);
            this.groupBox4.Controls.Add(this.lblBMSEleven27);
            this.groupBox4.Controls.Add(this.lblBMSEleven29);
            this.groupBox4.Controls.Add(this.lblBMSEleven26);
            this.groupBox4.Controls.Add(this.lblBMSEleven25);
            this.groupBox4.Controls.Add(this.lblBMSEleven24);
            this.groupBox4.Controls.Add(this.lblBMSEleven23);
            this.groupBox4.Controls.Add(this.lblBMSEleven22);
            this.groupBox4.Controls.Add(this.lblBMSEleven20);
            this.groupBox4.Controls.Add(this.lblBMSEleven21);
            this.groupBox4.Controls.Add(this.lblBMSEleven19);
            this.groupBox4.Controls.Add(this.lblBMSEleven17);
            this.groupBox4.Controls.Add(this.lblBMSEleven16);
            this.groupBox4.Controls.Add(this.lblBMSEleven18);
            this.groupBox4.Controls.Add(this.lblBMSEleven15);
            this.groupBox4.Controls.Add(this.lblBMSEleven14);
            this.groupBox4.Controls.Add(this.lblBMSEleven13);
            this.groupBox4.Controls.Add(this.lblBMSEleven12);
            this.groupBox4.Controls.Add(this.lblBMSEleven11);
            this.groupBox4.Controls.Add(this.lblBMSEleven9);
            this.groupBox4.Controls.Add(this.lblBMSEleven10);
            this.groupBox4.Controls.Add(this.lblBMSEleven8);
            this.groupBox4.Controls.Add(this.lblBMSEleven6);
            this.groupBox4.Controls.Add(this.lblBMSEleven5);
            this.groupBox4.Controls.Add(this.lblBMSEleven7);
            this.groupBox4.Controls.Add(this.lblBMSEleven4);
            this.groupBox4.Controls.Add(this.lblBMSEleven3);
            this.groupBox4.Controls.Add(this.lblBMSEleven2);
            this.groupBox4.Controls.Add(this.lblBMSEleven1);
            this.groupBox4.Controls.Add(this.lblBMSTop3);
            this.groupBox4.Controls.Add(this.lblBMSTop2);
            this.groupBox4.Controls.Add(this.lblBMSTop1);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 503);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 456);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Batarya Verileri";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SlateGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(233, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 73;
            this.label7.Text = "BMS2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SlateGray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "BMS1";
            // 
            // lblBMSEleven33
            // 
            this.lblBMSEleven33.AutoSize = true;
            this.lblBMSEleven33.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven33.Location = new System.Drawing.Point(388, 407);
            this.lblBMSEleven33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven33.Name = "lblBMSEleven33";
            this.lblBMSEleven33.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven33.TabIndex = 71;
            this.lblBMSEleven33.Text = "0000";
            // 
            // lblBMSEleven31
            // 
            this.lblBMSEleven31.AutoSize = true;
            this.lblBMSEleven31.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven31.Location = new System.Drawing.Point(388, 353);
            this.lblBMSEleven31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven31.Name = "lblBMSEleven31";
            this.lblBMSEleven31.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven31.TabIndex = 70;
            this.lblBMSEleven31.Text = "0000";
            // 
            // lblBMSEleven32
            // 
            this.lblBMSEleven32.AutoSize = true;
            this.lblBMSEleven32.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven32.Location = new System.Drawing.Point(388, 380);
            this.lblBMSEleven32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven32.Name = "lblBMSEleven32";
            this.lblBMSEleven32.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven32.TabIndex = 69;
            this.lblBMSEleven32.Text = "0000";
            // 
            // lblBMSEleven30
            // 
            this.lblBMSEleven30.AutoSize = true;
            this.lblBMSEleven30.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven30.Location = new System.Drawing.Point(388, 326);
            this.lblBMSEleven30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven30.Name = "lblBMSEleven30";
            this.lblBMSEleven30.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven30.TabIndex = 68;
            this.lblBMSEleven30.Text = "0000";
            // 
            // lblBMSEleven28
            // 
            this.lblBMSEleven28.AutoSize = true;
            this.lblBMSEleven28.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven28.Location = new System.Drawing.Point(388, 272);
            this.lblBMSEleven28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven28.Name = "lblBMSEleven28";
            this.lblBMSEleven28.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven28.TabIndex = 67;
            this.lblBMSEleven28.Text = "0000";
            // 
            // lblBMSEleven27
            // 
            this.lblBMSEleven27.AutoSize = true;
            this.lblBMSEleven27.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven27.Location = new System.Drawing.Point(388, 245);
            this.lblBMSEleven27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven27.Name = "lblBMSEleven27";
            this.lblBMSEleven27.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven27.TabIndex = 66;
            this.lblBMSEleven27.Text = "0000";
            // 
            // lblBMSEleven29
            // 
            this.lblBMSEleven29.AutoSize = true;
            this.lblBMSEleven29.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven29.Location = new System.Drawing.Point(388, 299);
            this.lblBMSEleven29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven29.Name = "lblBMSEleven29";
            this.lblBMSEleven29.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven29.TabIndex = 65;
            this.lblBMSEleven29.Text = "0000";
            // 
            // lblBMSEleven26
            // 
            this.lblBMSEleven26.AutoSize = true;
            this.lblBMSEleven26.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven26.Location = new System.Drawing.Point(388, 218);
            this.lblBMSEleven26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven26.Name = "lblBMSEleven26";
            this.lblBMSEleven26.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven26.TabIndex = 64;
            this.lblBMSEleven26.Text = "0000";
            // 
            // lblBMSEleven25
            // 
            this.lblBMSEleven25.AutoSize = true;
            this.lblBMSEleven25.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven25.Location = new System.Drawing.Point(388, 191);
            this.lblBMSEleven25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven25.Name = "lblBMSEleven25";
            this.lblBMSEleven25.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven25.TabIndex = 63;
            this.lblBMSEleven25.Text = "0000";
            // 
            // lblBMSEleven24
            // 
            this.lblBMSEleven24.AutoSize = true;
            this.lblBMSEleven24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven24.Location = new System.Drawing.Point(388, 163);
            this.lblBMSEleven24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven24.Name = "lblBMSEleven24";
            this.lblBMSEleven24.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven24.TabIndex = 62;
            this.lblBMSEleven24.Text = "0000";
            // 
            // lblBMSEleven23
            // 
            this.lblBMSEleven23.AutoSize = true;
            this.lblBMSEleven23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven23.Location = new System.Drawing.Point(388, 136);
            this.lblBMSEleven23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven23.Name = "lblBMSEleven23";
            this.lblBMSEleven23.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven23.TabIndex = 61;
            this.lblBMSEleven23.Text = "0000";
            // 
            // lblBMSEleven22
            // 
            this.lblBMSEleven22.AutoSize = true;
            this.lblBMSEleven22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven22.Location = new System.Drawing.Point(232, 407);
            this.lblBMSEleven22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven22.Name = "lblBMSEleven22";
            this.lblBMSEleven22.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven22.TabIndex = 60;
            this.lblBMSEleven22.Text = "0000";
            // 
            // lblBMSEleven20
            // 
            this.lblBMSEleven20.AutoSize = true;
            this.lblBMSEleven20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven20.Location = new System.Drawing.Point(232, 353);
            this.lblBMSEleven20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven20.Name = "lblBMSEleven20";
            this.lblBMSEleven20.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven20.TabIndex = 59;
            this.lblBMSEleven20.Text = "0000";
            // 
            // lblBMSEleven21
            // 
            this.lblBMSEleven21.AutoSize = true;
            this.lblBMSEleven21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven21.Location = new System.Drawing.Point(232, 380);
            this.lblBMSEleven21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven21.Name = "lblBMSEleven21";
            this.lblBMSEleven21.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven21.TabIndex = 58;
            this.lblBMSEleven21.Text = "0000";
            // 
            // lblBMSEleven19
            // 
            this.lblBMSEleven19.AutoSize = true;
            this.lblBMSEleven19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven19.Location = new System.Drawing.Point(232, 326);
            this.lblBMSEleven19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven19.Name = "lblBMSEleven19";
            this.lblBMSEleven19.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven19.TabIndex = 57;
            this.lblBMSEleven19.Text = "0000";
            // 
            // lblBMSEleven17
            // 
            this.lblBMSEleven17.AutoSize = true;
            this.lblBMSEleven17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven17.Location = new System.Drawing.Point(232, 272);
            this.lblBMSEleven17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven17.Name = "lblBMSEleven17";
            this.lblBMSEleven17.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven17.TabIndex = 56;
            this.lblBMSEleven17.Text = "0000";
            // 
            // lblBMSEleven16
            // 
            this.lblBMSEleven16.AutoSize = true;
            this.lblBMSEleven16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven16.Location = new System.Drawing.Point(232, 245);
            this.lblBMSEleven16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven16.Name = "lblBMSEleven16";
            this.lblBMSEleven16.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven16.TabIndex = 55;
            this.lblBMSEleven16.Text = "0000";
            // 
            // lblBMSEleven18
            // 
            this.lblBMSEleven18.AutoSize = true;
            this.lblBMSEleven18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven18.Location = new System.Drawing.Point(232, 299);
            this.lblBMSEleven18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven18.Name = "lblBMSEleven18";
            this.lblBMSEleven18.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven18.TabIndex = 54;
            this.lblBMSEleven18.Text = "0000";
            // 
            // lblBMSEleven15
            // 
            this.lblBMSEleven15.AutoSize = true;
            this.lblBMSEleven15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven15.Location = new System.Drawing.Point(232, 218);
            this.lblBMSEleven15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven15.Name = "lblBMSEleven15";
            this.lblBMSEleven15.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven15.TabIndex = 53;
            this.lblBMSEleven15.Text = "0000";
            // 
            // lblBMSEleven14
            // 
            this.lblBMSEleven14.AutoSize = true;
            this.lblBMSEleven14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven14.Location = new System.Drawing.Point(232, 191);
            this.lblBMSEleven14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven14.Name = "lblBMSEleven14";
            this.lblBMSEleven14.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven14.TabIndex = 52;
            this.lblBMSEleven14.Text = "0000";
            // 
            // lblBMSEleven13
            // 
            this.lblBMSEleven13.AutoSize = true;
            this.lblBMSEleven13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven13.Location = new System.Drawing.Point(232, 163);
            this.lblBMSEleven13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven13.Name = "lblBMSEleven13";
            this.lblBMSEleven13.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven13.TabIndex = 51;
            this.lblBMSEleven13.Text = "0000";
            // 
            // lblBMSEleven12
            // 
            this.lblBMSEleven12.AutoSize = true;
            this.lblBMSEleven12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven12.Location = new System.Drawing.Point(232, 136);
            this.lblBMSEleven12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven12.Name = "lblBMSEleven12";
            this.lblBMSEleven12.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven12.TabIndex = 50;
            this.lblBMSEleven12.Text = "0000";
            // 
            // lblBMSEleven11
            // 
            this.lblBMSEleven11.AutoSize = true;
            this.lblBMSEleven11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven11.Location = new System.Drawing.Point(71, 407);
            this.lblBMSEleven11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven11.Name = "lblBMSEleven11";
            this.lblBMSEleven11.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven11.TabIndex = 49;
            this.lblBMSEleven11.Text = "0000";
            // 
            // lblBMSEleven9
            // 
            this.lblBMSEleven9.AutoSize = true;
            this.lblBMSEleven9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven9.Location = new System.Drawing.Point(71, 353);
            this.lblBMSEleven9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven9.Name = "lblBMSEleven9";
            this.lblBMSEleven9.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven9.TabIndex = 48;
            this.lblBMSEleven9.Text = "0000";
            // 
            // lblBMSEleven10
            // 
            this.lblBMSEleven10.AutoSize = true;
            this.lblBMSEleven10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven10.Location = new System.Drawing.Point(71, 380);
            this.lblBMSEleven10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven10.Name = "lblBMSEleven10";
            this.lblBMSEleven10.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven10.TabIndex = 47;
            this.lblBMSEleven10.Text = "0000";
            // 
            // lblBMSEleven8
            // 
            this.lblBMSEleven8.AutoSize = true;
            this.lblBMSEleven8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven8.Location = new System.Drawing.Point(71, 326);
            this.lblBMSEleven8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven8.Name = "lblBMSEleven8";
            this.lblBMSEleven8.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven8.TabIndex = 46;
            this.lblBMSEleven8.Text = "0000";
            // 
            // lblBMSEleven6
            // 
            this.lblBMSEleven6.AutoSize = true;
            this.lblBMSEleven6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven6.Location = new System.Drawing.Point(71, 272);
            this.lblBMSEleven6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven6.Name = "lblBMSEleven6";
            this.lblBMSEleven6.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven6.TabIndex = 45;
            this.lblBMSEleven6.Text = "0000";
            // 
            // lblBMSEleven5
            // 
            this.lblBMSEleven5.AutoSize = true;
            this.lblBMSEleven5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven5.Location = new System.Drawing.Point(71, 245);
            this.lblBMSEleven5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven5.Name = "lblBMSEleven5";
            this.lblBMSEleven5.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven5.TabIndex = 44;
            this.lblBMSEleven5.Text = "0000";
            // 
            // lblBMSEleven7
            // 
            this.lblBMSEleven7.AutoSize = true;
            this.lblBMSEleven7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven7.Location = new System.Drawing.Point(71, 299);
            this.lblBMSEleven7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven7.Name = "lblBMSEleven7";
            this.lblBMSEleven7.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven7.TabIndex = 43;
            this.lblBMSEleven7.Text = "0000";
            // 
            // lblBMSEleven4
            // 
            this.lblBMSEleven4.AutoSize = true;
            this.lblBMSEleven4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven4.Location = new System.Drawing.Point(71, 218);
            this.lblBMSEleven4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven4.Name = "lblBMSEleven4";
            this.lblBMSEleven4.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven4.TabIndex = 42;
            this.lblBMSEleven4.Text = "0000";
            // 
            // lblBMSEleven3
            // 
            this.lblBMSEleven3.AutoSize = true;
            this.lblBMSEleven3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven3.Location = new System.Drawing.Point(71, 191);
            this.lblBMSEleven3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven3.Name = "lblBMSEleven3";
            this.lblBMSEleven3.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven3.TabIndex = 41;
            this.lblBMSEleven3.Text = "0000";
            // 
            // lblBMSEleven2
            // 
            this.lblBMSEleven2.AutoSize = true;
            this.lblBMSEleven2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven2.Location = new System.Drawing.Point(71, 163);
            this.lblBMSEleven2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven2.Name = "lblBMSEleven2";
            this.lblBMSEleven2.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven2.TabIndex = 40;
            this.lblBMSEleven2.Text = "0000";
            // 
            // lblBMSEleven1
            // 
            this.lblBMSEleven1.AutoSize = true;
            this.lblBMSEleven1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSEleven1.Location = new System.Drawing.Point(71, 136);
            this.lblBMSEleven1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.lblBMSEleven1.Name = "lblBMSEleven1";
            this.lblBMSEleven1.Size = new System.Drawing.Size(60, 26);
            this.lblBMSEleven1.TabIndex = 39;
            this.lblBMSEleven1.Text = "0000";
            // 
            // lblBMSTop3
            // 
            this.lblBMSTop3.AutoSize = true;
            this.lblBMSTop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSTop3.Location = new System.Drawing.Point(388, 93);
            this.lblBMSTop3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMSTop3.Name = "lblBMSTop3";
            this.lblBMSTop3.Size = new System.Drawing.Size(60, 26);
            this.lblBMSTop3.TabIndex = 38;
            this.lblBMSTop3.Text = "0000";
            // 
            // lblBMSTop2
            // 
            this.lblBMSTop2.AutoSize = true;
            this.lblBMSTop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSTop2.Location = new System.Drawing.Point(232, 93);
            this.lblBMSTop2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMSTop2.Name = "lblBMSTop2";
            this.lblBMSTop2.Size = new System.Drawing.Size(60, 26);
            this.lblBMSTop2.TabIndex = 37;
            this.lblBMSTop2.Text = "0000";
            // 
            // lblBMSTop1
            // 
            this.lblBMSTop1.AutoSize = true;
            this.lblBMSTop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBMSTop1.Location = new System.Drawing.Point(71, 93);
            this.lblBMSTop1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBMSTop1.Name = "lblBMSTop1";
            this.lblBMSTop1.Size = new System.Drawing.Size(60, 26);
            this.lblBMSTop1.TabIndex = 36;
            this.lblBMSTop1.Text = "0000";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnMinimize);
            this.groupBox6.Controls.Add(this.btnExit);
            this.groupBox6.Location = new System.Drawing.Point(730, 52);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(123, 168);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Windows State";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(25, 99);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 45);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "Minimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 39);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Crimson;
            this.groupBox8.Location = new System.Drawing.Point(1057, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(456, 191);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Hız";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Yellow;
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.label21);
            this.groupBox9.Controls.Add(this.label20);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Controls.Add(this.label18);
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label11);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Location = new System.Drawing.Point(569, 294);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(482, 334);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "MPPT Verileri";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(1057, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 236);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "MPPT1";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "MPPT3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "MPPT2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SlateGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(375, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "BMS3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(139, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 33);
            this.label12.TabIndex = 3;
            this.label12.Text = "Akım(A)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(316, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 33);
            this.label13.TabIndex = 4;
            this.label13.Text = "Güç(W)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 29);
            this.label14.TabIndex = 5;
            this.label14.Text = "TOPLAM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(165, 98);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 26);
            this.label15.TabIndex = 53;
            this.label15.Text = "0,000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(165, 182);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 26);
            this.label17.TabIndex = 55;
            this.label17.Text = "0,000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(165, 140);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 26);
            this.label18.TabIndex = 56;
            this.label18.Text = "0,000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(342, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 26);
            this.label16.TabIndex = 64;
            this.label16.Text = "0000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(342, 248);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 26);
            this.label19.TabIndex = 65;
            this.label19.Text = "0000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(342, 179);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 26);
            this.label20.TabIndex = 66;
            this.label20.Text = "0000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(342, 140);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 26);
            this.label21.TabIndex = 67;
            this.label21.Text = "0000";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(165, 248);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 26);
            this.label22.TabIndex = 68;
            this.label22.Text = "0,000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(15, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 29);
            this.label23.TabIndex = 0;
            this.label23.Text = "Motor Wh";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(11, 79);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(124, 29);
            this.label24.TabIndex = 1;
            this.label24.Text = "Güneş Wh";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(6, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 29);
            this.label25.TabIndex = 2;
            this.label25.Text = "Batarya Wh";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(280, 122);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(127, 29);
            this.label27.TabIndex = 6;
            this.label27.Text = "Batarya Ah";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(285, 79);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(117, 29);
            this.label28.TabIndex = 5;
            this.label28.Text = "Güneş Ah";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(289, 41);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 29);
            this.label29.TabIndex = 4;
            this.label29.Text = "Motor Ah";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 1004);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTU Mission Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox TextBoxDataIN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBoxParityBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBoxStopBits;
        private System.Windows.Forms.ComboBox CBoxDataBits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxBaudRate;
        private System.Windows.Forms.ComboBox CBoxCOMPort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblBMSEleven33;
        private System.Windows.Forms.Label lblBMSEleven31;
        private System.Windows.Forms.Label lblBMSEleven32;
        private System.Windows.Forms.Label lblBMSEleven30;
        private System.Windows.Forms.Label lblBMSEleven28;
        private System.Windows.Forms.Label lblBMSEleven27;
        private System.Windows.Forms.Label lblBMSEleven29;
        private System.Windows.Forms.Label lblBMSEleven26;
        private System.Windows.Forms.Label lblBMSEleven25;
        private System.Windows.Forms.Label lblBMSEleven24;
        private System.Windows.Forms.Label lblBMSEleven23;
        private System.Windows.Forms.Label lblBMSEleven22;
        private System.Windows.Forms.Label lblBMSEleven20;
        private System.Windows.Forms.Label lblBMSEleven21;
        private System.Windows.Forms.Label lblBMSEleven19;
        private System.Windows.Forms.Label lblBMSEleven17;
        private System.Windows.Forms.Label lblBMSEleven16;
        private System.Windows.Forms.Label lblBMSEleven18;
        private System.Windows.Forms.Label lblBMSEleven15;
        private System.Windows.Forms.Label lblBMSEleven14;
        private System.Windows.Forms.Label lblBMSEleven13;
        private System.Windows.Forms.Label lblBMSEleven12;
        private System.Windows.Forms.Label lblBMSEleven11;
        private System.Windows.Forms.Label lblBMSEleven9;
        private System.Windows.Forms.Label lblBMSEleven10;
        private System.Windows.Forms.Label lblBMSEleven8;
        private System.Windows.Forms.Label lblBMSEleven6;
        private System.Windows.Forms.Label lblBMSEleven5;
        private System.Windows.Forms.Label lblBMSEleven7;
        private System.Windows.Forms.Label lblBMSEleven4;
        private System.Windows.Forms.Label lblBMSEleven3;
        private System.Windows.Forms.Label lblBMSEleven2;
        private System.Windows.Forms.Label lblBMSEleven1;
        private System.Windows.Forms.Label lblBMSTop3;
        private System.Windows.Forms.Label lblBMSTop2;
        private System.Windows.Forms.Label lblBMSTop1;
        private System.Windows.Forms.Button DataShow;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label8;
    }
}

