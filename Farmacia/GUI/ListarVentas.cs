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
    public partial class ListarVentas : Form
    {
        BS bs = new BS();

        public ListarVentas()
        {
            InitializeComponent();
        }

        private void ListarVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = bs.Fill("select * from InfoVentas");
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvVentas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                double total = 0.0;

                dgvDetalleVenta.DataSource = bs.Fill("select Codigo,Producto,Descripcion,Cantidad,[Precio Unitario],Subtotal from InfoDetalleVenta where Fact_Ven ="
                    + dgvVentas.Rows[dgvVentas.CurrentCell.RowIndex].Cells[0].Value.ToString());

                lblFactura.Text = dgvVentas.Rows[dgvVentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
                lblFecha.Text = dgvVentas.Rows[dgvVentas.CurrentCell.RowIndex].Cells[3].Value.ToString();

                for (int i = 0; i < dgvDetalleVenta.Rows.Count; i++)
                {
                    total += Convert.ToDouble(dgvDetalleVenta.Rows[i].Cells[4].Value.ToString());
                }

                txbTotal.Text = total.ToString();
            }
            catch(Exception ex)
            {

            }

        }
    }
}
