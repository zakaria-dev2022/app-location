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
    public partial class gestion_profils : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader rd;
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
        public gestion_profils()
        {
            InitializeComponent();
        }

        private void lb_msg_Click(object sender, EventArgs e)
        {

        }

        private void gestion_profils_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(cnx);
            connection.Open();
            remplir();
        }
        private void remplir()
        {
            //initializez l'adapteur de donnée et le datatable
            dataAdapter = new SqlDataAdapter("select * from login_assistant ", cnx);
            dt = new DataTable();
            //remplissez le datatable avec less donnes
            dataAdapter.Fill(dt);
            //liez le datatable au tableau
            tableaux.DataSource = dt;
        }

        private void nouveau()
        {
            txtnu.Text = "";
            txtmp.Text = "";
            txtcmp.Text = "";
            txtnu.Focus();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Enregistrer La Modification ??", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtnu.Text !=null && txtmp.Text != null)
                {
                    SqlCommand cmd = new SqlCommand("update login_assistant set [utilisateur] = '" + txtnu.Text + "',[mot_passe] = '" + txtmp.Text + "' where [id_assistant]='" + txtid.Text + "'", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification effectuer", "Gestion Location Voiture");
                    nouveau();
                    remplir();
                    modifier.Enabled = false;
                    supprimer.Enabled = false;
                    enregistrer.Enabled = true;
                    lb_cmp.Visible = true;
                    txtcmp.Visible = true;
                }
                else
                {
                    MessageBox.Show("Verifier Les Donners!!!", "Gestion Location Voiture");
                }


            }
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            string ncr = Microsoft.VisualBasic.Interaction.InputBox("Non Utilisateur Que Vous Recherche", "Gestion Location Voiture");
            cmd = new SqlCommand("select *from login_assistant where [utilisateur]='" + ncr + "'", connection);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtid.Text = rd[0].ToString();
                txtnu.Text = rd[1].ToString();
                txtmp.Text = rd[2].ToString();
               
                modifier.Enabled = true;
                supprimer.Enabled = true;
                enregistrer.Enabled = false;
                lb_msg.Visible=false;
                txtcmp.Visible=false;
                lb_cmp.Visible=false;
            }
            else
            {
                MessageBox.Show("Non Utilisateur " + ncr + " Introuvable ", "Gestion Location Voiture");
            }
            rd.Close();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
             if(MessageBox.Show("Voulez Vous Supprimer  '" + txtnu.Text + "'","Gestion location De Voiture",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
           {
           cmd = new SqlCommand("Delete from login_assistant where [id_assistant]='" + txtid.Text + "'", connection);
           cmd.ExecuteNonQuery();
           MessageBox.Show("Suppretion Effectuer", "Gestion location De Voiture");
                remplir();
                nouveau();
                modifier.Enabled = false;
                supprimer.Enabled = false;
                enregistrer.Enabled = true;
                lb_cmp.Visible = true;
                txtcmp.Visible = true;
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (txtnu.Text != null && (txtmp.Text != null && txtmp.Text.Length > 2) && txtcmp.Text != null )
            {
                if (txtmp.Text==txtcmp.Text )
                {
                    cmd = new SqlCommand("select *from login_assistant where [utilisateur]='" + txtnu.Text + "'", connection);
                    rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        MessageBox.Show("Se Profil Est Déja Exiscte", "Gestion Location Voiture");
                        nouveau();
                        lb_msg.Visible = false;
                    }
                    else
                    {
                    rd.Close();
                    string req = "insert into login_assistant values (@utilisateur,@mot_passe)";
                     cmd = new SqlCommand(req, connection);
                     cmd.Parameters.AddWithValue("@utilisateur", txtnu.Text);
                     cmd.Parameters.AddWithValue("@mot_passe", txtmp.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bienvenue Mr(e).'" + txtnu.Text + "'", "Gestion Location Voiture");
                nouveau();
                remplir();

                    }
                }
                else
                {
                    lb_msg.Text = "Votre Mot De Passe Incorrect!!";
                    lb_msg.Visible = true;
                    txtcmp.Text = "";
                    txtmp.Text = "";
                    txtmp.Focus();
                    
                }
            }
            else
            {
                MessageBox.Show("Verifier Votre Donner", "Gestion Location Voiture");
            }
        }

        private void precedentGC_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
