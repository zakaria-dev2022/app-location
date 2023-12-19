using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace Gestion_Location_Voiture
{
    public partial class client : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";

        private SqlDataAdapter dataAdapter;
        SqlConnection Connection;
        SqlCommand cmd;
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        private DataTable dt;
        public client()
        {
            InitializeComponent();

        }

        private void client_Load(object sender, EventArgs e)
        {
            //cnx.Open();
            Connection = new SqlConnection(cnx);
            Connection.Open();
            remplir();
        }

        private void nouveau()
        {
            txtne.Text = "";
            txtn.Text = "";
            txtp.Text = "";
            txtnc.Text = "";
            txtt.Text = "";
            txtnp.Text = "";
            txta.Text = "";
           // txtnpr.Text = "";
            recto.Image = null;
            verso.Image = null;
            txtn.Focus();
        }
        private void remplir()
        {
            //initializez l'adapteur de donnée et le datatable
            dataAdapter = new SqlDataAdapter(" select non_entreprise,nom,prenom,[cin/passport],permis,tel,adresse from client", cnx);
            dt = new DataTable();
            //remplissez le datatable avec less donnes
            dataAdapter.Fill(dt);
            //liez le datatable au tableau
            tableaux.DataSource = dt;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
          /* string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Client Que Vous Voulez Supprimer", "Gestion Location Voiture");
             cmd = new SqlCommand("select *from client where [client_id]='" + ncr + "'", Connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                if (MessageBox.Show("Effectuer La Suppression", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from client where [client_id]='" + ncr + "'", Connection);
                    cmd.ExecuteNonQuery();
                    remplir();
                    MessageBox.Show("Suppression Effectué", "Gestion Location Voiture");
                }
            }
                
            else
            {
                MessageBox.Show("N°Client " + ncr + " Introuvable ", "Gestion Location Voiture");
            }
            rd.Close();*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
            connection connection = new connection();
            connection.Show();
            this.Hide();
        }
        private void tableaux_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void rechercher_Click(object sender, EventArgs e)
        {
            string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°CIN Ou N°Passport De CLient Que Vous Voulez Rechercher", "Gestion Location Voiture");
            cmd = new SqlCommand("select *from client where [cin/passport]='" + ncr + "'", Connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                
                rd.Read();
                txtid.Text = rd[0].ToString();
                txtne.Text = rd[1].ToString();
                txtn.Text = rd[2].ToString();
                txtp.Text = rd[3].ToString();
                txtnc.Text = rd[4].ToString();
                //txtnpr.Text = rd[5].ToString();
                txtnp.Text = rd[5].ToString();
                txtt.Text = rd[6].ToString();
                txta.Text = rd[7].ToString();
                lb_recto.Text = rd[8].ToString();
                lb_verso.Text = rd[9].ToString();
                verso.Load(Application.StartupPath + "/img_client/" + lb_verso.Text);
                recto.Load(Application.StartupPath + "/img_client/" + lb_recto.Text);
                modifier.Enabled = true;
                enregistrer.Enabled = false;

            }
            else
            {
                MessageBox.Show("N°Client " + ncr + " Introuvable ", "Gestion Location Voiture");
            }
                rd.Close();
            
        }

        private void modifier_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Enregistrer La Modification ??", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtn.Text != "" && txtp.Text != "" &&  txtnc.Text != ""  && txtt.Text !="" && txtnp.Text != "" && txta.Text != "" && recto.Image != null && verso.Image != null)
                {
                    SqlCommand cmd = new SqlCommand(" update client set [non_entreprise] = '" + txtne.Text + "',[nom] = '" + txtn.Text + "',[prenom] = '" + txtp.Text + "',[cin/passport]='" + txtnc.Text + "',[permis]='" + txtnp.Text + "',[tel]='" + txtt.Text + "',[adresse]='" + txta.Text + "' where [client_id]='" + txtid.Text + "'", Connection);
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

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (txtn.Text != "" && txtp.Text != "" && txtnc.Text != "" && txtnp.Text != "" && txtt.Text != "" && txta.Text != "" && recto.Image != null && verso.Image != null)
            {


                string req = "insert into client values (@non_entreprise,@nom,@prenom,@cin,@permis,@tel,@adresse,@carte_recto,@carte_verso)";
                cmd = new SqlCommand(req, Connection);
                cmd.Parameters.AddWithValue("@non_entreprise", txtne.Text);
                cmd.Parameters.AddWithValue("@nom", txtn.Text);
                cmd.Parameters.AddWithValue("@prenom", txtp.Text);
                cmd.Parameters.AddWithValue("@cin", txtnc.Text);
              //  cmd.Parameters.AddWithValue("@passport", txtnpr.Text);
                cmd.Parameters.AddWithValue("@permis", txtnp.Text);
                cmd.Parameters.AddWithValue("@tel", txtt.Text);
                cmd.Parameters.AddWithValue("@adresse", txta.Text);
                cmd.Parameters.AddWithValue("@carte_recto", lb_recto.Text);
                cmd.Parameters.AddWithValue("@carte_verso", lb_verso.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Votre Donner Et Bien Ajouter", "Gestion Location Voiture");
                nouveau();
                remplir();

            }
            else
            {
                MessageBox.Show("Verifier Votre Donner", "Gestion Location Voiture");
            }

        }

        private void btncr_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                recto.Image = img;
                lb_recto.Text = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} CIN-" + txtnc.Text + " carte recto" + typeFile;
                chemin = lb_recto.Text;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);

            }
        }

        private void btncv_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                verso.Image = img;
                lb_verso.Text = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} CIN-" + txtnc.Text + " carte verso" + typeFile;
                chemin = lb_verso.Text;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                File.Copy(fileinfo.FullName, Application.StartupPath + "/img_client/" + chemin);

            }
        }
    }
}
