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
    public partial class dashboard : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader rd;
        OpenFileDialog ofd = new OpenFileDialog();
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
        public dashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label5_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-Vous Se Déconnecter??", "Gestion Location De Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection cnx = new connection();
                cnx.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            gestion_voiture gs_voiture = new gestion_voiture();
            gs_voiture.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            client client = new client();
            client.Show();
            this.Hide();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            location location = new location();
            location.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setting para = new setting();
            para.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(cnx);
            connection.Open();
            remplir();
        }
        private void remplir()
        {
            string lb_logo = "";
            cmd = new SqlCommand("select *from parametre where [id]= 1", connection);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                lb_na.Text = rd[1].ToString();
                lb_logo = rd[2].ToString();
                logo.Load(Application.StartupPath + "/img_logo/" + lb_logo);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            gestion_profils gestion_Profils = new gestion_profils();
            gestion_Profils.Show();
            this.Hide();
        }
    }
}
