namespace RentCar
{
    partial class Renta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Renta));
            this.lblTituloRenta = new System.Windows.Forms.Label();
            this.btnRentarVehiculo = new System.Windows.Forms.Button();
            this.btnDevolverVehiculo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloRenta
            // 
            this.lblTituloRenta.AutoSize = true;
            this.lblTituloRenta.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRenta.ForeColor = System.Drawing.Color.Black;
            this.lblTituloRenta.Location = new System.Drawing.Point(19, 42);
            this.lblTituloRenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloRenta.Name = "lblTituloRenta";
            this.lblTituloRenta.Size = new System.Drawing.Size(131, 47);
            this.lblTituloRenta.TabIndex = 3;
            this.lblTituloRenta.Text = "Renta";
            // 
            // btnRentarVehiculo
            // 
            this.btnRentarVehiculo.BackColor = System.Drawing.Color.White;
            this.btnRentarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentarVehiculo.Location = new System.Drawing.Point(451, 166);
            this.btnRentarVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRentarVehiculo.Name = "btnRentarVehiculo";
            this.btnRentarVehiculo.Size = new System.Drawing.Size(118, 47);
            this.btnRentarVehiculo.TabIndex = 10;
            this.btnRentarVehiculo.Text = "Nueva Renta";
            this.btnRentarVehiculo.UseVisualStyleBackColor = false;
            this.btnRentarVehiculo.Click += new System.EventHandler(this.btnRentarVehiculo_Click);
            // 
            // btnDevolverVehiculo
            // 
            this.btnDevolverVehiculo.BackColor = System.Drawing.Color.White;
            this.btnDevolverVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverVehiculo.Location = new System.Drawing.Point(425, 381);
            this.btnDevolverVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDevolverVehiculo.Name = "btnDevolverVehiculo";
            this.btnDevolverVehiculo.Size = new System.Drawing.Size(172, 47);
            this.btnDevolverVehiculo.TabIndex = 9;
            this.btnDevolverVehiculo.Text = "Mis Rentas";
            this.btnDevolverVehiculo.UseVisualStyleBackColor = false;
            this.btnDevolverVehiculo.Click += new System.EventHandler(this.btnDevolverVehiculo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 275);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(455, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Renta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRentarVehiculo);
            this.Controls.Add(this.btnDevolverVehiculo);
            this.Controls.Add(this.lblTituloRenta);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Renta";
            this.Size = new System.Drawing.Size(1091, 588);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloRenta;
        private System.Windows.Forms.Button btnRentarVehiculo;
        private System.Windows.Forms.Button btnDevolverVehiculo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
