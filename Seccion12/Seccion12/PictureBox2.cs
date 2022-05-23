using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Seccion12
{
    public partial class PictureBox2 : Form
    {
        public PictureBox2()
        {
            InitializeComponent();
        }

        private void PictureBox2_Load(object sender, EventArgs e)
        {
            string rutaImagen = @"C:\Users\Yani\Pictures\20220315_122826.jpg";

            byte[] arregloImagen = File.ReadAllBytes(rutaImagen);

            using (MemoryStream ms = new MemoryStream(arregloImagen))
            {
                pbImagen2.Image = Image.FromStream(ms);
            }
        }
    }
}
