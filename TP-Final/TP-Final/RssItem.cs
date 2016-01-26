using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Final
{
    /// <summary>
    /// Ítem RSS.
    /// </summary>
    public class RssItem: Banner
    {
        //Atributos
        private string iTitulo;
        private string iDescripcion;
        private Uri iUrl;

        /// <summary>
        /// Título del ítem.
        /// </summary>
        public string Titulo
        {
            get { return this.iTitulo; }
            set { iTitulo = value; }
        }

        /// <summary>
        /// Descripción acerca del ítem.
        /// </summary>
        public String Descripcion
        {
            get { return this.iDescripcion; }
            set { iDescripcion = value; }
        }

        /// <summary>
        /// URL del ítem.
        /// </summary>
        public Uri Url
        {
            get { return this.iUrl; }
            set { iUrl = value; }
        }

        /// <summary>
        /// Fecha de publicación.
        /// </summary>
        public DateTime? FehcaPublicacion { get; set; }

        public string ObtenerCadena ()
        {
            return String.Format("{0} - {1}",this.Titulo,this.Descripcion);
        }

    }
}
