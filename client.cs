using System;
using System.Collections;
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
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";

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
             if (txtn.Text != "" && txtp.Text != "" &&( txtnc.Text != "" || txtnpr.Text !="") && txtt.Text != "" && txtnp.Text != "" && txta.Text != "")
             {
            cmd = new SqlCommand("insert into client values('" + txtne.Text + "', '" + txtn.Text + "', '" + txtp.Text + "', '" + txtnc.Text + "','"+txtnpr.Text+"' ,'" + txtnp.Text + "','" + txtt.Text + "','" + txta.Text + "')", Connection);
            cmd.ExecuteNonQuery();
            remplir();
            MessageBox.Show("Donner Enregistrer","Gestion Location Voiture");
                nouveau();



            }
             else
             {
                 MessageBox.Show("Verifier Les Donners!!!", "Gestion Location Voiture");
             }
            
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
            txtnpr.Text = "";
            txtn.Focus();
        }
        private void remplir()
        {
            //initializez l'adapteur de donnée et le datatable
            dataAdapter = new SqlDataAdapter("select * from client ", cnx);
            dt = new DataTable();
            //remplissez le datatable avec less donnes
            dataAdapter.Fill(dt);
            //liez le datatable au tableau
            tableaux.DataSource = dt;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
           string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Client Que Vous Voulez Supprimer", "Gestion Location Voiture");
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
            rd.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }

        private void modifier_Click(object sender, EventArgs e)
        {

                if (MessageBox.Show("Enregistrer La Modification ??", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                if (txtn.Text != "" && txtp.Text != "" && txtnc.Text != "" && txtt.Text != "" && txtnp.Text != "" && txta.Text != "")
                {
                    SqlCommand cmd = new SqlCommand(" update client set [non_entreprise] = '" + txtne.Text + "',[nom] = '" + txtn.Text + "',[prenom] = '" + txtp.Text + "',[cin]='" + txtnc.Text + "',[passport]='" + txtnpr.Text + "',[permis]='" + txtnp.Text + "',[tel]='" + txtt.Text + "',[adresse]='" + txta.Text + "' where [client_id]='" + txtid.Text + "'", Connection);
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

        private void rechercher_Click(object sender, EventArgs e)
        {
            string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Client Que Vous Voulez Rechercher", "Gestion Location Voiture");
            cmd = new SqlCommand("select *from client where [client_id]='" + ncr + "'", Connection);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtid.Text = rd[0].ToString();
                txtne.Text = rd[1].ToString();
                txtn.Text = rd[2].ToString();
                txtp.Text = rd[3].ToString();
                txtnc.Text = rd[4].ToString();
                txtnpr.Text = rd[5].ToString();
                txtnp.Text = rd[6].ToString();
                txtt.Text = rd[7].ToString();
                txta.Text = rd[8].ToString();
                modifier.Enabled = true;
                enregistrer.Enabled = false;

            }
            else
            {
                MessageBox.Show("N°Client " + ncr + " Introuvable ", "Gestion Location Voiture");
            }
            rd.Close();

        }

    }
}
