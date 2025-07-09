namespace ParcialDos
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
            this.btnGenerarComprobantes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstResultadoComprobantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerarComprobantes
            // 
            this.btnGenerarComprobantes.Location = new System.Drawing.Point(22, 27);
            this.btnGenerarComprobantes.Name = "btnGenerarComprobantes";
            this.btnGenerarComprobantes.Size = new System.Drawing.Size(139, 40);
            this.btnGenerarComprobantes.TabIndex = 0;
            this.btnGenerarComprobantes.Text = "Generar comprobantes";
            this.btnGenerarComprobantes.UseVisualStyleBackColor = true;
            this.btnGenerarComprobantes.Click += new System.EventHandler(this.btnGenerarComprobantes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(22, 73);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // lstResultadoComprobantes
            // 
            this.lstResultadoComprobantes.FormattingEnabled = true;
            this.lstResultadoComprobantes.Location = new System.Drawing.Point(199, 27);
            this.lstResultadoComprobantes.Name = "lstResultadoComprobantes";
            this.lstResultadoComprobantes.Size = new System.Drawing.Size(507, 394);
            this.lstResultadoComprobantes.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 434);
            this.Controls.Add(this.lstResultadoComprobantes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarComprobantes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarComprobantes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstResultadoComprobantes;
    }
}

