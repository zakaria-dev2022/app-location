using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Location_Voiture
{
    public partial class gestion_voiture : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";
        string imgcg;
        string imgas;
        string imgvt;
        string imglv;
        string img4;
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader rd;
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
            OpenFileDialog ofdas = new OpenFileDialog();
            ofdas.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            ofdas.ShowDialog();
            imgas = ofdas.FileName.ToString();
            assur.ImageLocation = imgas;
        }

            private void button6_Click(object sender, EventArgs e)
        {
            //string imgcg;
            OpenFileDialog ofdcg = new OpenFileDialog();
            ofdcg.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            ofdcg.ShowDialog();
            imgcg = ofdcg.FileName.ToString();
            carte_grise.ImageLocation = imgcg;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string imgVt;
            OpenFileDialog ofdvt = new OpenFileDialog();
            ofdvt.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            ofdvt.ShowDialog();
            imgvt = ofdvt.FileName.ToString();
            voiture.ImageLocation = imgvt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string imglv;
            OpenFileDialog ofdlv = new OpenFileDialog();
            ofdlv.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            ofdlv.ShowDialog();
            imglv = ofdlv.FileName.ToString();
            la_visite.ImageLocation = imglv;
        }

        private void modifier_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Enregistrer La Modification ??", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtmt.Text != "" && txtmr.Text != "" && txtmd.Text != "" && txttv.Text != "" && txttc.Text != "" && txtp.Text != "" && assur.Image != null && carte_grise.Image != null && la_visite.Image != null && voiture.Image != null)
                {
                    SqlCommand cmd = new SqlCommand("update voiture set [matricule] = '" + txtmt.Text + "',[marque] = '" + txtmr.Text + "',[model] = '" + txtmd.Text + "',[type_voiture]='" + txttv.Text + "',[type_carburant]='" + txttc.Text + "',[prix]='" + txtp.Text + "',[assurance]='" +((byte[])(assur.Image)) + "',[carte_grise]='" + carte_grise.Image + "', [visite]='"+la_visite.Image+"',[ph_voiture]='"+voiture.Image+"' where [voiture_id]='" + txtid.Text + "'", connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification effectuer", "Gestion Location Voiture");
                    //remplir();
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

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            string req = "insert into voiture values (@matricule,@marque,@model,@type_voiture,@type_carburant,@prix,@imgas,@imgcg,@imglv,@imgvt)";
            //byte[] img = null;
            FileStream fscg = new FileStream(imgcg, FileMode.Open, FileAccess.Read);
            FileStream fsas = new FileStream(imgas, FileMode.Open, FileAccess.Read);
            FileStream fslv = new FileStream(imglv, FileMode.Open, FileAccess.Read);
            FileStream fsvt = new FileStream(imgvt, FileMode.Open, FileAccess.Read);
            BinaryReader brcg = new BinaryReader(fscg);
            BinaryReader bras = new BinaryReader(fsas);
            BinaryReader brlv = new BinaryReader(fslv);
            BinaryReader brvt = new BinaryReader(fsvt);
            byte[] imagecg = brcg.ReadBytes((int)fscg.Length);
            byte[] imageas = bras.ReadBytes((int)fsas.Length);
            byte[] imagelv = brlv.ReadBytes((int)fslv.Length);
            byte[] imagevt = brvt.ReadBytes((int)fsvt.Length);
            cmd = new SqlCommand(req, connection);
            cmd.Parameters.AddWithValue("@matricule", txtmt.Text);
            cmd.Parameters.AddWithValue("@marque", txtmr.Text);
            cmd.Parameters.AddWithValue("@model", txtmd.Text);
            cmd.Parameters.AddWithValue("@type_voiture", txttv.Text);
            cmd.Parameters.AddWithValue("@type_carburant", txttc.Text);
            cmd.Parameters.AddWithValue("@prix", txtp.Text);
            cmd.Parameters.AddWithValue("@imgas", imageas);
            cmd.Parameters.AddWithValue("@imgcg", imagecg);
            cmd.Parameters.AddWithValue("@imglv", imagelv);
            cmd.Parameters.AddWithValue("@imgvt", imagevt);

            cmd.ExecuteNonQuery();
            //connection.Close();
            MessageBox.Show("bien ajouter");

        }
        private void textBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            string ncr = Microsoft.VisualBasic.Interaction.InputBox("N°Voiture Que Vous Voulez Rechercher", "Gestion Location Voiture");
            cmd = new SqlCommand("select *from voiture where [voiture_id]='" + ncr + "'", connection);
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
                byte[] imgas = (byte[])(rd[7]);
                byte[] imgcg = (byte[])(rd[8]);
                byte[] imglv = (byte[])(rd[9]);
                byte[] imgvt = (byte[])(rd[10]);
                if (imgas != null && imgcg != null && imglv != null && imgvt != null)
                {
                    MemoryStream ms_as = new MemoryStream(imgas);
                    MemoryStream ms_cg = new MemoryStream(imgcg);
                    MemoryStream ms_lv = new MemoryStream(imglv);
                    MemoryStream ms_vt = new MemoryStream(imgvt);
                     assur.Image=Image.FromStream(ms_as);
                    carte_grise.Image = Image.FromStream(ms_cg);
                    la_visite.Image = Image.FromStream(ms_lv);
                    voiture.Image = Image.FromStream(ms_vt);
                    /// assur.Image = null;
                }
                else
                {

                    //MemoryStream memoryStream = new MemoryStream(img);
                    // assur.Image=Image.FromStream(memoryStream);
                }
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



