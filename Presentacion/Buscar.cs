﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Buscar : Form
    {
        //Para mover el formulario
        public int xClick = 0, yClick = 0;

        public Buscar()
        {
            InitializeComponent();
        }

        //Para mover el formulario
        private void BiblioSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }         

        private void btnSalirEjemplar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirCruzEjemplar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
