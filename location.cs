using Microsoft.VisualBasic.Logging;
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
using static System.Net.Mime.MediaTypeNames;

namespace Gestion_Location_Voiture
{
    public partial class location : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader rd;
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
        public location()
        {
            InitializeComponent();
        }
        private void donner_client()
        {
            cmd = new SqlCommand("select client_id from client where [cin/passport] ='" + txtncc.Text + "'", connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtncc.Text = rd[0].ToString();
            }
            else
            {
                MessageBox.Show("Ce client introuvable!!!", "Gestion Location Voiture");
            }
            rd.Close();
        }

        private void donner_voiture()
        {
            cmd = new SqlCommand("select * from voitures where [matricule] = '" + txtnmv.Text + "'", connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtnmv.Text = rd[0].ToString();
            }
            else
            {
                MessageBox.Show("Cette Voiture introuvable!!!", "Gestion Location Voiture");
            }
            rd.Close();
        }
        private void enregistrer_Click(object sender, EventArgs e)
        {
            donner_client();
            donner_voiture();
            string req = "insert into location values (@cin_client,@matricule_voiture,@jour,@montant,@date_demande,@date_retour)";
            cmd = new SqlCommand(req, connection);
            cmd.Parameters.AddWithValue("@cin_client", txtncc.Text);
            cmd.Parameters.AddWithValue("@matricule_voiture", txtnmv.Text);
            cmd.Parameters.AddWithValue("@jour", txtnj.Text);
            cmd.Parameters.AddWithValue("@montant", txtm.Text);
            cmd.Parameters.AddWithValue("@date_demande", txtdd.Text);
            cmd.Parameters.AddWithValue("@date_retour", txtdr.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Votre Donner Et Bien Ajouter", "Gestion Location Voiture");
            nouveau();
            remplir();
        }
        private void nouveau()
        {
            txtnc.Text = "";
            txtncc.Text = "";
            txtnmv.Text = "";
            txtnj.Text = "";
            txtm.Text = "";
            txtp.Text = "";
            txtdd.Text = DateTime.Now.ToString();
            txtdr.Text = DateTime.Now.ToString();
        }

        private void location_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(cnx);
            connection.Open();
            remplir();
        }
        private void remplir()
        {
            //initializez l'adapteur de donnée et le datatable
            dataAdapter = new SqlDataAdapter("select contract,nombre_jour,montant,date_demande,date_retour ,non_entreprise,nom,prenom,[cin/passport],permis,tel,adresse,matricule,marque,model,type_voiture,type_carburant,prix from location JOIN client on location.client_cin = client.client_id JOIN voitures on location.voiture_matricule = voitures.voiture_id", cnx);
            dt = new DataTable();
            //remplissez le datatable avec less donnes
            dataAdapter.Fill(dt);
            //liez le datatable au tableau
            tableaux.DataSource = dt;
        }

        private void precedentGC_Click(object sender, EventArgs e)
        {
            connection connection = new connection();
            connection.Show();
            this.Hide();
        }
        private void rec_prix()
        {
            cmd = new SqlCommand("select * from voitures where [matricule] = '" + txtnmv.Text + "'", connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtp.Text = rd[6].ToString();
            }
            else
            {
                MessageBox.Show("Cette Voiture introuvable!!!", "Gestion Location Voiture");
            }
            rd.Close();
        }

        private void txtnmv_Leave(object sender, EventArgs e)
        {
            rec_prix();

        }

        private void txtnj_Leave(object sender, EventArgs e)
        {
           
        }
        string num_client;
        string num_voiture;

        private void rechercher_Click(object sender, EventArgs e)
        {
            
            string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Contract CLient Que Vous Voulez Rechercher", "Gestion Location Voiture");
            cmd = new SqlCommand("select *from location where [contract]='" + ncr + "'", connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {

                rd.Read();
                txtnc.Text = rd[0].ToString();
                num_client = rd[1].ToString();
                num_voiture = rd[2].ToString();
                txtnj.Text = rd[3].ToString();
                txtm.Text = rd[4].ToString();
                txtdd.Text= rd[5].ToString();
                txtdr.Text = rd[6].ToString();
                modifier.Enabled = true;
                enregistrer.Enabled = false;
                rd.Close();
                cmd = new SqlCommand("select *from client where [client_id]='" + num_client + "'", connection);
                SqlDataReader rd2 = cmd.ExecuteReader();
                    rd2.Read();
                    txtncc.Text= rd2[4].ToString();
                rd2.Close();
                cmd = new SqlCommand("select *from voitures where [voiture_id]='" + num_voiture + "'", connection);
                SqlDataReader rd3 = cmd.ExecuteReader();
                    rd3.Read();
                    txtnmv.Text = rd3[1].ToString();
                    rd3.Close();

            }
            else
            {
                MessageBox.Show("N°Client " + ncr + " Introuvable ", "Gestion Location Voiture");
            }
            rec_prix();

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Enregistrer La Modification ??", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtncc.Text != "" && txtnmv.Text != "" && txtdd.Text != "" && txtdr.Text != "" && txtnj.Text != "")
                {
                    donner_client();
                    donner_voiture();
                    SqlCommand cmd = new SqlCommand(" update location set [client_cin] =@num_client,voiture_matricule=@num_voiture , nombre_jour=@jour , montant= @montant ,date_demande = @date_demande , date_retour = @date_retour where contract = '"+ txtnc.Text+ "'" , connection);
                    cmd.Parameters.AddWithValue("@num_client", txtncc.Text);
                    cmd.Parameters.AddWithValue("@num_voiture", txtnmv.Text);
                    cmd.Parameters.AddWithValue("@jour", txtnj.Text);
                    cmd.Parameters.AddWithValue("@montant", txtm.Text);
                    cmd.Parameters.AddWithValue("@date_demande", txtdd.Text);
                    cmd.Parameters.AddWithValue("@date_retour", txtdr.Text); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification effectuer", "Gestion Location Voiture");
                    remplir();
                    nouveau();
                    modifier.Enabled = false;
                    enregistrer.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Verifier Les Donners!!!", "Gestion Location Voiture");
                }


            }
        }
        private void montant()
        {
            decimal.TryParse(txtnj.Text, out decimal jour);
            decimal.TryParse(txtp.Text, out decimal prix);
            decimal montant = jour * prix;
            txtm.Text = montant.ToString();
        }

        private void txtnj_TextChanged(object sender, EventArgs e)
        {
            montant();
        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {
            montant();
        }
    }
}
