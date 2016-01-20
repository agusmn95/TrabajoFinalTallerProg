using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final
{
    public class Banner
    {
        private IList<Horario> iFrecuencia;
        private DateTime iFechaInicio;
        private DateTime iFechaFin;

        public IList<Horario> Frecuencia
        {
            get { return iFrecuencia; }
            set { iFrecuencia = value; }
        }

        public DateTime FechaInicio
        {
            get { return iFechaInicio; }
            set { iFechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return iFechaFin; }
            set { iFechaFin = value; }
        }

        public Banner ()
        {
            iFrecuencia = new List<Horario>();
            iFechaFin = new DateTime();
            iFechaInicio = new DateTime();
        }
    }
}
