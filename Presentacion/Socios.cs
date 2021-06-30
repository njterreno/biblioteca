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
    public partial class frmSocios : Form
    {
        //Para mover el formulario
        public int xClick = 0, yClick = 0;

        Socio InfoSocio = new Socio();

        clsSocios objSocio = new clsSocios();

        public frmSocios()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.pnlAccesosDirectosSocios, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.dgvInfoSocios, "Aquí aparecerá la información de cada socio, para modificar uno haga click sobre él y luego presione 'Modificar'");
            this.ttMnj.SetToolTip(this.btnBuscarSocio, "Haga click aquí para visualizar información de todos los socios y habilitar los botones 'Nuevo' y 'Modificar'");
            this.ttMnj.SetToolTip(this.txtNomApeSocios, "Vaya ingresando letras que correspondan a un nombre de un socio que desee filtrar");
            this.ttMnj.SetToolTip(this.txtDNISocios, "Ingrese el DNI que corresponda a un socio que desee filtrar");
            this.ttMnj.SetToolTip(this.btnNuevoSocio, "Haga click aquí para agregar un nuevo socio");
            this.ttMnj.SetToolTip(this.btnModificarSocio, "Haga click aquí para modificar los datos de un socio. Recuerde seleccionar del listado el socio que desea modificar");
            this.ttMnj.SetToolTip(this.btnSalirSocios, "Haga click aqúi para salir de esta ventana");

            btnNuevoSocio.Enabled = false;
            btnModificarSocio.Enabled = false;
            btnInactivarOActivarSocio.Enabled = false;
        }        

        //Para mover el formulario
        private void frmSocios_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnSalirCruzSocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirSocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnNuevoSocio_Click(object sender, EventArgs e)
        {
            frmNuevoSocio NuevoSocio = new frmNuevoSocio();

            NuevoSocio.btnActualizarSocio.Visible = false;

            NuevoSocio.ShowDialog();

            dgvInfoSocios.Rows.Clear();

            btnBuscarSocio.PerformClick();

            NuevoSocio.btnActualizarSocio.Visible = true;
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            if (txtDNISocios.Text == "" & txtNomApeSocios.Text == "")
            {
                dgvInfoSocios.Rows.Clear();
                List<Socio> listaS = objSocio.LeerSocios();

                if (dgvInfoSocios.RowCount == 0)
                {
                    foreach (var itemS in listaS)
                    {
                        dgvInfoSocios.Rows.Add(itemS.IDSocio, itemS.Nombre, itemS.DNI, itemS.Estado.Nombre, itemS.Domicilio, itemS.Localidad.Nombre, itemS.Telefono, itemS.Correo);
                    }
                }
            }            
            else if (txtDNISocios.Text != "" & txtNomApeSocios.Text == "")
            {
                List<Socio> listaSDNI = objSocio.LeerSociosXDNI(Convert.ToInt32(txtDNISocios.Text));

                dgvInfoSocios.Rows.Clear();
               
                    foreach (var itemSDNI in listaSDNI)
                    {
                        dgvInfoSocios.Rows.Add(itemSDNI.IDSocio, itemSDNI.Nombre, itemSDNI.DNI, itemSDNI.Estado.Nombre, itemSDNI.Domicilio, itemSDNI.Localidad.Nombre, itemSDNI.Telefono, itemSDNI.Correo);
                    }
            }


            foreach (DataGridViewRow row in dgvInfoSocios.Rows)
            {
                for (int i = 0; i < dgvInfoSocios.RowCount; i++)
                {
                    if (dgvInfoSocios.Rows[i].Cells[3].Value.ToString().Equals("Inactivo"))
                    {
                        dgvInfoSocios.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }                    
                }                
            }            

            btnNuevoSocio.Enabled = true;
            btnModificarSocio.Enabled = true;
            btnInactivarOActivarSocio.Enabled = true;
        }        

        private void btnModificarSocio_Click(object sender, EventArgs e)
        {
            frmNuevoSocio NuevoSocio = new frmNuevoSocio();

            NuevoSocio.btnGuardarSocio.Visible = false;

            int i = dgvInfoSocios.CurrentRow.Index;

            NuevoSocio.CargarTxt(Convert.ToInt32(dgvInfoSocios.Rows[i].Cells[0].Value.ToString()));

            dgvInfoSocios.Rows.Clear();

            btnBuscarSocio.PerformClick();

            NuevoSocio.btnGuardarSocio.Visible = true;
        }

        private void txtNomApeSocios_TextChanged(object sender, EventArgs e)
        {
            btnNuevoSocio.Enabled = true;
            btnModificarSocio.Enabled = true;

            dgvInfoSocios.Rows.Clear();

            List<Socio> listaSN = objSocio.LeerSociosXNombre(txtNomApeSocios.Text.ToUpper());

            foreach (var itemSN in listaSN)
            {
                dgvInfoSocios.Rows.Add(itemSN.IDSocio, itemSN.Nombre, itemSN.DNI, itemSN.Estado.Nombre, itemSN.Domicilio, itemSN.Localidad.Nombre, itemSN.Telefono, itemSN.Correo);
            }

            foreach (DataGridViewRow row in dgvInfoSocios.Rows)
            {
                for (int i = 0; i < dgvInfoSocios.RowCount; i++)
                {
                    if (dgvInfoSocios.Rows[i].Cells[3].Value.ToString().Equals("Inactivo"))
                    {
                        dgvInfoSocios.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }          
        }                

        //private void btnInactivarOActivarSocio_Click(object sender, EventArgs e)
        //{
        //    frmNuevoSocio NuevoSocio = new frmNuevoSocio();

        //    int i = dgvInfoSocios.CurrentRow.Index;

        //    NuevoSocio.CambiarEstadoSocio(Convert.ToInt32(dgvInfoSocios.Rows[i].Cells[0].Value.ToString()));

        //    dgvInfoSocios.Rows.Clear();

        //    this.Close();            

        //    btnBuscarSocio.PerformClick();
        //}                                        
    }
}
