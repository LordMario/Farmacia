using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class NProducto : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        BS bs = new BS();
        ListarProveedores lp;

        public NProducto()
        {
            InitializeComponent();
            conn = new SqlConnection(bs.connectionstring);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)  &&
                !string.IsNullOrEmpty(textBox4.Text))
            {
                try
                {                    
                    comm = new SqlCommand("NuevoProducto", conn);
                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@NP", SqlDbType.VarChar).Value = textBox1.Text;
                    comm.Parameters.AddWithValue("@DP", SqlDbType.VarChar).Value = textBox2.Text;
                    comm.Parameters.AddWithValue("@MP", SqlDbType.VarChar).Value = textBox3.Text;
                    comm.Parameters.AddWithValue("@PRECIO", SqlDbType.Float).Value = textBox4.Text;
                    comm.Parameters.AddWithValue("@IDPROV", SqlDbType.Int).Value = comboBox1.SelectedValue.ToString();

                    conn.Open();
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Registro insertado exitosamente");
                    conn.Close();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                }
                catch
                {
                    MessageBox.Show("Error al insertar");
                }
            }
            else
            {
                MessageBox.Show("Inserte los datos obligatorios");
            }
            
        }

        private void NProducto_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bs.Fill("select * from Proveedor");
            comboBox1.DisplayMember = "PNPROV";
            comboBox1.ValueMember = "Id_Prov";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lp = new ListarProveedores();
            lp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
