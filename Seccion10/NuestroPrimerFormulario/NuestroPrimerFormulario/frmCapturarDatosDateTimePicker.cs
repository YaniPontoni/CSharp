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
    public partial class frmCapturarDatosDateTimePicker : Form
    {
        public frmCapturarDatosDateTimePicker()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpFecha.Value;
            lblRespuesta.Text = "La fecha seleccionada es: " + fecha.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Si uso el metodo Text para dtpFecha y se lo asigno a una cadena vacia, me sirve para resetear el caja de fecha
            dtpFecha.Text = "";
            lblRespuesta.Text = "";
        }
    }
}
