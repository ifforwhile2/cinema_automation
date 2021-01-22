namespace Cinema
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxTableList = new System.Windows.Forms.ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTableInfo = new System.Windows.Forms.Panel();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleBarName = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ıconPictureBoxMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBoxMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBoxExit = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ıconButton4 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTableList
            // 
            this.comboBoxTableList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableList.FormattingEnabled = true;
            this.comboBoxTableList.Items.AddRange(new object[] {
            "C_USER",
            "C_SALON",
            "C_SEAT",
            "C_SESSION",
            "C_TICKET",
            "C_FILM",
            "C_CATEGORY",
            "C_LOG"});
            this.comboBoxTableList.Location = new System.Drawing.Point(248, 180);
            this.comboBoxTableList.Name = "comboBoxTableList";
            this.comboBoxTableList.Size = new System.Drawing.Size(150, 21);
            this.comboBoxTableList.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(512, 183);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(29, 13);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Ara: ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(547, 180);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(321, 20);
            this.textBoxSearch.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(515, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 399);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelTableInfo);
            this.groupBox1.Location = new System.Drawing.Point(248, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 400);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçilen Satır";
            // 
            // panelTableInfo
            // 
            this.panelTableInfo.Location = new System.Drawing.Point(6, 19);
            this.panelTableInfo.Name = "panelTableInfo";
            this.panelTableInfo.Size = new System.Drawing.Size(220, 375);
            this.panelTableInfo.TabIndex = 0;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(874, 180);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSearch.TabIndex = 9;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.ıconButton4);
            this.panelMenu.Controls.Add(this.ıconButton3);
            this.panelMenu.Controls.Add(this.ıconButton2);
            this.panelMenu.Controls.Add(this.ıconButton1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 621);
            this.panelMenu.TabIndex = 10;
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
            this.ıconButton3.Location = new System.Drawing.Point(0, 260);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton3.Size = new System.Drawing.Size(200, 60);
            this.ıconButton3.TabIndex = 3;
            this.ıconButton3.Text = "Ayarlar";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // ıconButton2
            // 
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton2.ForeColor = System.Drawing.Color.White;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.ıconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.Location = new System.Drawing.Point(0, 200);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton2.Size = new System.Drawing.Size(200, 60);
            this.ıconButton2.TabIndex = 2;
            this.ıconButton2.Text = "Log";
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
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ıconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.Location = new System.Drawing.Point(0, 140);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton1.Size = new System.Drawing.Size(200, 60);
            this.ıconButton1.TabIndex = 1;
            this.ıconButton1.Text = "Veritabanı";
            this.ıconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.ButtonHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Image = global::Cinema.Properties.Resources.logo2;
            this.ButtonHome.Location = new System.Drawing.Point(12, 12);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(185, 122);
            this.ButtonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.TabStop = false;
            this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.labelTitleBarName);
            this.panelTitleBar.Controls.Add(this.ıconPictureBox1);
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.ıconPictureBoxMinimize);
            this.panelTitleBar.Controls.Add(this.ıconPictureBoxMaximize);
            this.panelTitleBar.Controls.Add(this.ıconPictureBoxExit);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(889, 75);
            this.panelTitleBar.TabIndex = 11;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleBarName
            // 
            this.labelTitleBarName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitleBarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitleBarName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleBarName.Location = new System.Drawing.Point(547, 56);
            this.labelTitleBarName.Name = "labelTitleBarName";
            this.labelTitleBarName.Size = new System.Drawing.Size(300, 16);
            this.labelTitleBarName.TabIndex = 7;
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
            this.ıconPictureBox1.Location = new System.Drawing.Point(853, 48);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.ıconPictureBox1.TabIndex = 6;
            this.ıconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 9);
            this.panel1.TabIndex = 5;
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
            this.ıconPictureBoxMinimize.Location = new System.Drawing.Point(777, 14);
            this.ıconPictureBoxMinimize.Name = "ıconPictureBoxMinimize";
            this.ıconPictureBoxMinimize.Size = new System.Drawing.Size(24, 24);
            this.ıconPictureBoxMinimize.TabIndex = 4;
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
            this.ıconPictureBoxMaximize.Location = new System.Drawing.Point(815, 12);
            this.ıconPictureBoxMaximize.Name = "ıconPictureBoxMaximize";
            this.ıconPictureBoxMaximize.Size = new System.Drawing.Size(24, 24);
            this.ıconPictureBoxMaximize.TabIndex = 3;
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
            this.ıconPictureBoxExit.Location = new System.Drawing.Point(853, 12);
            this.ıconPictureBoxExit.Name = "ıconPictureBoxExit";
            this.ıconPictureBoxExit.Size = new System.Drawing.Size(24, 24);
            this.ıconPictureBoxExit.TabIndex = 2;
            this.ıconPictureBoxExit.TabStop = false;
            this.ıconPictureBoxExit.Click += new System.EventHandler(this.ıconPictureBoxExit_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(62, 30);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(45, 16);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.SlateBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.SlateBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(23, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.ForeColor = System.Drawing.Color.Black;
            this.panelShadow.Location = new System.Drawing.Point(200, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(889, 9);
            this.panelShadow.TabIndex = 12;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.labelHour);
            this.panelDesktop.Controls.Add(this.labelDate);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(889, 537);
            this.panelDesktop.TabIndex = 13;
            // 
            // labelHour
            // 
            this.labelHour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHour.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHour.Location = new System.Drawing.Point(292, 267);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(212, 55);
            this.labelHour.TabIndex = 5;
            this.labelHour.Text = "15:27:56";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelDate.Location = new System.Drawing.Point(288, 322);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(216, 24);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "14 Ocak Perşembe 2021";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(344, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copyright © 2021";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(677, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Development by Burhan AFŞAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Cinema.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(252, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.ıconButton4.Location = new System.Drawing.Point(0, 320);
            this.ıconButton4.Name = "ıconButton4";
            this.ıconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton4.Size = new System.Drawing.Size(200, 60);
            this.ıconButton4.TabIndex = 4;
            this.ıconButton4.Text = "Çıkış";
            this.ıconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton4.UseVisualStyleBackColor = true;
            this.ıconButton4.Click += new System.EventHandler(this.ıconButton4_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 621);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.comboBoxTableList);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        protected internal System.Windows.Forms.Panel panelTableInfo;
        protected internal System.Windows.Forms.ComboBox comboBoxTableList;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        protected internal System.Windows.Forms.TextBox textBoxSearch;
        protected internal System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private System.Windows.Forms.PictureBox ButtonHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxMinimize;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxMaximize;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTitleBarName;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconButton ıconButton4;
    }
}