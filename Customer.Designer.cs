namespace Cinema
{
    partial class Customer
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ıconPictureBoxExit = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelTıcketID = new System.Windows.Forms.Label();
            this.trackBarVote = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxExit)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVote)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cinema.Properties.Resources.logo3;
            this.pictureBox2.Location = new System.Drawing.Point(49, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(338, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(62, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ıconPictureBoxExit
            // 
            this.ıconPictureBoxExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ıconPictureBoxExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconPictureBoxExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ıconPictureBoxExit.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconPictureBoxExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBoxExit.IconSize = 24;
            this.ıconPictureBoxExit.Location = new System.Drawing.Point(378, 12);
            this.ıconPictureBoxExit.Name = "ıconPictureBoxExit";
            this.ıconPictureBoxExit.Size = new System.Drawing.Size(24, 24);
            this.ıconPictureBoxExit.TabIndex = 9;
            this.ıconPictureBoxExit.TabStop = false;
            this.ıconPictureBoxExit.Click += new System.EventHandler(this.ıconPictureBoxExit_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.ıconPictureBoxExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(414, 40);
            this.panelTitleBar.TabIndex = 17;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(107, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Puan Ver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUser.Location = new System.Drawing.Point(107, 362);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(280, 26);
            this.textBoxUser.TabIndex = 18;
            // 
            // labelTıcketID
            // 
            this.labelTıcketID.AutoSize = true;
            this.labelTıcketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTıcketID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTıcketID.Location = new System.Drawing.Point(36, 365);
            this.labelTıcketID.Name = "labelTıcketID";
            this.labelTıcketID.Size = new System.Drawing.Size(65, 20);
            this.labelTıcketID.TabIndex = 20;
            this.labelTıcketID.Text = "Bilet ID:";
            // 
            // trackBarVote
            // 
            this.trackBarVote.Location = new System.Drawing.Point(83, 406);
            this.trackBarVote.Maximum = 5;
            this.trackBarVote.Minimum = 1;
            this.trackBarVote.Name = "trackBarVote";
            this.trackBarVote.Size = new System.Drawing.Size(280, 45);
            this.trackBarVote.TabIndex = 21;
            this.trackBarVote.Value = 1;
            this.trackBarVote.Scroll += new System.EventHandler(this.trackBarVote_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(59, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(369, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "5";
            // 
            // labelVote
            // 
            this.labelVote.AutoSize = true;
            this.labelVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVote.Location = new System.Drawing.Point(38, 471);
            this.labelVote.Name = "labelVote";
            this.labelVote.Size = new System.Drawing.Size(63, 20);
            this.labelVote.TabIndex = 24;
            this.labelVote.Text = "Puan: 1";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(414, 561);
            this.Controls.Add(this.labelVote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarVote);
            this.Controls.Add(this.labelTıcketID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxExit)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxExit;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelTıcketID;
        private System.Windows.Forms.TrackBar trackBarVote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVote;
    }
}