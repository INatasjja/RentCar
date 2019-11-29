namespace RentCar
{
    partial class TipoVehicloCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoVehicloCrear));
            this.dgvTipoVehiculo = new System.Windows.Forms.DataGridView();
            this.lblTipoVehiculoTitulo = new System.Windows.Forms.Label();
            this.btnTipoVehiculoGuardar = new System.Windows.Forms.Button();
            this.btnTipoVehiculoEditar = new System.Windows.Forms.Button();
            this.btnTipoVehiculoEliminar = new System.Windows.Forms.Button();
            this.txtTipoVehiculoDescripcion = new System.Windows.Forms.TextBox();
            this.lblTipoVehiculoDescripcion = new System.Windows.Forms.Label();
            this.btnTipoVehiculoCancelar = new System.Windows.Forms.Button();
            this.lblTipoVehiculoId = new System.Windows.Forms.Label();
            this.lblTipoVehiculoBuscar = new System.Windows.Forms.Label();
            this.txtTipoVehiculoBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoVehiculo
            // 
            this.dgvTipoVehiculo.AllowUserToAddRows = false;
            this.dgvTipoVehiculo.AllowUserToDeleteRows = false;
            this.dgvTipoVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVehiculo.Location = new System.Drawing.Point(16, 139);
            this.dgvTipoVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTipoVehiculo.Name = "dgvTipoVehiculo";
            this.dgvTipoVehiculo.ReadOnly = true;
            this.dgvTipoVehiculo.Size = new System.Drawing.Size(401, 250);
            this.dgvTipoVehiculo.TabIndex = 0;
            // 
            // lblTipoVehiculoTitulo
            // 
            this.lblTipoVehiculoTitulo.AutoSize = true;
            this.lblTipoVehiculoTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTipoVehiculoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTipoVehiculoTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTipoVehiculoTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVehiculoTitulo.Name = "lblTipoVehiculoTitulo";
            this.lblTipoVehiculoTitulo.Size = new System.Drawing.Size(335, 46);
            this.lblTipoVehiculoTitulo.TabIndex = 17;
            this.lblTipoVehiculoTitulo.Text = "Tipo de Vehículo";
            // 
            // btnTipoVehiculoGuardar
            // 
            this.btnTipoVehiculoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTipoVehiculoGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoVehiculoGuardar.Location = new System.Drawing.Point(546, 187);
            this.btnTipoVehiculoGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoVehiculoGuardar.Name = "btnTipoVehiculoGuardar";
            this.btnTipoVehiculoGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnTipoVehiculoGuardar.TabIndex = 27;
            this.btnTipoVehiculoGuardar.Text = "Guardar";
            this.btnTipoVehiculoGuardar.UseVisualStyleBackColor = false;
            this.btnTipoVehiculoGuardar.Click += new System.EventHandler(this.btnTipoVehiculoGuardar_Click);
            // 
            // btnTipoVehiculoEditar
            // 
            this.btnTipoVehiculoEditar.BackColor = System.Drawing.Color.Salmon;
            this.btnTipoVehiculoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoVehiculoEditar.Location = new System.Drawing.Point(546, 231);
            this.btnTipoVehiculoEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoVehiculoEditar.Name = "btnTipoVehiculoEditar";
            this.btnTipoVehiculoEditar.Size = new System.Drawing.Size(120, 37);
            this.btnTipoVehiculoEditar.TabIndex = 28;
            this.btnTipoVehiculoEditar.Text = "Editar";
            this.btnTipoVehiculoEditar.UseVisualStyleBackColor = false;
            this.btnTipoVehiculoEditar.Click += new System.EventHandler(this.btnTipoVehiculoEditar_Click);
            // 
            // btnTipoVehiculoEliminar
            // 
            this.btnTipoVehiculoEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnTipoVehiculoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoVehiculoEliminar.Location = new System.Drawing.Point(546, 276);
            this.btnTipoVehiculoEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoVehiculoEliminar.Name = "btnTipoVehiculoEliminar";
            this.btnTipoVehiculoEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnTipoVehiculoEliminar.TabIndex = 29;
            this.btnTipoVehiculoEliminar.Text = "Eliminar";
            this.btnTipoVehiculoEliminar.UseVisualStyleBackColor = false;
            this.btnTipoVehiculoEliminar.Click += new System.EventHandler(this.btnTipoVehiculoEliminar_Click);
            // 
            // txtTipoVehiculoDescripcion
            // 
            this.txtTipoVehiculoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVehiculoDescripcion.Location = new System.Drawing.Point(449, 128);
            this.txtTipoVehiculoDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoVehiculoDescripcion.Name = "txtTipoVehiculoDescripcion";
            this.txtTipoVehiculoDescripcion.Size = new System.Drawing.Size(319, 30);
            this.txtTipoVehiculoDescripcion.TabIndex = 30;
            // 
            // lblTipoVehiculoDescripcion
            // 
            this.lblTipoVehiculoDescripcion.AutoSize = true;
            this.lblTipoVehiculoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculoDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblTipoVehiculoDescripcion.Location = new System.Drawing.Point(444, 94);
            this.lblTipoVehiculoDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVehiculoDescripcion.Name = "lblTipoVehiculoDescripcion";
            this.lblTipoVehiculoDescripcion.Size = new System.Drawing.Size(147, 29);
            this.lblTipoVehiculoDescripcion.TabIndex = 31;
            this.lblTipoVehiculoDescripcion.Text = "Descripción:";
            // 
            // btnTipoVehiculoCancelar
            // 
            this.btnTipoVehiculoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoVehiculoCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnTipoVehiculoCancelar.Location = new System.Drawing.Point(546, 320);
            this.btnTipoVehiculoCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoVehiculoCancelar.Name = "btnTipoVehiculoCancelar";
            this.btnTipoVehiculoCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnTipoVehiculoCancelar.TabIndex = 32;
            this.btnTipoVehiculoCancelar.Text = "Cancelar";
            this.btnTipoVehiculoCancelar.UseVisualStyleBackColor = true;
            this.btnTipoVehiculoCancelar.Click += new System.EventHandler(this.btnTipoVehiculoCancelar_Click);
            // 
            // lblTipoVehiculoId
            // 
            this.lblTipoVehiculoId.AutoSize = true;
            this.lblTipoVehiculoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTipoVehiculoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculoId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTipoVehiculoId.Location = new System.Drawing.Point(528, 62);
            this.lblTipoVehiculoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVehiculoId.Name = "lblTipoVehiculoId";
            this.lblTipoVehiculoId.Size = new System.Drawing.Size(243, 36);
            this.lblTipoVehiculoId.TabIndex = 49;
            this.lblTipoVehiculoId.Text = "Tip. Vehiculo ID";
            // 
            // lblTipoVehiculoBuscar
            // 
            this.lblTipoVehiculoBuscar.AutoSize = true;
            this.lblTipoVehiculoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculoBuscar.ForeColor = System.Drawing.Color.White;
            this.lblTipoVehiculoBuscar.Location = new System.Drawing.Point(20, 98);
            this.lblTipoVehiculoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVehiculoBuscar.Name = "lblTipoVehiculoBuscar";
            this.lblTipoVehiculoBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblTipoVehiculoBuscar.TabIndex = 51;
            this.lblTipoVehiculoBuscar.Text = "Buscar:";
            // 
            // txtTipoVehiculoBuscar
            // 
            this.txtTipoVehiculoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVehiculoBuscar.Location = new System.Drawing.Point(112, 95);
            this.txtTipoVehiculoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoVehiculoBuscar.Name = "txtTipoVehiculoBuscar";
            this.txtTipoVehiculoBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtTipoVehiculoBuscar.TabIndex = 50;
            this.txtTipoVehiculoBuscar.TextChanged += new System.EventHandler(this.txtTipoVehiculoBuscar_TextChanged);
            // 
            // TipoVehicloCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(793, 404);
            this.Controls.Add(this.lblTipoVehiculoBuscar);
            this.Controls.Add(this.txtTipoVehiculoBuscar);
            this.Controls.Add(this.lblTipoVehiculoId);
            this.Controls.Add(this.btnTipoVehiculoCancelar);
            this.Controls.Add(this.lblTipoVehiculoDescripcion);
            this.Controls.Add(this.txtTipoVehiculoDescripcion);
            this.Controls.Add(this.btnTipoVehiculoEliminar);
            this.Controls.Add(this.btnTipoVehiculoEditar);
            this.Controls.Add(this.btnTipoVehiculoGuardar);
            this.Controls.Add(this.lblTipoVehiculoTitulo);
            this.Controls.Add(this.dgvTipoVehiculo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoVehicloCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Tipo de Vehiclo";
            this.Load += new System.EventHandler(this.TipoVehicloCrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculoTitulo;
        private System.Windows.Forms.Button btnTipoVehiculoGuardar;
        private System.Windows.Forms.Button btnTipoVehiculoEditar;
        private System.Windows.Forms.Button btnTipoVehiculoEliminar;
        private System.Windows.Forms.TextBox txtTipoVehiculoDescripcion;
        private System.Windows.Forms.Label lblTipoVehiculoDescripcion;
        private System.Windows.Forms.Button btnTipoVehiculoCancelar;
        private System.Windows.Forms.Label lblTipoVehiculoId;
        private System.Windows.Forms.Label lblTipoVehiculoBuscar;
        private System.Windows.Forms.TextBox txtTipoVehiculoBuscar;
    }
}