namespace Gestion_Location_Voiture
{
    partial class gestion_profils
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.precedentGC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcmp = new System.Windows.Forms.TextBox();
            this.lb_cmp = new System.Windows.Forms.Label();
            this.lb_msg = new System.Windows.Forms.Label();
            this.modifier = new System.Windows.Forms.Button();
            this.enregistrer = new System.Windows.Forms.Button();
            this.rechercher = new System.Windows.Forms.Button();
            this.tableaux = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.supprimer = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.precedentGC);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 100);
            this.panel2.TabIndex = 5;
            // 
            // precedentGC
            // 
            this.precedentGC.AutoSize = true;
            this.precedentGC.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.precedentGC.ForeColor = System.Drawing.Color.White;
            this.precedentGC.Location = new System.Drawing.Point(874, 46);
            this.precedentGC.Name = "precedentGC";
            this.precedentGC.Size = new System.Drawing.Size(113, 29);
            this.precedentGC.TabIndex = 7;
            this.precedentGC.Text = "précedent ";
            this.precedentGC.Click += new System.EventHandler(this.precedentGC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gestion Des Profils";
            // 
            // txtnu
            // 
            this.txtnu.BackColor = System.Drawing.Color.White;
            this.txtnu.Location = new System.Drawing.Point(329, 155);
            this.txtnu.Multiline = true;
            this.txtnu.Name = "txtnu";
            this.txtnu.Size = new System.Drawing.Size(253, 26);
            this.txtnu.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(35, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 33);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nom Utilisateur";
            // 
            // txtmp
            // 
            this.txtmp.BackColor = System.Drawing.Color.White;
            this.txtmp.Location = new System.Drawing.Point(329, 211);
            this.txtmp.Multiline = true;
            this.txtmp.Name = "txtmp";
            this.txtmp.Size = new System.Drawing.Size(253, 26);
            this.txtmp.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(35, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mot De Passe";
            // 
            // txtcmp
            // 
            this.txtcmp.BackColor = System.Drawing.Color.White;
            this.txtcmp.Location = new System.Drawing.Point(329, 284);
            this.txtcmp.Multiline = true;
            this.txtcmp.Name = "txtcmp";
            this.txtcmp.Size = new System.Drawing.Size(253, 26);
            this.txtcmp.TabIndex = 39;
            // 
            // lb_cmp
            // 
            this.lb_cmp.AutoSize = true;
            this.lb_cmp.BackColor = System.Drawing.Color.White;
            this.lb_cmp.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_cmp.ForeColor = System.Drawing.Color.Teal;
            this.lb_cmp.Location = new System.Drawing.Point(35, 284);
            this.lb_cmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cmp.Name = "lb_cmp";
            this.lb_cmp.Size = new System.Drawing.Size(287, 33);
            this.lb_cmp.TabIndex = 38;
            this.lb_cmp.Text = "Confirmer Mot De Passe ";
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_msg.ForeColor = System.Drawing.Color.Red;
            this.lb_msg.Location = new System.Drawing.Point(325, 251);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(46, 20);
            this.lb_msg.TabIndex = 40;
            this.lb_msg.Text = "label2";
            this.lb_msg.Visible = false;
            this.lb_msg.Click += new System.EventHandler(this.lb_msg_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Teal;
            this.modifier.Enabled = false;
            this.modifier.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(738, 241);
            this.modifier.Margin = new System.Windows.Forms.Padding(4);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(194, 44);
            this.modifier.TabIndex = 76;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Teal;
            this.enregistrer.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.Color.White;
            this.enregistrer.Location = new System.Drawing.Point(738, 119);
            this.enregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(194, 44);
            this.enregistrer.TabIndex = 74;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.Teal;
            this.rechercher.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.Location = new System.Drawing.Point(738, 183);
            this.rechercher.Margin = new System.Windows.Forms.Padding(4);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(194, 44);
            this.rechercher.TabIndex = 75;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // tableaux
            // 
            this.tableaux.BackgroundColor = System.Drawing.Color.White;
            this.tableaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableaux.Location = new System.Drawing.Point(202, 377);
            this.tableaux.Name = "tableaux";
            this.tableaux.RowHeadersWidth = 62;
            this.tableaux.RowTemplate.Height = 28;
            this.tableaux.Size = new System.Drawing.Size(576, 247);
            this.tableaux.TabIndex = 77;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Location = new System.Drawing.Point(329, 106);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(120, 26);
            this.txtid.TabIndex = 78;
            this.txtid.Visible = false;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Teal;
            this.supprimer.Enabled = false;
            this.supprimer.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(738, 293);
            this.supprimer.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(194, 44);
            this.supprimer.TabIndex = 79;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // gestion_profils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 653);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.tableaux);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.txtcmp);
            this.Controls.Add(this.lb_cmp);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestion_profils";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestion_profils";
            this.Load += new System.EventHandler(this.gestion_profils_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcmp;
        private System.Windows.Forms.Label lb_cmp;
        private System.Windows.Forms.Label lb_msg;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button rechercher;
        private System.Windows.Forms.DataGridView tableaux;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label precedentGC;
    }
}