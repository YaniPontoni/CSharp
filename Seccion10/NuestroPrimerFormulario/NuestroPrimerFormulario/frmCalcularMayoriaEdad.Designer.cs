
namespace NuestroPrimerFormulario
{
    partial class frmCalcularMayoriaEdad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblEdad = new System.Windows.Forms.Label();
            this.nmrcEdad = new System.Windows.Forms.NumericUpDown();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.errorEdad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(97, 40);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(72, 13);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Ingrese edad:";
            // 
            // nmrcEdad
            // 
            this.nmrcEdad.Location = new System.Drawing.Point(175, 38);
            this.nmrcEdad.Name = "nmrcEdad";
            this.nmrcEdad.Size = new System.Drawing.Size(120, 20);
            this.nmrcEdad.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(153, 82);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(100, 123);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
            this.lblRespuesta.TabIndex = 3;
            // 
            // errorEdad
            // 
            this.errorEdad.ContainerControl = this;
            // 
            // frmCalcularMayoriaEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 278);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.nmrcEdad);
            this.Controls.Add(this.lblEdad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalcularMayoriaEdad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular mayoria de edad";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown nmrcEdad;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.ErrorProvider errorEdad;
    }
}