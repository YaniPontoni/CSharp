
namespace Seccion12
{
    partial class ListBoxDinamico
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
            this.lbCursos = new System.Windows.Forms.ListBox();
            this.lbFrutas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCursos
            // 
            this.lbCursos.FormattingEnabled = true;
            this.lbCursos.Location = new System.Drawing.Point(52, 36);
            this.lbCursos.Name = "lbCursos";
            this.lbCursos.Size = new System.Drawing.Size(155, 108);
            this.lbCursos.TabIndex = 0;
            // 
            // lbFrutas
            // 
            this.lbFrutas.FormattingEnabled = true;
            this.lbFrutas.Location = new System.Drawing.Point(259, 36);
            this.lbFrutas.Name = "lbFrutas";
            this.lbFrutas.Size = new System.Drawing.Size(156, 108);
            this.lbFrutas.TabIndex = 1;
            this.lbFrutas.SelectedIndexChanged += new System.EventHandler(this.lbFrutas_SelectedIndexChanged);
            // 
            // ListBoxDinamico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 363);
            this.Controls.Add(this.lbFrutas);
            this.Controls.Add(this.lbCursos);
            this.Name = "ListBoxDinamico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBoxDinamico";
            this.Load += new System.EventHandler(this.ListBoxDinamico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCursos;
        private System.Windows.Forms.ListBox lbFrutas;
    }
}