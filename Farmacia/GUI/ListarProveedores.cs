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
    
    public partial class ListarProveedores : Form
    {
        BS bs = new BS();
      
        public ListarProveedores()
        {
            InitializeComponent();
        }


        private void ListarProveedores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bs.Fill("select * from InfoProveedores order by [Nombre Completo]");
        }

 
    }
}
