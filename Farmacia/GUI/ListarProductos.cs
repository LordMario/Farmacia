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
    public partial class ListarProductos : Form
    {

        BS bs = new BS();
        public string cod;

        public ListarProductos()
        {
            InitializeComponent();
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bs.Fill("select * from InfoProductos where Existencia > 1 order by Producto");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            cod = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cod = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bs.Fill("BuscarProductoNombre @NOM where Existencia > 1 order by Producto", "@NOM",textBox1.Text,SqlDbType.VarChar);
        }
    }
}
