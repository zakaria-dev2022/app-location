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
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supprimer = new Guna.UI2.WinForms.Guna2Button();
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
            this.txtt = new System.Windows.Forms.TextBox();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtdd = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.precedentGC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.txtdd);
            this.panel2.Controls.Add(this.supprimer);
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
            this.panel2.Controls.Add(this.txtt);
            this.panel2.Controls.Add(this.txtnp);
            this.panel2.Controls.Add(this.txtnm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 614);
            this.panel2.TabIndex = 1;
            // 
            // supprimer
            // 
            this.supprimer.BorderRadius = 18;
            this.supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.supprimer.FillColor = System.Drawing.Color.Teal;
            this.supprimer.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(755, 228);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(180, 45);
            this.supprimer.TabIndex = 40;
            this.supprimer.Text = "Supprimer";
            // 
            // modifier
            // 
            this.modifier.BorderRadius = 18;
            this.modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modifier.FillColor = System.Drawing.Color.Teal;
            this.modifier.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(148, 228);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(180, 45);
            this.modifier.TabIndex = 39;
            this.modifier.Text = "Modifier";
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
            this.enregistrer.Location = new System.Drawing.Point(445, 228);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(180, 45);
            this.enregistrer.TabIndex = 38;
            this.enregistrer.Text = "Enregistrer";
            // 
            // tableaux
            // 
            this.tableaux.BackgroundColor = System.Drawing.Color.White;
            this.tableaux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableaux.Location = new System.Drawing.Point(4, 301);
            this.tableaux.Name = "tableaux";
            this.tableaux.RowHeadersWidth = 62;
            this.tableaux.RowTemplate.Height = 28;
            this.tableaux.Size = new System.Drawing.Size(1063, 289);
            this.tableaux.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(547, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Date De Demande";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(795, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Date De Retour";
            // 
            // txtdr
            // 
            this.txtdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtdr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdr.Location = new System.Drawing.Point(540, 64);
            this.txtdr.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.txtdr.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtdr.Name = "txtdr";
            this.txtdr.Size = new System.Drawing.Size(188, 30);
            this.txtdr.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(720, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "montant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(210, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre Jour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(327, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "N°Voiture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(105, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "N°Client";
            // 
            // txtt
            // 
            this.txtt.Enabled = false;
            this.txtt.Location = new System.Drawing.Point(670, 150);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(182, 26);
            this.txtt.TabIndex = 26;
            // 
            // txtnp
            // 
            this.txtnp.Location = new System.Drawing.Point(311, 63);
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(182, 26);
            this.txtnp.TabIndex = 24;
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(89, 63);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(182, 26);
            this.txtnm.TabIndex = 23;
            // 
            // txtdd
            // 
            this.txtdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdd.Location = new System.Drawing.Point(786, 64);
            this.txtdd.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.txtdd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txtdd.Name = "txtdd";
            this.txtdd.Size = new System.Drawing.Size(188, 30);
            this.txtdd.TabIndex = 42;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(176, 151);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 26);
            this.numericUpDown1.TabIndex = 43;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.Text = "location";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button supprimer;
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
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.TextBox txtnp;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.DateTimePicker txtdd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label precedentGC;
    }
}