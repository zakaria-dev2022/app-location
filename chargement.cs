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

namespace Gestion_Location_Voiture
{
    public partial class chargement : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader rd;

        public chargement()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void chargement_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(cnx);
            connection.Open();
            remplir();

        }
        private void remplir()
        {
            cmd = new SqlCommand("select *from parametre where [id]= 1 ", connection);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                lb_na.Text = rd[1].ToString();
                lb_logo.Text = rd[2].ToString();
                logo.Load(Application.StartupPath + "/img_logo/" + lb_logo.Text);
            }
            rd.Close();
        }

        int p = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           p++;
            progress.Value = p;
            porssentage.Text = p.ToString() + " %";
            if (progress.Value == 100)
            {
                progress.Value = 0;
                timer1.Stop();
                connection cnx = new connection();
                cnx.Show();
                this.Hide();
            }
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progress_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
