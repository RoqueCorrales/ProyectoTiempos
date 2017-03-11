namespace ProyectoTiempos.Vistas
{
    partial class FrmVerSorteos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumeroSorteo = new System.Windows.Forms.Label();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblFechaSorteo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbSorteo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione sorteo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFechaSorteo);
            this.panel1.Controls.Add(this.lblNumeros);
            this.panel1.Controls.Add(this.lblNumeroSorteo);
            this.panel1.Location = new System.Drawing.Point(143, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 247);
            this.panel1.TabIndex = 1;
            // 
            // lblNumeroSorteo
            // 
            this.lblNumeroSorteo.AutoSize = true;
            this.lblNumeroSorteo.Location = new System.Drawing.Point(3, 14);
            this.lblNumeroSorteo.Name = "lblNumeroSorteo";
            this.lblNumeroSorteo.Size = new System.Drawing.Size(104, 17);
            this.lblNumeroSorteo.TabIndex = 0;
            this.lblNumeroSorteo.Text = "Numero Sorteo";
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(3, 157);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(73, 17);
            this.lblNumeros.TabIndex = 4;
            this.lblNumeros.Text = "lblPremios";
            // 
            // lblFechaSorteo
            // 
            this.lblFechaSorteo.AutoSize = true;
            this.lblFechaSorteo.Location = new System.Drawing.Point(3, 88);
            this.lblFechaSorteo.Name = "lblFechaSorteo";
            this.lblFechaSorteo.Size = new System.Drawing.Size(47, 17);
            this.lblFechaSorteo.TabIndex = 6;
            this.lblFechaSorteo.Text = "Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(371, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbSorteo
            // 
            this.cbSorteo.FormattingEnabled = true;
            this.cbSorteo.Location = new System.Drawing.Point(207, 22);
            this.cbSorteo.Name = "cbSorteo";
            this.cbSorteo.Size = new System.Drawing.Size(121, 24);
            this.cbSorteo.TabIndex = 3;
            // 
            // FrmVerSorteos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 339);
            this.Controls.Add(this.cbSorteo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmVerSorteos";
            this.Text = "FrmVerSorteos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaSorteo;
        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblNumeroSorteo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbSorteo;
    }
}