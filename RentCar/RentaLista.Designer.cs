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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloRentaL
            // 
            this.lblTituloRentaL.AutoSize = true;
            this.lblTituloRentaL.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRentaL.Location = new System.Drawing.Point(12, 9);
            this.lblTituloRentaL.Name = "lblTituloRentaL";
            this.lblTituloRentaL.Size = new System.Drawing.Size(237, 38);
            this.lblTituloRentaL.TabIndex = 71;
            this.lblTituloRentaL.Text = "Lista de rentas";
            // 
            // btnRentaLCancelar
            // 
            this.btnRentaLCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentaLCancelar.Location = new System.Drawing.Point(759, 436);
            this.btnRentaLCancelar.Name = "btnRentaLCancelar";
            this.btnRentaLCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnRentaLCancelar.TabIndex = 75;
            this.btnRentaLCancelar.Text = "Cancelar";
            this.btnRentaLCancelar.UseVisualStyleBackColor = true;
            this.btnRentaLCancelar.Click += new System.EventHandler(this.btnRentaLCancelar_Click);
            // 
            // btnRentaLEliminar
            // 
            this.btnRentaLEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentaLEliminar.Location = new System.Drawing.Point(663, 436);
            this.btnRentaLEliminar.Name = "btnRentaLEliminar";
            this.btnRentaLEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnRentaLEliminar.TabIndex = 74;
            this.btnRentaLEliminar.Text = "Eliminar";
            this.btnRentaLEliminar.UseVisualStyleBackColor = true;
            this.btnRentaLEliminar.Click += new System.EventHandler(this.btnRentaLEliminar_Click);
            // 
            // btnRentaLEditar
            // 
            this.btnRentaLEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentaLEditar.Location = new System.Drawing.Point(567, 436);
            this.btnRentaLEditar.Name = "btnRentaLEditar";
            this.btnRentaLEditar.Size = new System.Drawing.Size(90, 30);
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
            this.dgvRenta.Location = new System.Drawing.Point(12, 78);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.ReadOnly = true;
            this.dgvRenta.Size = new System.Drawing.Size(837, 336);
            this.dgvRenta.TabIndex = 72;
            // 
            // lblRentaBuscar
            // 
            this.lblRentaBuscar.AutoSize = true;
            this.lblRentaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentaBuscar.Location = new System.Drawing.Point(622, 25);
            this.lblRentaBuscar.Name = "lblRentaBuscar";
            this.lblRentaBuscar.Size = new System.Drawing.Size(63, 20);
            this.lblRentaBuscar.TabIndex = 77;
            this.lblRentaBuscar.Text = "Buscar:";
            // 
            // txtRentaBuscar
            // 
            this.txtRentaBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentaBuscar.Location = new System.Drawing.Point(691, 23);
            this.txtRentaBuscar.Name = "txtRentaBuscar";
            this.txtRentaBuscar.Size = new System.Drawing.Size(157, 26);
            this.txtRentaBuscar.TabIndex = 76;
            this.txtRentaBuscar.TextChanged += new System.EventHandler(this.txtRentaBuscar_TextChanged);
            // 
            // RentaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 486);
            this.Controls.Add(this.lblRentaBuscar);
            this.Controls.Add(this.txtRentaBuscar);
            this.Controls.Add(this.btnRentaLCancelar);
            this.Controls.Add(this.btnRentaLEliminar);
            this.Controls.Add(this.btnRentaLEditar);
            this.Controls.Add(this.dgvRenta);
            this.Controls.Add(this.lblTituloRentaL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}