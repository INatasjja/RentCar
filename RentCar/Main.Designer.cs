namespace RentaCar
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelSelector = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnRenta = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnInspeccion = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpleadoConectado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.inicio1 = new RentCar.Inicio();
            this.empleado1 = new RentCar.Empleado();
            this.renta1 = new RentCar.Renta();
            this.cliente1 = new RentCar.Cliente();
            this.vehiculos1 = new RentCar.Vehiculos();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.panelSelector);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnRenta);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.btnInspeccion);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnVehiculos);
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 77);
            this.panel1.TabIndex = 0;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(1142, 5);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(187, 66);
            this.btnEmpleados.TabIndex = 8;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(20, 4);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(117, 62);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "   Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelSelector
            // 
            this.panelSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(0)))));
            this.panelSelector.Location = new System.Drawing.Point(4, 4);
            this.panelSelector.Margin = new System.Windows.Forms.Padding(4);
            this.panelSelector.Name = "panelSelector";
            this.panelSelector.Size = new System.Drawing.Size(22, 66);
            this.panelSelector.TabIndex = 6;
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(972, 4);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(149, 66);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "   Reportes";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnRenta
            // 
            this.btnRenta.FlatAppearance.BorderSize = 0;
            this.btnRenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenta.ForeColor = System.Drawing.Color.White;
            this.btnRenta.Image = ((System.Drawing.Image)(resources.GetObject("btnRenta.Image")));
            this.btnRenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenta.Location = new System.Drawing.Point(652, 4);
            this.btnRenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenta.Name = "btnRenta";
            this.btnRenta.Size = new System.Drawing.Size(128, 66);
            this.btnRenta.TabIndex = 4;
            this.btnRenta.Text = "   Renta";
            this.btnRenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenta.UseVisualStyleBackColor = true;
            this.btnRenta.Click += new System.EventHandler(this.btnRenta_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(788, 5);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(157, 66);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "   Consultas";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnInspeccion
            // 
            this.btnInspeccion.FlatAppearance.BorderSize = 0;
            this.btnInspeccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnInspeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspeccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInspeccion.ForeColor = System.Drawing.Color.White;
            this.btnInspeccion.Image = ((System.Drawing.Image)(resources.GetObject("btnInspeccion.Image")));
            this.btnInspeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInspeccion.Location = new System.Drawing.Point(473, 4);
            this.btnInspeccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnInspeccion.Name = "btnInspeccion";
            this.btnInspeccion.Size = new System.Drawing.Size(173, 66);
            this.btnInspeccion.TabIndex = 2;
            this.btnInspeccion.Text = "   Inspección";
            this.btnInspeccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInspeccion.UseVisualStyleBackColor = true;
            this.btnInspeccion.Click += new System.EventHandler(this.btnInspeccion_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(324, 4);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(141, 66);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "   Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(65)))));
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehiculos.ForeColor = System.Drawing.Color.White;
            this.btnVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculos.Image")));
            this.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.Location = new System.Drawing.Point(159, 4);
            this.btnVehiculos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(157, 66);
            this.btnVehiculos.TabIndex = 0;
            this.btnVehiculos.Text = "   Vehiculos";
            this.btnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bienvenido";
            // 
            // lblEmpleadoConectado
            // 
            this.lblEmpleadoConectado.AutoSize = true;
            this.lblEmpleadoConectado.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoConectado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleadoConectado.Location = new System.Drawing.Point(35, 373);
            this.lblEmpleadoConectado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleadoConectado.Name = "lblEmpleadoConectado";
            this.lblEmpleadoConectado.Size = new System.Drawing.Size(145, 25);
            this.lblEmpleadoConectado.TabIndex = 8;
            this.lblEmpleadoConectado.Text = "*Empleado*";
            this.lblEmpleadoConectado.Click += new System.EventHandler(this.lblEmpleadoConectado_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1426, 12);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.lblEmpleadoConectado);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.lblEmpresa);
            this.panel3.Controls.Add(this.imgLogo);
            this.panel3.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(4, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 484);
            this.panel3.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(14, 246);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 38);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "COLONIAL";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.White;
            this.lblEmpresa.Location = new System.Drawing.Point(46, 210);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(137, 27);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Rent  A Car";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.InitialImage = null;
            this.imgLogo.Location = new System.Drawing.Point(40, 63);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(156, 124);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Location = new System.Drawing.Point(1360, 82);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(33, 31);
            this.btnEmpleado.TabIndex = 8;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1337, 17);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 31);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Cerrar";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // inicio1
            // 
            this.inicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.inicio1.Location = new System.Drawing.Point(235, 98);
            this.inicio1.Margin = new System.Windows.Forms.Padding(5);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(1092, 484);
            this.inicio1.TabIndex = 15;
            this.inicio1.Load += new System.EventHandler(this.inicio1_Load);
            // 
            // empleado1
            // 
            this.empleado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.empleado1.ForeColor = System.Drawing.Color.Black;
            this.empleado1.Location = new System.Drawing.Point(236, 98);
            this.empleado1.Margin = new System.Windows.Forms.Padding(5);
            this.empleado1.Name = "empleado1";
            this.empleado1.Size = new System.Drawing.Size(1091, 484);
            this.empleado1.TabIndex = 16;
            this.empleado1.Load += new System.EventHandler(this.empleado1_Load);
            // 
            // renta1
            // 
            this.renta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.renta1.ForeColor = System.Drawing.Color.Black;
            this.renta1.Location = new System.Drawing.Point(235, 98);
            this.renta1.Margin = new System.Windows.Forms.Padding(5);
            this.renta1.Name = "renta1";
            this.renta1.Size = new System.Drawing.Size(1092, 484);
            this.renta1.TabIndex = 13;
            this.renta1.Load += new System.EventHandler(this.renta1_Load);
            // 
            // cliente1
            // 
            this.cliente1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cliente1.ForeColor = System.Drawing.Color.Black;
            this.cliente1.Location = new System.Drawing.Point(235, 98);
            this.cliente1.Margin = new System.Windows.Forms.Padding(5);
            this.cliente1.Name = "cliente1";
            this.cliente1.Size = new System.Drawing.Size(1092, 484);
            this.cliente1.TabIndex = 10;
            // 
            // vehiculos1
            // 
            this.vehiculos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vehiculos1.ForeColor = System.Drawing.Color.Black;
            this.vehiculos1.Location = new System.Drawing.Point(235, 98);
            this.vehiculos1.Margin = new System.Windows.Forms.Padding(5);
            this.vehiculos1.Name = "vehiculos1";
            this.vehiculos1.Size = new System.Drawing.Size(1092, 484);
            this.vehiculos1.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1426, 596);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inicio1);
            this.Controls.Add(this.empleado1);
            this.Controls.Add(this.renta1);
            this.Controls.Add(this.cliente1);
            this.Controls.Add(this.vehiculos1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInspeccion;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnRenta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel panelSelector;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmpleado;
        private RentCar.Vehiculos vehiculos1;
        private RentCar.Cliente cliente1;
        private RentCar.Renta renta1;
        private System.Windows.Forms.Button btnInicio;
        private RentCar.Inicio inicio1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpleadoConectado;
        private RentCar.Empleado empleado1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnEmpleados;
    }
}