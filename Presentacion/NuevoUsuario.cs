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
    public partial class NuevoUsuario : Form
    {
        Usuario usuario = new Usuario();

        clsUsuarios objUsuarios = new clsUsuarios();

        public NuevoUsuario()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Ingrese un Usuario y una Clave para registrarse en el sistema");
            this.ttMnj.SetToolTip(this.txtNuevoUsuario, "Ingrese un Usuario. Por ej. nata_t12");
            this.ttMnj.SetToolTip(this.txtContraseñaNuevoUsuario, "Ingrese una Clave. Por ej. 1234");
            this.ttMnj.SetToolTip(this.btnGuardarNuevoUsuario, "Haga click aquí para guardar su Usuario y su Clave");
            this.ttMnj.SetToolTip(this.btnMostrarClave, "Haga click aquí para mostrar su clave. Presione nuevamente para ocultarla");
            this.ttMnj.SetToolTip(this.btnSalir, "Haga click aquí para salir de la ventana");

            txtContraseñaNuevoUsuario.UseSystemPasswordChar = true;
        }

        private void btnGuardarNuevoUsuario_Click(object sender, EventArgs e)
        {
            List<Usuario> listaUxN = objUsuarios.LeerUsuarioXNombre(txtNuevoUsuario.Text);
            if (listaUxN.Count == 0)
                {
                    usuario.Nombre = txtNuevoUsuario.Text;
                    usuario.Contraseña = txtContraseñaNuevoUsuario.Text;

                    objUsuarios.CrearUsuario(usuario);

                    MessageBox.Show("Los datos se han guardado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            else
            {
                MessageBox.Show("El usuario que desea registrar ya ha sido registrado","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtNuevoUsuario.Text = "";
                    txtContraseñaNuevoUsuario.Text = "";
                    txtNuevoUsuario.Select(0, 0);
                    txtNuevoUsuario.Focus();
            }            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarClave_Click(object sender, EventArgs e)
        {
            if (txtContraseñaNuevoUsuario.UseSystemPasswordChar == true)
            {
                txtContraseñaNuevoUsuario.UseSystemPasswordChar = false;
            }
            else if (txtContraseñaNuevoUsuario.UseSystemPasswordChar == false)
            {
                txtContraseñaNuevoUsuario.UseSystemPasswordChar = true;
            }    
        }
    }
}
