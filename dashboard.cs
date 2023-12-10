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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label5_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-Vous Se Déconnecter??", "Gestion Location De Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection cnx = new connection();
                cnx.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            voiture voiture = new voiture();
            voiture.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            location location = new location();
            location.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
