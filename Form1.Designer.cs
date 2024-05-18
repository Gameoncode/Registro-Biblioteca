
namespace Registro
{
    partial class FRMInicio
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
            this.BTInicioSesion = new System.Windows.Forms.Button();
            this.BTRegistro = new System.Windows.Forms.Button();
            this.lblRelog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTInicioSesion
            // 
            this.BTInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTInicioSesion.Location = new System.Drawing.Point(198, 205);
            this.BTInicioSesion.Name = "BTInicioSesion";
            this.BTInicioSesion.Size = new System.Drawing.Size(163, 125);
            this.BTInicioSesion.TabIndex = 0;
            this.BTInicioSesion.Text = "Inicio de Sesion";
            this.BTInicioSesion.UseVisualStyleBackColor = true;
            this.BTInicioSesion.Click += new System.EventHandler(this.BTInicioSesion_Click);
            // 
            // BTRegistro
            // 
            this.BTRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegistro.Location = new System.Drawing.Point(404, 205);
            this.BTRegistro.Name = "BTRegistro";
            this.BTRegistro.Size = new System.Drawing.Size(187, 125);
            this.BTRegistro.TabIndex = 1;
            this.BTRegistro.Text = "Registro";
            this.BTRegistro.UseVisualStyleBackColor = true;
            this.BTRegistro.Click += new System.EventHandler(this.BTRegistro_Click);
            // 
            // lblRelog
            // 
            this.lblRelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelog.Location = new System.Drawing.Point(12, 9);
            this.lblRelog.Name = "lblRelog";
            this.lblRelog.Size = new System.Drawing.Size(148, 74);
            this.lblRelog.TabIndex = 2;
            this.lblRelog.Text = "label1";
            // 
            // FRMInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRelog);
            this.Controls.Add(this.BTRegistro);
            this.Controls.Add(this.BTInicioSesion);
            this.Name = "FRMInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRMInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTInicioSesion;
        private System.Windows.Forms.Button BTRegistro;
        private System.Windows.Forms.Label lblRelog;
    }
}

