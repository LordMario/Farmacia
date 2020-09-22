using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace Farmacia
{
    public partial class Login : Form
    {
        Conexion con;
        Cifrado cifrado = new Cifrado();
        Form1 farmacia = new Form1();
        int contador = 0, seg = 10;

        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            con = new Conexion(textBox3.Text, textBox1.Text, cifrado.Descifrar(textBox2.Text));

            if (this.con.conectar.State == ConnectionState.Open)
            {
                farmacia.Show();
                farmacia.buscarProveedorToolStripMenuItem.Visible = false;
                this.con.conectar.Close();
                this.con.conectar.Dispose();
                this.Hide();
            }
            else
            {
                contador++;
                if (contador > 2)
                {
                    button1.Enabled = false;
                    textBox2.Enabled = false;
                    timer1.Start();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto",con.mensaje,MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
                    textBox2.Text = null;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            farmacia.Show();
            farmacia.buscarVentaToolStripMenuItem.Visible = false;
            farmacia.agregarProductoToolStripMenuItem.Visible = false;
            farmacia.buscarProductoToolStripMenuItem.Visible = false;
            farmacia.actualizarPrecioToolStripMenuItem.Visible = false;

            farmacia.proveedorToolStripMenuItem.Visible = false;
            farmacia.reportesToolStripMenuItem.Visible = false;
            farmacia.compraToolStripMenuItem.Visible = false;
            this.Hide();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue >= 65 && e.KeyValue <= 90) || (e.KeyValue >= 97 && e.KeyValue <= 122))
            {
                textBox2.Text = cifrado.Cifrar(textBox2.Text);
                textBox2.Select(textBox2.TextLength, 0);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
                        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seg >= 0)
            {
                lblTimer.Visible = true;
                lblTimer.Text = "Espere " + seg-- + " segundos para volver a intentar";
            }
            else
            {
                timer1.Stop();
                button1.Enabled = true;
                textBox2.Enabled = true;
                lblTimer.Visible = false;
            }            
        }
    }
}
