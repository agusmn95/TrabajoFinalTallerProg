namespace TP_Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.vCampaña = new System.Windows.Forms.PictureBox();
            this.vBanner = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vCampaña)).BeginInit();
            this.SuspendLayout();
            // 
            // vCampaña
            // 
            this.vCampaña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vCampaña.Image = ((System.Drawing.Image)(resources.GetObject("vCampaña.Image")));
            this.vCampaña.InitialImage = null;
            this.vCampaña.Location = new System.Drawing.Point(12, 12);
            this.vCampaña.Name = "vCampaña";
            this.vCampaña.Size = new System.Drawing.Size(620, 266);
            this.vCampaña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vCampaña.TabIndex = 0;
            this.vCampaña.TabStop = false;
            // 
            // vBanner
            // 
            this.vBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vBanner.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.vBanner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vBanner.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.vBanner.Font = new System.Drawing.Font("AR CENA", 20F, System.Drawing.FontStyle.Bold);
            this.vBanner.ForeColor = System.Drawing.Color.Yellow;
            this.vBanner.Location = new System.Drawing.Point(12, 289);
            this.vBanner.MaxLength = 500000;
            this.vBanner.Name = "vBanner";
            this.vBanner.ReadOnly = true;
            this.vBanner.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.vBanner.Size = new System.Drawing.Size(620, 33);
            this.vBanner.TabIndex = 1;
            this.vBanner.Text = "UUUULTIMO MOMENTO!!! SE HABRÍA VISTO A LA REINA BATATA SENTADA EN UN TRONO DE LAT" +
    "A... SEGUIREMOS INFORMANDO";
            this.vBanner.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(644, 334);
            this.Controls.Add(this.vBanner);
            this.Controls.Add(this.vCampaña);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vCampaña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vCampaña;
        private System.Windows.Forms.TextBox vBanner;
    }
}

