using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Final;

namespace WindowsFormsApplication1
{
    public partial class Programa : Form
    {
        private List<Horario> iListaHorarios = new List<Horario>();

        public List<Horario> ListaHorarios
        {
            get { return iListaHorarios; }
        }

        public Programa()
        {
            InitializeComponent();
        }

        protected TimeSpan TiempoMinimo()
        {
            if (iListaHorarios.Count == 0) 
            {
                return new TimeSpan(0, 0, 0);
            }
            else
            {
                return this.iListaHorarios.Min(elem => elem.HoraFin - elem.HoraInicio);
            }
        }
        private void bSeleccionarHorarios_Click(object sender, EventArgs e)
        {
            CapaVisual.SeleccionarHorarios vSelector = new CapaVisual.SeleccionarHorarios(iListaHorarios);
            DialogResult resultado = vSelector.ShowDialog();
            if (resultado == DialogResult.OK)
            {
            }
        }
    }
}
