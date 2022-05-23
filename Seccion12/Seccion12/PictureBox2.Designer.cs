
namespace Seccion12
{
    partial class PictureBox2
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
            this.pbImagen2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen2
            // 
            this.pbImagen2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen2.Location = new System.Drawing.Point(77, 12);
            this.pbImagen2.Name = "pbImagen2";
            this.pbImagen2.Size = new System.Drawing.Size(642, 426);
            this.pbImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen2.TabIndex = 0;
            this.pbImagen2.TabStop = false;
            // 
            // PictureBox2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbImagen2);
            this.Name = "PictureBox2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureBox2";
            this.Load += new System.EventHandler(this.PictureBox2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen2;
    }
}