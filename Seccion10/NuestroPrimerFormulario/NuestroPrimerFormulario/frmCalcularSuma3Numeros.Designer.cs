
namespace NuestroPrimerFormulario
{
    partial class frmCalcularSuma3Numeros
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.NUDNumero1 = new System.Windows.Forms.NumericUpDown();
            this.NUDNumero2 = new System.Windows.Forms.NumericUpDown();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.NUDNumero3 = new System.Windows.Forms.NumericUpDown();
            this.lblNumero3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumero3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(147, 77);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(92, 13);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Ingrese numero 1:";
            // 
            // NUDNumero1
            // 
            this.NUDNumero1.Location = new System.Drawing.Point(246, 75);
            this.NUDNumero1.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NUDNumero1.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.NUDNumero1.Name = "NUDNumero1";
            this.NUDNumero1.Size = new System.Drawing.Size(120, 20);
            this.NUDNumero1.TabIndex = 1;
            this.NUDNumero1.ValueChanged += new System.EventHandler(this.NUDNumero1_ValueChanged);
            // 
            // NUDNumero2
            // 
            this.NUDNumero2.Location = new System.Drawing.Point(246, 102);
            this.NUDNumero2.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NUDNumero2.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.NUDNumero2.Name = "NUDNumero2";
            this.NUDNumero2.Size = new System.Drawing.Size(120, 20);
            this.NUDNumero2.TabIndex = 3;
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(147, 104);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(92, 13);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Ingrese numero 2:";
            // 
            // NUDNumero3
            // 
            this.NUDNumero3.Location = new System.Drawing.Point(246, 131);
            this.NUDNumero3.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NUDNumero3.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.NUDNumero3.Name = "NUDNumero3";
            this.NUDNumero3.Size = new System.Drawing.Size(120, 20);
            this.NUDNumero3.TabIndex = 5;
            // 
            // lblNumero3
            // 
            this.lblNumero3.AutoSize = true;
            this.lblNumero3.Location = new System.Drawing.Point(147, 133);
            this.lblNumero3.Name = "lblNumero3";
            this.lblNumero3.Size = new System.Drawing.Size(92, 13);
            this.lblNumero3.TabIndex = 4;
            this.lblNumero3.Text = "Ingrese numero 3:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(147, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Introduzca tres numeros para realizar la sumatoria";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(150, 181);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(291, 181);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(147, 228);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(0, 13);
            this.lblRespuesta.TabIndex = 9;
            // 
            // frmCalcularSuma3Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(514, 389);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.NUDNumero3);
            this.Controls.Add(this.lblNumero3);
            this.Controls.Add(this.NUDNumero2);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.NUDNumero1);
            this.Controls.Add(this.lblNumero1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalcularSuma3Numeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Basica";
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumero3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.NumericUpDown NUDNumero1;
        private System.Windows.Forms.NumericUpDown NUDNumero2;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.NumericUpDown NUDNumero3;
        private System.Windows.Forms.Label lblNumero3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblRespuesta;
    }
}