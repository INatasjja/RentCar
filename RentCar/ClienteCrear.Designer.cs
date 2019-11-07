using System;
using System.Windows.Forms;

namespace RentCar
{
    partial class ClienteCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteCrear));
            this.lblClienteTitulo = new System.Windows.Forms.Label();
            this.lblCliNombre = new System.Windows.Forms.Label();
            this.lblCliApellido = new System.Windows.Forms.Label();
            this.txtCliApellido = new System.Windows.Forms.TextBox();
            this.lblCliCedula = new System.Windows.Forms.Label();
            this.txtCliCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtCliCredCard = new System.Windows.Forms.MaskedTextBox();
            this.lblCliCredCard = new System.Windows.Forms.Label();
            this.lblCliCredLim = new System.Windows.Forms.Label();
            this.txtCliCredLim = new System.Windows.Forms.TextBox();
            this.lblCliTipoCli = new System.Windows.Forms.Label();
            this.cbCliTipoCli = new System.Windows.Forms.ComboBox();
            this.ckbCliEstado = new System.Windows.Forms.CheckBox();
            this.lblCliEstado = new System.Windows.Forms.Label();
            this.lblCliId = new System.Windows.Forms.Label();
            this.btnCliGuardar = new System.Windows.Forms.Button();
            this.btnCliCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblClienteTitulo
            // 
            this.lblClienteTitulo.AutoSize = true;
            this.lblClienteTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblClienteTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteTitulo.ForeColor = System.Drawing.Color.White;
            this.lblClienteTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblClienteTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteTitulo.Name = "lblClienteTitulo";
            this.lblClienteTitulo.Size = new System.Drawing.Size(451, 46);
            this.lblClienteTitulo.TabIndex = 0;
            this.lblClienteTitulo.Text = "Informacion del Cliente";
            // 
            // lblCliNombre
            // 
            this.lblCliNombre.AutoSize = true;
            this.lblCliNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliNombre.ForeColor = System.Drawing.Color.White;
            this.lblCliNombre.Location = new System.Drawing.Point(19, 83);
            this.lblCliNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliNombre.Name = "lblCliNombre";
            this.lblCliNombre.Size = new System.Drawing.Size(107, 29);
            this.lblCliNombre.TabIndex = 2;
            this.lblCliNombre.Text = "Nombre:";
            // 
            // lblCliApellido
            // 
            this.lblCliApellido.AutoSize = true;
            this.lblCliApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliApellido.ForeColor = System.Drawing.Color.White;
            this.lblCliApellido.Location = new System.Drawing.Point(21, 130);
            this.lblCliApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliApellido.Name = "lblCliApellido";
            this.lblCliApellido.Size = new System.Drawing.Size(108, 29);
            this.lblCliApellido.TabIndex = 4;
            this.lblCliApellido.Text = "Apellido:";
            // 
            // txtCliApellido
            // 
            this.txtCliApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliApellido.Location = new System.Drawing.Point(291, 130);
            this.txtCliApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliApellido.Name = "txtCliApellido";
            this.txtCliApellido.Size = new System.Drawing.Size(225, 30);
            this.txtCliApellido.TabIndex = 2;
            // 
            // lblCliCedula
            // 
            this.lblCliCedula.AutoSize = true;
            this.lblCliCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCedula.ForeColor = System.Drawing.Color.White;
            this.lblCliCedula.Location = new System.Drawing.Point(21, 173);
            this.lblCliCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliCedula.Name = "lblCliCedula";
            this.lblCliCedula.Size = new System.Drawing.Size(96, 29);
            this.lblCliCedula.TabIndex = 5;
            this.lblCliCedula.Text = "Cédula:";
            // 
            // txtCliCedula
            // 
            this.txtCliCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliCedula.Location = new System.Drawing.Point(291, 167);
            this.txtCliCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliCedula.Mask = "000-0000000-0";
            this.txtCliCedula.Name = "txtCliCedula";
            this.txtCliCedula.Size = new System.Drawing.Size(155, 30);
            this.txtCliCedula.TabIndex = 3;
            this.txtCliCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtCliCedula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCliCedula_MaskInputRejected);
            // 
            // txtCliCredCard
            // 
            this.txtCliCredCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliCredCard.Location = new System.Drawing.Point(291, 212);
            this.txtCliCredCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliCredCard.Mask = "0000  0000  0000  0000";
            this.txtCliCredCard.Name = "txtCliCredCard";
            this.txtCliCredCard.Size = new System.Drawing.Size(233, 30);
            this.txtCliCredCard.TabIndex = 4;
            this.txtCliCredCard.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lblCliCredCard
            // 
            this.lblCliCredCard.AutoSize = true;
            this.lblCliCredCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCredCard.ForeColor = System.Drawing.Color.White;
            this.lblCliCredCard.Location = new System.Drawing.Point(21, 212);
            this.lblCliCredCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliCredCard.Name = "lblCliCredCard";
            this.lblCliCredCard.Size = new System.Drawing.Size(253, 29);
            this.lblCliCredCard.TabIndex = 7;
            this.lblCliCredCard.Text = "No. Tarjeta de crédito:";
            // 
            // lblCliCredLim
            // 
            this.lblCliCredLim.AutoSize = true;
            this.lblCliCredLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCredLim.ForeColor = System.Drawing.Color.White;
            this.lblCliCredLim.Location = new System.Drawing.Point(580, 83);
            this.lblCliCredLim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliCredLim.Name = "lblCliCredLim";
            this.lblCliCredLim.Size = new System.Drawing.Size(198, 29);
            this.lblCliCredLim.TabIndex = 10;
            this.lblCliCredLim.Text = "Límite de crédito:";
            // 
            // txtCliCredLim
            // 
            this.txtCliCredLim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliCredLim.Location = new System.Drawing.Point(786, 83);
            this.txtCliCredLim.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliCredLim.Name = "txtCliCredLim";
            this.txtCliCredLim.Size = new System.Drawing.Size(225, 30);
            this.txtCliCredLim.TabIndex = 5;
            this.txtCliCredLim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCliCredLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliCredLim_KeyPress);
            // 
            // lblCliTipoCli
            // 
            this.lblCliTipoCli.AutoSize = true;
            this.lblCliTipoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliTipoCli.ForeColor = System.Drawing.Color.White;
            this.lblCliTipoCli.Location = new System.Drawing.Point(581, 168);
            this.lblCliTipoCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliTipoCli.Name = "lblCliTipoCli";
            this.lblCliTipoCli.Size = new System.Drawing.Size(197, 29);
            this.lblCliTipoCli.TabIndex = 11;
            this.lblCliTipoCli.Text = "Tipo de persona:";
            // 
            // cbCliTipoCli
            // 
            this.cbCliTipoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliTipoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliTipoCli.FormattingEnabled = true;
            this.cbCliTipoCli.Location = new System.Drawing.Point(786, 168);
            this.cbCliTipoCli.Margin = new System.Windows.Forms.Padding(4);
            this.cbCliTipoCli.Name = "cbCliTipoCli";
            this.cbCliTipoCli.Size = new System.Drawing.Size(164, 33);
            this.cbCliTipoCli.TabIndex = 6;
            // 
            // ckbCliEstado
            // 
            this.ckbCliEstado.AutoSize = true;
            this.ckbCliEstado.Checked = true;
            this.ckbCliEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbCliEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCliEstado.Location = new System.Drawing.Point(127, 293);
            this.ckbCliEstado.Margin = new System.Windows.Forms.Padding(4);
            this.ckbCliEstado.Name = "ckbCliEstado";
            this.ckbCliEstado.Size = new System.Drawing.Size(18, 17);
            this.ckbCliEstado.TabIndex = 7;
            this.ckbCliEstado.UseVisualStyleBackColor = true;
            // 
            // lblCliEstado
            // 
            this.lblCliEstado.AutoSize = true;
            this.lblCliEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliEstado.ForeColor = System.Drawing.Color.White;
            this.lblCliEstado.Location = new System.Drawing.Point(21, 283);
            this.lblCliEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliEstado.Name = "lblCliEstado";
            this.lblCliEstado.Size = new System.Drawing.Size(83, 29);
            this.lblCliEstado.TabIndex = 14;
            this.lblCliEstado.Text = "Activo:";
            // 
            // lblCliId
            // 
            this.lblCliId.AutoSize = true;
            this.lblCliId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblCliId.Location = new System.Drawing.Point(854, 21);
            this.lblCliId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliId.Name = "lblCliId";
            this.lblCliId.Size = new System.Drawing.Size(154, 36);
            this.lblCliId.TabIndex = 15;
            this.lblCliId.Text = "Cliente ID";
            // 
            // btnCliGuardar
            // 
            this.btnCliGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCliGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliGuardar.ForeColor = System.Drawing.Color.White;
            this.btnCliGuardar.Location = new System.Drawing.Point(765, 351);
            this.btnCliGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliGuardar.Name = "btnCliGuardar";
            this.btnCliGuardar.Size = new System.Drawing.Size(120, 37);
            this.btnCliGuardar.TabIndex = 9;
            this.btnCliGuardar.Text = "Guardar";
            this.btnCliGuardar.UseVisualStyleBackColor = false;
            this.btnCliGuardar.Click += new System.EventHandler(this.btnCliGuardar_Click);
            // 
            // btnCliCancelar
            // 
            this.btnCliCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliCancelar.Location = new System.Drawing.Point(911, 351);
            this.btnCliCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCliCancelar.Name = "btnCliCancelar";
            this.btnCliCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnCliCancelar.TabIndex = 8;
            this.btnCliCancelar.Text = "Cancelar";
            this.btnCliCancelar.UseVisualStyleBackColor = true;
            this.btnCliCancelar.Click += new System.EventHandler(this.btnCliCancelar_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1035, 2);
            this.label1.TabIndex = 16;
            // 
            // txtCliNombre
            // 
            this.txtCliNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliNombre.Location = new System.Drawing.Point(291, 83);
            this.txtCliNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliNombre.Name = "txtCliNombre";
            this.txtCliNombre.Size = new System.Drawing.Size(225, 30);
            this.txtCliNombre.TabIndex = 1;
            // 
            // ClienteCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1067, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCliCancelar);
            this.Controls.Add(this.btnCliGuardar);
            this.Controls.Add(this.lblCliId);
            this.Controls.Add(this.lblCliEstado);
            this.Controls.Add(this.ckbCliEstado);
            this.Controls.Add(this.cbCliTipoCli);
            this.Controls.Add(this.lblCliTipoCli);
            this.Controls.Add(this.lblCliCredLim);
            this.Controls.Add(this.txtCliCredLim);
            this.Controls.Add(this.txtCliCredCard);
            this.Controls.Add(this.lblCliCredCard);
            this.Controls.Add(this.txtCliCedula);
            this.Controls.Add(this.lblCliCedula);
            this.Controls.Add(this.lblCliApellido);
            this.Controls.Add(this.txtCliApellido);
            this.Controls.Add(this.lblCliNombre);
            this.Controls.Add(this.txtCliNombre);
            this.Controls.Add(this.lblClienteTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.ClienteCrear_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtCliCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblClienteTitulo;
        private System.Windows.Forms.Label lblCliNombre;
        private System.Windows.Forms.Label lblCliApellido;
        private System.Windows.Forms.TextBox txtCliApellido;
        private System.Windows.Forms.Label lblCliCedula;
        private System.Windows.Forms.MaskedTextBox txtCliCedula;
        private System.Windows.Forms.MaskedTextBox txtCliCredCard;
        private System.Windows.Forms.Label lblCliCredCard;
        private System.Windows.Forms.Label lblCliCredLim;
        private System.Windows.Forms.TextBox txtCliCredLim;
        private System.Windows.Forms.Label lblCliTipoCli;
        private System.Windows.Forms.ComboBox cbCliTipoCli;
        private System.Windows.Forms.CheckBox ckbCliEstado;
        private System.Windows.Forms.Label lblCliEstado;
        private System.Windows.Forms.Label lblCliId;
        private System.Windows.Forms.Button btnCliGuardar;
        private System.Windows.Forms.Button btnCliCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliNombre;
    }
}