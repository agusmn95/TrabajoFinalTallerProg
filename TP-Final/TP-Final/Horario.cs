using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final
{
    public class Horario
    {
        private TimeSpan iHoraInicio;
        private TimeSpan iHoraFin;
        private DiaSemana iDia;

        public TimeSpan HoraInicio { get { return iHoraInicio; } }
        public TimeSpan HoraFin { get { return iHoraFin; } }
        public DiaSemana DiaSemana { get { return iDia; } }

        public Horario(DiaSemana pDia, TimeSpan pHoraInicio, TimeSpan pHoraFin)
        {
            iDia = pDia;
            iHoraInicio = pHoraInicio;
            iHoraFin = pHoraFin;
        }
    }
}
