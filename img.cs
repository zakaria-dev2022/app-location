using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Gestion_Location_Voiture
{
    public partial class img : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=gestion_donner_personne;Integrated Security=True";
        SqlConnection con;
        public img()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string chemin = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                var fileinfo= new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                pictureBox1.Image = img;
                chemin = fileinfo.Name;
                label1 .Text = chemin;
                File.Copy(fileinfo.FullName,Application.StartupPath+"/img_voiture/"+ chemin );
            }
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
           
            string req = "insert into image values ('" + txtn.Text + "','" + label1.Text + "')";
            SqlCommand cmd =new SqlCommand(req,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien ajouter");
            
        }

        private void img_Load(object sender, EventArgs e)
        {
            con =new SqlConnection(cnx);
            con.Open();
        }
    }
}
