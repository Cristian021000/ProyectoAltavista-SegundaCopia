
namespace ProyectoAltavista
{
    partial class ConsultarSitiosInteres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarSitiosInteres));
            this.DataGridVerSitioInteres = new System.Windows.Forms.DataGridView();
            this.lbSitioInteres = new System.Windows.Forms.Label();
            this.txtIngresarCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.pictureBox1Fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerSitioInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridVerSitioInteres
            // 
            this.DataGridVerSitioInteres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVerSitioInteres.Location = new System.Drawing.Point(19, 134);
            this.DataGridVerSitioInteres.Name = "DataGridVerSitioInteres";
            this.DataGridVerSitioInteres.RowHeadersWidth = 51;
            this.DataGridVerSitioInteres.Size = new System.Drawing.Size(432, 297);
            this.DataGridVerSitioInteres.TabIndex = 0;
            // 
            // lbSitioInteres
            // 
            this.lbSitioInteres.AutoSize = true;
            this.lbSitioInteres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbSitioInteres.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSitioInteres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSitioInteres.Location = new System.Drawing.Point(172, 21);
            this.lbSitioInteres.Name = "lbSitioInteres";
            this.lbSitioInteres.Size = new System.Drawing.Size(536, 79);
            this.lbSitioInteres.TabIndex = 21;
            this.lbSitioInteres.Text = "Visita sitios de Interés";
            // 
            // txtIngresarCodigo
            // 
            this.txtIngresarCodigo.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarCodigo.Location = new System.Drawing.Point(473, 165);
            this.txtIngresarCodigo.Multiline = true;
            this.txtIngresarCodigo.Name = "txtIngresarCodigo";
            this.txtIngresarCodigo.Size = new System.Drawing.Size(294, 30);
            this.txtIngresarCodigo.TabIndex = 26;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(443, 109);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(361, 22);
            this.lbCodigo.TabIndex = 27;
            this.lbCodigo.Text = "Ingrese Codigo de Interés a Modificar";
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(532, 227);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(168, 30);
            this.btAceptar.TabIndex = 41;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1Fondo
            // 
            this.pictureBox1Fondo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1Fondo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Fondo.Image")));
            this.pictureBox1Fondo.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1Fondo.Name = "pictureBox1Fondo";
            this.pictureBox1Fondo.Size = new System.Drawing.Size(839, 465);
            this.pictureBox1Fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Fondo.TabIndex = 42;
            this.pictureBox1Fondo.TabStop = false;
            // 
            // ConsultarSitiosInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txtIngresarCodigo);
            this.Controls.Add(this.lbSitioInteres);
            this.Controls.Add(this.DataGridVerSitioInteres);
            this.Controls.Add(this.pictureBox1Fondo);
            this.Name = "ConsultarSitiosInteres";
            this.Text = "MVerSitiosInteres";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerSitioInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridVerSitioInteres;
        private System.Windows.Forms.Label lbSitioInteres;
        private System.Windows.Forms.TextBox txtIngresarCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.PictureBox pictureBox1Fondo;
    }
}