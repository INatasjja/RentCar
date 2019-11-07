namespace RentCar
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.btnConsultaLCancelar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblTituloConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultaLCancelar
            // 
            this.btnConsultaLCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaLCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultaLCancelar.Location = new System.Drawing.Point(1012, 537);
            this.btnConsultaLCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaLCancelar.Name = "btnConsultaLCancelar";
            this.btnConsultaLCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnConsultaLCancelar.TabIndex = 35;
            this.btnConsultaLCancelar.Text = "Cancelar";
            this.btnConsultaLCancelar.UseVisualStyleBackColor = true;
            this.btnConsultaLCancelar.Click += new System.EventHandler(this.btnConsultaLCancelar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(16, 96);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(1116, 414);
            this.dgvConsulta.TabIndex = 32;
            // 
            // lblTituloConsulta
            // 
            this.lblTituloConsulta.AutoSize = true;
            this.lblTituloConsulta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsulta.Location = new System.Drawing.Point(13, 19);
            this.lblTituloConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloConsulta.Name = "lblTituloConsulta";
            this.lblTituloConsulta.Size = new System.Drawing.Size(191, 47);
            this.lblTituloConsulta.TabIndex = 31;
            this.lblTituloConsulta.Text = "Consulta";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1151, 598);
            this.Controls.Add(this.btnConsultaLCancelar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblTituloConsulta);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaLCancelar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblTituloConsulta;
    }
}