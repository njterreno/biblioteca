using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class LogIn : Form
    {
        //Para mover el formulario
        public int xClick = 0, yClick = 0;

        Usuario usuario = new Usuario();

        clsUsuarios objUsuarios = new clsUsuarios();

        public LogIn()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Ingrese su Usuario y Clave para ingresar al sistema");
            this.ttMnj.SetToolTip(this.txtUsuario, "Ingrese su Usuario. Por ej. nata_t12");
            this.ttMnj.SetToolTip(this.txtContraseña, "Ingrese su Clave. Por ej. 1234");
            this.ttMnj.SetToolTip(this.btnMostrarClave, "Haga click aquí para mostrar su clave. Presione nuevamente para ocultarla");
            this.ttMnj.SetToolTip(this.btnRegistrarUsuario, "Haga click aquí si desea registrarse para utilizar el sistema");
            this.ttMnj.SetToolTip(this.btnEntrar, "Haga click aquí luego de ingresar su Usuario y Contraseña");
            this.ttMnj.SetToolTip(this.btnSalir, "Haga click aquí para salir del sistema");

            txtContraseña.UseSystemPasswordChar = true;
        }

        //Para mover el formulario
        private void LogIn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" & txtContraseña.Text == "")
            {
                MessageBox.Show("Los campos están vacíos. Por favor ingrese su Clave y Contraseña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                List<Usuario> listaUxN = objUsuarios.LeerUsuarioXNombre(txtUsuario.Text);
                foreach (Usuario itemUxN in listaUxN)
                {
                    List<Usuario> listaUxID = objUsuarios.LeerUsuarioXID(itemUxN.IDUsuario);
                    foreach (Usuario itemUxID in listaUxID)
                    {
                        if(itemUxID.Contraseña == txtContraseña.Text & itemUxID.Nombre == txtUsuario.Text)
                        {
                            this.Hide();

                            frmInicio frmBiblioSystem = new frmInicio();

                            frmBiblioSystem.ShowDialog();
                        }
                    }
                }
            }

            MessageBox.Show("Usuario y/o clave incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtUsuario.Select(0, 0);
            txtUsuario.Focus();
        }       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            NuevoUsuario NuevoUsuario = new NuevoUsuario();

            NuevoUsuario.ShowDialog();
        }

        private void btnMostrarClave_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else if (txtContraseña.UseSystemPasswordChar == false)
            {
                txtContraseña.UseSystemPasswordChar = true;                
            }            
        }

             
    }
}
