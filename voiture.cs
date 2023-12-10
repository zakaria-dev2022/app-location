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
    public partial class voiture : Form
    {
        public voiture()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("\tMarque : Audi RS6 \n\tPrix : 3000DH/j\n\tN° Matricule : 122323/A/6\n\tModele : 2022\n\t", "Gestion Location De Voiture");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string rch = cbtype.Text;

            if (rch == "Voiture De Luxe")
            {
                l1.Visible = true;
                l2.Visible = true;
                l3.Visible = true;
                l4.Visible = true;
                l5.Visible = true;
                l6.Visible = true;
                l7.Visible = true;
                l8.Visible = true;
                l9.Visible = true;

                    e1.Visible = false;
                    e2.Visible = false;
                    e3.Visible = false;
                    e4.Visible = false;
                    e5.Visible = false;
                    e6.Visible = false;
                    e7.Visible = false;
                    e8.Visible = false;
                    e9.Visible = false;

                    c1.Visible = false;
                    c2.Visible = false;
                    c3.Visible = false;
                    c4.Visible = false;
                    c5.Visible = false;
                    c6.Visible = false;
                    c7.Visible = false;
                    c8.Visible = false;
                    c9.Visible = false;


            }

            else if (rch == "Voiture Cabriolet")
            {
                c1.Visible = true;
                c2.Visible = true;
                c3.Visible = true;
                c4.Visible = true;
                c5.Visible = true;
                c6.Visible = true;
                c7.Visible = true;
                c8.Visible = true;
                c9.Visible = true;

                    e1.Visible = false;
                    e2.Visible = false;
                    e3.Visible = false;
                    e4.Visible = false;
                    e5.Visible = false;
                    e6.Visible = false;
                    e7.Visible = false;
                    e8.Visible = false;
                    e9.Visible = false;

                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    l5.Visible = false;
                    l6.Visible = false;
                    l7.Visible = false;
                    l8.Visible = false;
                    l9.Visible = false;
               
            }
            else if (rch == "Voiture Économique")
            {
                e1.Visible = true;
                e2.Visible = true;
                e3.Visible = true;
                e4.Visible = true;
                e5.Visible = true;
                e6.Visible = true;
                e7.Visible = true;
                e8.Visible = true;
                e9.Visible = true;

                    c1.Visible = false;
                    c2.Visible = false;
                    c3.Visible = false;
                    c4.Visible = false;
                    c5.Visible = false;
                    c6.Visible = false;
                    c7.Visible = false;
                    c8.Visible = false;
                    c9.Visible = false;

                    l1.Visible = false;
                    l2.Visible = false;
                    l3.Visible = false;
                    l4.Visible = false;
                    l5.Visible = false;
                    l6.Visible = false;
                    l7.Visible = false;
                    l8.Visible = false;
                    l9.Visible = false;
                
            }



            }

        private void precedentGV_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void e1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
