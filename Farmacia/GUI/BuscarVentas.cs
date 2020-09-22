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
    public partial class BuscarVentas : Form
    {
        BS bs = new BS();
        DetalleVenta dv;

        public BuscarVentas()
        {
            InitializeComponent();
            dtpFecha.MaxDate = DateTime.Now;
        }

        private void BuscarVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.DataSource = bs.Fill("select * from InfoVentas");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrEmpty(cbxBuscar.Text)))
            {
                int op = cbxBuscar.SelectedIndex;
                BindingSource venta = new BindingSource();

                switch (op)
                {
                    case 0:

                        if (!(String.IsNullOrEmpty(txbDato.Text)))
                        {
                            venta = bs.Fill("select * from InfoVentas where [# Fact] = " + txbDato.Text);

                            if (venta.Count != 0)
                            {
                                dgvVentas.DataSource = venta;
                            }
                            else
                            {
                                MessageBox.Show("Sin Coincidencias");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el dato a buscar");
                        }
                        break;

                    case 1:

                        if (!(String.IsNullOrEmpty(dtpFecha.Text)))
                        {
                            venta = bs.Fill("select * from InfoVentas where [Fecha] = '" + dtpFecha.Text + "'");

                            if (venta.Count != 0)
                            {
                                dgvVentas.DataSource = venta;
                            }
                            else
                            {
                                MessageBox.Show("Sin Coincidencias");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el dato a buscar");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un método de busqueda!");
            }
            
        }

        private void cbxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            if(cbxBuscar.SelectedIndex >= 0)
            {
                if (cbxBuscar.SelectedIndex == 0)
                {
                    txbDato.Enabled = true;
                    dtpFecha.Enabled = false;
                }

                if (cbxBuscar.SelectedIndex == 1)
                {
                    dtpFecha.Enabled = true;
                    txbDato.Enabled = false;
                }
            }
        }

        private void txbDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = bs.Fill("select * from InfoVentas");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dv = new DetalleVenta();         

            dv.dataGridView1.DataSource = bs.Fill("select Cantidad,Producto,[Precio Unitario],Subtotal from " +
                "InfoDetalleVenta where Fact_Ven =" + dgvVentas.Rows[dgvVentas.CurrentCell.RowIndex].Cells[0].Value.ToString());
            dv.label2.Text = dgvVentas.Rows[dgvVentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
            dv.label4.Text = dgvVentas.Rows[dgvVentas.CurrentCell.RowIndex].Cells[3].Value.ToString();
            dv.label6.Text = dgvVentas.Rows[dgvVentas.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dv.ShowDialog();   
            
           
        }
    }
}
