using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    class BS
    {
        public string connectionstring = "Server=DESKTOP-R0IBPQT;Database=FARMACIA;UID=FarmaciaDiogenes;PWD=123456";

        public BS() { }

        public BindingSource Fill(string cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionstring);
                SqlDataAdapter adapter = new SqlDataAdapter();
                BindingSource bs = new BindingSource();
                DataTable table = new DataTable();
                SqlCommand prov;

                prov = new SqlCommand(cmd, conn);

                adapter.SelectCommand = prov;
                adapter.Fill(table);

                bs.DataSource = table;

                return bs;
            }
            catch
            {
                return null;
            }
        }

        public BindingSource Fill(string comm, string param, string valor, SqlDbType typedata)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter();
            BindingSource bs = new BindingSource();
            DataTable table = new DataTable();
            SqlCommand cmd;

            cmd = new SqlCommand(comm, conn);
            cmd.Parameters.AddWithValue(param, typedata).Value = valor;

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            bs.DataSource = table;

            return bs;
        }
    }
}
