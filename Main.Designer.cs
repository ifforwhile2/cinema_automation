namespace Cinema
{
    partial class Main
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
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleBarName = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBoxMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBoxMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBoxExit = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ıconButton4 = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.Controls.Add(this.labelHour);
            this.panelDesktop.Controls.Add(this.labelDate);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Location = new System.Drawing.Point(206, 81);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(880, 540);
            this.panelDesktop.TabIndex = 4;
            // 
            // labelHour
            // 
            this.labelHour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHour.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHour.Location = new System.Drawing.Point(380, 340);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(212, 55);
            this.labelHour.TabIndex = 10;
            this.labelHour.Text = "15:27:56";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelDate.Location = new System.Drawing.Point(376, 395);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(216, 24);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "14 Ocak Perşembe 2021";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(440, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Copyright © 2021";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(668, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Development by Burhan AFŞAR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::Cinema.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(340, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 621);
            this.panel2.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.ıconButton4);
            this.panelMenu.Controls.Add(this.ıconButton3);
            this.panelMenu.Controls.Add(this.ıconButton2);
            this.panelMenu.Controls.Add(this.ıconButton1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 140);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 481);
            this.panelMenu.TabIndex = 1;
            // 
            // ıconButton2
            // 
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ıconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.Location = new System.Drawing.Point(0, 60);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton2.Size = new System.Drawing.Size(200, 60);
            this.ıconButton2.TabIndex = 3;
            this.ıconButton2.Text = "Veritabanı";
            this.ıconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = true;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // ıconButton1
            // 
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt;
            this.ıconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.Location = new System.Drawing.Point(0, 0);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton1.Size = new System.Drawing.Size(200, 60);
            this.ıconButton1.TabIndex = 2;
            this.ıconButton1.Text = "Bilet Sat";
            this.ıconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 140);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.labelTitleBarName);
            this.panelTitleBar.Controls.Add(this.ıconPictureBox1);
            this.panelTitleBar.Controls.Add(this.ıconPictureBoxMinimize);
            this.panelTitleBar.Controls.Add(this.ıconPictureBoxMaximize);
            this.panelTitleBar.Controls.Add(this.ıconPictureBoxExit);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(889, 75);
            this.panelTitleBar.TabIndex = 6;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleBarName
            // 
            this.labelTitleBarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleBarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitleBarName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleBarName.Location = new System.Drawing.Point(550, 50);
            this.labelTitleBarName.Name = "labelTitleBarName";
            this.labelTitleBarName.Size = new System.Drawing.Size(300, 16);
            this.labelTitleBarName.TabIndex = 14;
            this.labelTitleBarName.Text = "Burhan AFŞAR";
            this.labelTitleBarName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 30;
            this.ıconPictureBox1.Location = new System.Drawing.Point(856, 42);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.ıconPictureBox1.TabIndex = 13;
            this.ıconPictureBox1.TabStop = false;
            // 
            // ıconPictureBoxMinimize
            // 
            this.ıconPictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ıconPictureBoxMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ıconPictureBoxMinimize.ForeColor = System.Drawing.Color.SlateBlue;
            this.ıconPictureBoxMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ıconPictureBoxMinimize.IconColor = System.Drawing.Color.SlateBlue;
            this.ıconPictureBoxMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBoxMinimize.IconSize = 24;
            this.ıconPictureBoxMinimize.Location = new System.Drawing.Point(780, 8);
            this.ıconPictureBoxMinimize.Name = "ıconPictureBoxMinimize";
            this.ıconPictureBoxMinimize.Size = new System.Drawing.Size(24, 24);
            this.ıconPictureBoxMinimize.TabIndex = 12;
            this.ıconPictureBoxMinimize.TabStop = false;
            this.ıconPictureBoxMinimize.Click += new System.EventHandler(this.ıconPictureBoxMinimize_Click);
            // 
            // ıconPictureBoxMaximize
            // 
            this.ıconPictureBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ıconPictureBoxMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ıconPictureBoxMaximize.ForeColor = System.Drawing.Color.SlateBlue;
            this.ıconPictureBoxMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ıconPictureBoxMaximize.IconColor = System.Drawing.Color.SlateBlue;
            this.ıconPictureBoxMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBoxMaximize.IconSize = 24;
            this.ıconPictureBoxMaximize.Location = new System.Drawing.Point(818, 6);
            this.ıconPictureBoxMaximize.Name = "ıconPictureBoxMaximize";
            this.ıconPictureBoxMaximize.Size = new System.Drawing.Size(24, 24);
            this.ıconPictureBoxMaximize.TabIndex = 11;
            this.ıconPictureBoxMaximize.TabStop = false;
            this.ıconPictureBoxMaximize.Click += new System.EventHandler(this.ıconPictureBoxMaximize_Click);
            // 
            // ıconPictureBoxExit
            // 
            this.ıconPictureBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ıconPictureBoxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ıconPictureBoxExit.ForeColor = System.Drawing.Color.SlateBlue;
            this.ıconPictureBoxExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ıconPictureBoxExit.IconColor = System.Drawing.Color.SlateBlue;
            this.ıconPictureBoxExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBoxExit.IconSize = 24;
            this.ıconPictureBoxExit.Location = new System.Drawing.Point(856, 6);
            this.ıconPictureBoxExit.Name = "ıconPictureBoxExit";
            this.ıconPictureBoxExit.Size = new System.Drawing.Size(24, 24);
            this.ıconPictureBoxExit.TabIndex = 10;
            this.ıconPictureBoxExit.TabStop = false;
            this.ıconPictureBoxExit.Click += new System.EventHandler(this.ıconPictureBoxExit_Click_1);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(65, 24);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(45, 16);
            this.labelTitleChildForm.TabIndex = 9;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.SlateBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.SlateBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(26, 17);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 8;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // ıconButton4
            // 
            this.ıconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton4.FlatAppearance.BorderSize = 0;
            this.ıconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton4.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.ıconButton4.IconColor = System.Drawing.Color.White;
            this.ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.Location = new System.Drawing.Point(0, 180);
            this.ıconButton4.Name = "ıconButton4";
            this.ıconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton4.Size = new System.Drawing.Size(200, 60);
            this.ıconButton4.TabIndex = 6;
            this.ıconButton4.Text = "Çıkış";
            this.ıconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton4.UseVisualStyleBackColor = true;
            // 
            // ıconButton3
            // 
            this.ıconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.SlidersH;
            this.ıconButton3.IconColor = System.Drawing.Color.White;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.Location = new System.Drawing.Point(0, 120);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton3.Size = new System.Drawing.Size(200, 60);
            this.ıconButton3.TabIndex = 5;
            this.ıconButton3.Text = "Ayarlar";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1089, 621);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel2);
            this.Name = "Main";
            this.Text = "BiletX";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTitleBarName;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxMinimize;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxMaximize;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxExit;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton3;
    }
}

