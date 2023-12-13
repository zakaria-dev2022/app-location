using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Location_Voiture
{
    public partial class gestion_voiture : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader rd;
        OpenFileDialog ofd = new OpenFileDialog();
        string chemin = "";
        
        public gestion_voiture()
        {
            InitializeComponent();
        }

        private void gestion_voiture_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(cnx);
            connection.Open();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string imgas;
            /*OpenFileDialog ofdas = new OpenFileDialog();
            ofdas.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            ofdas.ShowDialog();
            imgas = ofdas.FileName.ToString();
            assur.ImageLocation = imgas;*/

            //string chemin = "";
            //OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                assur.Image = img;
                chemin = txtmt.Text + " assurance"+ typeFile;
                lb_ass.Text = chemin;
                File.Copy(fileinfo.FullName, Application.StartupPath + "/img_voiture/" + chemin);
            }

        }

            private void button6_Click(object sender, EventArgs e)
        {
            //string imgcg;
            /*OpenFileDialog ofdcg = new OpenFileDialog();
            ofdcg.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            ofdcg.ShowDialog();
            imgcg = ofdcg.FileName.ToString();
            carte_grise.ImageLocation = imgcg;*/

            //string chemin = "";
            //OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                carte_grise.Image = img;
                chemin = txtmt.Text + " carte grise"+typeFile;
                 lb_cg.Text= chemin;
                File.Copy(fileinfo.FullName, Application.StartupPath + "/img_voiture/" + chemin);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string imgVt;
            /*OpenFileDialog ofdvt = new OpenFileDialog();
            ofdvt.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            ofdvt.ShowDialog();
            imgvt = ofdvt.FileName.ToString();
            voiture.ImageLocation = imgvt;*/

           // string chemin = "";
            //OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                voiture.Image = img;
                chemin = txtmt.Text + " photo voiture" +typeFile;
                lb_v.Text = chemin;
                File.Copy(fileinfo.FullName, Application.StartupPath + "/img_voiture/" + chemin);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string imglv;
           /* OpenFileDialog ofdlv = new OpenFileDialog();
            ofdlv.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            ofdlv.ShowDialog();
            imglv = ofdlv.FileName.ToString();
            la_visite.ImageLocation = imglv;*/

           // string chemin = "";
            //OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                la_visite.Image = img;
                chemin = txtmt.Text + " la visite"+typeFile;
                lb_lv.Text = chemin;
                File.Copy(fileinfo.FullName, Application.StartupPath + "/img_voiture/" + chemin);
            }
            
                

        }

        private void modifier_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Enregistrer La Modification ??", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtmt.Text != "" && txtmr.Text != "" && txtmd.Text != "" && txttv.Text != "" && txttc.Text != "" && txtp.Text != "" && assur.Image != null && carte_grise.Image != null && la_visite.Image != null && voiture.Image != null)
                {   
                    SqlCommand cmd = new SqlCommand("update voitures set [matricule] = '" + txtmt.Text + "',[marque] = '" + txtmr.Text + "',[model] = '" + txtmd.Text + "',[type_voiture]='" + txttv.Text + "',[type_carburant]='" + txttc.Text + "',[prix]='" + txtp.Text + "',[assurance]='" + lb_ass.Text + "',[carte_grise]='" + lb_cg.Text + "', [visite]='"+ lb_lv.Text + "',[ph_voiture]='"+ lb_v.Text + "' where [voiture_id]='" + txtid.Text + "'", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification effectuer", "Gestion Location Voiture");
                    //remplir();
                    nouveau();
                    modifier.Enabled = false;
                    supprimer.Enabled = false;
                    enregistrer.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Verifier Les Donners!!!", "Gestion Location Voiture");
                }


            }
        }
        private void nouveau()
        {
            txtmt.Text = "";
            txtmd.Text = "";
            txtmr.Text = "";
            txttv.Text = "";
            txttc.Text = "";
            txtp.Text = "";
            assur.Image= null;
            carte_grise.Image = null;
            la_visite.Image = null;
            voiture.Image = null;
            txtmt.Focus();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            //string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Matricule De Voiture Que Vous Voulez Supprimer", "Gestion Location Voiture");
            if(MessageBox.Show("Voulez Vous Supprimer La Voiture N° '" + txtmt.Text + "'","Gestion location De Voiture",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
            cmd = new SqlCommand("Delete from voitures where [matricule]='" + txtmt.Text + "'", connection);
            cmd.ExecuteNonQuery();

                string Url_ass = Application.StartupPath + "/img_voiture/" + lb_ass.Text;
                File.Delete(Url_ass);
                File.Delete(Application.StartupPath + "/img_voiture/" + lb_cg.Text);
                File.Delete(Application.StartupPath + "/img_voiture/" + lb_lv.Text);
                File.Delete(Application.StartupPath + "/img_voiture/" + lb_v.Text);
            MessageBox.Show("Suppretion Effectuer"); 
            }
            /*File.Delete(Application.StartupPath + "/img_voiture/" + lb_cg.Text);
            File.Delete(Application.StartupPath + "/img_voiture/" + lb_lv.Text);
            File.Delete(Application.StartupPath + "/img_voiture/" + lb_v.Text);*/
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            string req = "insert into voitures values (@matricule,@marque,@model,@type_voiture,@type_carburant,@prix,@imgas,@imgcg,@imglv,@imgvt)";
            cmd = new SqlCommand(req, connection);
            cmd.Parameters.AddWithValue("@matricule", txtmt.Text);
            cmd.Parameters.AddWithValue("@marque", txtmr.Text);
            cmd.Parameters.AddWithValue("@model", txtmd.Text);
            cmd.Parameters.AddWithValue("@type_voiture", txttv.Text);
            cmd.Parameters.AddWithValue("@type_carburant", txttc.Text);
            cmd.Parameters.AddWithValue("@prix", txtp.Text);
            cmd.Parameters.AddWithValue("@imgas", lb_ass.Text);
            cmd.Parameters.AddWithValue("@imgcg", lb_cg.Text);
            cmd.Parameters.AddWithValue("@imglv", lb_lv.Text);
            cmd.Parameters.AddWithValue("@imgvt", lb_v.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("bien ajouter");
            nouveau();

        }
        private void textBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Matricule De Voiture Que Vous Voulez Rechercher", "Gestion Location Voiture");
            cmd = new SqlCommand("select *from voitures where [matricule]='" + ncr + "'", connection);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtid.Text = rd[0].ToString();
                txtmt.Text = rd[1].ToString();
                txtmr.Text = rd[2].ToString();
                txtmd.Text = rd[3].ToString();
                txttv.Text = rd[4].ToString();
                txttc.Text = rd[5].ToString();
                txtp.Text = rd[6].ToString();
                lb_ass.Text = rd[7].ToString();
                lb_cg.Text = rd[8].ToString();  
                lb_lv.Text = rd[9].ToString();
                lb_v.Text = rd[10].ToString();
                voiture.Load(Application.StartupPath + "/img_voiture/" + lb_v.Text);
                assur.Load(Application.StartupPath + "/img_voiture/" + lb_ass.Text);
                carte_grise.Load(Application.StartupPath + "/img_voiture/" + lb_cg.Text);
                la_visite.Load(Application.StartupPath + "/img_voiture/" + lb_lv.Text);
                modifier.Enabled = true;
                supprimer.Enabled = true;
                enregistrer.Enabled = false;
            }
            else
            {
                MessageBox.Show("N°Voiture " + ncr + " Introuvable ", "Gestion Location Voiture");
            }
            rd.Close();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}



