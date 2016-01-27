namespace CapaVisual
{
    partial class NuevaCampaña
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAgregarImágenes = new System.Windows.Forms.Button();
            this.lvImagenes = new System.Windows.Forms.ListView();
            this.abrirImagenes = new System.Windows.Forms.OpenFileDialog();
            this.bQuitarImagenes = new System.Windows.Forms.Button();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.labelHoras = new System.Windows.Forms.Label();
            this.labelMinutos = new System.Windows.Forms.Label();
            this.numMinutos = new System.Windows.Forms.NumericUpDown();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.numSegundos = new System.Windows.Forms.NumericUpDown();
            this.labelTiempoxImagen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundos)).BeginInit();
            this.SuspendLayout();
            // 
            // bAgregarImágenes
            // 
            this.bAgregarImágenes.Location = new System.Drawing.Point(123, 122);
            this.bAgregarImágenes.Name = "bAgregarImágenes";
            this.bAgregarImágenes.Size = new System.Drawing.Size(105, 36);
            this.bAgregarImágenes.TabIndex = 7;
            this.bAgregarImágenes.Text = "Agregar Imágenes";
            this.bAgregarImágenes.UseVisualStyleBackColor = true;
            this.bAgregarImágenes.Click += new System.EventHandler(this.bSeleccionarImágenes_Click);
            // 
            // lvImagenes
            // 
            this.lvImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvImagenes.Location = new System.Drawing.Point(357, 0);
            this.lvImagenes.Name = "lvImagenes";
            this.lvImagenes.ShowItemToolTips = true;
            this.lvImagenes.Size = new System.Drawing.Size(320, 249);
            this.lvImagenes.TabIndex = 8;
            this.lvImagenes.UseCompatibleStateImageBehavior = false;
            this.lvImagenes.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // abrirImagenes
            // 
            this.abrirImagenes.FileName = "abrirImagenes";
            this.abrirImagenes.FileOk += new System.ComponentModel.CancelEventHandler(this.abrirImagenes_FileOk);
            // 
            // bQuitarImagenes
            // 
            this.bQuitarImagenes.Location = new System.Drawing.Point(234, 122);
            this.bQuitarImagenes.Name = "bQuitarImagenes";
            this.bQuitarImagenes.Size = new System.Drawing.Size(105, 36);
            this.bQuitarImagenes.TabIndex = 9;
            this.bQuitarImagenes.Text = "Quitar Imágenes Seleccionadas";
            this.bQuitarImagenes.UseVisualStyleBackColor = true;
            this.bQuitarImagenes.Click += new System.EventHandler(this.bQuitarImagenes_Click);
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(128, 179);
            this.numHoras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(42, 20);
            this.numHoras.TabIndex = 10;
            this.numHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelHoras
            // 
            this.labelHoras.AutoSize = true;
            this.labelHoras.Location = new System.Drawing.Point(174, 181);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(19, 13);
            this.labelHoras.TabIndex = 11;
            this.labelHoras.Text = "hh";
            this.labelHoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.Location = new System.Drawing.Point(248, 181);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(23, 13);
            this.labelMinutos.TabIndex = 13;
            this.labelMinutos.Text = "mm";
            this.labelMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMinutos
            // 
            this.numMinutos.Location = new System.Drawing.Point(202, 179);
            this.numMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutos.Name = "numMinutos";
            this.numMinutos.Size = new System.Drawing.Size(42, 20);
            this.numMinutos.TabIndex = 12;
            this.numMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSegundos
            // 
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.Location = new System.Drawing.Point(323, 181);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(17, 13);
            this.labelSegundos.TabIndex = 15;
            this.labelSegundos.Text = "ss";
            this.labelSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numSegundos
            // 
            this.numSegundos.Location = new System.Drawing.Point(277, 179);
            this.numSegundos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSegundos.Name = "numSegundos";
            this.numSegundos.Size = new System.Drawing.Size(42, 20);
            this.numSegundos.TabIndex = 14;
            this.numSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTiempoxImagen
            // 
            this.labelTiempoxImagen.AutoSize = true;
            this.labelTiempoxImagen.Location = new System.Drawing.Point(15, 181);
            this.labelTiempoxImagen.Name = "labelTiempoxImagen";
            this.labelTiempoxImagen.Size = new System.Drawing.Size(102, 13);
            this.labelTiempoxImagen.TabIndex = 16;
            this.labelTiempoxImagen.Text = "Tiempo Por Imágen:";
            // 
            // NuevaCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(677, 249);
            this.Controls.Add(this.labelTiempoxImagen);
            this.Controls.Add(this.labelSegundos);
            this.Controls.Add(this.numSegundos);
            this.Controls.Add(this.labelMinutos);
            this.Controls.Add(this.numMinutos);
            this.Controls.Add(this.labelHoras);
            this.Controls.Add(this.numHoras);
            this.Controls.Add(this.bQuitarImagenes);
            this.Controls.Add(this.lvImagenes);
            this.Controls.Add(this.bAgregarImágenes);
            this.Name = "NuevaCampaña";
            this.Controls.SetChildIndex(this.bAgregarImágenes, 0);
            this.Controls.SetChildIndex(this.lvImagenes, 0);
            this.Controls.SetChildIndex(this.bQuitarImagenes, 0);
            this.Controls.SetChildIndex(this.numHoras, 0);
            this.Controls.SetChildIndex(this.labelHoras, 0);
            this.Controls.SetChildIndex(this.numMinutos, 0);
            this.Controls.SetChildIndex(this.labelMinutos, 0);
            this.Controls.SetChildIndex(this.numSegundos, 0);
            this.Controls.SetChildIndex(this.labelSegundos, 0);
            this.Controls.SetChildIndex(this.labelTiempoxImagen, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAgregarImágenes;
        private System.Windows.Forms.ListView lvImagenes;
        private System.Windows.Forms.OpenFileDialog abrirImagenes;
        private System.Windows.Forms.Button bQuitarImagenes;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.NumericUpDown numMinutos;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.NumericUpDown numSegundos;
        private System.Windows.Forms.Label labelTiempoxImagen;
    }
}
