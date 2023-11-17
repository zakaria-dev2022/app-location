using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace Gestion_Location_Voiture
{
    public partial class client : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Location_voiture;Integrated Security=True";

        private SqlDataAdapter dataAdapter;
        SqlConnection Connection;
        SqlCommand cmd;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
             if (txtnm.Text != "" && txtnp.Text != "" && txtt.Text != "" && txtnc.Text != "" && txtdr.Text != "" && txtdd.Text != "" && txtp.Text != "")
             {
            cmd = new SqlCommand("insert into donner_clientTB values('" + txtnm.Text + "', '" + txtnp.Text + "', '" + txtnc.Text + "', '" + txtt.Text + "', '" + txtdd.Text + "','" + txtdr.Text + "','" + txtp.Text + "')", Connection);
            cmd.ExecuteNonQuery();
            remplir();
            MessageBox.Show("Donner Enregistrer","Gestion Location Voiture");

             }
             else
             {
                 MessageBox.Show("Verifier Les Donners!!!", "Gestion Location Voiture");
             }
            
        }
        private void remplir()
        {
            //initializez l'adapteur de donnée et le datatable
            dataAdapter = new SqlDataAdapter("select * from donner_clientTB ", cnx);
            dt = new DataTable();
            //remplissez le datatable avec less donnes
            dataAdapter.Fill(dt);
            //liez le datatable au tableau
            tableaux.DataSource = dt;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
           string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Client Que Vous Voulez Supprimer", "Gestion Location Voiture");
             cmd = new SqlCommand("select *from donner_clientTB where [id]='" + ncr + "'", Connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Close();
                if (MessageBox.Show("Effectuer La Suppression", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from donner_clientTB where [id]='" + ncr + "'", Connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression Effectué", "Gestion Location Voiture");
                    remplir();
                }
            }
                
            else
            {
                MessageBox.Show("N°Client " + ncr + " Introuvable ", "Gestion Location Voiture");
            }
            rd.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }
    }
}
