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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void deconnecter_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Voulez-Vous Se Déconnecter??","Gestion Location De Voiture",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    connection cnx = new connection();
                    cnx.Show();
                    this.Hide();
            }
        }

        private void pictureBoxGV_Click(object sender, EventArgs e)
        {
            voiture voiture = new voiture();
            voiture.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            voiture voiture = new voiture();
            voiture.Show();
            this.Hide();
        }

        private void pictureBoxGC_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
            this.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
