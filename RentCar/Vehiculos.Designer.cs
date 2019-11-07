namespace RentCar
{
    partial class Vehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculos));
            this.lblTituloVehiculo = new System.Windows.Forms.Label();
            this.btnClienteAgregar = new System.Windows.Forms.Button();
            this.btnClienteLista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloVehiculo
            // 
            this.lblTituloVehiculo.AutoSize = true;
            this.lblTituloVehiculo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVehiculo.ForeColor = System.Drawing.Color.Black;
            this.lblTituloVehiculo.Location = new System.Drawing.Point(31, 52);
            this.lblTituloVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloVehiculo.Name = "lblTituloVehiculo";
            this.lblTituloVehiculo.Size = new System.Drawing.Size(212, 47);
            this.lblTituloVehiculo.TabIndex = 2;
            this.lblTituloVehiculo.Text = "Vehiculos";
            // 
            // btnClienteAgregar
            // 
            this.btnClienteAgregar.BackColor = System.Drawing.Color.White;
            this.btnClienteAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteAgregar.Location = new System.Drawing.Point(478, 158);
            this.btnClienteAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteAgregar.Name = "btnClienteAgregar";
            this.btnClienteAgregar.Size = new System.Drawing.Size(128, 51);
            this.btnClienteAgregar.TabIndex = 10;
            this.btnClienteAgregar.Text = "Agregar";
            this.btnClienteAgregar.UseVisualStyleBackColor = false;
            this.btnClienteAgregar.Click += new System.EventHandler(this.btnClienteAgregar_Click);
            // 
            // btnClienteLista
            // 
            this.btnClienteLista.BackColor = System.Drawing.Color.White;
            this.btnClienteLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteLista.Location = new System.Drawing.Point(435, 350);
            this.btnClienteLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteLista.Name = "btnClienteLista";
            this.btnClienteLista.Size = new System.Drawing.Size(212, 44);
            this.btnClienteLista.TabIndex = 9;
            this.btnClienteLista.Text = "Mis Vehiculos";
            this.btnClienteLista.UseVisualStyleBackColor = false;
            this.btnClienteLista.Click += new System.EventHandler(this.btnClienteLista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 244);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(488, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClienteAgregar);
            this.Controls.Add(this.btnClienteLista);
            this.Controls.Add(this.lblTituloVehiculo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Vehiculos";
            this.Size = new System.Drawing.Size(1091, 588);
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloVehiculo;
        private System.Windows.Forms.Button btnClienteAgregar;
        private System.Windows.Forms.Button btnClienteLista;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
