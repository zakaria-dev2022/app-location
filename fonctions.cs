using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Location_Voiture
{
    internal class fonctions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private string cnx;
        private SqlDataAdapter adapter;
        public fonctions() {
            cnx = @"Data Source=DESKTOP-G1088CP;Initial Catalog=Location_voiture;Integrated Security=True";
            con= new SqlConnection(cnx);
            cmd = new SqlCommand();
            cmd.Connection = con;

        }
    }
}
