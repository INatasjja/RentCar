namespace RentCar
{
    partial class MarcaVehiculoCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcaVehiculoCrear));
            this.lblMarcaDescripcion = new System.Windows.Forms.Label();
            this.txtMarcaDescripcion = new System.Windows.Forms.TextBox();
            this.btnMarcaEliminar = new System.Windows.Forms.Button();
            this.btnMarcaEditar = new System.Windows.Forms.Button();
            this.btnMarcaGuardar = new System.Windows.Forms.Button();
            this.lblMarcaTitulo = new System.Windows.Forms.Label();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.btnMarcaCancelar = new System.Windows.Forms.Button();
            this.lblMarcaId = new System.Windows.Forms.Label();
            this.lblMarcaVehiculoBuscar = new System.Windows.Forms.Label();
            this.txtMarcaVehiculoBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarcaDescripcion
            // 
            this.lblMarcaDescripcion.AutoSize = true;
            this.lblMarcaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblMarcaDescripcion.Location = new System.Drawing.Point(452, 48);
            this.lblMarcaDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaDescripcion.Name = "lblMarcaDescripcion";
            this.lblMarcaDescripcion.Size = new System.Drawing.Size(282, 29);
            this.lblMarcaDescripcion.TabIndex = 45;
            this.lblMarcaDescripcion.Text = "Descripción del vehículo:";
            // 
            // txtMarcaDescripcion
            // 
            this.txtMarcaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaDescripcion.Location = new System.Drawing.Point(457, 93);
            this.txtMarcaDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarcaDescripcion.Name = "txtMarcaDescripcion";
            this.txtMarcaDescripcion.Size = new System.Drawing.Size(319, 30);
            this.txtMarcaDescripcion.TabIndex = 44;
            // 
            // btnMarcaEliminar
            // 
            this.btnMarcaEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnMarcaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaEliminar.ForeColor = System.Drawing.Color.White;
            this.btnMarcaEliminar.Location = new System.Drawing.Point(536, 264);
            this.btnMarcaEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarcaEliminar.Name = "btnMarcaEliminar";
            this.btnMarcaEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnMarcaEliminar.TabIndex = 43;
            this.btnMarcaEliminar.Text = "Eliminar";
            this.btnMarcaEliminar.UseVisualStyleBackColor = false;
            this.btnMarcaEliminar.Click += new System.EventHandler(this.btnMarcaEliminar_Click);
            // 
            // btnMarcaEditar
            // 
            this.btnMarcaEditar.BackColor = System.Drawing.Color.LightSalmon;
            this.btnMarcaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaEditar.ForeColor = System.Drawing.Color.White;
            this.btnMarcaEditar.Location = new System.Drawing.Point(536, 219);
            this.btnMarcaEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarcaEditar.Name = "btnMarcaEditar";
            this.btnMarcaEditar.Size = new System.Drawing.Size(120, 37);
            this.btnMarcaEditar.TabIndex = 42;
            this.btnMarcaEditar.Text = "Editar";
            this.btnMarcaEditar.UseVisualStyleBackColor = false;
            this.btnMarcaEditar.Click += new System.EventHandler(this.btnMarcaEditar_Click);
            // 
            // btnMarcaGuardar
            // 
            this.btnMarcaGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMarcaGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaGuardar.ForeColor = System.Drawing.Color.White;
            this.btnMarcaGuardar.Location = new System.Drawing.Point(536, 175);
            this.btnMarcaGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarcaGuardar.Name = "btnMarcaGuardar";
            this.btnMarcaGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnMarcaGuardar.TabIndex = 41;
            this.btnMarcaGuardar.Text = "Guardar";
            this.btnMarcaGuardar.UseVisualStyleBackColor = false;
            this.btnMarcaGuardar.Click += new System.EventHandler(this.btnMarcaGuardar_Click);
            // 
            // lblMarcaTitulo
            // 
            this.lblMarcaTitulo.AutoSize = true;
            this.lblMarcaTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaTitulo.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaTitulo.ForeColor = System.Drawing.Color.White;
            this.lblMarcaTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblMarcaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaTitulo.Name = "lblMarcaTitulo";
            this.lblMarcaTitulo.Size = new System.Drawing.Size(172, 41);
            this.lblMarcaTitulo.TabIndex = 40;
            this.lblMarcaTitulo.Text = "Vehículo";
            this.lblMarcaTitulo.Click += new System.EventHandler(this.lblMarcaTitulo_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AllowUserToAddRows = false;
            this.dgvMarca.AllowUserToDeleteRows = false;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(16, 139);
            this.dgvMarca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.Size = new System.Drawing.Size(401, 250);
            this.dgvMarca.TabIndex = 39;
            // 
            // btnMarcaCancelar
            // 
            this.btnMarcaCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaCancelar.Location = new System.Drawing.Point(536, 308);
            this.btnMarcaCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarcaCancelar.Name = "btnMarcaCancelar";
            this.btnMarcaCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnMarcaCancelar.TabIndex = 46;
            this.btnMarcaCancelar.Text = "Cancelar";
            this.btnMarcaCancelar.UseVisualStyleBackColor = true;
            this.btnMarcaCancelar.Click += new System.EventHandler(this.btnMarcaCancelar_Click);
            // 
            // lblMarcaId
            // 
            this.lblMarcaId.AutoSize = true;
            this.lblMarcaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMarcaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMarcaId.Location = new System.Drawing.Point(623, 15);
            this.lblMarcaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaId.Name = "lblMarcaId";
            this.lblMarcaId.Size = new System.Drawing.Size(142, 36);
            this.lblMarcaId.TabIndex = 47;
            this.lblMarcaId.Text = "Marca ID";
            // 
            // lblMarcaVehiculoBuscar
            // 
            this.lblMarcaVehiculoBuscar.AutoSize = true;
            this.lblMarcaVehiculoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaVehiculoBuscar.ForeColor = System.Drawing.Color.White;
            this.lblMarcaVehiculoBuscar.Location = new System.Drawing.Point(16, 98);
            this.lblMarcaVehiculoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaVehiculoBuscar.Name = "lblMarcaVehiculoBuscar";
            this.lblMarcaVehiculoBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblMarcaVehiculoBuscar.TabIndex = 49;
            this.lblMarcaVehiculoBuscar.Text = "Buscar:";
            // 
            // txtMarcaVehiculoBuscar
            // 
            this.txtMarcaVehiculoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaVehiculoBuscar.Location = new System.Drawing.Point(108, 95);
            this.txtMarcaVehiculoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarcaVehiculoBuscar.Name = "txtMarcaVehiculoBuscar";
            this.txtMarcaVehiculoBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtMarcaVehiculoBuscar.TabIndex = 48;
            this.txtMarcaVehiculoBuscar.TextChanged += new System.EventHandler(this.txtMarcaVehiculoBuscar_TextChanged);
            // 
            // MarcaVehiculoCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(793, 404);
            this.Controls.Add(this.lblMarcaVehiculoBuscar);
            this.Controls.Add(this.txtMarcaVehiculoBuscar);
            this.Controls.Add(this.lblMarcaId);
            this.Controls.Add(this.btnMarcaCancelar);
            this.Controls.Add(this.lblMarcaDescripcion);
            this.Controls.Add(this.txtMarcaDescripcion);
            this.Controls.Add(this.btnMarcaEliminar);
            this.Controls.Add(this.btnMarcaEditar);
            this.Controls.Add(this.btnMarcaGuardar);
            this.Controls.Add(this.lblMarcaTitulo);
            this.Controls.Add(this.dgvMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarcaVehiculoCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Marca de Vehiculo";
            this.Load += new System.EventHandler(this.MarcaVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcaDescripcion;
        private System.Windows.Forms.TextBox txtMarcaDescripcion;
        private System.Windows.Forms.Button btnMarcaEliminar;
        private System.Windows.Forms.Button btnMarcaEditar;
        private System.Windows.Forms.Button btnMarcaGuardar;
        private System.Windows.Forms.Label lblMarcaTitulo;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button btnMarcaCancelar;
        private System.Windows.Forms.Label lblMarcaId;
        private System.Windows.Forms.Label lblMarcaVehiculoBuscar;
        private System.Windows.Forms.TextBox txtMarcaVehiculoBuscar;
    }
}