using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Farmacia
{
    public partial class ActualizarPrecio : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        BS bs = new BS();

        public ActualizarPrecio()
        {
            InitializeComponent();
            conn = new SqlConnection(bs.connectionstring);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarPrecio_Load(object sender, EventArgs e)
        {
            cboxProducto.DataSource = bs.Fill("select * from Productos");
            cboxProducto.DisplayMember = "Nom_Prod";
            cboxProducto.ValueMember = "Cod_Prod";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tboxprecio.Text) && Convert.ToInt32(tboxprecio.Text)!=0)
            {               

                try
                {
                    
                    cmd = new SqlCommand("ModificarProducto", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@CP", SqlDbType.Char).Value = tbxCodigo.Text;
                    cmd.Parameters.AddWithValue("@PRECIO", SqlDbType.Float).Value = tboxprecio.Text;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Se actualizo el precio");
                    conn.Close();
                    tboxprecio.Text = null;
                    this.Dispose();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo modificar el precio: ");
                }
            }
            else
            {
                MessageBox.Show("No puede ser Cero o Nulo");
            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cboxprod_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cmd = new SqlCommand("Select * from Productos where Nom_Prod=@nom", conn);

            cmd.Parameters.AddWithValue("@nom", SqlDbType.VarChar).Value = cboxProducto.Text;

            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                sdr.Read();
                tbxCodigo.Text = sdr["Cod_Prod"].ToString();
                txbPrecioActual.Text = sdr["Prec_Prod"].ToString();
                sdr.Close();
            }
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
