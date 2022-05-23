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
    public partial class frmCalcularMayoriaEdad : Form
    {
        public frmCalcularMayoriaEdad()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            decimal edad = nmrcEdad.Value;

            if (edad <= 0)
            {
                errorEdad.SetError(nmrcEdad, "La edad no puede ser menor o igual a 0");
                return;
            }

            if (edad >= 18)
            {
                lblRespuesta.Text = "Es mayor de edad";
            }
            else
            {
                lblRespuesta.Text = "Es menor de edad";
            }
        }
    }
}
