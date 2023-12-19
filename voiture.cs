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
    public partial class voiture : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader rd;
        OpenFileDialog ofd = new OpenFileDialog();
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Matricule De Voiture Que Vous Voulez Rechercher", "Gestion Location Voiture");
            cmd = new SqlCommand("select *from voitures where [matricule]='" + ncr + "'", connection);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
               
                txtmt.Text = rd[1].ToString();
                txtmr.Text = rd[2].ToString();
                txtmd.Text = rd[3].ToString();
                txttv.Text = rd[4].ToString();
                txttc.Text = rd[5].ToString();
                txtp.Text =  rd[6].ToString();
                lb_ass.Text =rd[7].ToString();
                lb_cg.Text = rd[8].ToString();
                lb_lv.Text = rd[9].ToString();
                lb_v.Text =  rd[10].ToString();
                voiture_pb.Load(Application.StartupPath + "/img_voiture/" + lb_v.Text);
                assur.Load(Application.StartupPath + "/img_voiture/" + lb_ass.Text);
                carte_grise.Load(Application.StartupPath + "/img_voiture/" + lb_cg.Text);
                la_visite.Load(Application.StartupPath + "/img_voiture/" + lb_lv.Text);
               
            }
            else
            {
                MessageBox.Show("N°Voiture " + ncr + " Introuvable ", "Gestion Location Voiture");
            }
            rd.Close();


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

        private void voiture_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(cnx);
            connection.Open();
            remplir();
        }
        private void remplir()
        {
            //initializez l'adapteur de donnée et le datatable
            dataAdapter = new SqlDataAdapter("select matricule,marque,model,type_voiture,type_carburant,prix from voitures ", cnx);
            dt = new DataTable();
            //remplissez le datatable avec less donnes
            dataAdapter.Fill(dt);
            //liez le datatable au tableau
            tableaux.DataSource = dt;
        }

        private void precedentGC_Click(object sender, EventArgs e)
        {
            menu menu= new menu();
            menu.Show();
            this.Hide();
        }
    }
}
