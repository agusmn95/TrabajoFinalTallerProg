using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final
{
    public class BannerEstatico : Banner
    {
        private string iTexto;

        public string Texto
        {
            get { return iTexto; }
            set { iTexto = value; }
        }

        public BannerEstatico (string pTexto, IList<Horario> pFrecuencia, DateTime pFechaInicio, DateTime pFechaFin) : base ()
        {
            base.Frecuencia = pFrecuencia;
            base.FechaFin = pFechaFin;
            base.FechaInicio = pFechaInicio;
            this.Texto = pTexto;
        }

        public string ObtenerCadena ()
        {
            return this.Texto;
        }
    }
}
