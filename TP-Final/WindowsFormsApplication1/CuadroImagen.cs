using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class CuadroImagen : Form
    {
        public CuadroImagen(string pimagen)
        {
            InitializeComponent();
            this.pictureBox.Image = Image.FromFile(pimagen);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
