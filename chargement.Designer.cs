namespace Gestion_Location_Voiture
{
    partial class chargement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chargement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_logo = new System.Windows.Forms.Label();
            this.porssentage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lb_na = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lb_logo);
            this.panel1.Controls.Add(this.porssentage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progress);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.lb_na);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 555);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Location = new System.Drawing.Point(450, 419);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(51, 20);
            this.lb_logo.TabIndex = 6;
            this.lb_logo.Text = "label1";
            this.lb_logo.Visible = false;
            // 
            // porssentage
            // 
            this.porssentage.AutoSize = true;
            this.porssentage.Font = new System.Drawing.Font("Arial Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.porssentage.Location = new System.Drawing.Point(316, 419);
            this.porssentage.Name = "porssentage";
            this.porssentage.Size = new System.Drawing.Size(38, 37);
            this.porssentage.TabIndex = 5;
            this.porssentage.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(147, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chargement ";
            // 
            // progress
            // 
            this.progress.FillColor = System.Drawing.Color.White;
            this.progress.Location = new System.Drawing.Point(138, 476);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(687, 19);
            this.progress.TabIndex = 3;
            this.progress.Text = "guna2ProgressBar1";
            this.progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progress.ValueChanged += new System.EventHandler(this.progress_ValueChanged);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(283, 86);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(373, 304);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_na
            // 
            this.lb_na.AutoSize = true;
            this.lb_na.Font = new System.Drawing.Font("Arial Narrow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_na.Location = new System.Drawing.Point(273, 9);
            this.lb_na.Name = "lb_na";
            this.lb_na.Size = new System.Drawing.Size(818, 57);
            this.lb_na.TabIndex = 0;
            this.lb_na.Text = "Application De Getion Location De Voiture";
            this.lb_na.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 555);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chargement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.chargement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
        private System.Windows.Forms.Label lb_na;
        private System.Windows.Forms.Label porssentage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lb_logo;
    }
}

