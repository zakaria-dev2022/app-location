using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Location_Voiture
{
    public partial class chargement : Form
    {
        public chargement()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void chargement_Load(object sender, EventArgs e)
        {
            
            
        }

            int p = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            p++;
            progress.Value = p;
            porssentage.Text = p.ToString() + " %";
            if (progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                connection cnx = new connection();
                cnx.Show();
                this.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
