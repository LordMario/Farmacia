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
    public partial class Venta : Form
    {
        //Conexion con = new Conexion();
        BS bs = new BS();
        SqlConnection conn;
        SqlCommand cmd;        
        ListarProductos lp;

        private int existencia = 0;
        string celda;

        public Venta()
        {
            conn = new SqlConnection(bs.connectionstring);
            InitializeComponent();            
            NumFactura();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = bs.Fill("select * from Productos where Exist_Prod > 1 order by Nom_Prod");
            comboBox1.DisplayMember = "Nom_Prod";
            comboBox1.ValueMember = "Cod_Prod";
            comboBox1.SelectedItem = null;
            comboBox1.Text = "Seleccionar producto";

            dataGridView1.Columns[4].Visible = false;
        }


        //
        //Boton Agregar Producto
        //
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (!String.IsNullOrEmpty(textBox2.Text) && Convert.ToInt32(textBox2.Text.ToString()) != 0)
                {
                    if (Convert.ToInt32(textBox2.Text) < existencia)
                    {
                        conn.Open();
                        cmd = new SqlCommand("Select * FROM Productos WHERE Cod_Prod=@cod", conn);
                        cmd.Parameters.AddWithValue("@cod", SqlDbType.Char).Value = comboBox1.SelectedValue.ToString();

                        double total = 0;

                        if (dataGridView1.Rows.Count > 0)
                        {
                            bool existe = false;

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                if (dataGridView1.Rows[i].Cells[4].Value.ToString() == comboBox1.SelectedValue.ToString())
                                {
                                    dataGridView1.Rows[i].Cells[2].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString()) + Convert.ToInt32(textBox2.Text);
                                    dataGridView1.Rows[i].Cells[3].Value = Subtotal(dataGridView1.Rows[i].Cells[1].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString());
                                    for (int fila = 0; fila < dataGridView1.Rows.Count; fila++)
                                    {
                                        total += Convert.ToDouble(dataGridView1.Rows[fila].Cells[3].Value.ToString());
                                    }
                                    textBox1.Text = total.ToString();
                                    existencia = existencia - Convert.ToInt32(textBox2.Text);
                                    existe = true;
                                    lblDisponible.Text = "Disponible: " + existencia.ToString();
                                    textBox2.Text = null;
                                    break;
                                }
                            }

                            if (existe == false)
                            {
                                SqlDataReader codp = cmd.ExecuteReader();

                                if (codp.HasRows)
                                {
                                    codp.Read();
                                    dataGridView1.Rows.Add(codp["Nom_Prod"].ToString(), codp["Prec_Prod"].ToString(), 
                                        textBox2.Text, Subtotal(codp["Prec_Prod"].ToString(), textBox2.Text),codp["Cod_Prod"]);            
                                    codp.Close();
                                }

                                for (int fila = 0; fila < dataGridView1.Rows.Count; fila++)
                                {
                                    total += Convert.ToDouble(dataGridView1.Rows[fila].Cells[3].Value.ToString());
                                }
                                existencia = existencia - Convert.ToInt32(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value.ToString());
                                textBox1.Text = total.ToString();
                                lblDisponible.Text = "Disponible: " + existencia.ToString();
                                textBox2.Text = null;
                            }

                        }
                        else
                        {
                            SqlDataReader codp = cmd.ExecuteReader();

                            if (codp.HasRows)
                            {
                                codp.Read();
                                dataGridView1.Rows.Add(codp["Nom_Prod"].ToString(), codp["Prec_Prod"].ToString(), textBox2.Text,
                                    Subtotal(codp["Prec_Prod"].ToString(), textBox2.Text), codp["Cod_Prod"]);
                                codp.Close();
                            }

                            for (int fila = 0; fila < dataGridView1.Rows.Count; fila++)
                            {
                                total += Convert.ToDouble(dataGridView1.Rows[fila].Cells[3].Value.ToString());
                            }
                            existencia = existencia - Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString());
                            textBox1.Text = total.ToString();
                            lblDisponible.Text = "Disponible: " + existencia.ToString();
                            textBox2.Text = null;
                        }
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Inventario insuficiente");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la cantidad a comprar");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }
        //


        //
        //Boton Quitar Producto
        //
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea quitar el producto?","Eliminar Producto", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        double total = 0;
                        //existencia = existencia + Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        for (int fila = 0; fila < dataGridView1.Rows.Count; fila++)
                        {
                            total += Convert.ToDouble(dataGridView1.Rows[fila].Cells[3].Value.ToString());
                        }
                        textBox1.Text = total.ToString();
                        existencia = Convert.ToInt32(label13.Text);
                        lblDisponible.Text = "Disponible: " + existencia.ToString();
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
        }
        //


        //
        //Boton Registrar Venta
        //
        private void button3_Click(object sender, EventArgs e)
        {                   
            if (dataGridView1.Rows.Count > 0)
            {
                RegistrarVenta();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    RegistrarDetalleVenta(i);
                }

                MessageBox.Show("Venta registrada correctamente");

                NumFactura();
                InformacionProdGB();

                dataGridView1.Rows.Clear();
                textBox2.Text = null;
            }
            else
            {
                MessageBox.Show("sin producto");
            }            
        }
        //   


        private void RegistrarVenta()
        {
            SqlCommand venta;
            try
            {
                conn.Open();
                venta = new SqlCommand("NuevaVenta", conn);
                venta.CommandType = CommandType.StoredProcedure;
                venta.ExecuteNonQuery();

                //MessageBox.Show("Registro insertado: Venta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta");
                throw ex;
            }
            conn.Close();
        }

        private void RegistrarDetalleVenta(int i)
        {
            SqlCommand detalle;
;
            try
            {
                conn.Open();
                detalle = new SqlCommand("NuevoDetalleVenta", conn);
                detalle.CommandType = CommandType.StoredProcedure;

                detalle.Parameters.AddWithValue("@FV", SqlDbType.Int).Value = label8.Text;
                detalle.Parameters.AddWithValue("@CODP", SqlDbType.Char).Value = dataGridView1.Rows[i].Cells[4].Value.ToString();
                detalle.Parameters.AddWithValue("@CANT", SqlDbType.Int).Value = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                
                detalle.ExecuteNonQuery();
                         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta");
                throw ex;
            }
            conn.Close();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            InformacionProd();
            conn.Close();
            lblDisponible.Text = "Disponible: " + existencia.ToString();
        }

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value) != 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value) < Convert.ToInt32(label13.Text))
                    {
                        double total = 0;

                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = Subtotal(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                        for (int fila = 0; fila < dataGridView1.Rows.Count; fila++)
                        {
                            total += Convert.ToDouble(dataGridView1.Rows[fila].Cells[3].Value.ToString());
                        }
                        textBox1.Text = total.ToString();
                        existencia = Convert.ToInt32(label13.Text) - Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                        lblDisponible.Text = "Disponible: " + existencia.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Inventario insuficiente");
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = celda;
                    }
                }
                else
                {

                    MessageBox.Show("No se pudo modificar la celda \n No puede quedar vacia");
                    dataGridView1.Rows[e.RowIndex].Cells[2].Value = celda;
                }
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = celda;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;       
            }
        }


        private void InformacionProdGB()
        {
            cmd = new SqlCommand("Select * FROM Productos WHERE Nom_Prod=@nombre", conn);
            cmd.Parameters.AddWithValue("@nombre", Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()));

            conn.Open();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                //label8.Text = registro["Cod_Prod"].ToString();
                label10.Text = registro["Desc_Prod"].ToString();
                label12.Text = registro["Marca_Prod"].ToString();
                label11.Text = registro["Prec_Prod"].ToString(); ;
                label13.Text = registro["Exist_Prod"].ToString();
                registro.Close();
            }

            conn.Close();
        }

        private void InformacionProd()
        {
            cmd = new SqlCommand("Select * FROM Productos WHERE Cod_Prod=@cod", conn);

            try
            {
                cmd.Parameters.AddWithValue("@cod", SqlDbType.Char).Value = comboBox1.SelectedValue.ToString();
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    //label8.Text = registro["Cod_Prod"].ToString();
                    label10.Text = registro["Desc_Prod"].ToString();
                    label12.Text = registro["Marca_Prod"].ToString();
                    label11.Text = registro["Prec_Prod"].ToString();
                    label13.Text = registro["Exist_Prod"].ToString();

                    if (dataGridView1.Rows.Count == 0)
                    {
                        existencia = Convert.ToInt32(registro["Exist_Prod"].ToString());
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[4].Value.ToString() == registro["Cod_Prod"].ToString())
                            {
                                existencia = Convert.ToInt32(registro["Exist_Prod"].ToString()) - Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                break;
                            }
                            else
                            {
                                existencia = Convert.ToInt32(registro["Exist_Prod"].ToString());
                            }
                        }
                    }

                    registro.Close();
                }
            }
            catch
            {

            }
        }

        private void NumFactura()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MAX(Fact_Ven) from Ventas", conn);
            label8.Text = (Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1).ToString();
            conn.Close();
        }

        private string Subtotal(string precio, string cantidad)
        {
            string sbt = null;
            double prec, cant;
            prec = Convert.ToDouble(precio);
            cant = Convert.ToDouble(cantidad);
            sbt = Convert.ToString(prec * cant);
            return sbt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                celda = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select * FROM Productos WHERE Cod_Prod=@cod", conn);
                cmd.Parameters.AddWithValue("@cod", SqlDbType.Char).Value = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();

                conn.Open();
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();
                    //label8.Text = registro["Cod_Prod"].ToString();
                    label10.Text = registro["Desc_Prod"].ToString();
                    label12.Text = registro["Marca_Prod"].ToString();
                    label11.Text = registro["Prec_Prod"].ToString(); ;
                    label13.Text = registro["Exist_Prod"].ToString();

                    if (dataGridView1.Rows.Count == 0)
                    {
                        existencia = Convert.ToInt32(registro["Exist_Prod"].ToString());
                    }
                    else
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[4].Value.ToString() == registro["Cod_Prod"].ToString())
                            {
                                existencia = Convert.ToInt32(registro["Exist_Prod"].ToString()) - Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                break;
                            }
                            else
                            {
                                existencia = Convert.ToInt32(registro["Exist_Prod"].ToString());
                            }
                        }
                    }

                    registro.Close();
                }

                conn.Close();

                lblDisponible.Text = "Disponible: " + existencia.ToString();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea cancelar la venta actual?","Cancelar Venta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

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

        private void button6_Click(object sender, EventArgs e)
        {           
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea quitar todos los productos?", "", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();
                    existencia = Convert.ToInt32(label13.Text);
                    lblDisponible.Text = "Disponible: " + existencia.ToString();
                }

            }
            else
            {
                MessageBox.Show("Sin productos");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lp = new ListarProductos();
            lp.ShowDialog();
            try
            {
                comboBox1.SelectedValue = lp.cod;
            }
            catch
            {
                
            }
            
        }
    }
}
