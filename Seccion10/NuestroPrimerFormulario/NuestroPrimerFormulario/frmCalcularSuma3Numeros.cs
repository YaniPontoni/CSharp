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
    public partial class frmCalcularSuma3Numeros : Form
    {
        public frmCalcularSuma3Numeros()
        {
            InitializeComponent();
        }

        private void NUDNumero1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valor1 = NUDNumero1.Value;
            decimal valor2 = NUDNumero2.Value;
            decimal valor3 = NUDNumero3.Value;

            if (valor1 != 0 && valor2 != 0 && valor3 != 0)
            {
                decimal resultado = valor1 + valor2 + valor3;
                lblRespuesta.Text = "La sumatoria de los numeros seleccionados es: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Usted está tratando de ingresar un 0 en alguno de los campos. Vuelva a intentarlo.", "Advertencia");
                lblRespuesta.Text = "";
                return;
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NUDNumero1.Value = 0;
            NUDNumero2.Value = 0;
            NUDNumero3.Value = 0;
            lblRespuesta.Text = "";
        }
    }
}
