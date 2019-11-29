namespace RentCar
{
    partial class RentaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentaLista));
            this.lblTituloRentaL = new System.Windows.Forms.Label();
            this.btnRentaLCancelar = new System.Windows.Forms.Button();
            this.btnRentaLEliminar = new System.Windows.Forms.Button();
            this.btnRentaLEditar = new System.Windows.Forms.Button();
            this.dgvRenta = new System.Windows.Forms.DataGridView();
            this.lblRentaBuscar = new System.Windows.Forms.Label();
            this.txtRentaBuscar = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloRentaL
            // 
            this.lblTituloRentaL.AutoSize = true;
            this.lblTituloRentaL.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRentaL.ForeColor = System.Drawing.Color.White;
            this.lblTituloRentaL.Location = new System.Drawing.Point(16, 11);
            this.lblTituloRentaL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloRentaL.Name = "lblTituloRentaL";
            this.lblTituloRentaL.Size = new System.Drawing.Size(297, 47);
            this.lblTituloRentaL.TabIndex = 71;
            this.lblTituloRentaL.Text = "Lista de rentas";
            // 
            // btnRentaLCancelar
            // 
            this.btnRentaLCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentaLCancelar.Location = new System.Drawing.Point(1010, 537);
            this.btnRentaLCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentaLCancelar.Name = "btnRentaLCancelar";
            this.btnRentaLCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnRentaLCancelar.TabIndex = 75;
            this.btnRentaLCancelar.Text = "Cancelar";
            this.btnRentaLCancelar.UseVisualStyleBackColor = true;
            this.btnRentaLCancelar.Click += new System.EventHandler(this.btnRentaLCancelar_Click);
            // 
            // btnRentaLEliminar
            // 
            this.btnRentaLEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentaLEliminar.Location = new System.Drawing.Point(876, 537);
            this.btnRentaLEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentaLEliminar.Name = "btnRentaLEliminar";
            this.btnRentaLEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnRentaLEliminar.TabIndex = 74;
            this.btnRentaLEliminar.Text = "Eliminar";
            this.btnRentaLEliminar.UseVisualStyleBackColor = true;
            this.btnRentaLEliminar.Click += new System.EventHandler(this.btnRentaLEliminar_Click);
            // 
            // btnRentaLEditar
            // 
            this.btnRentaLEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentaLEditar.Location = new System.Drawing.Point(742, 537);
            this.btnRentaLEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentaLEditar.Name = "btnRentaLEditar";
            this.btnRentaLEditar.Size = new System.Drawing.Size(120, 37);
            this.btnRentaLEditar.TabIndex = 73;
            this.btnRentaLEditar.Text = "Editar";
            this.btnRentaLEditar.UseVisualStyleBackColor = true;
            this.btnRentaLEditar.Click += new System.EventHandler(this.btnRentaLEditar_Click);
            // 
            // dgvRenta
            // 
            this.dgvRenta.AllowUserToAddRows = false;
            this.dgvRenta.AllowUserToDeleteRows = false;
            this.dgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenta.Location = new System.Drawing.Point(16, 96);
            this.dgvRenta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.ReadOnly = true;
            this.dgvRenta.Size = new System.Drawing.Size(1116, 414);
            this.dgvRenta.TabIndex = 72;
            this.dgvRenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRenta_CellContentClick);
            // 
            // lblRentaBuscar
            // 
            this.lblRentaBuscar.AutoSize = true;
            this.lblRentaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentaBuscar.ForeColor = System.Drawing.Color.White;
            this.lblRentaBuscar.Location = new System.Drawing.Point(829, 31);
            this.lblRentaBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentaBuscar.Name = "lblRentaBuscar";
            this.lblRentaBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblRentaBuscar.TabIndex = 77;
            this.lblRentaBuscar.Text = "Buscar:";
            // 
            // txtRentaBuscar
            // 
            this.txtRentaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentaBuscar.Location = new System.Drawing.Point(921, 28);
            this.txtRentaBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentaBuscar.Name = "txtRentaBuscar";
            this.txtRentaBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtRentaBuscar.TabIndex = 76;
            this.txtRentaBuscar.TextChanged += new System.EventHandler(this.txtRentaBuscar_TextChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(608, 537);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(120, 37);
            this.btnExportar.TabIndex = 78;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // RentaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1151, 598);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblRentaBuscar);
            this.Controls.Add(this.txtRentaBuscar);
            this.Controls.Add(this.btnRentaLCancelar);
            this.Controls.Add(this.btnRentaLEliminar);
            this.Controls.Add(this.btnRentaLEditar);
            this.Controls.Add(this.dgvRenta);
            this.Controls.Add(this.lblTituloRentaL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentaLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Rentas";
            this.Load += new System.EventHandler(this.RentaLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRentaL;
        private System.Windows.Forms.Button btnRentaLCancelar;
        private System.Windows.Forms.Button btnRentaLEliminar;
        private System.Windows.Forms.Button btnRentaLEditar;
        private System.Windows.Forms.DataGridView dgvRenta;
        private System.Windows.Forms.Label lblRentaBuscar;
        private System.Windows.Forms.TextBox txtRentaBuscar;
        private System.Windows.Forms.Button btnExportar;
    }
}