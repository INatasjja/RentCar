namespace RentCar
{
    partial class RentaCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentaCrear));
            this.lblRentaFechaActual = new System.Windows.Forms.Label();
            this.lblInspecFecha = new System.Windows.Forms.Label();
            this.lblInspecCliente = new System.Windows.Forms.Label();
            this.lblInspecVehiculo = new System.Windows.Forms.Label();
            this.cbRentaCliente = new System.Windows.Forms.ComboBox();
            this.cbRentaVehiculo = new System.Windows.Forms.ComboBox();
            this.lblTituloRenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliNombre = new System.Windows.Forms.Label();
            this.txtRentaMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRentaDias = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCliCancelar = new System.Windows.Forms.Button();
            this.btnCliGuardar = new System.Windows.Forms.Button();
            this.lblCliEstado = new System.Windows.Forms.Label();
            this.lblCliTipoCli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRentaComentario = new System.Windows.Forms.TextBox();
            this.lblRentaEmpleado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRentaTotal = new System.Windows.Forms.TextBox();
            this.lblRentaFechaDevolucion = new System.Windows.Forms.Label();
            this.cbEstatusRenta = new System.Windows.Forms.ComboBox();
            this.lblRentaId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentaDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRentaFechaActual
            // 
            this.lblRentaFechaActual.AutoSize = true;
            this.lblRentaFechaActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentaFechaActual.Location = new System.Drawing.Point(846, 20);
            this.lblRentaFechaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentaFechaActual.Name = "lblRentaFechaActual";
            this.lblRentaFechaActual.Size = new System.Drawing.Size(122, 23);
            this.lblRentaFechaActual.TabIndex = 76;
            this.lblRentaFechaActual.Text = "Fecha actual";
            // 
            // lblInspecFecha
            // 
            this.lblInspecFecha.AutoSize = true;
            this.lblInspecFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspecFecha.Location = new System.Drawing.Point(667, 19);
            this.lblInspecFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspecFecha.Name = "lblInspecFecha";
            this.lblInspecFecha.Size = new System.Drawing.Size(158, 24);
            this.lblInspecFecha.TabIndex = 75;
            this.lblInspecFecha.Text = "Fecha de renta:";
            // 
            // lblInspecCliente
            // 
            this.lblInspecCliente.AutoSize = true;
            this.lblInspecCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspecCliente.Location = new System.Drawing.Point(30, 81);
            this.lblInspecCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspecCliente.Name = "lblInspecCliente";
            this.lblInspecCliente.Size = new System.Drawing.Size(82, 24);
            this.lblInspecCliente.TabIndex = 74;
            this.lblInspecCliente.Text = "Cliente:";
            // 
            // lblInspecVehiculo
            // 
            this.lblInspecVehiculo.AutoSize = true;
            this.lblInspecVehiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspecVehiculo.Location = new System.Drawing.Point(30, 126);
            this.lblInspecVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInspecVehiculo.Name = "lblInspecVehiculo";
            this.lblInspecVehiculo.Size = new System.Drawing.Size(97, 24);
            this.lblInspecVehiculo.TabIndex = 73;
            this.lblInspecVehiculo.Text = "Vehiculo:";
            // 
            // cbRentaCliente
            // 
            this.cbRentaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRentaCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRentaCliente.FormattingEnabled = true;
            this.cbRentaCliente.Location = new System.Drawing.Point(169, 74);
            this.cbRentaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbRentaCliente.Name = "cbRentaCliente";
            this.cbRentaCliente.Size = new System.Drawing.Size(239, 31);
            this.cbRentaCliente.TabIndex = 72;
            // 
            // cbRentaVehiculo
            // 
            this.cbRentaVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRentaVehiculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRentaVehiculo.FormattingEnabled = true;
            this.cbRentaVehiculo.Location = new System.Drawing.Point(168, 126);
            this.cbRentaVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.cbRentaVehiculo.Name = "cbRentaVehiculo";
            this.cbRentaVehiculo.Size = new System.Drawing.Size(239, 31);
            this.cbRentaVehiculo.TabIndex = 71;
            // 
            // lblTituloRenta
            // 
            this.lblTituloRenta.AutoSize = true;
            this.lblTituloRenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRenta.Location = new System.Drawing.Point(16, 11);
            this.lblTituloRenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloRenta.Name = "lblTituloRenta";
            this.lblTituloRenta.Size = new System.Drawing.Size(131, 46);
            this.lblTituloRenta.TabIndex = 70;
            this.lblTituloRenta.Text = "Renta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "Fecha de devolución:";
            // 
            // lblCliNombre
            // 
            this.lblCliNombre.AutoSize = true;
            this.lblCliNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliNombre.Location = new System.Drawing.Point(471, 79);
            this.lblCliNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliNombre.Name = "lblCliNombre";
            this.lblCliNombre.Size = new System.Drawing.Size(149, 24);
            this.lblCliNombre.TabIndex = 81;
            this.lblCliNombre.Text = "Monto por dia:";
            // 
            // txtRentaMonto
            // 
            this.txtRentaMonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentaMonto.Location = new System.Drawing.Point(665, 76);
            this.txtRentaMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentaMonto.Name = "txtRentaMonto";
            this.txtRentaMonto.Size = new System.Drawing.Size(172, 30);
            this.txtRentaMonto.TabIndex = 80;
            this.txtRentaMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRentaMonto.TextChanged += new System.EventHandler(this.txtRentaMonto_TextChanged);
            this.txtRentaMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentaMonto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 83;
            this.label2.Text = "Cantidad de dias:";
            // 
            // txtRentaDias
            // 
            this.txtRentaDias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentaDias.Location = new System.Drawing.Point(670, 131);
            this.txtRentaDias.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentaDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRentaDias.Name = "txtRentaDias";
            this.txtRentaDias.Size = new System.Drawing.Size(75, 30);
            this.txtRentaDias.TabIndex = 84;
            this.txtRentaDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRentaDias.ValueChanged += new System.EventHandler(this.txtRentaDias_ValueChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(23, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1035, 2);
            this.label3.TabIndex = 91;
            // 
            // btnCliCancelar
            // 
            this.btnCliCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCliCancelar.Location = new System.Drawing.Point(937, 491);
            this.btnCliCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliCancelar.Name = "btnCliCancelar";
            this.btnCliCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnCliCancelar.TabIndex = 87;
            this.btnCliCancelar.Text = "Cancelar";
            this.btnCliCancelar.UseVisualStyleBackColor = true;
            this.btnCliCancelar.Click += new System.EventHandler(this.btnCliCancelar_Click);
            // 
            // btnCliGuardar
            // 
            this.btnCliGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCliGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliGuardar.Location = new System.Drawing.Point(792, 491);
            this.btnCliGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliGuardar.Name = "btnCliGuardar";
            this.btnCliGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnCliGuardar.TabIndex = 88;
            this.btnCliGuardar.Text = "Guardar";
            this.btnCliGuardar.UseVisualStyleBackColor = false;
            this.btnCliGuardar.Click += new System.EventHandler(this.btnCliGuardar_Click);
            // 
            // lblCliEstado
            // 
            this.lblCliEstado.AutoSize = true;
            this.lblCliEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEstado.Location = new System.Drawing.Point(29, 343);
            this.lblCliEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliEstado.Name = "lblCliEstado";
            this.lblCliEstado.Size = new System.Drawing.Size(94, 29);
            this.lblCliEstado.TabIndex = 90;
            this.lblCliEstado.Text = "Estado:";
            // 
            // lblCliTipoCli
            // 
            this.lblCliTipoCli.AutoSize = true;
            this.lblCliTipoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliTipoCli.Location = new System.Drawing.Point(29, 276);
            this.lblCliTipoCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliTipoCli.Name = "lblCliTipoCli";
            this.lblCliTipoCli.Size = new System.Drawing.Size(130, 29);
            this.lblCliTipoCli.TabIndex = 89;
            this.lblCliTipoCli.Text = "Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 93;
            this.label4.Text = "Comentario:";
            // 
            // txtRentaComentario
            // 
            this.txtRentaComentario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentaComentario.Location = new System.Drawing.Point(437, 275);
            this.txtRentaComentario.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentaComentario.Multiline = true;
            this.txtRentaComentario.Name = "txtRentaComentario";
            this.txtRentaComentario.Size = new System.Drawing.Size(613, 123);
            this.txtRentaComentario.TabIndex = 94;
            // 
            // lblRentaEmpleado
            // 
            this.lblRentaEmpleado.AutoSize = true;
            this.lblRentaEmpleado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentaEmpleado.Location = new System.Drawing.Point(164, 281);
            this.lblRentaEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentaEmpleado.Name = "lblRentaEmpleado";
            this.lblRentaEmpleado.Size = new System.Drawing.Size(199, 23);
            this.lblRentaEmpleado.TabIndex = 96;
            this.lblRentaEmpleado.Text = "Empleado Conectado";
            this.lblRentaEmpleado.Click += new System.EventHandler(this.lblRentaEmpleado_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 98;
            this.label5.Text = "Total a pagar:";
            // 
            // txtRentaTotal
            // 
            this.txtRentaTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentaTotal.Location = new System.Drawing.Point(181, 214);
            this.txtRentaTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtRentaTotal.Name = "txtRentaTotal";
            this.txtRentaTotal.ReadOnly = true;
            this.txtRentaTotal.Size = new System.Drawing.Size(152, 30);
            this.txtRentaTotal.TabIndex = 97;
            // 
            // lblRentaFechaDevolucion
            // 
            this.lblRentaFechaDevolucion.AutoSize = true;
            this.lblRentaFechaDevolucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentaFechaDevolucion.Location = new System.Drawing.Point(906, 193);
            this.lblRentaFechaDevolucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentaFechaDevolucion.Name = "lblRentaFechaDevolucion";
            this.lblRentaFechaDevolucion.Size = new System.Drawing.Size(161, 23);
            this.lblRentaFechaDevolucion.TabIndex = 99;
            this.lblRentaFechaDevolucion.Text = "Fecha devolucion";
            // 
            // cbEstatusRenta
            // 
            this.cbEstatusRenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstatusRenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstatusRenta.FormattingEnabled = true;
            this.cbEstatusRenta.Location = new System.Drawing.Point(169, 344);
            this.cbEstatusRenta.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstatusRenta.Name = "cbEstatusRenta";
            this.cbEstatusRenta.Size = new System.Drawing.Size(106, 31);
            this.cbEstatusRenta.TabIndex = 100;
            // 
            // lblRentaId
            // 
            this.lblRentaId.AutoSize = true;
            this.lblRentaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentaId.ForeColor = System.Drawing.Color.Black;
            this.lblRentaId.Location = new System.Drawing.Point(895, 79);
            this.lblRentaId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentaId.Name = "lblRentaId";
            this.lblRentaId.Size = new System.Drawing.Size(139, 36);
            this.lblRentaId.TabIndex = 95;
            this.lblRentaId.Text = "Renta ID";
            this.lblRentaId.Click += new System.EventHandler(this.lblRentaId_Click);
            // 
            // RentaCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1076, 549);
            this.Controls.Add(this.cbEstatusRenta);
            this.Controls.Add(this.lblRentaFechaDevolucion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRentaTotal);
            this.Controls.Add(this.lblRentaEmpleado);
            this.Controls.Add(this.lblRentaId);
            this.Controls.Add(this.txtRentaComentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCliCancelar);
            this.Controls.Add(this.btnCliGuardar);
            this.Controls.Add(this.lblCliEstado);
            this.Controls.Add(this.lblCliTipoCli);
            this.Controls.Add(this.txtRentaDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCliNombre);
            this.Controls.Add(this.txtRentaMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRentaFechaActual);
            this.Controls.Add(this.lblInspecFecha);
            this.Controls.Add(this.lblInspecCliente);
            this.Controls.Add(this.lblInspecVehiculo);
            this.Controls.Add(this.cbRentaCliente);
            this.Controls.Add(this.cbRentaVehiculo);
            this.Controls.Add(this.lblTituloRenta);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentaCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentar Vehiculo";
            this.Load += new System.EventHandler(this.RentaCrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRentaDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRentaFechaActual;
        private System.Windows.Forms.Label lblInspecFecha;
        private System.Windows.Forms.Label lblInspecCliente;
        private System.Windows.Forms.Label lblInspecVehiculo;
        private System.Windows.Forms.ComboBox cbRentaCliente;
        private System.Windows.Forms.ComboBox cbRentaVehiculo;
        private System.Windows.Forms.Label lblTituloRenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliNombre;
        private System.Windows.Forms.TextBox txtRentaMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtRentaDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCliCancelar;
        private System.Windows.Forms.Button btnCliGuardar;
        private System.Windows.Forms.Label lblCliEstado;
        private System.Windows.Forms.Label lblCliTipoCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRentaComentario;
        private System.Windows.Forms.Label lblRentaEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRentaTotal;
        private System.Windows.Forms.Label lblRentaFechaDevolucion;
        private System.Windows.Forms.ComboBox cbEstatusRenta;
        private System.Windows.Forms.Label lblRentaId;
    }
}