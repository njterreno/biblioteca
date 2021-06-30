using System;
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
    public partial class frmInicio : Form
    {
        //Para mover el formulario
        public int xClick = 0, yClick = 0;

        public frmInicio()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Haga click sobre el botón que corresponda según lo que desee administrar, o bien presione 'Salir' para salir del sistema");
            this.ttMnj.SetToolTip(this.pbxLogoInicio, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.pnlAccesosDirectosInicio, "Haga click sobre el botón que corresponda según lo que desee administrar, o bien presione 'Salir' para salir del sistema");
            this.ttMnj.SetToolTip(this.btnLibrosInicio, "Haga click aquí para administrar los libros");
            this.ttMnj.SetToolTip(this.btnPrestamosInicio, "Haga click aquí para administrar los préstamos");
            this.ttMnj.SetToolTip(this.btnSociosInicio, "Haga click aquí para administrar los socios");
            this.ttMnj.SetToolTip(this.btnSalirInicio, "Haga click sobre aquí para salir del sistema");
        }

        //Para mover el formulario
        private void BiblioSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }         

        private void btnSalirCruz_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        private void btnSociosInicio_Click(object sender, EventArgs e)
        {
            frmSocios Socios = new frmSocios();

            Socios.ShowDialog();
        }

        private void btnPrestamosInicio_Click(object sender, EventArgs e)
        {
            frmPrestamos Prestamos = new frmPrestamos();

            Prestamos.ShowDialog();
        }

        private void btnLibrosInicio_Click(object sender, EventArgs e)
        {
            frmLibros Libros = new frmLibros();

            Libros.ShowDialog();
        }        
    }
}
