
namespace AterrizarObserver
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
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.lstVuelos = new System.Windows.Forms.ListBox();
            this.lstHotel = new System.Windows.Forms.ListBox();
            this.lstNotificaciones = new System.Windows.Forms.ListBox();
            this.BtnSuscribirVuelo = new System.Windows.Forms.Button();
            this.BtnDesuscribirVuelo = new System.Windows.Forms.Button();
            this.BtnSuscribirHotel = new System.Windows.Forms.Button();
            this.BtnDesuscribirHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.ItemHeight = 16;
            this.lstUsuarios.Location = new System.Drawing.Point(12, 168);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(224, 244);
            this.lstUsuarios.TabIndex = 0;
            this.lstUsuarios.SelectedValueChanged += new System.EventHandler(this.lstUsuarios_SelectedValueChanged);
            // 
            // lstVuelos
            // 
            this.lstVuelos.FormattingEnabled = true;
            this.lstVuelos.ItemHeight = 16;
            this.lstVuelos.Location = new System.Drawing.Point(408, 29);
            this.lstVuelos.Name = "lstVuelos";
            this.lstVuelos.Size = new System.Drawing.Size(224, 244);
            this.lstVuelos.TabIndex = 1;
            this.lstVuelos.SelectedValueChanged += new System.EventHandler(this.lstVuelos_SelectedValueChanged);
            this.lstVuelos.DoubleClick += new System.EventHandler(this.lstVuelos_DoubleClick);
            // 
            // lstHotel
            // 
            this.lstHotel.FormattingEnabled = true;
            this.lstHotel.ItemHeight = 16;
            this.lstHotel.Location = new System.Drawing.Point(408, 295);
            this.lstHotel.Name = "lstHotel";
            this.lstHotel.Size = new System.Drawing.Size(224, 244);
            this.lstHotel.TabIndex = 2;
            this.lstHotel.SelectedValueChanged += new System.EventHandler(this.lstHotel_SelectedValueChanged);
            this.lstHotel.DoubleClick += new System.EventHandler(this.lstHotel_DoubleClick);
            // 
            // lstNotificaciones
            // 
            this.lstNotificaciones.FormattingEnabled = true;
            this.lstNotificaciones.ItemHeight = 16;
            this.lstNotificaciones.Location = new System.Drawing.Point(665, 158);
            this.lstNotificaciones.Name = "lstNotificaciones";
            this.lstNotificaciones.Size = new System.Drawing.Size(696, 292);
            this.lstNotificaciones.TabIndex = 3;
            // 
            // BtnSuscribirVuelo
            // 
            this.BtnSuscribirVuelo.Location = new System.Drawing.Point(282, 91);
            this.BtnSuscribirVuelo.Name = "BtnSuscribirVuelo";
            this.BtnSuscribirVuelo.Size = new System.Drawing.Size(107, 29);
            this.BtnSuscribirVuelo.TabIndex = 4;
            this.BtnSuscribirVuelo.Text = "Suscribir";
            this.BtnSuscribirVuelo.UseVisualStyleBackColor = true;
            this.BtnSuscribirVuelo.Click += new System.EventHandler(this.BtnSuscribirVuelo_Click);
            // 
            // BtnDesuscribirVuelo
            // 
            this.BtnDesuscribirVuelo.Location = new System.Drawing.Point(282, 126);
            this.BtnDesuscribirVuelo.Name = "BtnDesuscribirVuelo";
            this.BtnDesuscribirVuelo.Size = new System.Drawing.Size(107, 29);
            this.BtnDesuscribirVuelo.TabIndex = 5;
            this.BtnDesuscribirVuelo.Text = "Desuscribir";
            this.BtnDesuscribirVuelo.UseVisualStyleBackColor = true;
            this.BtnDesuscribirVuelo.Click += new System.EventHandler(this.BtnDesuscribirVuelo_Click);
            // 
            // BtnSuscribirHotel
            // 
            this.BtnSuscribirHotel.Location = new System.Drawing.Point(282, 362);
            this.BtnSuscribirHotel.Name = "BtnSuscribirHotel";
            this.BtnSuscribirHotel.Size = new System.Drawing.Size(107, 31);
            this.BtnSuscribirHotel.TabIndex = 6;
            this.BtnSuscribirHotel.Text = "Suscribir";
            this.BtnSuscribirHotel.UseVisualStyleBackColor = true;
            this.BtnSuscribirHotel.Click += new System.EventHandler(this.BtnSuscribirHotel_Click);
            // 
            // BtnDesuscribirHotel
            // 
            this.BtnDesuscribirHotel.Location = new System.Drawing.Point(282, 404);
            this.BtnDesuscribirHotel.Name = "BtnDesuscribirHotel";
            this.BtnDesuscribirHotel.Size = new System.Drawing.Size(107, 31);
            this.BtnDesuscribirHotel.TabIndex = 7;
            this.BtnDesuscribirHotel.Text = "Desuscribir";
            this.BtnDesuscribirHotel.UseVisualStyleBackColor = true;
            this.BtnDesuscribirHotel.Click += new System.EventHandler(this.BtnDesuscribirHotel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 677);
            this.Controls.Add(this.BtnDesuscribirHotel);
            this.Controls.Add(this.BtnSuscribirHotel);
            this.Controls.Add(this.BtnDesuscribirVuelo);
            this.Controls.Add(this.BtnSuscribirVuelo);
            this.Controls.Add(this.lstNotificaciones);
            this.Controls.Add(this.lstHotel);
            this.Controls.Add(this.lstVuelos);
            this.Controls.Add(this.lstUsuarios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.ListBox lstVuelos;
        private System.Windows.Forms.ListBox lstHotel;
        private System.Windows.Forms.ListBox lstNotificaciones;
        private System.Windows.Forms.Button BtnSuscribirVuelo;
        private System.Windows.Forms.Button BtnDesuscribirVuelo;
        private System.Windows.Forms.Button BtnSuscribirHotel;
        private System.Windows.Forms.Button BtnDesuscribirHotel;
    }
}

