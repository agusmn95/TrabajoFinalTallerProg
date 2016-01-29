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

namespace CapaVisual
{
    public partial class SeleccionarHorarios : Form
    {
        private List<Horario> iListaHorarios;
        
        public SeleccionarHorarios(List<Horario> pListaHorarios)
        {
            InitializeComponent();
            iListaHorarios = pListaHorarios;
            foreach (Horario elem in iListaHorarios)
            {
                //No tengo internet para ver como convertir de timespan a datetime o como hacer cuadros personalizados.
                DateTime elemInicio = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day, elem.HoraInicio.Hours, elem.HoraInicio.Minutes, elem.HoraInicio.Seconds);
                DateTime elemFin = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, elem.HoraFin.Hours, elem.HoraFin.Minutes, elem.HoraFin.Seconds);
                switch (elem.DiaSemana)
                {
                    case DiaSemana.Lunes:
                        {
                            cbLunes.Checked = true;
                            dtpLunesInicio.Value = elemInicio;
                            dtpLunesFin.Value = elemFin;
                            break;
                        }
                    case DiaSemana.Martes:
                        {
                            cbMartes.Checked = true;
                            dtpMartesInicio.Value = elemInicio;
                            dtpMartesFin.Value = elemFin;
                            break;
                        }
                    case DiaSemana.Miercoles:
                        {
                            cbMiercoles.Checked = true;
                            dtpMiercolesInicio.Value = elemInicio;
                            dtpMiercolesFin.Value = elemFin;
                            break;
                        }
                    case DiaSemana.Jueves:
                        {
                            cbJueves.Checked = true;
                            dtpJuevesInicio.Value = elemInicio;
                            dtpJuevesFin.Value = elemFin;
                            break;
                        }
                    case DiaSemana.Viernes:
                        {
                            cbViernes.Checked = true;
                            dtpViernesInicio.Value = elemInicio;
                            dtpViernesFin.Value = elemFin;
                            break;
                        }
                    case DiaSemana.Sabado:
                        {
                            cbSabado.Checked = true;
                            dtpSabadoInicio.Value = elemInicio;
                            dtpSabadoFin.Value = elemFin;
                            break;
                        }
                    case DiaSemana.Domingo:
                        {
                            cbDomingo.Checked = true;
                            dtpDomingoInicio.Value = elemInicio;
                            dtpDomingoFin.Value = elemFin;
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void cbLunes_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpLunesInicio.Visible = this.cbLunes.Checked;
            this.dtpLunesFin.Visible = this.cbLunes.Checked;
        }

        private void cbMartes_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpMartesInicio.Visible = this.cbMartes.Checked;
            this.dtpMartesFin.Visible = this.cbMartes.Checked;
        }

        private void cbMiercoles_CheckedChanged(object sender, EventArgs e)
        {
           this. dtpMiercolesInicio.Visible = this.cbMiercoles.Checked;
           this.dtpMiercolesFin.Visible = this.cbMiercoles.Checked;
        }

        private void cbJueves_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpJuevesInicio.Visible = this.cbJueves.Checked;
            this.dtpJuevesFin.Visible = this.cbJueves.Checked;
        }

        private void cbViernes_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpViernesInicio.Visible = this.cbViernes.Checked;
            this.dtpViernesFin.Visible = this.cbViernes.Checked;
        }

        private void cbSabado_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpSabadoInicio.Visible = this.cbSabado.Checked; ;
            this.dtpSabadoFin.Visible = this.cbSabado.Checked;
        }

        private void cbDomingo_CheckedChanged(object sender, EventArgs e)
        {
            this.dtpDomingoInicio.Visible = this.cbDomingo.Checked; ;
            this.dtpDomingoFin.Visible = this.cbDomingo.Checked; ;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (cbLunes.Checked)
            {
                iListaHorarios.Add(new Horario(
                                                DiaSemana.Lunes,
                                                new TimeSpan(dtpLunesInicio.Value.Hour, dtpLunesInicio.Value.Minute, 0),
                                                new TimeSpan(dtpLunesFin.Value.Hour, dtpLunesFin.Value.Minute, 0)
                                              )
                                   );
            }
            if (cbMartes.Checked)
            {
                iListaHorarios.Add(new Horario(
                                                DiaSemana.Martes,
                                                new TimeSpan(dtpMartesInicio.Value.Hour, dtpMartesInicio.Value.Minute, 0),
                                                new TimeSpan(dtpMartesFin.Value.Hour, dtpMartesFin.Value.Minute, 0)
                                              )
                                   );
            }
            if (cbMiercoles.Checked)
            {
                iListaHorarios.Add(new Horario(
                                                DiaSemana.Miercoles,
                                                new TimeSpan(dtpMiercolesInicio.Value.Hour, dtpMiercolesInicio.Value.Minute, 0),
                                                new TimeSpan(dtpMiercolesFin.Value.Hour, dtpMiercolesFin.Value.Minute, 0)
                                              )
                                   );
            }
            if (cbJueves.Checked)
            {
                iListaHorarios.Add(new Horario(
                                                DiaSemana.Jueves,
                                                new TimeSpan(dtpJuevesInicio.Value.Hour, dtpJuevesInicio.Value.Minute, 0),
                                                new TimeSpan(dtpJuevesFin.Value.Hour, dtpJuevesFin.Value.Minute, 0)
                                              )
                                   );
            }
            if (cbViernes.Checked)
            {
                iListaHorarios.Add(new Horario(
                                                DiaSemana.Viernes,
                                                new TimeSpan(dtpViernesInicio.Value.Hour, dtpViernesInicio.Value.Minute, 0),
                                                new TimeSpan(dtpViernesFin.Value.Hour, dtpViernesFin.Value.Minute, 0)
                                              )
                                   );
            }
            if (cbSabado.Checked)
            {
                iListaHorarios.Add(new Horario(
                                                DiaSemana.Sabado,
                                                new TimeSpan(dtpSabadoInicio.Value.Hour, dtpSabadoInicio.Value.Minute, 0),
                                                new TimeSpan(dtpSabadoFin.Value.Hour, dtpSabadoFin.Value.Minute, 0)
                                              )
                                   );
            }
            if (cbDomingo.Checked)
            {
                iListaHorarios.Add(new Horario(
                                                DiaSemana.Domingo,
                                                new TimeSpan(dtpDomingoInicio.Value.Hour, dtpDomingoInicio.Value.Minute, 0),
                                                new TimeSpan(dtpDomingoFin.Value.Hour, dtpDomingoFin.Value.Minute, 0)
                                              )
                                   );
            }
            this.Close();
        }
    }
}
