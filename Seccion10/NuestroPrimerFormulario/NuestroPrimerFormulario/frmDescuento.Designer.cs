
namespace NuestroPrimerFormulario
{
    partial class frmDescuento
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
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nmrcPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grpBxDatos = new System.Windows.Forms.GroupBox();
            this.lblPrecioReal = new System.Windows.Forms.Label();
            this.txtBxPrecioReal = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtBxDescuento = new System.Windows.Forms.TextBox();
            this.lblPagoTotal = new System.Windows.Forms.Label();
            this.txtBxPagoTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPrecio)).BeginInit();
            this.grpBxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(80, 105);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(77, 13);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Ingrese precio:";
            // 
            // nmrcPrecio
            // 
            this.nmrcPrecio.Location = new System.Drawing.Point(163, 103);
            this.nmrcPrecio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmrcPrecio.Name = "nmrcPrecio";
            this.nmrcPrecio.Size = new System.Drawing.Size(120, 20);
            this.nmrcPrecio.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(121, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Calculadora de descuentos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(143, 144);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grpBxDatos
            // 
            this.grpBxDatos.Controls.Add(this.txtBxPagoTotal);
            this.grpBxDatos.Controls.Add(this.lblPagoTotal);
            this.grpBxDatos.Controls.Add(this.txtBxDescuento);
            this.grpBxDatos.Controls.Add(this.lblDescuento);
            this.grpBxDatos.Controls.Add(this.txtBxPrecioReal);
            this.grpBxDatos.Controls.Add(this.lblPrecioReal);
            this.grpBxDatos.Location = new System.Drawing.Point(83, 195);
            this.grpBxDatos.Name = "grpBxDatos";
            this.grpBxDatos.Size = new System.Drawing.Size(216, 125);
            this.grpBxDatos.TabIndex = 5;
            this.grpBxDatos.TabStop = false;
            this.grpBxDatos.Text = "Datos de venta";
            // 
            // lblPrecioReal
            // 
            this.lblPrecioReal.AutoSize = true;
            this.lblPrecioReal.Location = new System.Drawing.Point(23, 22);
            this.lblPrecioReal.Name = "lblPrecioReal";
            this.lblPrecioReal.Size = new System.Drawing.Size(60, 13);
            this.lblPrecioReal.TabIndex = 0;
            this.lblPrecioReal.Text = "Precio real:";
            // 
            // txtBxPrecioReal
            // 
            this.txtBxPrecioReal.Location = new System.Drawing.Point(91, 19);
            this.txtBxPrecioReal.Name = "txtBxPrecioReal";
            this.txtBxPrecioReal.ReadOnly = true;
            this.txtBxPrecioReal.Size = new System.Drawing.Size(100, 20);
            this.txtBxPrecioReal.TabIndex = 1;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(22, 51);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 2;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtBxDescuento
            // 
            this.txtBxDescuento.Location = new System.Drawing.Point(91, 48);
            this.txtBxDescuento.Name = "txtBxDescuento";
            this.txtBxDescuento.ReadOnly = true;
            this.txtBxDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtBxDescuento.TabIndex = 3;
            // 
            // lblPagoTotal
            // 
            this.lblPagoTotal.AutoSize = true;
            this.lblPagoTotal.Location = new System.Drawing.Point(12, 81);
            this.lblPagoTotal.Name = "lblPagoTotal";
            this.lblPagoTotal.Size = new System.Drawing.Size(73, 13);
            this.lblPagoTotal.TabIndex = 4;
            this.lblPagoTotal.Text = "Total a pagar:";
            // 
            // txtBxPagoTotal
            // 
            this.txtBxPagoTotal.Location = new System.Drawing.Point(91, 78);
            this.txtBxPagoTotal.Name = "txtBxPagoTotal";
            this.txtBxPagoTotal.ReadOnly = true;
            this.txtBxPagoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBxPagoTotal.TabIndex = 5;
            // 
            // frmDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 380);
            this.Controls.Add(this.grpBxDatos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.nmrcPrecio);
            this.Controls.Add(this.lblPrecio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDescuento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Descuento";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcPrecio)).EndInit();
            this.grpBxDatos.ResumeLayout(false);
            this.grpBxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nmrcPrecio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpBxDatos;
        private System.Windows.Forms.TextBox txtBxPagoTotal;
        private System.Windows.Forms.Label lblPagoTotal;
        private System.Windows.Forms.TextBox txtBxDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtBxPrecioReal;
        private System.Windows.Forms.Label lblPrecioReal;
    }
}