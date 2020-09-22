using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class ListarCompra : Form
    {
        BS bs = new BS();

        public ListarCompra()
        {
            InitializeComponent();
        }

        private void ListarCompra_Load(object sender, EventArgs e)
        {
            dgvCompras.DataSource = bs.Fill("select * from InfoCompras");
        }

        private void dgvCompras_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDetalleCompra.DataSource = bs.Fill("select Codigo,Producto,[Costo Unitario],Subtotal from InfoDetalleCompra " +
                "where Fact_Com =" + dgvCompras.Rows[dgvCompras.CurrentCell.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }
    }
}
