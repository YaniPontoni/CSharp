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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Persona> listaPersona = new List<Persona>
            {
                new Persona{id=1, nombre="Yani"},
                new Persona{id=2, nombre="Gisela"},
                new Persona{id=3, nombre="Samira"}
            };

            cmbBxPersonas.DataSource = listaPersona;
            cmbBxPersonas.DisplayMember = "nombre";
            cmbBxPersonas.ValueMember = "id";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombrePersona = cmbBxPersonas.Text;
            MessageBox.Show("Nombre: " + nombrePersona, "Aviso");
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            string idPersona = cmbBxPersonas.SelectedValue.ToString();
            MessageBox.Show("ID: " + idPersona, "Aviso");
        }

        private void btnMostrarValores_Click(object sender, EventArgs e)
        {
            Persona persona = (Persona) cmbBxPersonas.SelectedItem;
            MessageBox.Show("Nombre: " + persona.nombre, "Mostrando nombre");
            MessageBox.Show("ID: " + persona.id, "Mostrando ID");
        }
    }
}
