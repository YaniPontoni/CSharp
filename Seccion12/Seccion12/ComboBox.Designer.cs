
namespace Seccion12
{
    partial class ComboBox
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
            this.cmbBxPersonas = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnValue = new System.Windows.Forms.Button();
            this.btnMostrarValores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBxPersonas
            // 
            this.cmbBxPersonas.FormattingEnabled = true;
            this.cmbBxPersonas.Location = new System.Drawing.Point(46, 33);
            this.cmbBxPersonas.Name = "cmbBxPersonas";
            this.cmbBxPersonas.Size = new System.Drawing.Size(121, 21);
            this.cmbBxPersonas.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(187, 30);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(281, 30);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(90, 23);
            this.btnValue.TabIndex = 2;
            this.btnValue.Text = "MostrarValue";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // btnMostrarValores
            // 
            this.btnMostrarValores.Location = new System.Drawing.Point(388, 30);
            this.btnMostrarValores.Name = "btnMostrarValores";
            this.btnMostrarValores.Size = new System.Drawing.Size(90, 23);
            this.btnMostrarValores.TabIndex = 3;
            this.btnMostrarValores.Text = "MostrarValores";
            this.btnMostrarValores.UseVisualStyleBackColor = true;
            this.btnMostrarValores.Click += new System.EventHandler(this.btnMostrarValores_Click);
            // 
            // ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 270);
            this.Controls.Add(this.btnMostrarValores);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbBxPersonas);
            this.Name = "ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxPersonas;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnValue;
        private System.Windows.Forms.Button btnMostrarValores;
    }
}

