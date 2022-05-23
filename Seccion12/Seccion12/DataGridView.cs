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
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        private void dgvGrilla_Load(object sender, EventArgs e)
        {
            dgvPersonas.Rows.Add("Yani", "Pontoni", "Masculino");
            dgvPersonas.Rows.Add("Gisela", "Rotatori", "Femenino");
            dgvPersonas.Rows.Add("Samira", "Pontoni", "Femenino");

            dgvPersonas.Columns[1].Width = 150; // Con esto puedo ampliar el ancho de la columna
        }
    }
}
