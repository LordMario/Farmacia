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
    public partial class BuscarProducto : Form
    {
        BS bs = new BS();
        BindingSource producto;

        public BuscarProducto()
        {
            InitializeComponent();
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bs.Fill("select * from InfoProductos");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int op = cboxprod.SelectedIndex;

            switch (op)
            {
                case -1:
                    MessageBox.Show("Seleccione un metodo de busqueda");
                    break;
                case 0:

                    if (!String.IsNullOrEmpty(tboxdato.Text))
                    {

                        producto = bs.Fill("select * from InfoProductos where Codigo=@Cod", "@Cod", tboxdato.Text, SqlDbType.Char);

                        if (producto.Count > 0)
                        {
                            dataGridView1.DataSource = producto;
                        }
                        else
                        {
                            MessageBox.Show("Sin coincidencias");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el dato a buscar");
                    }

                    break;

                case 1:

                    if (!String.IsNullOrEmpty(tboxdato.Text))
                    {
                        producto = bs.Fill("select * from InfoProductos where Producto= @Prod", "@Prod", tboxdato.Text, SqlDbType.VarChar);

                        if (producto.Count > 0)
                        {
                            dataGridView1.DataSource = producto;
                        }
                        else
                        {
                            MessageBox.Show("Sin coincidencias");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingrese el dato a buscar");
                    }

                    break;

                case 2:

                    if (!String.IsNullOrEmpty(tboxdato.Text))
                    {
                        producto = bs.Fill("select * from InfoProductos where Marca=@Marca", "@Marca", tboxdato.Text, SqlDbType.VarChar);

                        if (producto.Count > 0)
                        {
                            dataGridView1.DataSource = producto;
                        }
                        else
                        {
                            MessageBox.Show("Sin coincidencias");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingrese el dato a buscar");
                    }

                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NProducto np = new NProducto();
            np.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            np.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bs.Fill("select * from InfoProductos");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActualizarPrecio ap = new ActualizarPrecio();
            ap.ShowDialog();

            if (ap.IsDisposed)
            {
                dataGridView1.DataSource = bs.Fill("select * from InfoProductos");
            }
        }
    }
}
