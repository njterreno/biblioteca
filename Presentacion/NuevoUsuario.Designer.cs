namespace Presentacion
{
    partial class NuevoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.txtContraseñaNuevoUsuario = new System.Windows.Forms.TextBox();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardarNuevoUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrarClave = new System.Windows.Forms.Button();
            this.ttMnj = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContraseñaNuevoUsuario
            // 
            this.txtContraseñaNuevoUsuario.Location = new System.Drawing.Point(75, 110);
            this.txtContraseñaNuevoUsuario.Name = "txtContraseñaNuevoUsuario";
            this.txtContraseñaNuevoUsuario.Size = new System.Drawing.Size(197, 20);
            this.txtContraseñaNuevoUsuario.TabIndex = 7;
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(75, 50);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(197, 20);
            this.txtNuevoUsuario.TabIndex = 6;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(18, 111);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(38, 16);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Clave";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 51);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(51, 16);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(195, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 29);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardarNuevoUsuario
            // 
            this.btnGuardarNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuardarNuevoUsuario.FlatAppearance.BorderSize = 2;
            this.btnGuardarNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoUsuario.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardarNuevoUsuario.Location = new System.Drawing.Point(75, 168);
            this.btnGuardarNuevoUsuario.Name = "btnGuardarNuevoUsuario";
            this.btnGuardarNuevoUsuario.Size = new System.Drawing.Size(100, 29);
            this.btnGuardarNuevoUsuario.TabIndex = 9;
            this.btnGuardarNuevoUsuario.Text = "Guardar";
            this.btnGuardarNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarNuevoUsuario.Click += new System.EventHandler(this.btnGuardarNuevoUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 20);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Usuario";
            // 
            // btnMostrarClave
            // 
            this.btnMostrarClave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMostrarClave.Location = new System.Drawing.Point(197, 136);
            this.btnMostrarClave.Name = "btnMostrarClave";
            this.btnMostrarClave.Size = new System.Drawing.Size(75, 27);
            this.btnMostrarClave.TabIndex = 11;
            this.btnMostrarClave.Text = "Mostrar Clave";
            this.btnMostrarClave.UseVisualStyleBackColor = true;
            this.btnMostrarClave.Click += new System.EventHandler(this.btnMostrarClave_Click);
            // 
            // ttMnj
            // 
            this.ttMnj.AutoPopDelay = 5000;
            this.ttMnj.InitialDelay = 500;
            this.ttMnj.IsBalloon = true;
            this.ttMnj.ReshowDelay = 100;
            this.ttMnj.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMostrarClave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGuardarNuevoUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtContraseñaNuevoUsuario);
            this.Controls.Add(this.txtNuevoUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevoUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseñaNuevoUsuario;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardarNuevoUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarClave;
        private System.Windows.Forms.ToolTip ttMnj;
    }
}