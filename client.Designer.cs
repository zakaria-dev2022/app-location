namespace Gestion_Location_Voiture
{
    partial class client
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.precedentGC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtne = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtnc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableaux = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rechercher = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.btncv = new System.Windows.Forms.Button();
            this.btncr = new System.Windows.Forms.Button();
            this.lb_recto = new System.Windows.Forms.Label();
            this.recto = new System.Windows.Forms.PictureBox();
            this.lb_verso = new System.Windows.Forms.Label();
            this.verso = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.precedentGC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(246, 54);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(114, 26);
            this.txtid.TabIndex = 26;
            this.txtid.Visible = false;
            // 
            // precedentGC
            // 
            this.precedentGC.AutoSize = true;
            this.precedentGC.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.precedentGC.ForeColor = System.Drawing.Color.White;
            this.precedentGC.Location = new System.Drawing.Point(1040, 54);
            this.precedentGC.Name = "precedentGC";
            this.precedentGC.Size = new System.Drawing.Size(113, 29);
            this.precedentGC.TabIndex = 4;
            this.precedentGC.Text = "précedent ";
            this.precedentGC.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(396, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion Des Clients";
            // 
            // txtne
            // 
            this.txtne.Location = new System.Drawing.Point(269, 125);
            this.txtne.Name = "txtne";
            this.txtne.Size = new System.Drawing.Size(182, 26);
            this.txtne.TabIndex = 1;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(270, 166);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(182, 26);
            this.txtn.TabIndex = 2;
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(269, 209);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(182, 26);
            this.txtp.TabIndex = 3;
            // 
            // txtnc
            // 
            this.txtnc.Location = new System.Drawing.Point(269, 251);
            this.txtnc.Name = "txtnc";
            this.txtnc.Size = new System.Drawing.Size(182, 26);
            this.txtnc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom Entreprise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(47, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(47, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "N° C.I.N / N°Passport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(47, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "N° Tel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(47, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Prenom";
            // 
            // tableaux
            // 
            this.tableaux.BackgroundColor = System.Drawing.Color.White;
            this.tableaux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableaux.Location = new System.Drawing.Point(12, 504);
            this.tableaux.Name = "tableaux";
            this.tableaux.RowHeadersWidth = 62;
            this.tableaux.RowTemplate.Height = 28;
            this.tableaux.Size = new System.Drawing.Size(1156, 205);
            this.tableaux.TabIndex = 15;
            this.tableaux.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableaux_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(45, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "N° Permis";
            // 
            // txtnp
            // 
            this.txtnp.Location = new System.Drawing.Point(269, 293);
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(182, 26);
            this.txtnp.TabIndex = 5;
            this.txtnp.Tag = "";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(269, 374);
            this.txta.Multiline = true;
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(182, 26);
            this.txta.TabIndex = 8;
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(269, 334);
            this.txtt.Mask = "00 00 00 00 00";
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(182, 26);
            this.txtt.TabIndex = 7;
            this.txtt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(47, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Adresse";
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.Teal;
            this.rechercher.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.Location = new System.Drawing.Point(464, 432);
            this.rechercher.Margin = new System.Windows.Forms.Padding(4);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(194, 44);
            this.rechercher.TabIndex = 29;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Teal;
            this.modifier.Enabled = false;
            this.modifier.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(705, 432);
            this.modifier.Margin = new System.Windows.Forms.Padding(4);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(194, 44);
            this.modifier.TabIndex = 30;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click_1);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Teal;
            this.enregistrer.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(945, 432);
            this.enregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(194, 44);
            this.enregistrer.TabIndex = 31;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // btncv
            // 
            this.btncv.BackColor = System.Drawing.Color.Teal;
            this.btncv.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncv.ForeColor = System.Drawing.Color.White;
            this.btncv.Location = new System.Drawing.Point(945, 292);
            this.btncv.Margin = new System.Windows.Forms.Padding(4);
            this.btncv.Name = "btncv";
            this.btncv.Size = new System.Drawing.Size(145, 44);
            this.btncv.TabIndex = 32;
            this.btncv.Text = "Carte Verso";
            this.btncv.UseVisualStyleBackColor = false;
            this.btncv.Click += new System.EventHandler(this.btncv_Click);
            // 
            // btncr
            // 
            this.btncr.BackColor = System.Drawing.Color.Teal;
            this.btncr.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncr.ForeColor = System.Drawing.Color.White;
            this.btncr.Location = new System.Drawing.Point(550, 295);
            this.btncr.Margin = new System.Windows.Forms.Padding(4);
            this.btncr.Name = "btncr";
            this.btncr.Size = new System.Drawing.Size(147, 44);
            this.btncr.TabIndex = 33;
            this.btncr.Text = "Carte Recto";
            this.btncr.UseVisualStyleBackColor = false;
            this.btncr.Click += new System.EventHandler(this.btncr_Click);
            // 
            // lb_recto
            // 
            this.lb_recto.AutoSize = true;
            this.lb_recto.Location = new System.Drawing.Point(585, 103);
            this.lb_recto.Name = "lb_recto";
            this.lb_recto.Size = new System.Drawing.Size(51, 20);
            this.lb_recto.TabIndex = 78;
            this.lb_recto.Text = "label7";
            this.lb_recto.Visible = false;
            // 
            // recto
            // 
            this.recto.Location = new System.Drawing.Point(475, 127);
            this.recto.Margin = new System.Windows.Forms.Padding(4);
            this.recto.Name = "recto";
            this.recto.Size = new System.Drawing.Size(299, 155);
            this.recto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recto.TabIndex = 77;
            this.recto.TabStop = false;
            // 
            // lb_verso
            // 
            this.lb_verso.AutoSize = true;
            this.lb_verso.Location = new System.Drawing.Point(1027, 103);
            this.lb_verso.Name = "lb_verso";
            this.lb_verso.Size = new System.Drawing.Size(51, 20);
            this.lb_verso.TabIndex = 80;
            this.lb_verso.Text = "label7";
            this.lb_verso.Visible = false;
            // 
            // verso
            // 
            this.verso.Location = new System.Drawing.Point(869, 127);
            this.verso.Margin = new System.Windows.Forms.Padding(4);
            this.verso.Name = "verso";
            this.verso.Size = new System.Drawing.Size(299, 155);
            this.verso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verso.TabIndex = 79;
            this.verso.TabStop = false;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 732);
            this.Controls.Add(this.lb_verso);
            this.Controls.Add(this.verso);
            this.Controls.Add(this.lb_recto);
            this.Controls.Add(this.recto);
            this.Controls.Add(this.btncr);
            this.Controls.Add(this.btncv);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.tableaux);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnc);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtne);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "client";
            this.Load += new System.EventHandler(this.client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label precedentGC;
        private System.Windows.Forms.TextBox txtne;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtnc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView tableaux;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnp;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.MaskedTextBox txtt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button btncv;
        private System.Windows.Forms.Button btncr;
        private System.Windows.Forms.Label lb_recto;
        private System.Windows.Forms.PictureBox recto;
        private System.Windows.Forms.Label lb_verso;
        private System.Windows.Forms.PictureBox verso;
    }
}