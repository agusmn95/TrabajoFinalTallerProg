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
        private Horario iHorarios;
        private TimeSpan iTiempoImagen;
        private List<ImagenCampaña> iListaImagenes;

        //Constructor
        public Campaña()
        {
            iFechaInicio = new DateTime();
            iFechaFin = new DateTime();
            iHorarios = new Horario();
            iTiempoImagen = new TimeSpan();
            iListaImagenes = new List<ImagenCampaña>;
        }

        //Propiedades
        public DateTime FechaInicio { set { iFechaInicio = value; } }
        public DateTime FechaFin { set { iFechaFin = value; } }
        public TimeSpan TiempoImagen
        {
            get { return iTiempoImagen; }
            set { iTiempoImagen = value; }
        }
        public Horario Horarios { set { iHorarios = value; } }


        //Mensajes
        public void AgregarImagen(string pRuta)
        {
            iListaImagenes.Add(new ImagenCampaña(pRuta));
        }

        public void Mostrar()
        {
           // TiempoImagen.TotalSeconds
        }
    }
}
