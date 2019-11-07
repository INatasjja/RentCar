namespace RentCar
{
    partial class VehiculoCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculoCrear));
            this.lblVehiculoId = new System.Windows.Forms.Label();
            this.lblCliNombre = new System.Windows.Forms.Label();
            this.txtVehiculoDescripcion = new System.Windows.Forms.TextBox();
            this.lblInspecCliente = new System.Windows.Forms.Label();
            this.lblInspecVehiculo = new System.Windows.Forms.Label();
            this.cbVehiculoMarca = new System.Windows.Forms.ComboBox();
            this.cbVehiculoTipo = new System.Windows.Forms.ComboBox();
            this.lblTituloVehiculo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVehiculoCombustible = new System.Windows.Forms.ComboBox();
            this.cbVehiculoModelo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVehiculoChasis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVehiculoPlaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVehiculoMotor = new System.Windows.Forms.TextBox();
            this.lblCliEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVehiculoCancelar = new System.Windows.Forms.Button();
            this.btnVehiculoGuardar = new System.Windows.Forms.Button();
            this.btnVehiculoTipo = new System.Windows.Forms.Button();
            this.btnVehiculoModelo = new System.Windows.Forms.Button();
            this.btnVehiculoMarca = new System.Windows.Forms.Button();
            this.btnVehiculoComb = new System.Windows.Forms.Button();
            this.ckbVehiculoEstado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblVehiculoId
            // 
            this.lblVehiculoId.AutoSize = true;
            this.lblVehiculoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculoId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblVehiculoId.Location = new System.Drawing.Point(745, 11);
            this.lblVehiculoId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculoId.Name = "lblVehiculoId";
            this.lblVehiculoId.Size = new System.Drawing.Size(46, 36);
            this.lblVehiculoId.TabIndex = 103;
            this.lblVehiculoId.Text = "ID";
            this.lblVehiculoId.Click += new System.EventHandler(this.lblVehiculoId_Click);
            // 
            // lblCliNombre
            // 
            this.lblCliNombre.AutoSize = true;
            this.lblCliNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliNombre.Location = new System.Drawing.Point(29, 265);
            this.lblCliNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliNombre.Name = "lblCliNombre";
            this.lblCliNombre.Size = new System.Drawing.Size(129, 24);
            this.lblCliNombre.TabIndex = 102;
            this.lblCliNombre.Text = "Descripción:";
            // 
            // txtVehiculoDescripcion
            // 
            this.txtVehiculoDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculoDescripcion.Location = new System.Drawing.Point(166, 265);
            this.txtVehiculoDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehiculoDescripcion.Name = "txtVehiculoDescripcion";
            this.txtVehiculoDescripcion.Size = new System.Drawing.Size(265, 30);
            this.txtVehiculoDescripcion.TabIndex = 101;
            // 
            // lblInspecCliente
            // 
            this.lblInspecCliente.AutoSize = true;
            this.lblInspecCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspecCliente.Location = new System.Drawing.Point(30, 120);
            this.lblInspecCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspecCliente.Name = "lblInspecCliente";
            this.lblInspecCliente.Size = new System.Drawing.Size(75, 24);
            this.lblInspecCliente.TabIndex = 100;
            this.lblInspecCliente.Text = "Marca:";
            // 
            // lblInspecVehiculo
            // 
            this.lblInspecVehiculo.AutoSize = true;
            this.lblInspecVehiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspecVehiculo.Location = new System.Drawing.Point(30, 77);
            this.lblInspecVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspecVehiculo.Name = "lblInspecVehiculo";
            this.lblInspecVehiculo.Size = new System.Drawing.Size(173, 24);
            this.lblInspecVehiculo.TabIndex = 99;
            this.lblInspecVehiculo.Text = "Tipo de vehiculo:";
            // 
            // cbVehiculoMarca
            // 
            this.cbVehiculoMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculoMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculoMarca.FormattingEnabled = true;
            this.cbVehiculoMarca.Location = new System.Drawing.Point(291, 120);
            this.cbVehiculoMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbVehiculoMarca.Name = "cbVehiculoMarca";
            this.cbVehiculoMarca.Size = new System.Drawing.Size(265, 31);
            this.cbVehiculoMarca.TabIndex = 98;
            // 
            // cbVehiculoTipo
            // 
            this.cbVehiculoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculoTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculoTipo.FormattingEnabled = true;
            this.cbVehiculoTipo.Location = new System.Drawing.Point(291, 80);
            this.cbVehiculoTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVehiculoTipo.Name = "cbVehiculoTipo";
            this.cbVehiculoTipo.Size = new System.Drawing.Size(265, 31);
            this.cbVehiculoTipo.TabIndex = 97;
            // 
            // lblTituloVehiculo
            // 
            this.lblTituloVehiculo.AutoSize = true;
            this.lblTituloVehiculo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVehiculo.Location = new System.Drawing.Point(16, 11);
            this.lblTituloVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloVehiculo.Name = "lblTituloVehiculo";
            this.lblTituloVehiculo.Size = new System.Drawing.Size(333, 47);
            this.lblTituloVehiculo.TabIndex = 96;
            this.lblTituloVehiculo.Text = "Nuevo Vehículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 107;
            this.label1.Text = "Tipo de combustible:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "Modelo:";
            // 
            // cbVehiculoCombustible
            // 
            this.cbVehiculoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculoCombustible.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculoCombustible.FormattingEnabled = true;
            this.cbVehiculoCombustible.Location = new System.Drawing.Point(291, 206);
            this.cbVehiculoCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.cbVehiculoCombustible.Name = "cbVehiculoCombustible";
            this.cbVehiculoCombustible.Size = new System.Drawing.Size(265, 31);
            this.cbVehiculoCombustible.TabIndex = 105;
            // 
            // cbVehiculoModelo
            // 
            this.cbVehiculoModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculoModelo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculoModelo.FormattingEnabled = true;
            this.cbVehiculoModelo.Location = new System.Drawing.Point(291, 163);
            this.cbVehiculoModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVehiculoModelo.Name = "cbVehiculoModelo";
            this.cbVehiculoModelo.Size = new System.Drawing.Size(265, 31);
            this.cbVehiculoModelo.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 109;
            this.label3.Text = "No. Chasis:";
            // 
            // txtVehiculoChasis
            // 
            this.txtVehiculoChasis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculoChasis.Location = new System.Drawing.Point(652, 265);
            this.txtVehiculoChasis.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehiculoChasis.Name = "txtVehiculoChasis";
            this.txtVehiculoChasis.Size = new System.Drawing.Size(265, 30);
            this.txtVehiculoChasis.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 113;
            this.label4.Text = "No. Placa:";
            // 
            // txtVehiculoPlaca
            // 
            this.txtVehiculoPlaca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculoPlaca.Location = new System.Drawing.Point(652, 307);
            this.txtVehiculoPlaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehiculoPlaca.Name = "txtVehiculoPlaca";
            this.txtVehiculoPlaca.Size = new System.Drawing.Size(265, 30);
            this.txtVehiculoPlaca.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 111;
            this.label5.Text = "No. Motor";
            // 
            // txtVehiculoMotor
            // 
            this.txtVehiculoMotor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculoMotor.Location = new System.Drawing.Point(166, 307);
            this.txtVehiculoMotor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehiculoMotor.Name = "txtVehiculoMotor";
            this.txtVehiculoMotor.Size = new System.Drawing.Size(265, 30);
            this.txtVehiculoMotor.TabIndex = 110;
            // 
            // lblCliEstado
            // 
            this.lblCliEstado.AutoSize = true;
            this.lblCliEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEstado.Location = new System.Drawing.Point(28, 390);
            this.lblCliEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliEstado.Name = "lblCliEstado";
            this.lblCliEstado.Size = new System.Drawing.Size(94, 29);
            this.lblCliEstado.TabIndex = 115;
            this.lblCliEstado.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(16, 438);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(933, 2);
            this.label6.TabIndex = 118;
            // 
            // btnVehiculoCancelar
            // 
            this.btnVehiculoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculoCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnVehiculoCancelar.Location = new System.Drawing.Point(829, 455);
            this.btnVehiculoCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoCancelar.Name = "btnVehiculoCancelar";
            this.btnVehiculoCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnVehiculoCancelar.TabIndex = 116;
            this.btnVehiculoCancelar.Text = "Cancelar";
            this.btnVehiculoCancelar.UseVisualStyleBackColor = true;
            this.btnVehiculoCancelar.Click += new System.EventHandler(this.btnVehiculoCancelar_Click);
            // 
            // btnVehiculoGuardar
            // 
            this.btnVehiculoGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVehiculoGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculoGuardar.Location = new System.Drawing.Point(684, 455);
            this.btnVehiculoGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoGuardar.Name = "btnVehiculoGuardar";
            this.btnVehiculoGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnVehiculoGuardar.TabIndex = 117;
            this.btnVehiculoGuardar.Text = "Guardar";
            this.btnVehiculoGuardar.UseVisualStyleBackColor = false;
            this.btnVehiculoGuardar.Click += new System.EventHandler(this.btnVehiculoGuardar_Click);
            // 
            // btnVehiculoTipo
            // 
            this.btnVehiculoTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculoTipo.Image")));
            this.btnVehiculoTipo.Location = new System.Drawing.Point(563, 79);
            this.btnVehiculoTipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoTipo.Name = "btnVehiculoTipo";
            this.btnVehiculoTipo.Size = new System.Drawing.Size(40, 37);
            this.btnVehiculoTipo.TabIndex = 119;
            this.btnVehiculoTipo.UseVisualStyleBackColor = true;
            this.btnVehiculoTipo.Click += new System.EventHandler(this.btnVehiculoTipo_Click);
            // 
            // btnVehiculoModelo
            // 
            this.btnVehiculoModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculoModelo.Image")));
            this.btnVehiculoModelo.Location = new System.Drawing.Point(563, 160);
            this.btnVehiculoModelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoModelo.Name = "btnVehiculoModelo";
            this.btnVehiculoModelo.Size = new System.Drawing.Size(40, 37);
            this.btnVehiculoModelo.TabIndex = 120;
            this.btnVehiculoModelo.UseVisualStyleBackColor = true;
            this.btnVehiculoModelo.Click += new System.EventHandler(this.btnVehiculoModelo_Click);
            // 
            // btnVehiculoMarca
            // 
            this.btnVehiculoMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculoMarca.Image")));
            this.btnVehiculoMarca.Location = new System.Drawing.Point(563, 120);
            this.btnVehiculoMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoMarca.Name = "btnVehiculoMarca";
            this.btnVehiculoMarca.Size = new System.Drawing.Size(40, 37);
            this.btnVehiculoMarca.TabIndex = 121;
            this.btnVehiculoMarca.UseVisualStyleBackColor = true;
            this.btnVehiculoMarca.Click += new System.EventHandler(this.btnVehiculoMarca_Click);
            // 
            // btnVehiculoComb
            // 
            this.btnVehiculoComb.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculoComb.Image")));
            this.btnVehiculoComb.Location = new System.Drawing.Point(563, 205);
            this.btnVehiculoComb.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculoComb.Name = "btnVehiculoComb";
            this.btnVehiculoComb.Size = new System.Drawing.Size(40, 37);
            this.btnVehiculoComb.TabIndex = 122;
            this.btnVehiculoComb.UseVisualStyleBackColor = true;
            this.btnVehiculoComb.Click += new System.EventHandler(this.btnVehiculoComb_Click);
            // 
            // ckbVehiculoEstado
            // 
            this.ckbVehiculoEstado.AutoSize = true;
            this.ckbVehiculoEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVehiculoEstado.Location = new System.Drawing.Point(130, 398);
            this.ckbVehiculoEstado.Margin = new System.Windows.Forms.Padding(4);
            this.ckbVehiculoEstado.Name = "ckbVehiculoEstado";
            this.ckbVehiculoEstado.Size = new System.Drawing.Size(18, 17);
            this.ckbVehiculoEstado.TabIndex = 114;
            this.ckbVehiculoEstado.UseVisualStyleBackColor = true;
            // 
            // VehiculoCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(965, 508);
            this.Controls.Add(this.btnVehiculoComb);
            this.Controls.Add(this.btnVehiculoMarca);
            this.Controls.Add(this.btnVehiculoModelo);
            this.Controls.Add(this.btnVehiculoTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnVehiculoCancelar);
            this.Controls.Add(this.btnVehiculoGuardar);
            this.Controls.Add(this.lblCliEstado);
            this.Controls.Add(this.ckbVehiculoEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVehiculoPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVehiculoMotor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVehiculoChasis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVehiculoCombustible);
            this.Controls.Add(this.cbVehiculoModelo);
            this.Controls.Add(this.lblVehiculoId);
            this.Controls.Add(this.lblCliNombre);
            this.Controls.Add(this.txtVehiculoDescripcion);
            this.Controls.Add(this.lblInspecCliente);
            this.Controls.Add(this.lblInspecVehiculo);
            this.Controls.Add(this.cbVehiculoMarca);
            this.Controls.Add(this.cbVehiculoTipo);
            this.Controls.Add(this.lblTituloVehiculo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehiculoCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Vehiculo";
            this.Load += new System.EventHandler(this.VehiculoCrear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehiculoId;
        private System.Windows.Forms.Label lblCliNombre;
        private System.Windows.Forms.TextBox txtVehiculoDescripcion;
        private System.Windows.Forms.Label lblInspecCliente;
        private System.Windows.Forms.Label lblInspecVehiculo;
        private System.Windows.Forms.ComboBox cbVehiculoMarca;
        private System.Windows.Forms.ComboBox cbVehiculoTipo;
        private System.Windows.Forms.Label lblTituloVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVehiculoCombustible;
        private System.Windows.Forms.ComboBox cbVehiculoModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVehiculoChasis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVehiculoPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVehiculoMotor;
        private System.Windows.Forms.Label lblCliEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVehiculoCancelar;
        private System.Windows.Forms.Button btnVehiculoGuardar;
        private System.Windows.Forms.Button btnVehiculoTipo;
        private System.Windows.Forms.Button btnVehiculoModelo;
        private System.Windows.Forms.Button btnVehiculoMarca;
        private System.Windows.Forms.Button btnVehiculoComb;
        private System.Windows.Forms.CheckBox ckbVehiculoEstado;
    }
}