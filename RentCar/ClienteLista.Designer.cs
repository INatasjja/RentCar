namespace RentCar
{
    partial class ClienteLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteLista));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblClienteTitulo = new System.Windows.Forms.Label();
            this.btnClienteLEditar = new System.Windows.Forms.Button();
            this.btnClienteLEliminar = new System.Windows.Forms.Button();
            this.btnClienteLCancelar = new System.Windows.Forms.Button();
            this.txtClienteBuscar = new System.Windows.Forms.TextBox();
            this.lblClienteBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(16, 96);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(1116, 414);
            this.dgvClientes.TabIndex = 1;
            // 
            // lblClienteTitulo
            // 
            this.lblClienteTitulo.AutoSize = true;
            this.lblClienteTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblClienteTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblClienteTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteTitulo.Name = "lblClienteTitulo";
            this.lblClienteTitulo.Size = new System.Drawing.Size(323, 46);
            this.lblClienteTitulo.TabIndex = 2;
            this.lblClienteTitulo.Text = "Lista de clientes";
            // 
            // btnClienteLEditar
            // 
            this.btnClienteLEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClienteLEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteLEditar.Location = new System.Drawing.Point(756, 537);
            this.btnClienteLEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteLEditar.Name = "btnClienteLEditar";
            this.btnClienteLEditar.Size = new System.Drawing.Size(120, 37);
            this.btnClienteLEditar.TabIndex = 10;
            this.btnClienteLEditar.Text = "Editar";
            this.btnClienteLEditar.UseVisualStyleBackColor = false;
            this.btnClienteLEditar.Click += new System.EventHandler(this.btnClienteLEditar_Click);
            // 
            // btnClienteLEliminar
            // 
            this.btnClienteLEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnClienteLEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteLEliminar.Location = new System.Drawing.Point(884, 537);
            this.btnClienteLEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteLEliminar.Name = "btnClienteLEliminar";
            this.btnClienteLEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnClienteLEliminar.TabIndex = 11;
            this.btnClienteLEliminar.Text = "Eliminar";
            this.btnClienteLEliminar.UseVisualStyleBackColor = false;
            this.btnClienteLEliminar.Click += new System.EventHandler(this.btnClienteLEliminar_Click);
            // 
            // btnClienteLCancelar
            // 
            this.btnClienteLCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteLCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnClienteLCancelar.Location = new System.Drawing.Point(1012, 537);
            this.btnClienteLCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteLCancelar.Name = "btnClienteLCancelar";
            this.btnClienteLCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnClienteLCancelar.TabIndex = 12;
            this.btnClienteLCancelar.Text = "Cancelar";
            this.btnClienteLCancelar.UseVisualStyleBackColor = true;
            this.btnClienteLCancelar.Click += new System.EventHandler(this.btnClienteLCancelar_Click);
            // 
            // txtClienteBuscar
            // 
            this.txtClienteBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteBuscar.Location = new System.Drawing.Point(923, 28);
            this.txtClienteBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClienteBuscar.Name = "txtClienteBuscar";
            this.txtClienteBuscar.Size = new System.Drawing.Size(208, 30);
            this.txtClienteBuscar.TabIndex = 13;
            this.txtClienteBuscar.TextChanged += new System.EventHandler(this.txtClienteBuscar_TextChanged);
            // 
            // lblClienteBuscar
            // 
            this.lblClienteBuscar.AutoSize = true;
            this.lblClienteBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteBuscar.Location = new System.Drawing.Point(831, 32);
            this.lblClienteBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteBuscar.Name = "lblClienteBuscar";
            this.lblClienteBuscar.Size = new System.Drawing.Size(79, 25);
            this.lblClienteBuscar.TabIndex = 14;
            this.lblClienteBuscar.Text = "Buscar:";
            // 
            // ClienteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1159, 598);
            this.Controls.Add(this.lblClienteBuscar);
            this.Controls.Add(this.txtClienteBuscar);
            this.Controls.Add(this.btnClienteLCancelar);
            this.Controls.Add(this.btnClienteLEliminar);
            this.Controls.Add(this.btnClienteLEditar);
            this.Controls.Add(this.lblClienteTitulo);
            this.Controls.Add(this.dgvClientes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de clientes";
            this.Load += new System.EventHandler(this.ClienteLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblClienteTitulo;
        private System.Windows.Forms.Button btnClienteLEditar;
        private System.Windows.Forms.Button btnClienteLEliminar;
        private System.Windows.Forms.Button btnClienteLCancelar;
        private System.Windows.Forms.TextBox txtClienteBuscar;
        private System.Windows.Forms.Label lblClienteBuscar;
    }
}