using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final
{
    /// <summary>
    /// Clase de datos para campañas.
    /// </summary>
    public class Campaña
    {
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private IList<Horario> iHorario;
        private TimeSpan iTiempoXImagen;
        private List<ImagenCampaña> iListaImagenes;

        //Constructor
        public Campaña(DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pTiempoXImagen)
        {
            iFechaInicio = pFechaInicio;
            iFechaFin = pFechaFin;
            iHorario = new List<Horario>();
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
        public IList<Horario> Horario { get { return iHorario; } }
        public List<ImagenCampaña> ListaImagenes { get { return iListaImagenes; } }


        //Mensajes
        /// <summary>
        /// Método para agregar imágenes a una campaña. Obteniendo como parámetro la ruta a la imágen a agregar.
        /// </summary>
        /// <param name="pRuta">Ruta en disco a la imagen.</param>
        public void AgregarImagen(string pRuta)
        {
            this.iListaImagenes.Add(new ImagenCampaña(pRuta));
        }
    }
}
