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
    public partial class connection : Form
    {
        public connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnu.Text!="" && txtmp.Text!="")
            {
                string np = "admin";
                string mp = "admin";

                if (txtnu.Text == np && txtmp.Text == mp) {
                    menu menu = new menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nom Utilisateur Ou Mot De Passe Incorect", "Gestion Location De Voiture");
                }

            }
            else
            {
                MessageBox.Show("Entrer Nom Utilisateur Et Mot De Passe", "Gestion Location De Voiture");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-Vous Quitter L'application??", "Gestion Location De Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           this.Close();
        }
    }
}
