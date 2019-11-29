namespace RentCar
{
    partial class TipoCombustibleCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoCombustibleCrear));
            this.lblTipoCombustibleDescripcion = new System.Windows.Forms.Label();
            this.txtTipoCombustibleDescripcion = new System.Windows.Forms.TextBox();
            this.btnTipoCombustibleEliminar = new System.Windows.Forms.Button();
            this.btnTipoCombustibleEditar = new System.Windows.Forms.Button();
            this.btnTipoCombustibleGuardar = new System.Windows.Forms.Button();
            this.lblTipoCombustibleTitulo = new System.Windows.Forms.Label();
            this.dgvTipoCombustible = new System.Windows.Forms.DataGridView();
            this.btnTipoCombustibleCancelar = new System.Windows.Forms.Button();
            this.lblTipoCombustibleId = new System.Windows.Forms.Label();
            this.lblCombustibleBuscar = new System.Windows.Forms.Label();
            this.txtCombustibleBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoCombustibleDescripcion
            // 
            this.lblTipoCombustibleDescripcion.AutoSize = true;
            this.lblTipoCombustibleDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCombustibleDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblTipoCombustibleDescripcion.Location = new System.Drawing.Point(449, 94);
            this.lblTipoCombustibleDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCombustibleDescripcion.Name = "lblTipoCombustibleDescripcion";
            this.lblTipoCombustibleDescripcion.Size = new System.Drawing.Size(147, 29);
            this.lblTipoCombustibleDescripcion.TabIndex = 38;
            this.lblTipoCombustibleDescripcion.Text = "Descripción:";
            // 
            // txtTipoCombustibleDescripcion
            // 
            this.txtTipoCombustibleDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCombustibleDescripcion.Location = new System.Drawing.Point(454, 128);
            this.txtTipoCombustibleDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoCombustibleDescripcion.Name = "txtTipoCombustibleDescripcion";
            this.txtTipoCombustibleDescripcion.Size = new System.Drawing.Size(319, 30);
            this.txtTipoCombustibleDescripcion.TabIndex = 37;
            // 
            // btnTipoCombustibleEliminar
            // 
            this.btnTipoCombustibleEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnTipoCombustibleEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoCombustibleEliminar.Location = new System.Drawing.Point(546, 274);
            this.btnTipoCombustibleEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoCombustibleEliminar.Name = "btnTipoCombustibleEliminar";
            this.btnTipoCombustibleEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnTipoCombustibleEliminar.TabIndex = 36;
            this.btnTipoCombustibleEliminar.Text = "Eliminar";
            this.btnTipoCombustibleEliminar.UseVisualStyleBackColor = false;
            this.btnTipoCombustibleEliminar.Click += new System.EventHandler(this.btnTipoCombustibleEliminar_Click);
            // 
            // btnTipoCombustibleEditar
            // 
            this.btnTipoCombustibleEditar.BackColor = System.Drawing.Color.Salmon;
            this.btnTipoCombustibleEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoCombustibleEditar.Location = new System.Drawing.Point(546, 229);
            this.btnTipoCombustibleEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoCombustibleEditar.Name = "btnTipoCombustibleEditar";
            this.btnTipoCombustibleEditar.Size = new System.Drawing.Size(120, 37);
            this.btnTipoCombustibleEditar.TabIndex = 35;
            this.btnTipoCombustibleEditar.Text = "Editar";
            this.btnTipoCombustibleEditar.UseVisualStyleBackColor = false;
            this.btnTipoCombustibleEditar.Click += new System.EventHandler(this.btnTipoCombustibleEditar_Click);
            // 
            // btnTipoCombustibleGuardar
            // 
            this.btnTipoCombustibleGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTipoCombustibleGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoCombustibleGuardar.Location = new System.Drawing.Point(546, 185);
            this.btnTipoCombustibleGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoCombustibleGuardar.Name = "btnTipoCombustibleGuardar";
            this.btnTipoCombustibleGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnTipoCombustibleGuardar.TabIndex = 34;
            this.btnTipoCombustibleGuardar.Text = "Guardar";
            this.btnTipoCombustibleGuardar.UseVisualStyleBackColor = false;
            this.btnTipoCombustibleGuardar.Click += new System.EventHandler(this.btnTipoCombustibleGuardar_Click);
            // 
            // lblTipoCombustibleTitulo
            // 
            this.lblTipoCombustibleTitulo.AutoSize = true;
            this.lblTipoCombustibleTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTipoCombustibleTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCombustibleTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTipoCombustibleTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTipoCombustibleTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCombustibleTitulo.Name = "lblTipoCombustibleTitulo";
            this.lblTipoCombustibleTitulo.Size = new System.Drawing.Size(397, 46);
            this.lblTipoCombustibleTitulo.TabIndex = 33;
            this.lblTipoCombustibleTitulo.Text = "Tipo de combustible";
            // 
            // dgvTipoCombustible
            // 
            this.dgvTipoCombustible.AllowUserToAddRows = false;
            this.dgvTipoCombustible.AllowUserToDeleteRows = false;
            this.dgvTipoCombustible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCombustible.Location = new System.Drawing.Point(16, 139);
            this.dgvTipoCombustible.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTipoCombustible.Name = "dgvTipoCombustible";
            this.dgvTipoCombustible.ReadOnly = true;
            this.dgvTipoCombustible.Size = new System.Drawing.Size(401, 250);
            this.dgvTipoCombustible.TabIndex = 32;
            // 
            // btnTipoCombustibleCancelar
            // 
            this.btnTipoCombustibleCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoCombustibleCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnTipoCombustibleCancelar.Location = new System.Drawing.Point(546, 318);
            this.btnTipoCombustibleCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoCombustibleCancelar.Name = "btnTipoCombustibleCancelar";
            this.btnTipoCombustibleCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnTipoCombustibleCancelar.TabIndex = 39;
            this.btnTipoCombustibleCancelar.Text = "Cancelar";
            this.btnTipoCombustibleCancelar.UseVisualStyleBackColor = true;
            this.btnTipoCombustibleCancelar.Click += new System.EventHandler(this.btnTipoCombustibleCancelar_Click);
            // 
            // lblTipoCombustibleId
            // 
            this.lblTipoCombustibleId.AutoSize = true;
            this.lblTipoCombustibleId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTipoCombustibleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCombustibleId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTipoCombustibleId.Location = new System.Drawing.Point(616, 62);
            this.lblTipoCombustibleId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCombustibleId.Name = "lblTipoCombustibleId";
            this.lblTipoCombustibleId.Size = new System.Drawing.Size(146, 36);
            this.lblTipoCombustibleId.TabIndex = 48;
            this.lblTipoCombustibleId.Text = "Comb. ID";
            // 
            // lblCombustibleBuscar
            // 
            this.lblCombustibleBuscar.AutoSize = true;
            this.lblCombustibleBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCombustibleBuscar.ForeColor = System.Drawing.Color.White;
            this.lblCombustibleBuscar.Location = new System.Drawing.Point(16, 98);
            this.lblCombustibleBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCombustibleBuscar.Name = "lblCombustibleBuscar";
            this.lblCombustibleBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblCombustibleBuscar.TabIndex = 50;
            this.lblCombustibleBuscar.Text = "Buscar:";
            // 
            // txtCombustibleBuscar
            // 
            this.txtCombustibleBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustibleBuscar.Location = new System.Drawing.Point(108, 95);
            this.txtCombustibleBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCombustibleBuscar.Name = "txtCombustibleBuscar";
            this.txtCombustibleBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtCombustibleBuscar.TabIndex = 49;
            this.txtCombustibleBuscar.TextChanged += new System.EventHandler(this.txtCombustibleBuscar_TextChanged);
            // 
            // TipoCombustibleCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(793, 404);
            this.Controls.Add(this.lblCombustibleBuscar);
            this.Controls.Add(this.txtCombustibleBuscar);
            this.Controls.Add(this.lblTipoCombustibleId);
            this.Controls.Add(this.btnTipoCombustibleCancelar);
            this.Controls.Add(this.lblTipoCombustibleDescripcion);
            this.Controls.Add(this.txtTipoCombustibleDescripcion);
            this.Controls.Add(this.btnTipoCombustibleEliminar);
            this.Controls.Add(this.btnTipoCombustibleEditar);
            this.Controls.Add(this.btnTipoCombustibleGuardar);
            this.Controls.Add(this.lblTipoCombustibleTitulo);
            this.Controls.Add(this.dgvTipoCombustible);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TipoCombustibleCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrgar Tipo de Combustible";
            this.Load += new System.EventHandler(this.TipoCombustible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCombustibleDescripcion;
        private System.Windows.Forms.TextBox txtTipoCombustibleDescripcion;
        private System.Windows.Forms.Button btnTipoCombustibleEliminar;
        private System.Windows.Forms.Button btnTipoCombustibleEditar;
        private System.Windows.Forms.Button btnTipoCombustibleGuardar;
        private System.Windows.Forms.Label lblTipoCombustibleTitulo;
        private System.Windows.Forms.DataGridView dgvTipoCombustible;
        private System.Windows.Forms.Button btnTipoCombustibleCancelar;
        private System.Windows.Forms.Label lblTipoCombustibleId;
        private System.Windows.Forms.Label lblCombustibleBuscar;
        private System.Windows.Forms.TextBox txtCombustibleBuscar;
    }
}