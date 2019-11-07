namespace RentCar
{
    partial class EmpleadoLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoLista));
            this.btnEmpleadoLCancelar = new System.Windows.Forms.Button();
            this.btnEmpleadoLEliminar = new System.Windows.Forms.Button();
            this.btnEmpleadoLEditar = new System.Windows.Forms.Button();
            this.lblEmpleadosTitulo = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblEmpleadoBuscar = new System.Windows.Forms.Label();
            this.txtEmpleadoBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpleadoLCancelar
            // 
            this.btnEmpleadoLCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleadoLCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnEmpleadoLCancelar.Location = new System.Drawing.Point(1012, 535);
            this.btnEmpleadoLCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpleadoLCancelar.Name = "btnEmpleadoLCancelar";
            this.btnEmpleadoLCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnEmpleadoLCancelar.TabIndex = 19;
            this.btnEmpleadoLCancelar.Text = "Cancelar";
            this.btnEmpleadoLCancelar.UseVisualStyleBackColor = true;
            this.btnEmpleadoLCancelar.Click += new System.EventHandler(this.btnEmpleadoLCancelar_Click);
            // 
            // btnEmpleadoLEliminar
            // 
            this.btnEmpleadoLEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEmpleadoLEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleadoLEliminar.Location = new System.Drawing.Point(884, 535);
            this.btnEmpleadoLEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpleadoLEliminar.Name = "btnEmpleadoLEliminar";
            this.btnEmpleadoLEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnEmpleadoLEliminar.TabIndex = 18;
            this.btnEmpleadoLEliminar.Text = "Eliminar";
            this.btnEmpleadoLEliminar.UseVisualStyleBackColor = false;
            this.btnEmpleadoLEliminar.Click += new System.EventHandler(this.btnEmpleadoLEliminar_Click);
            // 
            // btnEmpleadoLEditar
            // 
            this.btnEmpleadoLEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEmpleadoLEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleadoLEditar.Location = new System.Drawing.Point(756, 535);
            this.btnEmpleadoLEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmpleadoLEditar.Name = "btnEmpleadoLEditar";
            this.btnEmpleadoLEditar.Size = new System.Drawing.Size(120, 37);
            this.btnEmpleadoLEditar.TabIndex = 17;
            this.btnEmpleadoLEditar.Text = "Editar";
            this.btnEmpleadoLEditar.UseVisualStyleBackColor = false;
            this.btnEmpleadoLEditar.Click += new System.EventHandler(this.btnEmpleadoLEditar_Click);
            // 
            // lblEmpleadosTitulo
            // 
            this.lblEmpleadosTitulo.AutoSize = true;
            this.lblEmpleadosTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEmpleadosTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadosTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblEmpleadosTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleadosTitulo.Name = "lblEmpleadosTitulo";
            this.lblEmpleadosTitulo.Size = new System.Drawing.Size(383, 46);
            this.lblEmpleadosTitulo.TabIndex = 16;
            this.lblEmpleadosTitulo.Text = "Lista de empleados";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(16, 96);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(1115, 414);
            this.dgvEmpleados.TabIndex = 15;
            // 
            // lblEmpleadoBuscar
            // 
            this.lblEmpleadoBuscar.AutoSize = true;
            this.lblEmpleadoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoBuscar.Location = new System.Drawing.Point(831, 32);
            this.lblEmpleadoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleadoBuscar.Name = "lblEmpleadoBuscar";
            this.lblEmpleadoBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblEmpleadoBuscar.TabIndex = 21;
            this.lblEmpleadoBuscar.Text = "Buscar:";
            // 
            // txtEmpleadoBuscar
            // 
            this.txtEmpleadoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpleadoBuscar.Location = new System.Drawing.Point(923, 28);
            this.txtEmpleadoBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpleadoBuscar.Name = "txtEmpleadoBuscar";
            this.txtEmpleadoBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtEmpleadoBuscar.TabIndex = 20;
            this.txtEmpleadoBuscar.TextChanged += new System.EventHandler(this.txtEmpleadoBuscar_TextChanged);
            // 
            // EmpleadoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1147, 598);
            this.Controls.Add(this.lblEmpleadoBuscar);
            this.Controls.Add(this.txtEmpleadoBuscar);
            this.Controls.Add(this.btnEmpleadoLCancelar);
            this.Controls.Add(this.btnEmpleadoLEliminar);
            this.Controls.Add(this.btnEmpleadoLEditar);
            this.Controls.Add(this.lblEmpleadosTitulo);
            this.Controls.Add(this.dgvEmpleados);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpleadoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de empleados";
            this.Load += new System.EventHandler(this.EmpleadoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmpleadoLCancelar;
        private System.Windows.Forms.Button btnEmpleadoLEliminar;
        private System.Windows.Forms.Button btnEmpleadoLEditar;
        private System.Windows.Forms.Label lblEmpleadosTitulo;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblEmpleadoBuscar;
        private System.Windows.Forms.TextBox txtEmpleadoBuscar;
    }
}