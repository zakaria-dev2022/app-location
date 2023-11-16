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
            /* if (txtnm.Text != "" && txtnp.Text != "" && txtt.Text != "" && txtnc.Text != "" && txtdr.Text != "" && txtdd.Text != "" && txtp.Text != "")
             {
                 SqlCommand cmd = new SqlCommand("insert into donner_clientTB values('" + txtnm.Text + "','" + txtnp.Text + "','" + txtnc.Text + "','" + txtt.Text + "','" + txtdd.Text + "',,'" + txtdr.Text + "',,'" + txtp.Text + "')", cnx);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("enregistrement effectué", "Gestion facturation clients");
                 remplir();
                 //Nouveau_Click(sender, e);

             }
             else
             {
                 MessageBox.Show("verifier la saisie");
             }*/
            /*string insertQuery = "INSERT INTO client ([N°matricule],[nom_prenom],[N°cin],[N°tel],date_reservation,date_retour,[N°permis]) " +
               "VALUES ([N°matricule], [nom_prenom], [N°cin], [N°tel], date_reservation,date_retour,[N°permis])";*/
            cmd = new SqlCommand("insert into donner_clientTB values('" + txtnm.Text + "', '" + txtnp.Text + "', '" + txtnc.Text + "', '" + txtt.Text + "', '" + txtdd.Text + "','" + txtdr.Text + "','" + txtp.Text + "')", Connection);
            /*cmd.Parameters.AddWithValue("[N°matricule]", txtnm.Text);
            cmd.Parameters.AddWithValue("[nom_prenom]", txtnp.Text);
            cmd.Parameters.AddWithValue("[N°cin]", txtnc.Text);
            cmd.Parameters.AddWithValue("[N°tel]", txtt.Text);
            cmd.Parameters.AddWithValue("date_reservation", txtdd.Text);
            cmd.Parameters.AddWithValue("date_retour", txtdr.Text);
            cmd.Parameters.AddWithValue("[N°permis]", txtp.Text);*/
            cmd.ExecuteNonQuery();
            remplir();
            MessageBox.Show("ok ");
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
    }
}
