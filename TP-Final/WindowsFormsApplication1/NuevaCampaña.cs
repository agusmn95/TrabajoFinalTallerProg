using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaVisual
{
    public partial class NuevaCampaña : WindowsFormsApplication1.Programa
    {
        public NuevaCampaña()
        {
            InitializeComponent();
            abrirImagenes.Multiselect = true;
            lvImagenes.LargeImageList = new ImageList();
            lvImagenes.LargeImageList.ImageSize = new Size(128, 128);
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bSeleccionarImágenes_Click(object sender, EventArgs e)
        {
            abrirImagenes.Filter = "Todas las Imágenes|*.png;*.jpg;*.bmp";
            DialogResult result = abrirImagenes.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] rutas = abrirImagenes.FileNames;
                for (int i = 0; i < rutas.Length; i++)
                {
                    Image iImage = Image.FromFile(rutas[i]);
                    lvImagenes.LargeImageList.Images.Add(rutas[i], Image.FromFile(rutas[i]));
                    lvImagenes.Items.Add(rutas[i], rutas[i]);
                }
                
            }
        }

        private void abrirImagenes_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void bQuitarImagenes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvImagenes.SelectedItems.Count; i++)
            {
                ListViewItem item = lvImagenes.SelectedItems[i];
                lvImagenes.Items.Remove(item);
                lvImagenes.LargeImageList.Images.RemoveByKey(item.ImageKey);
            }
        }
    }
}
