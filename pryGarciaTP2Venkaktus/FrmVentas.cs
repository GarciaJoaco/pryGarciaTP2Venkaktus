using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryGarciaTP2Venkaktus
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Abro el Agregado de datos, y uso StreamWrite (para salida de caracteres en una codificacion determinada)

            TextWriter eVentas = new StreamWriter("./ventas.txt", true);

            //Uso la variable "eVentas" para escribir en el archivo ("./ventas.txt)
            eVentas.WriteLine(Convert.ToString("ID del Cliente: " + cbxClienteID.Text + "\nID del Vendedor: " + cbxVendedorID.Text + "\nTipo de Factura: " + cbxFactura.Text + "\nNumero de factura: " + txtFactura.Text + "\nMonto: " + txtMonto.Text + "\nFecha: " + dtpFecha.Text));
            eVentas.Close();

            //DialogResult, que se basa en el resultado que el usuario de cuando se muestre la MessageBox (Resultados de dialogo: Si - No)
            DialogResult ndatos = MessageBox.Show("¡Datos registrados con exito!" + "\n¿Desea registrar nuevamente mas datos?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ndatos == DialogResult.Yes)
            {
                cbxClienteID.Text = "";
                cbxVendedorID.Text = "";
                cbxFactura.Text = "";
                txtFactura.Text = "";
                txtMonto.Text = "";
            }
            //Si el usuario no desea cargar mas datos, el formulario se cierra
            if (ndatos == DialogResult.No)
            {
                this.Close();
            }
        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Identificacion si el usuario apreta una tecla que no este permitida en la TextBox a traves del uso del evento "KeyPress"
            //Uso de codigo ASCII
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}
