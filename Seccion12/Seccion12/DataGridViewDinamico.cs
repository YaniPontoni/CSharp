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
    public partial class DataGridViewDinamico : Form
    {
        public DataGridViewDinamico()
        {
            InitializeComponent();
        }

        private void DataGridViewDinamico_Load(object sender, EventArgs e)
        {
            List<Empleado> listaEmpleados = new List<Empleado>
            {
                new Empleado { nombre = "Yani", sueldo = 1600, diasTrabajadosAlMes = 30 },
                new Empleado { nombre = "Gisela", sueldo = 2700, diasTrabajadosAlMes = 25 },
                new Empleado { nombre = "Samira", sueldo = 3000, diasTrabajadosAlMes = 20 },
            };

            dgvEmpleado.DataSource = listaEmpleados;

            dgvEmpleado.Columns[0].HeaderText = "Nombre";
            dgvEmpleado.Columns[1].HeaderText = "Apellido";
            dgvEmpleado.Columns[2].HeaderText = "Dias trabajados";

            dgvEmpleado.Columns[0].Width = 150;
            dgvEmpleado.Columns[1].Width = 150;
            dgvEmpleado.Columns[2].Width = 150;
        }
    }
}