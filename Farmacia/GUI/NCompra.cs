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
    public partial class NCompra : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        BS bs = new BS();

        string cantidad, costo;

        public NCompra()
        {
            InitializeComponent();
            conn = new SqlConnection(bs.connectionstring);
        }

        private void NCompra_Load(object sender, EventArgs e)
        {
            FillComboBox("select * from Proveedor", "PNPROV", cbxProveedor);
            FillComboBox("select * from Productos", "Nom_Prod", cbxProducto);

            dtpFecha.MaxDate = DateTime.Now;
            dgvCompra.Columns[0].Visible = false;
        }

        private void FillComboBox(string com, string DisplayMember, ComboBox cb)
        {
            cb.DataSource = bs.Fill(com);
            cb.DisplayMember = DisplayMember;
        }


        private void cbxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTexBox("Select Id_Prov FROM Proveedor WHERE Id_Prov=@dato", cbxProveedor, txbIDProv, "Id_Prov");
        }
        private void cbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTexBox("Select Cod_Prod FROM Productos WHERE Cod_Prod=@dato", cbxProducto, txbCodProd, "Cod_Prod");
        }


        private void FillTexBox(string com, ComboBox cb, TextBox tb, string param)
        {
            cmd = new SqlCommand(com, conn);

            try
            {
                cmd.Parameters.AddWithValue("@dato", cb.SelectedValue.ToString());

                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    sdr.Read();
                    tb.Text = sdr[param].ToString();
                    sdr.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txbFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txbCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txbCosto.Text) || !String.IsNullOrEmpty(txbCantidad.Text))
            {
                if (Convert.ToInt32(txbCantidad.Text.ToString()) != 0)
                {
                    double total = 0;

                    if (dgvCompra.Rows.Count > 0)
                    {
                        bool existe = false;

                        for (int i = 0; i < dgvCompra.Rows.Count; i++)
                        {
                            if (dgvCompra.Rows[i].Cells[1].Value.ToString() == cbxProducto.Text.ToString())
                            {
                                dgvCompra.Rows[i].Cells[3].Value = Convert.ToInt32(dgvCompra.Rows[i].Cells[3].Value.ToString()) + Convert.ToInt32(txbCantidad.Text);
                                dgvCompra.Rows[i].Cells[4].Value = Subtotal(dgvCompra.Rows[i].Cells[2].Value.ToString(), dgvCompra.Rows[i].Cells[3].Value.ToString());
                                for (int fila = 0; fila < dgvCompra.Rows.Count; fila++)
                                {
                                    total += Convert.ToDouble(dgvCompra.Rows[fila].Cells[4].Value.ToString());
                                }
                                txbTotal.Text = total.ToString();
                                existe = true;
                                txbCantidad.Text = null;
                                txbCosto.Text = null;
                                break;
                            }
                        }

                        if (existe == false)
                        {

                            dgvCompra.Rows.Add(txbCodProd.Text, cbxProducto.Text, txbCosto.Text, txbCantidad.Text,
                                Subtotal(txbCosto.Text, txbCantidad.Text));

                            for (int fila = 0; fila < dgvCompra.Rows.Count; fila++)
                            {
                                total += Convert.ToDouble(dgvCompra.Rows[fila].Cells[4].Value.ToString());
                            }
                            txbTotal.Text = total.ToString();
                            txbCantidad.Text = null;
                            txbCosto.Text = null;
                        }

                    }
                    else
                    {
                        dgvCompra.Rows.Add(txbCodProd.Text, cbxProducto.Text, txbCosto.Text, txbCantidad.Text,
                                Subtotal(txbCosto.Text, txbCantidad.Text));

                        for (int fila = 0; fila < dgvCompra.Rows.Count; fila++)
                        {
                            total += Convert.ToDouble(dgvCompra.Rows[fila].Cells[4].Value.ToString());
                        }
                        txbTotal.Text = total.ToString();
                        txbCantidad.Text = null;
                        txbCosto.Text = null;
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad mayor a 0");
                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos correspondiente");
            }
        }

        private string Subtotal(string costo, string cantidad)
        {
            string sbt = null;
            double cost, cant;
            cost = Convert.ToDouble(costo);
            cant = Convert.ToDouble(cantidad);
            sbt = Convert.ToString(cost * cant);
            return sbt;
        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el producto?", "", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                if (dgvCompra.Rows.Count > 0)
                {
                    if (dgvCompra.SelectedRows.Count > 0)
                    {
                        double total = 0;
                        dgvCompra.Rows.Remove(dgvCompra.CurrentRow);
                        for (int fila = 0; fila < dgvCompra.Rows.Count; fila++)
                        {
                            total += Convert.ToDouble(dgvCompra.Rows[fila].Cells[4].Value.ToString());
                        }
                        txbTotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un producto para quitarlo");
                    }
                }
                else
                {
                    MessageBox.Show("Sin produtos aun");
                }
            }
            else if (result == DialogResult.No)
            {
            }
            else if (result == DialogResult.Cancel)
            {
            }
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            if (txbFactura.TextLength==8)
            {
                if (!String.IsNullOrEmpty(txbFactura.Text))
                {
                    if (NumFact())
                    {
                        if (dgvCompra.Rows.Count > 0)
                        {
                            RegistrarCompra();

                            for (int i = 0; i < dgvCompra.Rows.Count; i++)
                            {
                                RegistrarDetalleCompra(i);
                            }

                            dgvCompra.Rows.Clear();
                            txbFactura.Text = null;
                            txbCantidad.Text = null;
                            txbCosto.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("sin producto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numero de factura ya existente");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese los datos correspondiente");
                }
            }
            else
            {
                MessageBox.Show("El numero de factura debe tener 8 digitos");
                txbFactura.Text = null;
            }
        }

        private void RegistrarCompra()
        {
            SqlCommand venta;
            try
            {
                conn.Open();
                venta = new SqlCommand("NuevaCompra", conn);
                venta.CommandType = CommandType.StoredProcedure;

                venta.Parameters.AddWithValue("@FC", SqlDbType.Char).Value = txbFactura.Text;
                venta.Parameters.AddWithValue("@FECHACOM", SqlDbType.DateTime).Value = dtpFecha.Text.ToString();
                venta.Parameters.AddWithValue("@TOTAL", SqlDbType.Float).Value = txbTotal.Text;
                venta.Parameters.AddWithValue("@IDPROV", SqlDbType.Int).Value = txbIDProv.Text;

                venta.ExecuteNonQuery();

                //MessageBox.Show("Registro insertado: Compra");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro no insertado: Compra");
                throw ex;
            }
            conn.Close();
        }

        private void RegistrarDetalleCompra(int i)
        {
            SqlCommand detalle;
            ;
            try
            {
                conn.Open();
                detalle = new SqlCommand("NuevoDetalleCom", conn);
                detalle.CommandType = CommandType.StoredProcedure;

                detalle.Parameters.AddWithValue("@FC", SqlDbType.Int).Value = txbFactura.Text;
                detalle.Parameters.AddWithValue("@CP", SqlDbType.Char).Value = dgvCompra.Rows[i].Cells[0].Value.ToString();
                detalle.Parameters.AddWithValue("@COSTOP", SqlDbType.Float).Value = dgvCompra.Rows[i].Cells[2].Value.ToString();
                detalle.Parameters.AddWithValue("@CC", SqlDbType.Int).Value = dgvCompra.Rows[i].Cells[3].Value.ToString();
                detalle.Parameters.AddWithValue("@SUT", SqlDbType.Float).Value = dgvCompra.Rows[i].Cells[4].Value.ToString();

                detalle.ExecuteNonQuery();

                MessageBox.Show("Compra registrada correctamente", "Registro Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro no insertado: DetalleCompra");
                throw ex;
            }
            conn.Close();
        }

        private bool NumFact()
        {
            cmd = new SqlCommand("select * from Compras where Fact_Com=@fact_com", conn);
            cmd.Parameters.AddWithValue("@fact_com", SqlDbType.Char).Value = txbFactura.Text;

            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }
        }

        private void dgvCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompra.Rows[e.RowIndex].Cells[2].Value != null && 
                (dgvCompra.Rows[e.RowIndex].Cells[3].Value != null || 
                Convert.ToInt32(dgvCompra.Rows[e.RowIndex].Cells[3].Value) != 0))
            {
                double total = 0;

                dgvCompra.Rows[e.RowIndex].Cells[4].Value = Subtotal(dgvCompra.Rows[e.RowIndex].Cells[2].Value.ToString(), dgvCompra.Rows[e.RowIndex].Cells[3].Value.ToString());

                for (int fila = 0; fila < dgvCompra.Rows.Count; fila++)
                {
                    total += Convert.ToDouble(dgvCompra.Rows[fila].Cells[4].Value.ToString());
                }
                txbTotal.Text = total.ToString();
            }
            else
            {

                MessageBox.Show("No se pudo modificar la celda \n No puede quedar vacia");
                dgvCompra.Rows[e.RowIndex].Cells[2].Value = costo;
                dgvCompra.Rows[e.RowIndex].Cells[3].Value = cantidad;
            }
        }

        private void txbFactura_Leave(object sender, EventArgs e)
        {
            txbFactura.Text = txbFactura.Text.PadLeft(8, '0');
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea cancelar la compra actual?","Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCompra_DoubleClick(object sender, EventArgs e)
        {
            costo = dgvCompra.Rows[dgvCompra.CurrentCell.RowIndex].Cells[2].Value.ToString();
            cantidad = dgvCompra.Rows[dgvCompra.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }
    }
}
