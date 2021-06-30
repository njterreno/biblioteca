using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Datos;
using Negocio;


namespace Presentacion
{
    public partial class frmNuevoSocio : Form
    {
        //Para mover el formulario
        public int xClick = 0, yClick = 0;

        clsSocios objSocio = new clsSocios();

        Socio InfoSocio = new Socio();

        frmSocios Socios = new frmSocios();

        
        public frmNuevoSocio()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Llene los campos y luego presione 'Guardar' o 'Actualizar' para guardar o actualizar los datos de un socio, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.txtNombreSocio, "Ingrese el nombre del socio");
            this.ttMnj.SetToolTip(this.txtDNISocio, "Ingrese el DNI del socio");
            this.ttMnj.SetToolTip(this.txtDomicilioSocio, "Ingrese el domicilio del socio");
            this.ttMnj.SetToolTip(this.txtTelefonoSocio, "Ingrese el teléfono del socio");
            this.ttMnj.SetToolTip(this.txtCorreoSocio, "Ingrese el correo electrónico del socio");
            this.ttMnj.SetToolTip(this.cbxEstadoSocio, "Seleccione el estado del socio");
            this.ttMnj.SetToolTip(this.cbxLocalidadSocio, "Seleccione la localidad del socio");
            this.ttMnj.SetToolTip(this.btnBuscarFotoSocio, "Haga click aquí para buscar y seleccionar la foto del socio");
            this.ttMnj.SetToolTip(this.btnGuardarSocio, "Presione aquí para guardar los datos del socio");
            this.ttMnj.SetToolTip(this.btnActualizarSocio, "Presione aquí para actualizar los datos del socio");
            this.ttMnj.SetToolTip(this.btnSalirSocio, "Presione aquí para salir de esta ventana");

            //Llenar combo Localidad
            cbxLocalidadSocio.DataSource = objSocio.LeerLocalidades();
            cbxLocalidadSocio.ValueMember = "IDLocalidad";
            cbxLocalidadSocio.DisplayMember = "Nombre";


            //Llenar combo Estado de Socio
            List<Estado> ListaEstados = objSocio.LeerEstados();            

            foreach (Estado item in ListaEstados)
            {
                if (item.IDEstado == 1)
                {
                    cbxEstadoSocio.Items.Add(item.Nombre);
                }
                else if (item.IDEstado == 2)
                {
                    cbxEstadoSocio.Items.Add(item.Nombre);
                }

                cbxEstadoSocio.SelectedIndex = 0;
            }   
        }        

        //Para mover el formulario
        private void frmNuevoSocio_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnSalirSocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirCruzSocio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarSocio_Click(object sender, EventArgs e)
        {
            bool band = false;

            if (InfoSocio.DNI.ToString() != txtDNISocio.Text)
            {
                try
                {
                    List<Estado> ListaEstadosSocios = objSocio.LeerEstadoNombre(cbxEstadoSocio.Text);

                    InfoSocio.Nombre = txtNombreSocio.Text.ToUpper();
                    InfoSocio.DNI = Convert.ToInt32(txtDNISocio.Text);

                    foreach (var i in ListaEstadosSocios)
                    {
                        InfoSocio.IDEstado = i.IDEstado;
                    }

                    InfoSocio.Domicilio = txtDomicilioSocio.Text;
                    InfoSocio.IDLocalidad = Convert.ToInt32(cbxLocalidadSocio.SelectedValue);
                    InfoSocio.Telefono = Convert.ToInt64(txtTelefonoSocio.Text);
                    InfoSocio.Correo = txtCorreoSocio.Text;
                    if (pbxFotoSocio.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        pbxFotoSocio.Image.Save(ms, ImageFormat.Png);
                        InfoSocio.Foto = ms.ToArray();
                    }
                    

                    objSocio.Crear(InfoSocio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PROBLEMA AL GUARDAR EL SOCIO" + ex.ToString());
                    band = true;
                }
                finally
                {
                    if (band == false)
                    {
                        MessageBox.Show("Los datos se han guardado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                    }
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("El socio que desea registrar ya ha sido registrado","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }               
        }

        private void btnActualizarSocio_Click(object sender, EventArgs e)
        {
            bool band = false;
            
            try
            {
                List<Estado> ListaEstadosSocios = objSocio.LeerEstadoNombre(cbxEstadoSocio.Text);

                InfoSocio.Nombre = txtNombreSocio.Text.ToUpper();
                InfoSocio.DNI = Convert.ToInt32(txtDNISocio.Text);
                foreach (var i in ListaEstadosSocios)
                {
                    InfoSocio.IDEstado = i.IDEstado;
                }
                InfoSocio.Domicilio = txtDomicilioSocio.Text;
                InfoSocio.Telefono = Convert.ToInt64(txtTelefonoSocio.Text);
                InfoSocio.Correo = txtCorreoSocio.Text;
                InfoSocio.IDLocalidad = Convert.ToInt32(cbxLocalidadSocio.SelectedValue);
                if (pbxFotoSocio.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    pbxFotoSocio.Image.Save(ms, ImageFormat.Png);
                    InfoSocio.Foto = ms.ToArray();
                    pbxFotoSocio.SizeMode = PictureBoxSizeMode.Zoom;
                }

                objSocio.Actualizar(InfoSocio);

                this.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("PROBLEMA EN LA ACTUALIZACIÓN DEL SOCIO" + ex2.ToString());
                band = true;
            }
            finally
            {
                if (band == false)
                {
                    MessageBox.Show("Los datos se han actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                }
            }            
        }

        private void btnBuscarFotoSocio_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de imagen (*.png)|*.jpg|All files (*.*)|*.*" ;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                String Dir = BuscarImagen.FileName;
                Bitmap Picture = new Bitmap(Dir);
                pbxFotoSocio.Image = (Image)Picture;
                pbxFotoSocio.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        public void CargarTxt(int IDS)
        {
            try
            {
                InfoSocio = objSocio.LeerPorID(IDS);

                List<Estado> ListaEstadosSocios = objSocio.LeerEstadoID(InfoSocio.IDEstado);


                txtNombreSocio.Text = InfoSocio.Nombre.ToUpper();
                txtDNISocio.Text = InfoSocio.DNI.ToString();
                foreach (var i in ListaEstadosSocios)
                {
                    cbxEstadoSocio.Text = i.Nombre;
                }
                txtDomicilioSocio.Text = InfoSocio.Domicilio;
                txtTelefonoSocio.Text = InfoSocio.Telefono.ToString();
                txtCorreoSocio.Text = InfoSocio.Correo;
                cbxLocalidadSocio.SelectedValue = Convert.ToInt32(InfoSocio.IDLocalidad);
                if (InfoSocio.Foto != null)
                {
                    MemoryStream ms = new MemoryStream(InfoSocio.Foto);
                    pbxFotoSocio.Image = Image.FromStream(ms);
                    pbxFotoSocio.SizeMode = PictureBoxSizeMode.Zoom;
                }
                
                this.ShowDialog();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("PROBLEMA AL CARGAR LOS DATOS PARA MODIFICARLOS" + ex3.ToString());
            }
        }

        //public void CambiarEstadoSocio(int IDS)
        //{
        //    frmSocios Socio = new frmSocios();

        //    InfoSocio = objSocio.LeerPorID(IDS);

        //    List<Estado> ListaEstadosSocios = objSocio.LeerEstadoID(InfoSocio.IDEstado);

        //    txtNombreSocio.Text = InfoSocio.Nombre;
        //    txtDNISocio.Text = InfoSocio.DNI.ToString();
        //    foreach (var i in ListaEstadosSocios)
        //    {
        //        cbxEstadoSocio.Text = i.Nombre;
        //    }
        //    txtDomicilioSocio.Text = InfoSocio.Domicilio;
        //    txtTelefonoSocio.Text = InfoSocio.Telefono.ToString();
        //    txtCorreoSocio.Text = InfoSocio.Correo;
        //    cbxLocalidadSocio.SelectedValue = Convert.ToInt32(InfoSocio.IDLocalidad);

        //    foreach (var i in ListaEstadosSocios)
        //    {
        //        if (i.Nombre == "Inactivo")
        //        {
        //            txtNombreSocio.Enabled = false;
        //            txtDNISocio.Enabled = false;
        //            txtDomicilioSocio.Enabled = false;
        //            cbxLocalidadSocio.Enabled = false;
        //            txtTelefonoSocio.Enabled = false;
        //            txtCorreoSocio.Enabled = false;
        //            btnBuscarFotoSocio.Enabled = false;

        //            this.Show();

        //            Socio.dgvInfoSocios.Rows.Clear();

        //            Socio.btnBuscarSocio.PerformClick();

        //            DataGridViewCellStyle style = new DataGridViewCellStyle();
        //            style.Font = new Font(Socio.dgvInfoSocios.Font, FontStyle.Strikeout);                   
        //        }
        //        else
        //        {
        //            txtNombreSocio.Enabled = true;
        //            txtDNISocio.Enabled = true;
        //            txtDomicilioSocio.Enabled = true;
        //            cbxLocalidadSocio.Enabled = true;
        //            txtTelefonoSocio.Enabled = true;
        //            txtCorreoSocio.Enabled = true;
        //            btnBuscarFotoSocio.Enabled = true;

        //            this.Show();

        //            Socio.dgvInfoSocios.Rows.Clear();

        //            Socio.btnBuscarSocio.PerformClick();

        //            DataGridViewCellStyle style = new DataGridViewCellStyle();
        //            style.Font = new Font(Socio.dgvInfoSocios.Font, FontStyle.Regular);                   
        //        }
        //    } 
        //}
    }
}
