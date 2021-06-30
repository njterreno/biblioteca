namespace Presentacion
{
    partial class frmLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl4Libros = new System.Windows.Forms.Panel();
            this.pnl3Libros = new System.Windows.Forms.Panel();
            this.pnl1Libros = new System.Windows.Forms.Panel();
            this.btnSalirCruzLibros = new System.Windows.Forms.Button();
            this.pnlAccesosDirectosLibros = new System.Windows.Forms.Panel();
            this.btnBajaOAltaLibro = new System.Windows.Forms.Button();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.btnSalirLibros = new System.Windows.Forms.Button();
            this.btnNuevoLibro = new System.Windows.Forms.Button();
            this.pnl2Libros = new System.Windows.Forms.Panel();
            this.dgvInfoLibros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutorLibro = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.lblAutorLibro = new System.Windows.Forms.Label();
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.ttMnj = new System.Windows.Forms.ToolTip(this.components);
            this.pnl1Libros.SuspendLayout();
            this.pnlAccesosDirectosLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl4Libros
            // 
            this.pnl4Libros.BackColor = System.Drawing.Color.Maroon;
            this.pnl4Libros.Location = new System.Drawing.Point(865, 26);
            this.pnl4Libros.Name = "pnl4Libros";
            this.pnl4Libros.Size = new System.Drawing.Size(11, 404);
            this.pnl4Libros.TabIndex = 16;
            // 
            // pnl3Libros
            // 
            this.pnl3Libros.BackColor = System.Drawing.Color.Maroon;
            this.pnl3Libros.Location = new System.Drawing.Point(267, 26);
            this.pnl3Libros.Name = "pnl3Libros";
            this.pnl3Libros.Size = new System.Drawing.Size(11, 404);
            this.pnl3Libros.TabIndex = 15;
            // 
            // pnl1Libros
            // 
            this.pnl1Libros.BackColor = System.Drawing.Color.Maroon;
            this.pnl1Libros.Controls.Add(this.btnSalirCruzLibros);
            this.pnl1Libros.Location = new System.Drawing.Point(3, -1);
            this.pnl1Libros.Name = "pnl1Libros";
            this.pnl1Libros.Size = new System.Drawing.Size(873, 30);
            this.pnl1Libros.TabIndex = 17;
            // 
            // btnSalirCruzLibros
            // 
            this.btnSalirCruzLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCruzLibros.ForeColor = System.Drawing.Color.Black;
            this.btnSalirCruzLibros.Location = new System.Drawing.Point(848, 4);
            this.btnSalirCruzLibros.Name = "btnSalirCruzLibros";
            this.btnSalirCruzLibros.Size = new System.Drawing.Size(22, 23);
            this.btnSalirCruzLibros.TabIndex = 0;
            this.btnSalirCruzLibros.Text = "X";
            this.btnSalirCruzLibros.UseVisualStyleBackColor = true;
            this.btnSalirCruzLibros.Click += new System.EventHandler(this.btnSalirCruzLibros_Click);
            // 
            // pnlAccesosDirectosLibros
            // 
            this.pnlAccesosDirectosLibros.BackColor = System.Drawing.Color.Gray;
            this.pnlAccesosDirectosLibros.Controls.Add(this.btnBajaOAltaLibro);
            this.pnlAccesosDirectosLibros.Controls.Add(this.btnModificarLibro);
            this.pnlAccesosDirectosLibros.Controls.Add(this.btnSalirLibros);
            this.pnlAccesosDirectosLibros.Controls.Add(this.btnNuevoLibro);
            this.pnlAccesosDirectosLibros.Location = new System.Drawing.Point(39, 52);
            this.pnlAccesosDirectosLibros.Name = "pnlAccesosDirectosLibros";
            this.pnlAccesosDirectosLibros.Size = new System.Drawing.Size(200, 355);
            this.pnlAccesosDirectosLibros.TabIndex = 14;
            // 
            // btnBajaOAltaLibro
            // 
            this.btnBajaOAltaLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnBajaOAltaLibro.FlatAppearance.BorderSize = 0;
            this.btnBajaOAltaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaOAltaLibro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaOAltaLibro.ForeColor = System.Drawing.Color.Transparent;
            this.btnBajaOAltaLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnBajaOAltaLibro.Image")));
            this.btnBajaOAltaLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaOAltaLibro.Location = new System.Drawing.Point(18, 183);
            this.btnBajaOAltaLibro.Name = "btnBajaOAltaLibro";
            this.btnBajaOAltaLibro.Size = new System.Drawing.Size(163, 60);
            this.btnBajaOAltaLibro.TabIndex = 8;
            this.btnBajaOAltaLibro.Text = "Baja/Alta";
            this.btnBajaOAltaLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaOAltaLibro.UseVisualStyleBackColor = false;
            this.btnBajaOAltaLibro.Visible = false;
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarLibro.FlatAppearance.BorderSize = 0;
            this.btnModificarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarLibro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLibro.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificarLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarLibro.Image")));
            this.btnModificarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarLibro.Location = new System.Drawing.Point(17, 105);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(165, 60);
            this.btnModificarLibro.TabIndex = 7;
            this.btnModificarLibro.Text = "Modificar";
            this.btnModificarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarLibro.UseVisualStyleBackColor = false;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
            // 
            // btnSalirLibros
            // 
            this.btnSalirLibros.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirLibros.FlatAppearance.BorderSize = 0;
            this.btnSalirLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirLibros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirLibros.ForeColor = System.Drawing.Color.Red;
            this.btnSalirLibros.Location = new System.Drawing.Point(41, 302);
            this.btnSalirLibros.Name = "btnSalirLibros";
            this.btnSalirLibros.Size = new System.Drawing.Size(120, 50);
            this.btnSalirLibros.TabIndex = 6;
            this.btnSalirLibros.Text = "SALIR";
            this.btnSalirLibros.UseVisualStyleBackColor = false;
            this.btnSalirLibros.Click += new System.EventHandler(this.btnSalirLibros_Click);
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoLibro.FlatAppearance.BorderSize = 0;
            this.btnNuevoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoLibro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoLibro.ForeColor = System.Drawing.Color.Transparent;
            this.btnNuevoLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoLibro.Image")));
            this.btnNuevoLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoLibro.Location = new System.Drawing.Point(27, 27);
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.Size = new System.Drawing.Size(145, 60);
            this.btnNuevoLibro.TabIndex = 2;
            this.btnNuevoLibro.Text = "Nuevo";
            this.btnNuevoLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoLibro.UseVisualStyleBackColor = false;
            this.btnNuevoLibro.Click += new System.EventHandler(this.btnNuevoLibro_Click);
            // 
            // pnl2Libros
            // 
            this.pnl2Libros.BackColor = System.Drawing.Color.Maroon;
            this.pnl2Libros.Location = new System.Drawing.Point(3, 26);
            this.pnl2Libros.Name = "pnl2Libros";
            this.pnl2Libros.Size = new System.Drawing.Size(11, 404);
            this.pnl2Libros.TabIndex = 18;
            // 
            // dgvInfoLibros
            // 
            this.dgvInfoLibros.AllowUserToAddRows = false;
            this.dgvInfoLibros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column7});
            this.dgvInfoLibros.Location = new System.Drawing.Point(284, 133);
            this.dgvInfoLibros.Name = "dgvInfoLibros";
            this.dgvInfoLibros.Size = new System.Drawing.Size(575, 271);
            this.dgvInfoLibros.TabIndex = 34;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "IDLibro";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Titulo";
            this.Column2.Name = "Column2";
            // 
            // Column9
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column9.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column9.HeaderText = "Autores";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column8.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column8.HeaderText = "Categoria";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column6.HeaderText = "Ubicacion";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "Editorial";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column4.HeaderText = "Edicion";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column7.HeaderText = "ISBN";
            this.Column7.Name = "Column7";
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.Location = new System.Drawing.Point(400, 83);
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(167, 20);
            this.txtAutorLibro.TabIndex = 39;
            this.txtAutorLibro.TextChanged += new System.EventHandler(this.txtAutorLibro_TextChanged);
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(400, 52);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(167, 20);
            this.txtTituloLibro.TabIndex = 38;
            this.txtTituloLibro.TextChanged += new System.EventHandler(this.txtTituloLibro_TextChanged);
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.AutoSize = true;
            this.lblAutorLibro.Location = new System.Drawing.Point(344, 86);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(32, 13);
            this.lblAutorLibro.TabIndex = 37;
            this.lblAutorLibro.Text = "Autor";
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Location = new System.Drawing.Point(344, 55);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(35, 13);
            this.lblTituloLibro.TabIndex = 36;
            this.lblTituloLibro.Text = "Título";
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.FlatAppearance.BorderSize = 0;
            this.btnBuscarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLibro.Image")));
            this.btnBuscarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarLibro.Location = new System.Drawing.Point(605, 52);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(103, 54);
            this.btnBuscarLibro.TabIndex = 35;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // ttMnj
            // 
            this.ttMnj.IsBalloon = true;
            this.ttMnj.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(879, 432);
            this.Controls.Add(this.txtAutorLibro);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.lblAutorLibro);
            this.Controls.Add(this.lblTituloLibro);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.dgvInfoLibros);
            this.Controls.Add(this.pnl2Libros);
            this.Controls.Add(this.pnl4Libros);
            this.Controls.Add(this.pnl3Libros);
            this.Controls.Add(this.pnl1Libros);
            this.Controls.Add(this.pnlAccesosDirectosLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLibros_MouseMove);
            this.pnl1Libros.ResumeLayout(false);
            this.pnlAccesosDirectosLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl4Libros;
        private System.Windows.Forms.Panel pnl3Libros;
        private System.Windows.Forms.Panel pnl1Libros;
        private System.Windows.Forms.Button btnSalirCruzLibros;
        private System.Windows.Forms.Panel pnlAccesosDirectosLibros;
        private System.Windows.Forms.Button btnSalirLibros;
        private System.Windows.Forms.Button btnNuevoLibro;
        private System.Windows.Forms.Panel pnl2Libros;
        private System.Windows.Forms.DataGridView dgvInfoLibros;
        private System.Windows.Forms.Button btnBajaOAltaLibro;
        private System.Windows.Forms.Button btnModificarLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.Label lblAutorLibro;
        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ToolTip ttMnj;
    }
}