using System;
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
using System.Windows.Forms;

namespace Gestion_Location_Voiture
{
    public partial class setting : Form
    {
        string cnx = "Data Source=DESKTOP-G1088CP;Initial Catalog=Gestion_Location_Voiture;Integrated Security=True";
        SqlCommand cmd;
        SqlConnection connection;
        SqlDataReader rd;
        OpenFileDialog ofd = new OpenFileDialog();
        private SqlDataAdapter dataAdapter;
        private DataTable dt;
        string chemin = "";
        public setting()
        {
            InitializeComponent();
        }

        private void precedentGC_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(cnx);
            connection.Open();
            remplir();
            remplir2();
        }
        private void remplir()
        {
            cmd = new SqlCommand("select *from parametre where [id]= 1 ", connection);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtna.Text = rd[1].ToString();
                lb_logo.Text = rd[2].ToString();
                logo.Load(Application.StartupPath + "/img_logo/" + lb_logo.Text);
            }
            rd.Close();
        }

        private void remplir2()
        {
            cmd = new SqlCommand("select *from login where [id]= 1 ", connection);
            rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txtnu.Text = rd[1].ToString();
                txtmp.Text = rd[2].ToString();
            }
            rd.Close();
        }

        private void btn_changer_Click(object sender, EventArgs e)
        {
            txtmp.Visible = false;
            txtnu.Visible = false;
            oeil_mp.Visible = false;
            lb_nu.Visible = false;
            lb_mp.Visible = false;
            btn_changer.Visible = false;
            txtnu_modifier.Visible = true;
            txtmp_modifier.Visible = true;
            txtcmp_modifier.Visible = true;
            oeil_cmp_modifier.Visible = true;
            oeil_mp_modifier.Visible = true;
            lb_nu_modifier.Visible = true;
            lb_mp_modifier.Visible = true;
            lb_cmp_modifier.Visible=true;
           btn_modifier_info.Visible = true;
            btn_ann_info.Visible = true;
            txtnu_modifier.Focus();

        }

        private void oeil_mp_modifier_Click(object sender, EventArgs e)
        {
             if(txtmp_modifier.PasswordChar == '*')
             {
                txtmp_modifier.PasswordChar = '\0';
            }
            else
            {
                txtmp_modifier.PasswordChar = '*';
            }
        }

        private void oeil_mp_Click(object sender, EventArgs e)
        {
            if (txtmp.PasswordChar == '*')
            {
                txtmp.PasswordChar = '\0';
            }
            else
            {
                txtmp.PasswordChar = '*';
            }
        }

        private void oeil_cmp_modifier_Click(object sender, EventArgs e)
        {
            if (txtcmp_modifier.PasswordChar == '*')
            {
                txtcmp_modifier.PasswordChar = '\0';
            }
            else
            {
                txtcmp_modifier.PasswordChar = '*';
            }
        }

        private void btn_logo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png | all files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileinfo = new FileInfo(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                string typeFile = Path.GetExtension(ofd.FileName);
                logo.Image = img;
                lb_logo.Text = $"{DateTime.Now:yyyy_MM_dd HH-mm-ss} " + " logo" + typeFile;
                chemin = lb_logo.Text;
                //chemin =txtmt.Text + " Photo voiture" : typeFile;
                File.Copy(fileinfo.FullName, Application.StartupPath + "/img_logo/" + chemin);
            }
        }

        private void txtna_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Enregistrer La Modification ??", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtna.Text != null && logo.Image != null)
                {
                    SqlCommand cmd = new SqlCommand("update parametre set [nom_app] = '" + txtna.Text + "',[logo] = '" + lb_logo.Text + "'where [id]= 1", connection);
                    //string req = "insert into parametre values (@nom_app,@logo)";
                    //cmd = new SqlCommand(req, connection);
                    //cmd.Parameters.AddWithValue("@nom_app", txtna.Text);
                    //cmd.Parameters.AddWithValue("@logo",lb_logo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification effectuer", "Gestion Location Voiture");
                    remplir();
                    remplir2();
                }
                else
                {
                    MessageBox.Show("Verifier Les Donners!!!", "Gestion Location Voiture");
                }
            }
        }

        private void btn_modifier_info_Click(object sender, EventArgs e)
        {
            if(txtnu_modifier.Text!= null && txtmp_modifier.Text != null && txtcmp_modifier.Text != null) 
            {
                if (txtmp_modifier.Text == txtcmp_modifier.Text)
                {
                    if (MessageBox.Show("Voulez-Vous Modifier Vos Donner?", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    {
                        SqlCommand cmd = new SqlCommand("update login set [utilisateur] = '" + txtnu_modifier.Text + "',[mot_passe] = '" + txtmp_modifier.Text + "'where [id]= 1", connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Modification effectuer", "Gestion Location Voiture");
                        remplir();
                        remplir2();
                        enable_info();
                    }
                }
                else
                {
                    lb_msg.Text = "Votre Mot De Passe Incorrect!!";
                    lb_msg.Visible = true;
                    txtmp_modifier.Text = "";
                    txtcmp_modifier.Text = "";
                    txtmp_modifier.Focus();
                }

            }
            else
            {
                MessageBox.Show("Tu Dois Remplir Votre Donner!!", "Gestion Location Voiture");
                txtnu_modifier.Text = "";
                txtmp_modifier.Text = "";
                txtcmp_modifier.Text = "";
                txtnu_modifier.Focus();
            }
        }
        private void enable_info()
        {
            txtmp.Visible = true;
            txtnu.Visible = true;
            oeil_mp.Visible = true;
            lb_nu.Visible = true;
            lb_mp.Visible = true;
            btn_changer.Visible = true;
            txtnu_modifier.Visible = false;
            txtmp_modifier.Visible = false;
            txtcmp_modifier.Visible = false;
            oeil_cmp_modifier.Visible = false;
            oeil_mp_modifier.Visible = false;
            lb_nu_modifier.Visible = false;
            lb_mp_modifier.Visible = false;
            lb_cmp_modifier.Visible = false;
            btn_modifier_info.Visible = false;
            btn_ann_info.Visible = false;
            lb_msg.Visible = false;
        }

        private void btn_ann_info_Click(object sender, EventArgs e)
        {
            enable_info();
            btn_save.Focus();
        }

        private void btn_ann_para_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-Vous Sortir??", "Gestion Location Voiture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dashboard dashboard = new dashboard();
                 dashboard.Show();
                 this.Hide();
            }

        }

        private void lb_msg_Click(object sender, EventArgs e)
        {

        }
    }
}
