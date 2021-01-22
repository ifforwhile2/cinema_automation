namespace Cinema.Forms
{
    partial class FormSellTicket
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
            this.panelSeats = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxFilmList = new System.Windows.Forms.ComboBox();
            this.groupBoxFilmList = new System.Windows.Forms.GroupBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxSeatID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSessionID = new System.Windows.Forms.TextBox();
            this.groupBoxTicket = new System.Windows.Forms.GroupBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelSalonID = new System.Windows.Forms.Label();
            this.textBoxSalonID = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFilmList.SuspendLayout();
            this.groupBoxTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSeats
            // 
            this.panelSeats.Location = new System.Drawing.Point(452, 109);
            this.panelSeats.Name = "panelSeats";
            this.panelSeats.Size = new System.Drawing.Size(425, 425);
            this.panelSeats.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 461);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboBoxFilmList
            // 
            this.comboBoxFilmList.FormattingEnabled = true;
            this.comboBoxFilmList.Location = new System.Drawing.Point(6, 19);
            this.comboBoxFilmList.Name = "comboBoxFilmList";
            this.comboBoxFilmList.Size = new System.Drawing.Size(132, 21);
            this.comboBoxFilmList.TabIndex = 8;
            this.comboBoxFilmList.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmList_SelectedIndexChanged);
            // 
            // groupBoxFilmList
            // 
            this.groupBoxFilmList.Controls.Add(this.comboBoxFilmList);
            this.groupBoxFilmList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilmList.Name = "groupBoxFilmList";
            this.groupBoxFilmList.Size = new System.Drawing.Size(144, 55);
            this.groupBoxFilmList.TabIndex = 9;
            this.groupBoxFilmList.TabStop = false;
            this.groupBoxFilmList.Text = "Filmler";
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.buttonSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSell.Location = new System.Drawing.Point(727, 73);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(150, 30);
            this.buttonSell.TabIndex = 11;
            this.buttonSell.Text = "Bileti Sat";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxSeatID
            // 
            this.textBoxSeatID.Enabled = false;
            this.textBoxSeatID.Location = new System.Drawing.Point(303, 19);
            this.textBoxSeatID.Name = "textBoxSeatID";
            this.textBoxSeatID.Size = new System.Drawing.Size(50, 20);
            this.textBoxSeatID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Koltuk ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "X:";
            // 
            // textBoxX
            // 
            this.textBoxX.Enabled = false;
            this.textBoxX.Location = new System.Drawing.Point(382, 19);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(40, 20);
            this.textBoxX.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Y:";
            // 
            // textBoxY
            // 
            this.textBoxY.Enabled = false;
            this.textBoxY.Location = new System.Drawing.Point(451, 19);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(40, 20);
            this.textBoxY.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Seans ID:";
            // 
            // textBoxSessionID
            // 
            this.textBoxSessionID.Enabled = false;
            this.textBoxSessionID.Location = new System.Drawing.Point(187, 19);
            this.textBoxSessionID.Name = "textBoxSessionID";
            this.textBoxSessionID.Size = new System.Drawing.Size(50, 20);
            this.textBoxSessionID.TabIndex = 18;
            // 
            // groupBoxTicket
            // 
            this.groupBoxTicket.Controls.Add(this.textBoxDate);
            this.groupBoxTicket.Controls.Add(this.labelSalonID);
            this.groupBoxTicket.Controls.Add(this.textBoxSalonID);
            this.groupBoxTicket.Controls.Add(this.checkBox1);
            this.groupBoxTicket.Controls.Add(this.label4);
            this.groupBoxTicket.Controls.Add(this.textBoxSeatID);
            this.groupBoxTicket.Controls.Add(this.textBoxSessionID);
            this.groupBoxTicket.Controls.Add(this.label1);
            this.groupBoxTicket.Controls.Add(this.label3);
            this.groupBoxTicket.Controls.Add(this.textBoxX);
            this.groupBoxTicket.Controls.Add(this.textBoxY);
            this.groupBoxTicket.Controls.Add(this.label2);
            this.groupBoxTicket.Location = new System.Drawing.Point(162, 12);
            this.groupBoxTicket.Name = "groupBoxTicket";
            this.groupBoxTicket.Size = new System.Drawing.Size(715, 55);
            this.groupBoxTicket.TabIndex = 20;
            this.groupBoxTicket.TabStop = false;
            this.groupBoxTicket.Text = "Bilet Bilgileri";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(560, 19);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(149, 20);
            this.textBoxDate.TabIndex = 23;
            // 
            // labelSalonID
            // 
            this.labelSalonID.AutoSize = true;
            this.labelSalonID.Location = new System.Drawing.Point(11, 22);
            this.labelSalonID.Name = "labelSalonID";
            this.labelSalonID.Size = new System.Drawing.Size(51, 13);
            this.labelSalonID.TabIndex = 22;
            this.labelSalonID.Text = "Salon ID:";
            // 
            // textBoxSalonID
            // 
            this.textBoxSalonID.Enabled = false;
            this.textBoxSalonID.Location = new System.Drawing.Point(71, 19);
            this.textBoxSalonID.Name = "textBoxSalonID";
            this.textBoxSalonID.Size = new System.Drawing.Size(50, 20);
            this.textBoxSalonID.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(497, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Dolu ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(861, 522);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(28, 25);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.Visible = false;
            // 
            // FormSellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(889, 546);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBoxTicket);
            this.Controls.Add(this.groupBoxFilmList);
            this.Controls.Add(this.panelSeats);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormSellTicket";
            this.Text = "Bilet Sat";
            this.Load += new System.EventHandler(this.FormSellTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFilmList.ResumeLayout(false);
            this.groupBoxTicket.ResumeLayout(false);
            this.groupBoxTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFilmList;
        protected internal System.Windows.Forms.ComboBox comboBoxFilmList;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        protected internal System.Windows.Forms.Panel panelSeats;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.TextBox textBoxSeatID;
        protected internal System.Windows.Forms.TextBox textBoxX;
        protected internal System.Windows.Forms.TextBox textBoxY;
        protected internal System.Windows.Forms.TextBox textBoxSessionID;
        protected internal System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelSalonID;
        protected internal System.Windows.Forms.TextBox textBoxSalonID;
        protected internal System.Windows.Forms.TextBox textBoxDate;
        protected internal System.Windows.Forms.GroupBox groupBoxTicket;
        protected internal System.Windows.Forms.DataGridView dataGridView2;
    }
}