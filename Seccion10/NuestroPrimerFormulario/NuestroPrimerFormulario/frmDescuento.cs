using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuestroPrimerFormulario
{
    public partial class frmDescuento : Form
    {
        public frmDescuento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal precio = nmrcPrecio.Value;

            if (precio != 0)
            {
                decimal precioReal = nmrcPrecio.Value;
                decimal descuento = nmrcPrecio.Value * 20 / 100;
                decimal total = precio - descuento;

                txtBxPrecioReal.Text = precioReal.ToString();
                txtBxDescuento.Text = descuento.ToString();
                txtBxPagoTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("El precio no puede ser 0. Intentelo nuevamente", "Advertencia");
            }

            
        }
    }
}
