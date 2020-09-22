using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    class Conexion
    {
        public SqlConnection conectar;
        public string mensaje;

        public Conexion() { }

        public Conexion(string server, string login, string passwd)
        {
            try
            {
                conectar = new SqlConnection("Server=" + server + ";Database=FARMACIA;UID=" + login + ";PWD=" + passwd);
                conectar.Open();
            }
            catch
            {
                //MessageBox.Show("Error de Conexión", "FARMACIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                mensaje = "Error de conexion";
            }

        }
    }
}
