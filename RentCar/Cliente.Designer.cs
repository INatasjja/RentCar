namespace RentCar
{
    partial class Cliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.btnClienteLista = new System.Windows.Forms.Button();
            this.btnClienteAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.Location = new System.Drawing.Point(35, 56);
            this.lblTituloCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(177, 47);
            this.lblTituloCliente.TabIndex = 3;
            this.lblTituloCliente.Text = "Clientes";
            // 
            // btnClienteLista
            // 
            this.btnClienteLista.BackColor = System.Drawing.Color.White;
            this.btnClienteLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteLista.Location = new System.Drawing.Point(451, 383);
            this.btnClienteLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteLista.Name = "btnClienteLista";
            this.btnClienteLista.Size = new System.Drawing.Size(192, 54);
            this.btnClienteLista.TabIndex = 4;
            this.btnClienteLista.Text = "Mis Clientes";
            this.btnClienteLista.UseVisualStyleBackColor = false;
            this.btnClienteLista.Click += new System.EventHandler(this.btnClienteLista_Click);
            // 
            // btnClienteAgregar
            // 
            this.btnClienteAgregar.BackColor = System.Drawing.Color.White;
            this.btnClienteAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnClienteAgregar.Location = new System.Drawing.Point(451, 162);
            this.btnClienteAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteAgregar.Name = "btnClienteAgregar";
            this.btnClienteAgregar.Size = new System.Drawing.Size(192, 54);
            this.btnClienteAgregar.TabIndex = 5;
            this.btnClienteAgregar.Text = "Nuevo";
            this.btnClienteAgregar.UseVisualStyleBackColor = false;
            this.btnClienteAgregar.Click += new System.EventHandler(this.btnClienteAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(492, 277);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(492, 56);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClienteAgregar);
            this.Controls.Add(this.btnClienteLista);
            this.Controls.Add(this.lblTituloCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cliente";
            this.Size = new System.Drawing.Size(1091, 588);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.Button btnClienteLista;
        private System.Windows.Forms.Button btnClienteAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
