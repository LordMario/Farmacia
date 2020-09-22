using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Nuevo_Proveedor : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        BS bs = new BS();


        public Nuevo_Proveedor()
        {
            InitializeComponent();
            conn = new SqlConnection(bs.connectionstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrEmpty(textBox5.Text))
            {
                comm = new SqlCommand("NuevoProveedor", conn);
                comm.CommandType = CommandType.StoredProcedure;

                comm.Parameters.AddWithValue("@PNPROV", textBox1.Text);
                comm.Parameters.AddWithValue("@SNPROV", textBox2.Text);
                comm.Parameters.AddWithValue("@PAPROV", textBox3.Text);
                comm.Parameters.AddWithValue("@SAPROV", textBox4.Text);
                comm.Parameters.AddWithValue("@TELPROV", textBox5.Text);
                comm.Parameters.AddWithValue("@MAILPROV", textBox6.Text);
                comm.Parameters.AddWithValue("@DIRPROV", textBox7.Text);

                try
                {
                    conn.Open();
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Registro insertado exitosamente");
                    conn.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";

                }
                catch
                {
                    MessageBox.Show("Error insertando proveedor");
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos obligatorios");
            }         
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros");
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
