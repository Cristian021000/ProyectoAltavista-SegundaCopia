﻿
namespace ProyectoAltavista
{
    partial class MantenedorCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorCliente));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.label1Bnaco = new System.Windows.Forms.Label();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(60, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 62);
            this.button2.TabIndex = 53;
            this.button2.Text = "Registrar ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 62);
            this.button1.TabIndex = 52;
            this.button1.Text = "Lista";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(378, 397);
            this.bt2.Margin = new System.Windows.Forms.Padding(4);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(231, 62);
            this.bt2.TabIndex = 51;
            this.bt2.Text = "Regresar";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // label1Bnaco
            // 
            this.label1Bnaco.AutoSize = true;
            this.label1Bnaco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1Bnaco.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Bnaco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1Bnaco.Location = new System.Drawing.Point(411, 52);
            this.label1Bnaco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Bnaco.Name = "label1Bnaco";
            this.label1Bnaco.Size = new System.Drawing.Size(210, 97);
            this.label1Bnaco.TabIndex = 49;
            this.label1Bnaco.Text = "Menu";
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-14, -11);
            this.pictureBox1Fondo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(1119, 572);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 50;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 551);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.label1Bnaco);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenedorCliente";
            this.Text = "Mantenedor del Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Label label1Bnaco;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}

