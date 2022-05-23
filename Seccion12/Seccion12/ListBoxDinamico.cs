using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seccion12
{
    public partial class ListBoxDinamico : Form
    {
        public ListBoxDinamico()
        {
            InitializeComponent();
        }

        private void ListBoxDinamico_Load(object sender, EventArgs e)
        {
            string[] cursos =
            {
                "Matematicas", "Religion", "Comunicacion", "Educacion Fisica"
            };

            lbCursos.DataSource = cursos;

            List<string> frutas = new List<string>
            {
                "Banana", "Naranja", "Frutilla", "Pera", "Manzana"
            };

            lbFrutas.DataSource = frutas;
        }

        private void lbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
