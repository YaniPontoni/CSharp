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
    public partial class frmCapturarDatosNumericUpDown : Form
    {
        public frmCapturarDatosNumericUpDown()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Al name del NumericUpDown le cargo el metodo Value para obtener el valor ingresado, el cual tengo que guardar
            // en un decimal
            decimal valor = nmrcForValor.Value;
            // Al name del Label con el metodo Text le asigno lo que me trae la variable valor, pasandolo a string con el
            // metodo ToString ya que el Text espera un string y la variable valor es de tipo decimal
            // Si utilizo un string para concatenar la variable de tipo decimal, no hace falta invocar al ToString
            lblRespuesta.Text = "El valor ingresado es: " + valor;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Con este codigo vuelvo a inicializar el texto del label que da respuesta al botón Mostrar
            lblRespuesta.Text = "";
            // Con este codigo vuelvo a cero el NumericUpDown para reiniciarlo.
            nmrcForValor.Value = 0;
        }
    }
}
