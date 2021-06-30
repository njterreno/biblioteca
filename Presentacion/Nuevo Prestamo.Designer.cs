namespace Presentacion
{
    partial class frmNuevoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoPrestamo));
            this.pnlCbxLibros = new System.Windows.Forms.Panel();
            this.cbxLibro1 = new System.Windows.Forms.ComboBox();
            this.lblLibros = new System.Windows.Forms.Label();
            this.btnAgregarCbx = new System.Windows.Forms.Button();
            this.cbxEstadoPrestamo = new System.Windows.Forms.ComboBox();
            this.lblEstadoPrestamo = new System.Windows.Forms.Label();
            this.btnActualizarPrestamo = new System.Windows.Forms.Button();
            this.btnSalirPrestamo = new System.Windows.Forms.Button();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            this.pnl3NuevoPrestamo = new System.Windows.Forms.Panel();
            this.pnl2NuevoPrestamo = new System.Windows.Forms.Panel();
            this.pnl1NuevoPrestamo = new System.Windows.Forms.Panel();
            this.btnSalirCruzNuevoPrestamo = new System.Windows.Forms.Button();
            this.btnSalirCruzPrestamo = new System.Windows.Forms.Button();
            this.cbxSocioPrestamo = new System.Windows.Forms.ComboBox();
            this.lblSocioPrestamo = new System.Windows.Forms.Label();
            this.txtFechaDevolucion = new System.Windows.Forms.TextBox();
            this.txtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.ttMnj = new System.Windows.Forms.ToolTip(this.components);
            this.pnlCbxLibros.SuspendLayout();
            this.pnl1NuevoPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCbxLibros
            // 
            this.pnlCbxLibros.Controls.Add(this.cbxLibro1);
            this.pnlCbxLibros.Controls.Add(this.lblLibros);
            this.pnlCbxLibros.Controls.Add(this.btnAgregarCbx);
            this.pnlCbxLibros.Location = new System.Drawing.Point(271, 46);
            this.pnlCbxLibros.Name = "pnlCbxLibros";
            this.pnlCbxLibros.Size = new System.Drawing.Size(230, 235);
            this.pnlCbxLibros.TabIndex = 128;
            // 
            // cbxLibro1
            // 
            this.cbxLibro1.FormattingEnabled = true;
            this.cbxLibro1.Location = new System.Drawing.Point(1, 15);
            this.cbxLibro1.Name = "cbxLibro1";
            this.cbxLibro1.Size = new System.Drawing.Size(196, 21);
            this.cbxLibro1.TabIndex = 107;
            // 
            // lblLibros
            // 
            this.lblLibros.AutoSize = true;
            this.lblLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibros.Location = new System.Drawing.Point(66, 0);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(47, 13);
            this.lblLibros.TabIndex = 89;
            this.lblLibros.Text = "Libro/s";
            // 
            // btnAgregarCbx
            // 
            this.btnAgregarCbx.FlatAppearance.BorderSize = 0;
            this.btnAgregarCbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCbx.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCbx.Image")));
            this.btnAgregarCbx.Location = new System.Drawing.Point(197, 9);
            this.btnAgregarCbx.Name = "btnAgregarCbx";
            this.btnAgregarCbx.Size = new System.Drawing.Size(31, 31);
            this.btnAgregarCbx.TabIndex = 106;
            this.btnAgregarCbx.UseVisualStyleBackColor = true;
            this.btnAgregarCbx.Visible = false;
            this.btnAgregarCbx.Click += new System.EventHandler(this.btnAgregarCbx_Click);
            // 
            // cbxEstadoPrestamo
            // 
            this.cbxEstadoPrestamo.BackColor = System.Drawing.Color.LightCoral;
            this.cbxEstadoPrestamo.FormattingEnabled = true;
            this.cbxEstadoPrestamo.Location = new System.Drawing.Point(59, 217);
            this.cbxEstadoPrestamo.Name = "cbxEstadoPrestamo";
            this.cbxEstadoPrestamo.Size = new System.Drawing.Size(206, 21);
            this.cbxEstadoPrestamo.TabIndex = 125;
            // 
            // lblEstadoPrestamo
            // 
            this.lblEstadoPrestamo.AutoSize = true;
            this.lblEstadoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPrestamo.Location = new System.Drawing.Point(14, 220);
            this.lblEstadoPrestamo.Name = "lblEstadoPrestamo";
            this.lblEstadoPrestamo.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoPrestamo.TabIndex = 124;
            this.lblEstadoPrestamo.Text = "Estado";
            // 
            // btnActualizarPrestamo
            // 
            this.btnActualizarPrestamo.BackColor = System.Drawing.Color.DarkGray;
            this.btnActualizarPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnActualizarPrestamo.FlatAppearance.BorderSize = 2;
            this.btnActualizarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPrestamo.ForeColor = System.Drawing.Color.Green;
            this.btnActualizarPrestamo.Location = new System.Drawing.Point(312, 296);
            this.btnActualizarPrestamo.Name = "btnActualizarPrestamo";
            this.btnActualizarPrestamo.Size = new System.Drawing.Size(89, 33);
            this.btnActualizarPrestamo.TabIndex = 113;
            this.btnActualizarPrestamo.Text = "Actualizar";
            this.btnActualizarPrestamo.UseVisualStyleBackColor = false;
            this.btnActualizarPrestamo.Click += new System.EventHandler(this.btnActualizarPrestamo_Click);
            // 
            // btnSalirPrestamo
            // 
            this.btnSalirPrestamo.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalirPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalirPrestamo.FlatAppearance.BorderSize = 2;
            this.btnSalirPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPrestamo.ForeColor = System.Drawing.Color.Red;
            this.btnSalirPrestamo.Location = new System.Drawing.Point(407, 296);
            this.btnSalirPrestamo.Name = "btnSalirPrestamo";
            this.btnSalirPrestamo.Size = new System.Drawing.Size(89, 33);
            this.btnSalirPrestamo.TabIndex = 112;
            this.btnSalirPrestamo.Text = "Salir";
            this.btnSalirPrestamo.UseVisualStyleBackColor = false;
            this.btnSalirPrestamo.Click += new System.EventHandler(this.btnSalirPrestamo_Click);
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.BackColor = System.Drawing.Color.DarkGray;
            this.btnGuardarPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnGuardarPrestamo.FlatAppearance.BorderSize = 2;
            this.btnGuardarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrestamo.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(298, 296);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(89, 33);
            this.btnGuardarPrestamo.TabIndex = 111;
            this.btnGuardarPrestamo.Text = "Guardar";
            this.btnGuardarPrestamo.UseVisualStyleBackColor = false;
            this.btnGuardarPrestamo.Click += new System.EventHandler(this.btnGuardarPrestamo_Click);
            // 
            // pnl3NuevoPrestamo
            // 
            this.pnl3NuevoPrestamo.BackColor = System.Drawing.Color.Maroon;
            this.pnl3NuevoPrestamo.Location = new System.Drawing.Point(502, 29);
            this.pnl3NuevoPrestamo.Name = "pnl3NuevoPrestamo";
            this.pnl3NuevoPrestamo.Size = new System.Drawing.Size(11, 300);
            this.pnl3NuevoPrestamo.TabIndex = 110;
            // 
            // pnl2NuevoPrestamo
            // 
            this.pnl2NuevoPrestamo.BackColor = System.Drawing.Color.Maroon;
            this.pnl2NuevoPrestamo.Location = new System.Drawing.Point(3, 29);
            this.pnl2NuevoPrestamo.Name = "pnl2NuevoPrestamo";
            this.pnl2NuevoPrestamo.Size = new System.Drawing.Size(11, 300);
            this.pnl2NuevoPrestamo.TabIndex = 109;
            // 
            // pnl1NuevoPrestamo
            // 
            this.pnl1NuevoPrestamo.BackColor = System.Drawing.Color.Maroon;
            this.pnl1NuevoPrestamo.Controls.Add(this.btnSalirCruzNuevoPrestamo);
            this.pnl1NuevoPrestamo.Controls.Add(this.btnSalirCruzPrestamo);
            this.pnl1NuevoPrestamo.Location = new System.Drawing.Point(3, 2);
            this.pnl1NuevoPrestamo.Name = "pnl1NuevoPrestamo";
            this.pnl1NuevoPrestamo.Size = new System.Drawing.Size(510, 30);
            this.pnl1NuevoPrestamo.TabIndex = 108;
            // 
            // btnSalirCruzNuevoPrestamo
            // 
            this.btnSalirCruzNuevoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCruzNuevoPrestamo.ForeColor = System.Drawing.Color.Black;
            this.btnSalirCruzNuevoPrestamo.Location = new System.Drawing.Point(485, 3);
            this.btnSalirCruzNuevoPrestamo.Name = "btnSalirCruzNuevoPrestamo";
            this.btnSalirCruzNuevoPrestamo.Size = new System.Drawing.Size(22, 23);
            this.btnSalirCruzNuevoPrestamo.TabIndex = 22;
            this.btnSalirCruzNuevoPrestamo.Text = "X";
            this.btnSalirCruzNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btnSalirCruzNuevoPrestamo.Click += new System.EventHandler(this.btnSalirCruzNuevoPrestamo_Click);
            // 
            // btnSalirCruzPrestamo
            // 
            this.btnSalirCruzPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCruzPrestamo.ForeColor = System.Drawing.Color.Black;
            this.btnSalirCruzPrestamo.Location = new System.Drawing.Point(848, 4);
            this.btnSalirCruzPrestamo.Name = "btnSalirCruzPrestamo";
            this.btnSalirCruzPrestamo.Size = new System.Drawing.Size(22, 23);
            this.btnSalirCruzPrestamo.TabIndex = 0;
            this.btnSalirCruzPrestamo.Text = "X";
            this.btnSalirCruzPrestamo.UseVisualStyleBackColor = true;
            // 
            // cbxSocioPrestamo
            // 
            this.cbxSocioPrestamo.FormattingEnabled = true;
            this.cbxSocioPrestamo.Location = new System.Drawing.Point(59, 52);
            this.cbxSocioPrestamo.Name = "cbxSocioPrestamo";
            this.cbxSocioPrestamo.Size = new System.Drawing.Size(206, 21);
            this.cbxSocioPrestamo.TabIndex = 130;
            // 
            // lblSocioPrestamo
            // 
            this.lblSocioPrestamo.AutoSize = true;
            this.lblSocioPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocioPrestamo.Location = new System.Drawing.Point(14, 55);
            this.lblSocioPrestamo.Name = "lblSocioPrestamo";
            this.lblSocioPrestamo.Size = new System.Drawing.Size(39, 13);
            this.lblSocioPrestamo.TabIndex = 129;
            this.lblSocioPrestamo.Text = "Socio";
            // 
            // txtFechaDevolucion
            // 
            this.txtFechaDevolucion.Enabled = false;
            this.txtFechaDevolucion.Location = new System.Drawing.Point(59, 152);
            this.txtFechaDevolucion.Name = "txtFechaDevolucion";
            this.txtFechaDevolucion.Size = new System.Drawing.Size(206, 20);
            this.txtFechaDevolucion.TabIndex = 134;
            // 
            // txtFechaPrestamo
            // 
            this.txtFechaPrestamo.Enabled = false;
            this.txtFechaPrestamo.Location = new System.Drawing.Point(59, 106);
            this.txtFechaPrestamo.Name = "txtFechaPrestamo";
            this.txtFechaPrestamo.Size = new System.Drawing.Size(206, 20);
            this.txtFechaPrestamo.TabIndex = 133;
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.Location = new System.Drawing.Point(98, 136);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(128, 13);
            this.lblFechaDevolucion.TabIndex = 132;
            this.lblFechaDevolucion.Text = "Fecha de Devolución";
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.Location = new System.Drawing.Point(104, 90);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(116, 13);
            this.lblFechaPrestamo.TabIndex = 131;
            this.lblFechaPrestamo.Text = "Fecha de Préstamo";
            // 
            // ttMnj
            // 
            this.ttMnj.IsBalloon = true;
            this.ttMnj.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmNuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(516, 330);
            this.Controls.Add(this.txtFechaDevolucion);
            this.Controls.Add(this.txtFechaPrestamo);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.cbxSocioPrestamo);
            this.Controls.Add(this.lblSocioPrestamo);
            this.Controls.Add(this.pnlCbxLibros);
            this.Controls.Add(this.cbxEstadoPrestamo);
            this.Controls.Add(this.lblEstadoPrestamo);
            this.Controls.Add(this.btnActualizarPrestamo);
            this.Controls.Add(this.btnSalirPrestamo);
            this.Controls.Add(this.btnGuardarPrestamo);
            this.Controls.Add(this.pnl3NuevoPrestamo);
            this.Controls.Add(this.pnl2NuevoPrestamo);
            this.Controls.Add(this.pnl1NuevoPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo_Prestamo";
            this.pnlCbxLibros.ResumeLayout(false);
            this.pnlCbxLibros.PerformLayout();
            this.pnl1NuevoPrestamo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCbxLibros;
        public System.Windows.Forms.ComboBox cbxLibro1;
        private System.Windows.Forms.Label lblLibros;
        private System.Windows.Forms.Button btnAgregarCbx;
        private System.Windows.Forms.Label lblEstadoPrestamo;
        public System.Windows.Forms.Button btnActualizarPrestamo;
        private System.Windows.Forms.Button btnSalirPrestamo;
        public System.Windows.Forms.Button btnGuardarPrestamo;
        private System.Windows.Forms.Panel pnl3NuevoPrestamo;
        private System.Windows.Forms.Panel pnl2NuevoPrestamo;
        private System.Windows.Forms.Panel pnl1NuevoPrestamo;
        private System.Windows.Forms.Button btnSalirCruzNuevoPrestamo;
        private System.Windows.Forms.Button btnSalirCruzPrestamo;
        private System.Windows.Forms.ComboBox cbxSocioPrestamo;
        private System.Windows.Forms.Label lblSocioPrestamo;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Label lblFechaPrestamo;
        public System.Windows.Forms.ComboBox cbxEstadoPrestamo;
        public System.Windows.Forms.TextBox txtFechaDevolucion;
        public System.Windows.Forms.TextBox txtFechaPrestamo;
        private System.Windows.Forms.ToolTip ttMnj;
    }
}