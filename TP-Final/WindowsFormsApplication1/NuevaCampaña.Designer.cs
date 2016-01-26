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
            this.bSeleccionarImágenes = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bSeleccionarImágenes
            // 
            this.bSeleccionarImágenes.Location = new System.Drawing.Point(214, 122);
            this.bSeleccionarImágenes.Name = "bSeleccionarImágenes";
            this.bSeleccionarImágenes.Size = new System.Drawing.Size(105, 36);
            this.bSeleccionarImágenes.TabIndex = 7;
            this.bSeleccionarImágenes.Text = "Seleccionar Imágenes";
            this.bSeleccionarImágenes.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(332, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(325, 139);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // NuevaCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(677, 177);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bSeleccionarImágenes);
            this.Name = "NuevaCampaña";
            this.Controls.SetChildIndex(this.bSeleccionarImágenes, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSeleccionarImágenes;
        private System.Windows.Forms.ListView listView1;
    }
}
