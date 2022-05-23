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
    public partial class frmCapturarDatosComboBox : Form
    {
        public frmCapturarDatosComboBox()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string diaSeleccionado = cmbBxSemana.Text;
            lblRespuesta.Text = "El día seleccionado es: " + diaSeleccionado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblRespuesta.Text = "";
            cmbBxSemana.Text = "";
        }
    }
}
