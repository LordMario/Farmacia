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

namespace Farmacia
{
    public partial class ModificarProveedor : Form
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-R0IBPQT;Database=FARMACIA;UID=FarmaciaDiogenes;PWD=123456");
        SqlCommand cmd;
        BS bs = new BS();
        public ModificarProveedor()
        {
            InitializeComponent();
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bs.Fill("select * from Proveedor");
            comboBox1.DisplayMember = "PNPROV";
            comboBox1.ValueMember = "Id_Prov";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros");
                e.Handled = true;
                return;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength==8)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {

                    try
                    {

                        cmd = new SqlCommand("ModificarProveedor", conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IDPROV", SqlDbType.Int).Value = textBox2.Text;
                        cmd.Parameters.AddWithValue("@TELPROV", SqlDbType.Char).Value = textBox1.Text;

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se actualizo el Telefono");
                        conn.Close();
                        textBox1.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No pudo modificar el telefono: " + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No puede ser Cero o Nulo");
                }
            }
            else
            {
                MessageBox.Show("El numero de telefono debe tener 8 digitos");
                textBox1.Text = null;
            }
        }
      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from Proveedor where PNPROV=@nom", conn);

            cmd.Parameters.AddWithValue("@nom", SqlDbType.VarChar).Value = comboBox1.Text;

            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                sdr.Read();
                textBox2.Text = sdr["Id_Prov"].ToString();
                textBox3.Text = sdr["TelProv"].ToString();
                sdr.Close();
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
