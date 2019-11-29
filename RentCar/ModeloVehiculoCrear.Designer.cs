namespace RentCar
{
    partial class ModeloVehiculoCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeloVehiculoCrear));
            this.lblModeloDescripcion = new System.Windows.Forms.Label();
            this.txtModeloDescripcion = new System.Windows.Forms.TextBox();
            this.btnModeloEliminar = new System.Windows.Forms.Button();
            this.btnModeloEditar = new System.Windows.Forms.Button();
            this.btnModeloGuardar = new System.Windows.Forms.Button();
            this.lblMarcaTitulo = new System.Windows.Forms.Label();
            this.dgvModelo = new System.Windows.Forms.DataGridView();
            this.lblModeloMarca = new System.Windows.Forms.Label();
            this.cbModeloMarca = new System.Windows.Forms.ComboBox();
            this.btnModeloCancelar = new System.Windows.Forms.Button();
            this.lblModeloId = new System.Windows.Forms.Label();
            this.lblModeloVehiculoBuscar = new System.Windows.Forms.Label();
            this.txtModeloVehiculoBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModeloDescripcion
            // 
            this.lblModeloDescripcion.AutoSize = true;
            this.lblModeloDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblModeloDescripcion.Location = new System.Drawing.Point(518, 58);
            this.lblModeloDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeloDescripcion.Name = "lblModeloDescripcion";
            this.lblModeloDescripcion.Size = new System.Drawing.Size(147, 29);
            this.lblModeloDescripcion.TabIndex = 52;
            this.lblModeloDescripcion.Text = "Descripcion:";
            // 
            // txtModeloDescripcion
            // 
            this.txtModeloDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloDescripcion.Location = new System.Drawing.Point(535, 102);
            this.txtModeloDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtModeloDescripcion.Name = "txtModeloDescripcion";
            this.txtModeloDescripcion.Size = new System.Drawing.Size(247, 30);
            this.txtModeloDescripcion.TabIndex = 51;
            // 
            // btnModeloEliminar
            // 
            this.btnModeloEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnModeloEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeloEliminar.Location = new System.Drawing.Point(662, 273);
            this.btnModeloEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeloEliminar.Name = "btnModeloEliminar";
            this.btnModeloEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnModeloEliminar.TabIndex = 50;
            this.btnModeloEliminar.Text = "Eliminar";
            this.btnModeloEliminar.UseVisualStyleBackColor = false;
            this.btnModeloEliminar.Click += new System.EventHandler(this.btnModeloEliminar_Click);
            // 
            // btnModeloEditar
            // 
            this.btnModeloEditar.BackColor = System.Drawing.Color.Salmon;
            this.btnModeloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeloEditar.Location = new System.Drawing.Point(535, 318);
            this.btnModeloEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeloEditar.Name = "btnModeloEditar";
            this.btnModeloEditar.Size = new System.Drawing.Size(120, 37);
            this.btnModeloEditar.TabIndex = 49;
            this.btnModeloEditar.Text = "Editar";
            this.btnModeloEditar.UseVisualStyleBackColor = false;
            this.btnModeloEditar.Click += new System.EventHandler(this.btnModeloEditar_Click);
            // 
            // btnModeloGuardar
            // 
            this.btnModeloGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModeloGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeloGuardar.Location = new System.Drawing.Point(534, 273);
            this.btnModeloGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeloGuardar.Name = "btnModeloGuardar";
            this.btnModeloGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnModeloGuardar.TabIndex = 48;
            this.btnModeloGuardar.Text = "Guardar";
            this.btnModeloGuardar.UseVisualStyleBackColor = false;
            this.btnModeloGuardar.Click += new System.EventHandler(this.btnModeloGuardar_Click);
            // 
            // lblMarcaTitulo
            // 
            this.lblMarcaTitulo.AutoSize = true;
            this.lblMarcaTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMarcaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaTitulo.ForeColor = System.Drawing.Color.White;
            this.lblMarcaTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblMarcaTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaTitulo.Name = "lblMarcaTitulo";
            this.lblMarcaTitulo.Size = new System.Drawing.Size(318, 46);
            this.lblMarcaTitulo.TabIndex = 47;
            this.lblMarcaTitulo.Text = "Agregar Modelo";
            // 
            // dgvModelo
            // 
            this.dgvModelo.AllowUserToAddRows = false;
            this.dgvModelo.AllowUserToDeleteRows = false;
            this.dgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelo.Location = new System.Drawing.Point(16, 118);
            this.dgvModelo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvModelo.Name = "dgvModelo";
            this.dgvModelo.ReadOnly = true;
            this.dgvModelo.Size = new System.Drawing.Size(401, 250);
            this.dgvModelo.TabIndex = 46;
            // 
            // lblModeloMarca
            // 
            this.lblModeloMarca.AutoSize = true;
            this.lblModeloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloMarca.ForeColor = System.Drawing.Color.White;
            this.lblModeloMarca.Location = new System.Drawing.Point(518, 170);
            this.lblModeloMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeloMarca.Name = "lblModeloMarca";
            this.lblModeloMarca.Size = new System.Drawing.Size(85, 29);
            this.lblModeloMarca.TabIndex = 53;
            this.lblModeloMarca.Text = "Marca:";
            // 
            // cbModeloMarca
            // 
            this.cbModeloMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModeloMarca.FormattingEnabled = true;
            this.cbModeloMarca.Location = new System.Drawing.Point(535, 203);
            this.cbModeloMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbModeloMarca.Name = "cbModeloMarca";
            this.cbModeloMarca.Size = new System.Drawing.Size(247, 33);
            this.cbModeloMarca.TabIndex = 54;
            // 
            // btnModeloCancelar
            // 
            this.btnModeloCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModeloCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnModeloCancelar.Location = new System.Drawing.Point(662, 318);
            this.btnModeloCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModeloCancelar.Name = "btnModeloCancelar";
            this.btnModeloCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnModeloCancelar.TabIndex = 55;
            this.btnModeloCancelar.Text = "Cancelar";
            this.btnModeloCancelar.UseVisualStyleBackColor = true;
            this.btnModeloCancelar.Click += new System.EventHandler(this.btnModeloCancelar_Click);
            // 
            // lblModeloId
            // 
            this.lblModeloId.AutoSize = true;
            this.lblModeloId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblModeloId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblModeloId.Location = new System.Drawing.Point(683, 50);
            this.lblModeloId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeloId.Name = "lblModeloId";
            this.lblModeloId.Size = new System.Drawing.Size(160, 36);
            this.lblModeloId.TabIndex = 56;
            this.lblModeloId.Text = "Modelo ID";
            // 
            // lblModeloVehiculoBuscar
            // 
            this.lblModeloVehiculoBuscar.AutoSize = true;
            this.lblModeloVehiculoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeloVehiculoBuscar.ForeColor = System.Drawing.Color.White;
            this.lblModeloVehiculoBuscar.Location = new System.Drawing.Point(16, 78);
            this.lblModeloVehiculoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModeloVehiculoBuscar.Name = "lblModeloVehiculoBuscar";
            this.lblModeloVehiculoBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblModeloVehiculoBuscar.TabIndex = 58;
            this.lblModeloVehiculoBuscar.Text = "Buscar:";
            // 
            // txtModeloVehiculoBuscar
            // 
            this.txtModeloVehiculoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloVehiculoBuscar.Location = new System.Drawing.Point(108, 74);
            this.txtModeloVehiculoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtModeloVehiculoBuscar.Name = "txtModeloVehiculoBuscar";
            this.txtModeloVehiculoBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtModeloVehiculoBuscar.TabIndex = 57;
            this.txtModeloVehiculoBuscar.TextChanged += new System.EventHandler(this.txtModeloVehiculoBuscar_TextChanged);
            // 
            // ModeloVehiculoCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(881, 383);
            this.Controls.Add(this.lblModeloVehiculoBuscar);
            this.Controls.Add(this.txtModeloVehiculoBuscar);
            this.Controls.Add(this.lblModeloId);
            this.Controls.Add(this.btnModeloCancelar);
            this.Controls.Add(this.cbModeloMarca);
            this.Controls.Add(this.lblModeloMarca);
            this.Controls.Add(this.lblModeloDescripcion);
            this.Controls.Add(this.txtModeloDescripcion);
            this.Controls.Add(this.btnModeloEliminar);
            this.Controls.Add(this.btnModeloEditar);
            this.Controls.Add(this.btnModeloGuardar);
            this.Controls.Add(this.lblMarcaTitulo);
            this.Controls.Add(this.dgvModelo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModeloVehiculoCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Modelo Vehiculo";
            this.Load += new System.EventHandler(this.ModeloVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModeloDescripcion;
        private System.Windows.Forms.TextBox txtModeloDescripcion;
        private System.Windows.Forms.Button btnModeloEliminar;
        private System.Windows.Forms.Button btnModeloEditar;
        private System.Windows.Forms.Button btnModeloGuardar;
        private System.Windows.Forms.Label lblMarcaTitulo;
        private System.Windows.Forms.DataGridView dgvModelo;
        private System.Windows.Forms.Label lblModeloMarca;
        private System.Windows.Forms.ComboBox cbModeloMarca;
        private System.Windows.Forms.Button btnModeloCancelar;
        private System.Windows.Forms.Label lblModeloId;
        private System.Windows.Forms.Label lblModeloVehiculoBuscar;
        private System.Windows.Forms.TextBox txtModeloVehiculoBuscar;
    }
}