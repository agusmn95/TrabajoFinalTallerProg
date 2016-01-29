using Common.Logging;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TP_Final;

namespace CapaVisual
{
    public partial class NuevoRSS : Form
    {
        private static readonly ILog cLogger = LogManager.GetLogger<NuevoRSS>();

        public NuevoRSS()
        {
            InitializeComponent();
            this.dataRss.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NuevoRSS_Load(object sender, EventArgs e)
        {
            // Simplemente se hace para que visualmente se vea la implementación de IRssReader que se está utilizando.
            this.lblStatus.Text = String.Format("Implementación IRssReader: {0}", IoCContainerLocator.Container.Resolve<IRssReader>().GetType().FullName);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.bgWorker.IsBusy)
                {
                    if (String.IsNullOrWhiteSpace(this.url.Text))
                    {
                        throw new ArgumentException("Debe ingresar una URL");
                    }

                    Uri mUrl;

                    if (!Uri.TryCreate(this.url.Text.Trim(), UriKind.Absolute, out mUrl))
                    {
                        throw new ArgumentException("La URL ingresada no es válida.");
                    }

                    cLogger.Info("Deshabilitando botón de actualización...");
                    this.btnAceptar.Enabled = false;

                    cLogger.Info("Cambiando a cursor de espera...");
                    this.Cursor = Cursors.WaitCursor;

                    cLogger.Info("Iniciando operación en worker thread...");
                    this.bgWorker.RunWorkerAsync(mUrl);
                }
            }
            catch (Exception bEx)
            {
                cLogger.Error("Se ha producido un error al intentar actualizar los feeds.", bEx);
                MessageBox.Show(bEx.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
