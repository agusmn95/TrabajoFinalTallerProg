using System.Drawing;
using System;
namespace TP_Final
{
    public class ImagenCampaña
    {
        private string iRuta;
        private Image iImagen;

        //Constructor
        public ImagenCampaña(string pRuta)
        {
            iRuta = pRuta;
            iImagen = Image.FromFile(iRuta);
        }

        //Propiedades
        public string Ruta
        {
            get { return iRuta; }
            set
            {
                iRuta = value;
                iImagen = Image.FromFile(iRuta);
            }
        }
        public Image Imagen { get { return iImagen; } }
    }
}