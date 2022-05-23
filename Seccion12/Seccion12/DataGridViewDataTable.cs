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
    public partial class DataGridViewDataTable : Form
    {
        public DataGridViewDataTable()
        {
            InitializeComponent();
        }

        private void DataGridViewDataTable_Load(object sender, EventArgs e)
        {
            DataTable tablaPersona = new DataTable();

            tablaPersona.Columns.Add("Nombre ", Type.GetType("System.String"));
            tablaPersona.Columns.Add("Edad ", Type.GetType("System.Int32"));
            tablaPersona.Columns.Add("Sueldo ", Type.GetType("System.Double"));

            DataRow fila1 = tablaPersona.NewRow();

            fila1[0] = "Pedro";
            fila1[1] = 25;
            fila1[2] = 1780.9;

            DataRow fila2 = tablaPersona.NewRow();

            fila2[0] = "Luis";
            fila2[1] = 26;
            fila2[2] = 1670.8;

            tablaPersona.Rows.Add(fila1);
            tablaPersona.Rows.Add(fila2);

            dgvPersonas.DataSource = tablaPersona;
        }
    }
}
