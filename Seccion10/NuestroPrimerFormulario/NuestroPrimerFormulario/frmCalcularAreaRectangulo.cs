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
    public partial class frmCalcularAreaRectangulo : Form
    {
        public frmCalcularAreaRectangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (lblRespuesta.Text == "")
            {
                MessageBox.Show("El campo de respuesta se encuentra actualmente limpio.", "Advertencia");
                nmrcBase.Value = 0;
                nmrcAltura.Value = 0;
            }
            else
            {
                nmrcBase.Value = 0;
                nmrcAltura.Value = 0;
                lblRespuesta.Text = "";
                txtBxRespuesta.Text = "";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal baseR = nmrcBase.Value;
            decimal alturaR = nmrcAltura.Value;

            if (baseR != 0 && alturaR != 0)
            {
                decimal resultado = baseR * alturaR;
                lblRespuesta.Text = "El resultado de la operacion es: ";
                txtBxRespuesta.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Ha ingresado un 0 en alguno de los campos numericos. Intente nuevamente.", "Advertencia");
            }
        }
    }
}
