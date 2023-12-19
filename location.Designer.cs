namespace Gestion_Location_Voiture
{
    partial class location
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.precedentGC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnc = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtnj = new System.Windows.Forms.TextBox();
            this.rechercher = new Guna.UI2.WinForms.Guna2Button();
            this.txtdd = new System.Windows.Forms.DateTimePicker();
            this.modifier = new Guna.UI2.WinForms.Guna2Button();
            this.enregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.tableaux = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdr = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtncc = new System.Windows.Forms.TextBox();
            this.txtnmv = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.precedentGC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 94);
            this.panel1.TabIndex = 0;
            // 
            // precedentGC
            // 
            this.precedentGC.AutoSize = true;
            this.precedentGC.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.precedentGC.ForeColor = System.Drawing.Color.White;
            this.precedentGC.Location = new System.Drawing.Point(954, 52);
            this.precedentGC.Name = "precedentGC";
            this.precedentGC.Size = new System.Drawing.Size(113, 29);
            this.precedentGC.TabIndex = 5;
            this.precedentGC.Text = "précedent ";
            this.precedentGC.Click += new System.EventHandler(this.precedentGC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(265, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 62);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gestion De Location";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtnc);
            this.panel2.Controls.Add(this.txtp);
            this.panel2.Controls.Add(this.txtnj);
            this.panel2.Controls.Add(this.rechercher);
            this.panel2.Controls.Add(this.txtdd);
            this.panel2.Controls.Add(this.modifier);
            this.panel2.Controls.Add(this.enregistrer);
            this.panel2.Controls.Add(this.tableaux);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtdr);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtm);
            this.panel2.Controls.Add(this.txtncc);
            this.panel2.Controls.Add(this.txtnmv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 614);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(35, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "N°Contract";
            // 
            // txtnc
            // 
            this.txtnc.Enabled = false;
            this.txtnc.Location = new System.Drawing.Point(266, 23);
            this.txtnc.Name = "txtnc";
            this.txtnc.Size = new System.Drawing.Size(143, 26);
            this.txtnc.TabIndex = 38;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(266, 154);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(143, 26);
            this.txtp.TabIndex = 36;
            this.txtp.TextChanged += new System.EventHandler(this.txtp_TextChanged);
            // 
            // txtnj
            // 
            this.txtnj.Location = new System.Drawing.Point(266, 67);
            this.txtnj.Name = "txtnj";
            this.txtnj.Size = new System.Drawing.Size(143, 26);
            this.txtnj.TabIndex = 37;
            this.txtnj.Text = "1";
            this.txtnj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnj.TextChanged += new System.EventHandler(this.txtnj_TextChanged);
            this.txtnj.Leave += new System.EventHandler(this.txtnj_Leave);
            // 
            // rechercher
            // 
            this.rechercher.BorderRadius = 18;
            this.rechercher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rechercher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rechercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rechercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rechercher.FillColor = System.Drawing.Color.Teal;
            this.rechercher.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.Location = new System.Drawing.Point(45, 251);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(180, 45);
            this.rechercher.TabIndex = 9;
            this.rechercher.Text = "Rechercher";
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // txtdd
            // 
            this.txtdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdd.Location = new System.Drawing.Point(815, 110);
            this.txtdd.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.txtdd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(235, 30);
            this.txtdd.TabIndex = 5;
            // 
            // modifier
            // 
            this.modifier.BorderRadius = 18;
            this.modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modifier.Enabled = false;
            this.modifier.FillColor = System.Drawing.Color.Teal;
            this.modifier.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(432, 251);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(180, 45);
            this.modifier.TabIndex = 11;
            this.modifier.Text = "Modifier";
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BorderRadius = 18;
            this.enregistrer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.enregistrer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.enregistrer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.enregistrer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.enregistrer.FillColor = System.Drawing.Color.Teal;
            this.enregistrer.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(815, 251);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(180, 45);
            this.enregistrer.TabIndex = 8;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // tableaux
            // 
            this.tableaux.BackgroundColor = System.Drawing.Color.White;
            this.tableaux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableaux.Location = new System.Drawing.Point(60, 354);
            this.tableaux.Name = "tableaux";
            this.tableaux.RowHeadersWidth = 62;
            this.tableaux.RowTemplate.Height = 28;
            this.tableaux.Size = new System.Drawing.Size(975, 200);
            this.tableaux.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(584, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Date De Demande";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(584, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Date De Retour";
            // 
            // txtdr
            // 
            this.txtdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtdr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdr.Location = new System.Drawing.Point(815, 154);
            this.txtdr.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.txtdr.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtdr.Name = "txtdr";
            this.txtdr.Size = new System.Drawing.Size(235, 30);
            this.txtdr.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(35, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Montant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre Jour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(584, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "N°Matricule Voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(584, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "N°CIN Client";
            // 
            // txtm
            // 
            this.txtm.Enabled = false;
            this.txtm.Location = new System.Drawing.Point(266, 110);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(143, 26);
            this.txtm.TabIndex = 26;
            this.txtm.Text = "0";
            this.txtm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtncc
            // 
            this.txtncc.Location = new System.Drawing.Point(815, 23);
            this.txtncc.Name = "txtncc";
            this.txtncc.Size = new System.Drawing.Size(235, 26);
            this.txtncc.TabIndex = 2;
            // 
            // txtnmv
            // 
            this.txtnmv.Location = new System.Drawing.Point(815, 67);
            this.txtnmv.Name = "txtnmv";
            this.txtnmv.Size = new System.Drawing.Size(235, 26);
            this.txtnmv.TabIndex = 3;
            this.txtnmv.Leave += new System.EventHandler(this.txtnmv_Leave);
            // 
            // location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 708);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "location";
            this.Load += new System.EventHandler(this.location_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button modifier;
        private Guna.UI2.WinForms.Guna2Button enregistrer;
        private System.Windows.Forms.DataGridView tableaux;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtdr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtncc;
        private System.Windows.Forms.TextBox txtnmv;
        private System.Windows.Forms.DateTimePicker txtdd;
        private System.Windows.Forms.Label precedentGC;
        private Guna.UI2.WinForms.Guna2Button rechercher;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtnj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnc;
    }
}