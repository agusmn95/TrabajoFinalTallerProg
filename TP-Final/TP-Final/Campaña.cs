using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final
{
    public class Campaña
    {
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private Horario iHorario;
        private TimeSpan iTiempoXImagen;
        private List<ImagenCampaña> iListaImagenes;

        //Constructor
        public Campaña(DateTime pFechaInicio, DateTime pFechaFin, Horario pHorario, TimeSpan pTiempoXImagen)
        {
            iFechaInicio = pFechaInicio;
            iFechaFin = pFechaFin;
            iHorario = pHorario;
            iTiempoXImagen = pTiempoXImagen;
            iListaImagenes = new List<ImagenCampaña>();
        }

        //Propiedades
        public DateTime FechaInicio { set { iFechaInicio = value; } }
        public DateTime FechaFin { set { iFechaFin = value; } }
        public TimeSpan TiempoImagen
        {
            get { return iTiempoXImagen; }
            set { iTiempoXImagen = value; }
        }
        public Horario Horario { get { return iHorario; } }
        public List<ImagenCampaña> ListaImagenes { get { return iListaImagenes; } }


        //Mensajes
        public void AgregarImagen(string pRuta)
        {
            this.iListaImagenes.Add(new ImagenCampaña(pRuta));
        }
    }
}
