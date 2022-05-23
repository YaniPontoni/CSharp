
namespace NuestroPrimerFormulario
{
    partial class frmCalcularAreaRectangulo
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
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.nmrcBase = new System.Windows.Forms.NumericUpDown();
            this.nmrcAltura = new System.Windows.Forms.NumericUpDown();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtBxRespuesta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcAltura)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(123, 86);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(71, 13);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Ingrese base:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(123, 116);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(74, 13);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Ingrese altura:";
            this.lblAltura.Click += new System.EventHandler(this.label1_Click);
            // 
            // nmrcBase
            // 
            this.nmrcBase.Location = new System.Drawing.Point(200, 84);
            this.nmrcBase.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmrcBase.Name = "nmrcBase";
            this.nmrcBase.Size = new System.Drawing.Size(120, 20);
            this.nmrcBase.TabIndex = 2;
            // 
            // nmrcAltura
            // 
            this.nmrcAltura.Location = new System.Drawing.Point(200, 116);
            this.nmrcAltura.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmrcAltura.Name = "nmrcAltura";
            this.nmrcAltura.Size = new System.Drawing.Size(120, 20);
            this.nmrcAltura.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(139, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Calculadora de area de rectangulo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(126, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(245, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(126, 203);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
            this.lblRespuesta.TabIndex = 7;
            // 
            // txtBxRespuesta
            // 
            this.txtBxRespuesta.Location = new System.Drawing.Point(175, 223);
            this.txtBxRespuesta.Name = "txtBxRespuesta";
            this.txtBxRespuesta.ReadOnly = true;
            this.txtBxRespuesta.Size = new System.Drawing.Size(100, 20);
            this.txtBxRespuesta.TabIndex = 8;
            this.txtBxRespuesta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCalcularAreaRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.txtBxRespuesta);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.nmrcAltura);
            this.Controls.Add(this.nmrcBase);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalcularAreaRectangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Area Rectangulo";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcAltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.NumericUpDown nmrcBase;
        private System.Windows.Forms.NumericUpDown nmrcAltura;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtBxRespuesta;
    }
}