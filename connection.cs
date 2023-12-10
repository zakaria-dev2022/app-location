using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Location_Voiture
{
    public partial class connection : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";

        private SqlDataAdapter dataAdapter;
        SqlConnection Connection;
        SqlCommand cmd;
        private DataTable dt;
        public connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnu.Text != "" && txtmp.Text != "")
            {

                cmd = new SqlCommand("select * from login where [id]= 1", Connection);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();

                if (txtnu.Text== rd[1].ToString() && txtmp.Text== rd[2].ToString())
                {
                    dashboard dash = new dashboard();
                    dash.Show();
                    this.Hide();
                }



                else if(txtnu.Text != rd[1].ToString() && txtmp.Text != rd[2].ToString())
                {
                    rd.Close();
                    cmd = new SqlCommand("select * from login_assistant where [utilisateur] ='" + txtnu.Text + "'", Connection);
                    SqlDataReader rd2 = cmd.ExecuteReader();
                    if (rd2.HasRows)
                    {
                        rd2.Read();
                        if (txtnu.Text == rd2[1].ToString() && txtmp.Text == rd2[2].ToString())
                        {
                            menu menu = new menu();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Mot De Passe Incorect", "Gestion Location De Voiture");
                            //txtnu.Text = "";
                            txtmp.Text = "";
                            txtmp.Focus();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Il n'y a pas ce profil ", "Gestion Location De Voiture");
                        txtnu.Text = "";
                        txtmp.Text = "";
                        txtnu.Focus();

                    }

                    rd2.Close();

                }


                else
                {
                    MessageBox.Show("Nom Utilisateur Ou Mot De Passe Incorect", "Gestion Location De Voiture");
                    txtnu.Text = "";
                    txtmp.Text = "";
                    txtnu.Focus();
                    //rd.Close();
                }
                rd.Close();
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

        private void connection_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(cnx);
            Connection.Open();
        }
    }
}
