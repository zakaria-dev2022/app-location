namespace Gestion_Location_Voiture
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logo = new System.Windows.Forms.Button();
            this.lb_nu = new System.Windows.Forms.Label();
            this.txtnu = new System.Windows.Forms.TextBox();
            this.txtmp = new System.Windows.Forms.TextBox();
            this.lb_mp = new System.Windows.Forms.Label();
            this.oeil_mp = new System.Windows.Forms.PictureBox();
            this.oeil_mp_modifier = new System.Windows.Forms.PictureBox();
            this.txtmp_modifier = new System.Windows.Forms.TextBox();
            this.lb_mp_modifier = new System.Windows.Forms.Label();
            this.txtnu_modifier = new System.Windows.Forms.TextBox();
            this.lb_nu_modifier = new System.Windows.Forms.Label();
            this.oeil_cmp_modifier = new System.Windows.Forms.PictureBox();
            this.txtcmp_modifier = new System.Windows.Forms.TextBox();
            this.lb_cmp_modifier = new System.Windows.Forms.Label();
            this.btn_ann_para = new System.Windows.Forms.Button();
            this.btn_changer = new System.Windows.Forms.Button();
            this.lb_msg = new System.Windows.Forms.Label();
            this.lb_logo = new System.Windows.Forms.Label();
            this.txtna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_modifier_info = new System.Windows.Forms.Button();
            this.btn_ann_info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oeil_mp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeil_mp_modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeil_cmp_modifier)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 66);
            this.label1.TabIndex = 6;
            this.label1.Text = "Paramétre";
            // 
            // logo
            // 
            this.logo.Location = new System.Drawing.Point(743, 122);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(304, 153);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 100);
            this.panel2.TabIndex = 4;
            // 
            // btn_logo
            // 
            this.btn_logo.BackColor = System.Drawing.Color.Teal;
            this.btn_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logo.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_logo.ForeColor = System.Drawing.Color.White;
            this.btn_logo.Location = new System.Drawing.Point(816, 297);
            this.btn_logo.Name = "btn_logo";
            this.btn_logo.Size = new System.Drawing.Size(181, 54);
            this.btn_logo.TabIndex = 9;
            this.btn_logo.Text = "Importer";
            this.btn_logo.UseVisualStyleBackColor = false;
            this.btn_logo.Click += new System.EventHandler(this.btn_logo_Click);
            // 
            // lb_nu
            // 
            this.lb_nu.AutoSize = true;
            this.lb_nu.BackColor = System.Drawing.Color.White;
            this.lb_nu.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_nu.ForeColor = System.Drawing.Color.Teal;
            this.lb_nu.Location = new System.Drawing.Point(24, 210);
            this.lb_nu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nu.Name = "lb_nu";
            this.lb_nu.Size = new System.Drawing.Size(185, 33);
            this.lb_nu.TabIndex = 10;
            this.lb_nu.Text = "Nom Utilisateur";
            // 
            // txtnu
            // 
            this.txtnu.BackColor = System.Drawing.Color.White;
            this.txtnu.Location = new System.Drawing.Point(273, 217);
            this.txtnu.Name = "txtnu";
            this.txtnu.ReadOnly = true;
            this.txtnu.Size = new System.Drawing.Size(216, 26);
            this.txtnu.TabIndex = 11;
            // 
            // txtmp
            // 
            this.txtmp.BackColor = System.Drawing.Color.White;
            this.txtmp.Location = new System.Drawing.Point(273, 264);
            this.txtmp.Name = "txtmp";
            this.txtmp.PasswordChar = '*';
            this.txtmp.ReadOnly = true;
            this.txtmp.Size = new System.Drawing.Size(216, 26);
            this.txtmp.TabIndex = 13;
            // 
            // lb_mp
            // 
            this.lb_mp.AutoSize = true;
            this.lb_mp.BackColor = System.Drawing.Color.White;
            this.lb_mp.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_mp.ForeColor = System.Drawing.Color.Teal;
            this.lb_mp.Location = new System.Drawing.Point(24, 258);
            this.lb_mp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mp.Name = "lb_mp";
            this.lb_mp.Size = new System.Drawing.Size(165, 33);
            this.lb_mp.TabIndex = 12;
            this.lb_mp.Text = "Mot De Passe";
            // 
            // oeil_mp
            // 
            this.oeil_mp.Image = ((System.Drawing.Image)(resources.GetObject("oeil_mp.Image")));
            this.oeil_mp.Location = new System.Drawing.Point(495, 264);
            this.oeil_mp.Name = "oeil_mp";
            this.oeil_mp.Size = new System.Drawing.Size(38, 27);
            this.oeil_mp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oeil_mp.TabIndex = 14;
            this.oeil_mp.TabStop = false;
            this.oeil_mp.Click += new System.EventHandler(this.oeil_mp_Click);
            // 
            // oeil_mp_modifier
            // 
            this.oeil_mp_modifier.Image = ((System.Drawing.Image)(resources.GetObject("oeil_mp_modifier.Image")));
            this.oeil_mp_modifier.Location = new System.Drawing.Point(532, 260);
            this.oeil_mp_modifier.Name = "oeil_mp_modifier";
            this.oeil_mp_modifier.Size = new System.Drawing.Size(38, 27);
            this.oeil_mp_modifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oeil_mp_modifier.TabIndex = 20;
            this.oeil_mp_modifier.TabStop = false;
            this.oeil_mp_modifier.Visible = false;
            this.oeil_mp_modifier.Click += new System.EventHandler(this.oeil_mp_modifier_Click);
            // 
            // txtmp_modifier
            // 
            this.txtmp_modifier.Location = new System.Drawing.Point(310, 260);
            this.txtmp_modifier.Name = "txtmp_modifier";
            this.txtmp_modifier.PasswordChar = '*';
            this.txtmp_modifier.Size = new System.Drawing.Size(216, 26);
            this.txtmp_modifier.TabIndex = 19;
            this.txtmp_modifier.Visible = false;
            // 
            // lb_mp_modifier
            // 
            this.lb_mp_modifier.AutoSize = true;
            this.lb_mp_modifier.BackColor = System.Drawing.Color.White;
            this.lb_mp_modifier.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_mp_modifier.ForeColor = System.Drawing.Color.Teal;
            this.lb_mp_modifier.Location = new System.Drawing.Point(24, 260);
            this.lb_mp_modifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mp_modifier.Name = "lb_mp_modifier";
            this.lb_mp_modifier.Size = new System.Drawing.Size(165, 33);
            this.lb_mp_modifier.TabIndex = 18;
            this.lb_mp_modifier.Text = "Mot De Passe";
            this.lb_mp_modifier.Visible = false;
            // 
            // txtnu_modifier
            // 
            this.txtnu_modifier.Location = new System.Drawing.Point(310, 217);
            this.txtnu_modifier.Name = "txtnu_modifier";
            this.txtnu_modifier.Size = new System.Drawing.Size(216, 26);
            this.txtnu_modifier.TabIndex = 17;
            this.txtnu_modifier.Visible = false;
            // 
            // lb_nu_modifier
            // 
            this.lb_nu_modifier.AutoSize = true;
            this.lb_nu_modifier.BackColor = System.Drawing.Color.White;
            this.lb_nu_modifier.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_nu_modifier.ForeColor = System.Drawing.Color.Teal;
            this.lb_nu_modifier.Location = new System.Drawing.Point(24, 217);
            this.lb_nu_modifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nu_modifier.Name = "lb_nu_modifier";
            this.lb_nu_modifier.Size = new System.Drawing.Size(185, 33);
            this.lb_nu_modifier.TabIndex = 16;
            this.lb_nu_modifier.Text = "Nom Utilisateur";
            this.lb_nu_modifier.Visible = false;
            // 
            // oeil_cmp_modifier
            // 
            this.oeil_cmp_modifier.Image = ((System.Drawing.Image)(resources.GetObject("oeil_cmp_modifier.Image")));
            this.oeil_cmp_modifier.Location = new System.Drawing.Point(532, 338);
            this.oeil_cmp_modifier.Name = "oeil_cmp_modifier";
            this.oeil_cmp_modifier.Size = new System.Drawing.Size(38, 27);
            this.oeil_cmp_modifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oeil_cmp_modifier.TabIndex = 23;
            this.oeil_cmp_modifier.TabStop = false;
            this.oeil_cmp_modifier.Visible = false;
            this.oeil_cmp_modifier.Click += new System.EventHandler(this.oeil_cmp_modifier_Click);
            // 
            // txtcmp_modifier
            // 
            this.txtcmp_modifier.Location = new System.Drawing.Point(310, 338);
            this.txtcmp_modifier.Name = "txtcmp_modifier";
            this.txtcmp_modifier.PasswordChar = '*';
            this.txtcmp_modifier.Size = new System.Drawing.Size(216, 26);
            this.txtcmp_modifier.TabIndex = 22;
            this.txtcmp_modifier.Visible = false;
            // 
            // lb_cmp_modifier
            // 
            this.lb_cmp_modifier.AutoSize = true;
            this.lb_cmp_modifier.BackColor = System.Drawing.Color.White;
            this.lb_cmp_modifier.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_cmp_modifier.ForeColor = System.Drawing.Color.Teal;
            this.lb_cmp_modifier.Location = new System.Drawing.Point(22, 331);
            this.lb_cmp_modifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cmp_modifier.Name = "lb_cmp_modifier";
            this.lb_cmp_modifier.Size = new System.Drawing.Size(281, 33);
            this.lb_cmp_modifier.TabIndex = 21;
            this.lb_cmp_modifier.Text = "Confirmer Mot De Passe";
            this.lb_cmp_modifier.Visible = false;
            // 
            // btn_ann_para
            // 
            this.btn_ann_para.BackColor = System.Drawing.Color.Silver;
            this.btn_ann_para.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ann_para.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_ann_para.ForeColor = System.Drawing.Color.White;
            this.btn_ann_para.Location = new System.Drawing.Point(923, 540);
            this.btn_ann_para.Name = "btn_ann_para";
            this.btn_ann_para.Size = new System.Drawing.Size(124, 46);
            this.btn_ann_para.TabIndex = 26;
            this.btn_ann_para.Text = "Sortir";
            this.btn_ann_para.UseVisualStyleBackColor = false;
            this.btn_ann_para.Click += new System.EventHandler(this.btn_ann_para_Click);
            // 
            // btn_changer
            // 
            this.btn_changer.BackColor = System.Drawing.Color.Teal;
            this.btn_changer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changer.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_changer.ForeColor = System.Drawing.Color.White;
            this.btn_changer.Location = new System.Drawing.Point(371, 311);
            this.btn_changer.Name = "btn_changer";
            this.btn_changer.Size = new System.Drawing.Size(118, 40);
            this.btn_changer.TabIndex = 27;
            this.btn_changer.Text = "Changer";
            this.btn_changer.UseVisualStyleBackColor = false;
            this.btn_changer.Click += new System.EventHandler(this.btn_changer_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_msg.ForeColor = System.Drawing.Color.Red;
            this.lb_msg.Location = new System.Drawing.Point(306, 298);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(46, 20);
            this.lb_msg.TabIndex = 28;
            this.lb_msg.Text = "label2";
            this.lb_msg.Visible = false;
            this.lb_msg.Click += new System.EventHandler(this.lb_msg_Click);
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Location = new System.Drawing.Point(750, 318);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(51, 20);
            this.lb_logo.TabIndex = 31;
            this.lb_logo.Text = "label2";
            this.lb_logo.Visible = false;
            // 
            // txtna
            // 
            this.txtna.BackColor = System.Drawing.Color.White;
            this.txtna.Location = new System.Drawing.Point(273, 145);
            this.txtna.Multiline = true;
            this.txtna.Name = "txtna";
            this.txtna.Size = new System.Drawing.Size(253, 26);
            this.txtna.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nom De Application";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Teal;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(779, 540);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(124, 46);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_modifier_info
            // 
            this.btn_modifier_info.BackColor = System.Drawing.Color.Teal;
            this.btn_modifier_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifier_info.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_modifier_info.ForeColor = System.Drawing.Color.White;
            this.btn_modifier_info.Location = new System.Drawing.Point(318, 400);
            this.btn_modifier_info.Name = "btn_modifier_info";
            this.btn_modifier_info.Size = new System.Drawing.Size(118, 40);
            this.btn_modifier_info.TabIndex = 35;
            this.btn_modifier_info.Text = "Modifier";
            this.btn_modifier_info.UseVisualStyleBackColor = false;
            this.btn_modifier_info.Visible = false;
            this.btn_modifier_info.Click += new System.EventHandler(this.btn_modifier_info_Click);
            // 
            // btn_ann_info
            // 
            this.btn_ann_info.BackColor = System.Drawing.Color.Silver;
            this.btn_ann_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ann_info.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_ann_info.ForeColor = System.Drawing.Color.White;
            this.btn_ann_info.Location = new System.Drawing.Point(455, 400);
            this.btn_ann_info.Name = "btn_ann_info";
            this.btn_ann_info.Size = new System.Drawing.Size(118, 40);
            this.btn_ann_info.TabIndex = 36;
            this.btn_ann_info.Text = "Annuler";
            this.btn_ann_info.UseVisualStyleBackColor = false;
            this.btn_ann_info.Visible = false;
            this.btn_ann_info.Click += new System.EventHandler(this.btn_ann_info_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 611);
            this.Controls.Add(this.btn_ann_info);
            this.Controls.Add(this.btn_modifier_info);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_logo);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.btn_changer);
            this.Controls.Add(this.btn_ann_para);
            this.Controls.Add(this.oeil_cmp_modifier);
            this.Controls.Add(this.txtcmp_modifier);
            this.Controls.Add(this.lb_cmp_modifier);
            this.Controls.Add(this.oeil_mp_modifier);
            this.Controls.Add(this.txtmp_modifier);
            this.Controls.Add(this.lb_mp_modifier);
            this.Controls.Add(this.txtnu_modifier);
            this.Controls.Add(this.lb_nu_modifier);
            this.Controls.Add(this.oeil_mp);
            this.Controls.Add(this.txtmp);
            this.Controls.Add(this.lb_mp);
            this.Controls.Add(this.txtnu);
            this.Controls.Add(this.lb_nu);
            this.Controls.Add(this.btn_logo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "setting";
            this.Load += new System.EventHandler(this.setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oeil_mp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeil_mp_modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oeil_cmp_modifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_logo;
        private System.Windows.Forms.Label lb_nu;
        private System.Windows.Forms.TextBox txtnu;
        private System.Windows.Forms.TextBox txtmp;
        private System.Windows.Forms.Label lb_mp;
        private System.Windows.Forms.PictureBox oeil_mp;
        private System.Windows.Forms.PictureBox oeil_mp_modifier;
        private System.Windows.Forms.TextBox txtmp_modifier;
        private System.Windows.Forms.Label lb_mp_modifier;
        private System.Windows.Forms.TextBox txtnu_modifier;
        private System.Windows.Forms.Label lb_nu_modifier;
        private System.Windows.Forms.PictureBox oeil_cmp_modifier;
        private System.Windows.Forms.TextBox txtcmp_modifier;
        private System.Windows.Forms.Label lb_cmp_modifier;
        private System.Windows.Forms.Button btn_ann_para;
        private System.Windows.Forms.Button btn_changer;
        private System.Windows.Forms.Label lb_msg;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.TextBox txtna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_modifier_info;
        private System.Windows.Forms.Button btn_ann_info;
    }
}