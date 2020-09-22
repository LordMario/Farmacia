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
    public partial class Form1 : Form
    {
        //ReporteVentas rv;

        List<Button> botones = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            tmrFecha.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
            botones.Add(button3);
            botones.Add(button4);
            botones.Add(button5);
            
            botones.Add(button7);
        }


        //
        //PRODUCTO
        //
        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NProducto np = new NProducto();
            FormHijoLoad(np);
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProducto b = new BuscarProducto();
            FormHijoLoad(b);
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProductos l = new ListarProductos();
            FormHijoLoad(l);
        }

        private void actualizarPrecioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ActualizarPrecio ap = new ActualizarPrecio();
            FormHijoLoad(ap);
        }
        //


        //
        //PROVEEDOR
        //
        private void proveedorNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Proveedor nprov = new Nuevo_Proveedor();
            FormHijoLoad(nprov);
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarProveedores lp = new ListarProveedores();
            FormHijoLoad(lp);
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarProveedor mp = new ModificarProveedor();
            FormHijoLoad(mp);
        }

        private void buscarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProveedor bp = new BuscarProveedor();
            FormHijoLoad(bp);
        }
        //



        //
        //VENTAS
        //
        private void agregarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            FormHijoLoad(v);
        }

        private void lIstarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarVentas lv = new ListarVentas();
            FormHijoLoad(lv);
        }
        
        private void buscarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarVentas bv = new BuscarVentas();
            FormHijoLoad(bv);
        }
        //

        //
        // COMPRAS
        //
        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NCompra nc = new NCompra();
            FormHijoLoad(nc);
        }

        private void listarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCompra lc = new ListarCompra();
            FormHijoLoad(lc);
        }
        //

        ////
        //private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    rv = new ReporteVentas();
        //    rv.MdiParent = this;
        //    this.pnlContenedor.Controls.Clear();
        //    this.pnlContenedor.Controls.Add(rv);
        //    rv.Location = new Point((pnlContenedor.Width - rv.Width) / 2, (pnlContenedor.Height - rv.Height) / 2);
        //    rv.Show();
        //}
        ////


        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }       

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToString("hh:mm  tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel();
        }

        public void Panel()
        {
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(label2);
            label2.Location = new Point((pnlContenedor.Width - label2.Width) / 2, 30);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarVentas bv = new BuscarVentas();
            FormHijoLoad(bv);
            ColorBoton(button4);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            FormHijoLoad(v);
            ColorBoton(button3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BuscarProducto b = new BuscarProducto();
            FormHijoLoad(b);
            ColorBoton(button5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas de seguro de cerrar sesión?","Cerrar sesión",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void FormLoad()
        {
            label1.Location = new Point((panel1.Width - label1.Width) / 2, 20);
            label2.Location = new Point((pnlContenedor.Width - label2.Width) / 2, 30);
        }

        private void FormHijoLoad(Form fh)
        {
            fh.MdiParent = this;
            pnlContenedor.Controls.Clear();
            this.pnlContenedor.Controls.Add(fh);
            fh.Location = new Point((pnlContenedor.Width - fh.Width) / 2, pnlHeader.Height+5);
            fh.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas de seguro de cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorBoton(button7);
            NCompra nc = new NCompra();
            FormHijoLoad(nc);
            
        }

        private void ColorBoton(Button bot)
        {
            bot.BackColor = Color.DarkCyan;
            foreach (Button b in botones)
            {
                if(b.BackColor == Color.DarkCyan && b != bot)
                {
                    b.BackColor = Color.LightSteelBlue;
                }
            }
        }

        
    }
}
