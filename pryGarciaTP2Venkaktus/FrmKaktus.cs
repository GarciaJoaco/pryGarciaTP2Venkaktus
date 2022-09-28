using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGarciaTP2Venkaktus
{
    public partial class frmVenkaktus : Form
    {
        public frmVenkaktus()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // se basa en el resultado que el usuario  muestre  en la MessageBox (Resultados de dialogo: Si - No)
            DialogResult s = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si el resultado del dialogo es Si, la aplicacion se cierra
            if (s == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            //Mostrar el formulario frmCliente
            frmCliente rcliente = new frmCliente();
            rcliente.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario frmVendedor
            FrmVendedor vendedor = new FrmVendedor ();
            vendedor.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mostrar el formulario frmVentas
            FrmVentas ventas = new FrmVentas(); 
            ventas.ShowDialog();

        }
    }
    
}
