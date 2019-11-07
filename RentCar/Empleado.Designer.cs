namespace RentCar
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.lblTituloEmpleados = new System.Windows.Forms.Label();
            this.btnClienteAgregar = new System.Windows.Forms.Button();
            this.btnClienteLista = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloEmpleados
            // 
            this.lblTituloEmpleados.AutoSize = true;
            this.lblTituloEmpleados.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmpleados.ForeColor = System.Drawing.Color.Black;
            this.lblTituloEmpleados.Location = new System.Drawing.Point(20, 43);
            this.lblTituloEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloEmpleados.Name = "lblTituloEmpleados";
            this.lblTituloEmpleados.Size = new System.Drawing.Size(237, 47);
            this.lblTituloEmpleados.TabIndex = 4;
            this.lblTituloEmpleados.Text = "Empleados";
            // 
            // btnClienteAgregar
            // 
            this.btnClienteAgregar.BackColor = System.Drawing.Color.White;
            this.btnClienteAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteAgregar.Location = new System.Drawing.Point(421, 149);
            this.btnClienteAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteAgregar.Name = "btnClienteAgregar";
            this.btnClienteAgregar.Size = new System.Drawing.Size(156, 46);
            this.btnClienteAgregar.TabIndex = 10;
            this.btnClienteAgregar.Text = "Agregar";
            this.btnClienteAgregar.UseVisualStyleBackColor = false;
            this.btnClienteAgregar.Click += new System.EventHandler(this.btnClienteAgregar_Click);
            // 
            // btnClienteLista
            // 
            this.btnClienteLista.BackColor = System.Drawing.Color.White;
            this.btnClienteLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteLista.Location = new System.Drawing.Point(384, 353);
            this.btnClienteLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClienteLista.Name = "btnClienteLista";
            this.btnClienteLista.Size = new System.Drawing.Size(235, 46);
            this.btnClienteLista.TabIndex = 9;
            this.btnClienteLista.Text = "Ver empleados";
            this.btnClienteLista.UseVisualStyleBackColor = false;
            this.btnClienteLista.Click += new System.EventHandler(this.btnClienteLista_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(445, 43);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 247);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClienteAgregar);
            this.Controls.Add(this.btnClienteLista);
            this.Controls.Add(this.lblTituloEmpleados);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Empleado";
            this.Size = new System.Drawing.Size(1091, 588);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloEmpleados;
        private System.Windows.Forms.Button btnClienteAgregar;
        private System.Windows.Forms.Button btnClienteLista;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
