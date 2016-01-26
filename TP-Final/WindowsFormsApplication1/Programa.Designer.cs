namespace WindowsFormsApplication1
{
    partial class Programa
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
            this.lFechaInicio = new System.Windows.Forms.Label();
            this.lFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.bSeleccionarHorarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.Location = new System.Drawing.Point(12, 23);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lFechaInicio.TabIndex = 2;
            this.lFechaInicio.Text = "Fecha Inicio:";
            // 
            // lFechaFin
            // 
            this.lFechaFin.AutoSize = true;
            this.lFechaFin.Location = new System.Drawing.Point(12, 78);
            this.lFechaFin.Name = "lFechaFin";
            this.lFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lFechaFin.TabIndex = 3;
            this.lFechaFin.Text = "Fecha Fin:";
            this.lFechaFin.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(119, 19);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 4;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(119, 74);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 5;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // bSeleccionarHorarios
            // 
            this.bSeleccionarHorarios.Location = new System.Drawing.Point(12, 122);
            this.bSeleccionarHorarios.Name = "bSeleccionarHorarios";
            this.bSeleccionarHorarios.Size = new System.Drawing.Size(105, 36);
            this.bSeleccionarHorarios.TabIndex = 6;
            this.bSeleccionarHorarios.Text = "Seleccionar Horarios";
            this.bSeleccionarHorarios.UseVisualStyleBackColor = true;
            this.bSeleccionarHorarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 177);
            this.Controls.Add(this.bSeleccionarHorarios);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lFechaFin);
            this.Controls.Add(this.lFechaInicio);
            this.Name = "Programa";
            this.Text = "Nueva";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lFechaInicio;
        private System.Windows.Forms.Label lFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button bSeleccionarHorarios;
    }
}

