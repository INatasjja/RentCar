namespace RentCar
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.lblTituloReporte = new System.Windows.Forms.Label();
            this.btnReporteLCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(12, 78);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.Size = new System.Drawing.Size(837, 336);
            this.dgvReporte.TabIndex = 27;
            // 
            // lblTituloReporte
            // 
            this.lblTituloReporte.AutoSize = true;
            this.lblTituloReporte.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporte.Location = new System.Drawing.Point(12, 9);
            this.lblTituloReporte.Name = "lblTituloReporte";
            this.lblTituloReporte.Size = new System.Drawing.Size(137, 38);
            this.lblTituloReporte.TabIndex = 26;
            this.lblTituloReporte.Text = "Reporte";
            // 
            // btnReporteLCancelar
            // 
            this.btnReporteLCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteLCancelar.Location = new System.Drawing.Point(759, 436);
            this.btnReporteLCancelar.Name = "btnReporteLCancelar";
            this.btnReporteLCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnReporteLCancelar.TabIndex = 30;
            this.btnReporteLCancelar.Text = "Cancelar";
            this.btnReporteLCancelar.UseVisualStyleBackColor = true;
            this.btnReporteLCancelar.Click += new System.EventHandler(this.btnReporteLCancelar_Click);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 486);
            this.Controls.Add(this.btnReporteLCancelar);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.lblTituloReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Label lblTituloReporte;
        private System.Windows.Forms.Button btnReporteLCancelar;
    }
}