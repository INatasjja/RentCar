namespace RentCar
{
    partial class VehiculoLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculoLista));
            this.btnVehiculoLCancelar = new System.Windows.Forms.Button();
            this.btnVehiculoLEliminar = new System.Windows.Forms.Button();
            this.btnVehiculoLEditar = new System.Windows.Forms.Button();
            this.lblVehiculoTitulo = new System.Windows.Forms.Label();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.lblVehiculoBuscar = new System.Windows.Forms.Label();
            this.txtVehiculoBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVehiculoLCancelar
            // 
            this.btnVehiculoLCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculoLCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnVehiculoLCancelar.Location = new System.Drawing.Point(1012, 537);
            this.btnVehiculoLCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoLCancelar.Name = "btnVehiculoLCancelar";
            this.btnVehiculoLCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnVehiculoLCancelar.TabIndex = 19;
            this.btnVehiculoLCancelar.Text = "Cancelar";
            this.btnVehiculoLCancelar.UseVisualStyleBackColor = true;
            this.btnVehiculoLCancelar.Click += new System.EventHandler(this.btnVehiculoLCancelar_Click);
            // 
            // btnVehiculoLEliminar
            // 
            this.btnVehiculoLEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnVehiculoLEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculoLEliminar.Location = new System.Drawing.Point(884, 537);
            this.btnVehiculoLEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoLEliminar.Name = "btnVehiculoLEliminar";
            this.btnVehiculoLEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnVehiculoLEliminar.TabIndex = 18;
            this.btnVehiculoLEliminar.Text = "Eliminar";
            this.btnVehiculoLEliminar.UseVisualStyleBackColor = false;
            this.btnVehiculoLEliminar.Click += new System.EventHandler(this.btnVehiculoLEliminar_Click);
            // 
            // btnVehiculoLEditar
            // 
            this.btnVehiculoLEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVehiculoLEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculoLEditar.Location = new System.Drawing.Point(756, 537);
            this.btnVehiculoLEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoLEditar.Name = "btnVehiculoLEditar";
            this.btnVehiculoLEditar.Size = new System.Drawing.Size(120, 37);
            this.btnVehiculoLEditar.TabIndex = 17;
            this.btnVehiculoLEditar.Text = "Editar";
            this.btnVehiculoLEditar.UseVisualStyleBackColor = false;
            this.btnVehiculoLEditar.Click += new System.EventHandler(this.btnVehiculoLEditar_Click);
            // 
            // lblVehiculoTitulo
            // 
            this.lblVehiculoTitulo.AutoSize = true;
            this.lblVehiculoTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblVehiculoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblVehiculoTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblVehiculoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculoTitulo.Name = "lblVehiculoTitulo";
            this.lblVehiculoTitulo.Size = new System.Drawing.Size(355, 46);
            this.lblVehiculoTitulo.TabIndex = 16;
            this.lblVehiculoTitulo.Text = "Lista de vehículos";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(16, 96);
            this.dgvVehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.Size = new System.Drawing.Size(1116, 414);
            this.dgvVehiculos.TabIndex = 15;
            // 
            // lblVehiculoBuscar
            // 
            this.lblVehiculoBuscar.AutoSize = true;
            this.lblVehiculoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoBuscar.ForeColor = System.Drawing.Color.White;
            this.lblVehiculoBuscar.Location = new System.Drawing.Point(831, 32);
            this.lblVehiculoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculoBuscar.Name = "lblVehiculoBuscar";
            this.lblVehiculoBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblVehiculoBuscar.TabIndex = 21;
            this.lblVehiculoBuscar.Text = "Buscar:";
            // 
            // txtVehiculoBuscar
            // 
            this.txtVehiculoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculoBuscar.Location = new System.Drawing.Point(923, 28);
            this.txtVehiculoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehiculoBuscar.Name = "txtVehiculoBuscar";
            this.txtVehiculoBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtVehiculoBuscar.TabIndex = 20;
            this.txtVehiculoBuscar.TextChanged += new System.EventHandler(this.txtVehiculoBuscar_TextChanged);
            // 
            // VehiculoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1151, 598);
            this.Controls.Add(this.lblVehiculoBuscar);
            this.Controls.Add(this.txtVehiculoBuscar);
            this.Controls.Add(this.btnVehiculoLCancelar);
            this.Controls.Add(this.btnVehiculoLEliminar);
            this.Controls.Add(this.btnVehiculoLEditar);
            this.Controls.Add(this.lblVehiculoTitulo);
            this.Controls.Add(this.dgvVehiculos);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehiculoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de vehiculos";
            this.Load += new System.EventHandler(this.VehiculoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVehiculoLCancelar;
        private System.Windows.Forms.Button btnVehiculoLEliminar;
        private System.Windows.Forms.Button btnVehiculoLEditar;
        private System.Windows.Forms.Label lblVehiculoTitulo;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Label lblVehiculoBuscar;
        private System.Windows.Forms.TextBox txtVehiculoBuscar;
    }
}