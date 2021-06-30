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
    public partial class frmNuevoPrestamo : Form
    {
        clsPrestamos objPrestamos = new clsPrestamos();        

        Prestamo InfoPrestamo = new Prestamo();

        LibroXPrestamo InfoLibroXPrestamo = new LibroXPrestamo();

        public frmNuevoPrestamo()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Llene los campos y luego presione 'Guardar' o 'Actualizar' para guardar o actualizar los datos de un préstamo, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.pnlCbxLibros, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.cbxSocioPrestamo, "Vaya ingresando letras que correspondan a un nombre de un socio que desee seleccionar");
            this.ttMnj.SetToolTip(this.cbxLibro1, "Vaya ingresando letras que correspondan a un título de un libro que desee seleccionar");
            this.ttMnj.SetToolTip(this.txtFechaPrestamo, "Las fechas ya estan predeterminadas");
            this.ttMnj.SetToolTip(this.txtFechaDevolucion, "Las fechas ya estan predeterminadas");
            this.ttMnj.SetToolTip(this.cbxEstadoPrestamo, "Seleccione un estado");
            this.ttMnj.SetToolTip(this.btnGuardarPrestamo, "Presione aquí para guardar los datos del préstamo");
            this.ttMnj.SetToolTip(this.btnActualizarPrestamo, "Presione aquí para actualizar los datos del préstamo");
            this.ttMnj.SetToolTip(this.btnSalirPrestamo, "Presione aquí para salir de esta ventana");


            
            txtFechaPrestamo.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            DateTime fecha = Convert.ToDateTime(txtFechaPrestamo.Text);
            if (fecha.DayOfWeek.ToString() == "Friday")
                fecha = fecha.AddDays(3);
            else
                fecha = fecha.AddDays(1);
            string resultado = fecha.ToString("dd/MM/yyyy hh:mm:ss");
            txtFechaDevolucion.Text = resultado;

            LlenarComboLibros(cbxLibro1);

            LlenarComboSocios(cbxSocioPrestamo);

            //Llenar combo Estado
            List<Estado> ListaEstados = objPrestamos.LeerEstados();

            foreach (Estado item in ListaEstados)
            {
                if (item.IDEstado == 5)
                {
                    cbxEstadoPrestamo.Items.Add(item.Nombre);
                }
                else if (item.IDEstado == 6)
                {
                    cbxEstadoPrestamo.Items.Add(item.Nombre);
                }
                else if (item.IDEstado == 7)
                {
                    cbxEstadoPrestamo.Items.Add(item.Nombre);
                }

                cbxEstadoPrestamo.Text = "En Proceso";
            }
        }

        private void btnSalirPrestamo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirCruzNuevoPrestamo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarCbx_Click(object sender, EventArgs e)
        {
            foreach (Control cbx in this.pnlCbxLibros.Controls.OfType<ComboBox>())
            {
                if (cbx.Name == "cbxLibro1")
                {
                    CrearComboBoxLibros("cbxLibro2", new Point(1, 45), new Size(196, 21));
                }
                else if (cbx.Name == "cbxLibro2")
                {
                    CrearComboBoxLibros("cbxLibro3", new Point(1, 75), new Size(196, 21));
                }
                else if (cbx.Name == "cbxLibro3")
                {
                    CrearComboBoxLibros("cbxLibro4", new Point(1, 105), new Size(196, 21));
                }
                else if (cbx.Name == "cbxLibro4")
                {
                    CrearComboBoxLibros("cbxLibro5", new Point(1, 135), new Size(196, 21));
                }
                else if (cbx.Name == "cbxLibro5")
                {
                    CrearComboBoxLibros("cbxLibro6", new Point(1, 165), new Size(196, 21));
                }
                else if (cbx.Name == "cbxLibro6")
                {
                    CrearComboBoxLibros("cbxLibro7", new Point(1, 195), new Size(196, 21));
                }
                else if (cbx.Name == "cbxLibro7")
                {
                    btnAgregarCbx.Enabled = false;
                }
            }

        }

        public void CrearComboBoxLibros(string nombre, Point ubicacion, Size tamaño)
        {
            ComboBox cbx = new ComboBox();
            cbx.Name = nombre;
            cbx.Location = (ubicacion);
            cbx.Size = (tamaño);
            LlenarComboLibros(cbx);
            this.pnlCbxLibros.Controls.Add(cbx);
        }

        public void LlenarComboLibros(ComboBox cbx)
        {
            cbx.DataSource = objPrestamos.LeerLibros();
            cbx.ValueMember = "IDLibro";
            cbx.DisplayMember = "Titulo";

            cbx.AutoCompleteCustomSource = CargarLibros();
            cbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx.AutoCompleteSource = AutoCompleteSource.CustomSource; 
        }

        public AutoCompleteStringCollection CargarLibros()
        {
            List<Libro> libros = objPrestamos.LeerLibros();
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            foreach (Libro itemL in libros)
            {
                datos.Add(itemL.Titulo);               
            }

            return datos;
        }

        public void LlenarComboSocios(ComboBox cbx)
        {
            cbx.DataSource = objPrestamos.LeerSocios();
            cbx.ValueMember = "IDSocio";
            cbx.DisplayMember = "Nombre";
            //cbx.SelectedIndex = -1;

            cbx.AutoCompleteCustomSource = CargarSocios();
            cbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public AutoCompleteStringCollection CargarSocios()
        {
            List<Socio> socios = objPrestamos.LeerSocios();
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            foreach (Socio itemS in socios)
            {
                datos.Add(itemS.Nombre);
            }

            return datos;
        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            bool band = false;

            try
            {
                List<Socio> listaS = objPrestamos.LeerSocioXNombre(cbxSocioPrestamo.Text);
                foreach (Socio itemS in listaS)
                {
                    InfoPrestamo.IDSocio = itemS.IDSocio;
                }

                List<Estado> listaE = objPrestamos.LeerEstadosXNombre(cbxEstadoPrestamo.Text);
                foreach (Estado itemE in listaE)
                {
                    InfoPrestamo.IDEstado = itemE.IDEstado;
                }

                InfoPrestamo.FechaPrestamo = Convert.ToDateTime(txtFechaPrestamo.Text);

                objPrestamos.CrearPrestamo(InfoPrestamo);

                List<Prestamo> listaP = objPrestamos.LeerPrestamos();
                foreach (Prestamo itemP in listaP)
                {
                    if(listaP.Count == itemP.IDPrestamo)
                    {
                        InfoLibroXPrestamo.IDPrestamo = itemP.IDPrestamo;

                        if (cbxLibro1 != null)
                        {
                            foreach (Control cbx in this.pnlCbxLibros.Controls.OfType<ComboBox>())
                            {
                                if (cbx.Name == "cbxLibro1")
                                {
                                    List<Libro> listaL = objPrestamos.LeerLibroXNombre(cbxLibro1.Text);
                                    foreach (Libro itemL in listaL)
                                    {
                                        InfoLibroXPrestamo.IDLibro = itemL.IDLibro;
                                        break;
                                    }
                                }

                                InfoLibroXPrestamo.FechaDevolucion = Convert.ToDateTime(txtFechaDevolucion.Text);

                                objPrestamos.CrearLibroXPrestamo(InfoLibroXPrestamo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL GUARDAR EL PRESTAMO  " + ex.ToString());
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

        public void CargarTxt(int IDP)
        {
            try
            {
                InfoPrestamo = objPrestamos.LeerPrestamoXid(IDP);

                List<Socio> listaS = objPrestamos.LeerSocioXID(InfoPrestamo.IDSocio);
                foreach (Socio itemS in listaS)
                {
                    cbxSocioPrestamo.Text = itemS.Nombre;                    
                }

                List<Estado> listaE = objPrestamos.LeerEstadosXID(InfoPrestamo.IDEstado);
                foreach (Estado itemE in listaE)
                {
                    cbxEstadoPrestamo.Text = itemE.Nombre;
                }

                txtFechaPrestamo.Text = InfoPrestamo.FechaPrestamo.ToString();

                List<LibroXPrestamo> listaLxP = objPrestamos.LeerPrestamoXID(IDP);
                foreach (LibroXPrestamo itemLxP in listaLxP)
                {
                    List<Libro> listaL = objPrestamos.LeerLibroXID(itemLxP.IDLibro);
                    foreach (Libro itemL in listaL)
                    {
                        cbxLibro1.Text = itemL.Titulo;                        
                    }

                    txtFechaDevolucion.Text = itemLxP.FechaDevolucion.ToString();

                    txtFechaPrestamo.Enabled = true;
                    txtFechaDevolucion.Enabled = true;
                }

                this.ShowDialog();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("PROBLEMA AL CARGAR LOS DATOS PARA MODIFICARLOS" + ex3.ToString());
            }
        }

        private void btnActualizarPrestamo_Click(object sender, EventArgs e)
        {
            bool band = false;

            try
            {
                List<Socio> listaS = objPrestamos.LeerSocioXNombre(cbxSocioPrestamo.Text);
                foreach (Socio itemS in listaS)
                {
                    InfoPrestamo.IDSocio = itemS.IDSocio;
                }

                List<Estado> listaE = objPrestamos.LeerEstadosXNombre(cbxEstadoPrestamo.Text);
                foreach (Estado itemE in listaE)
                {
                    InfoPrestamo.IDEstado = itemE.IDEstado;
                }

                InfoPrestamo.FechaPrestamo = Convert.ToDateTime(txtFechaPrestamo.Text);

                objPrestamos.ActualizarPrestamo(InfoPrestamo);

                List<Prestamo> listaP = objPrestamos.LeerPrestamos();
                foreach (Prestamo itemP in listaP)
                {
                    if (listaP.Count == itemP.IDPrestamo)
                    {
                        InfoLibroXPrestamo.IDPrestamo = itemP.IDPrestamo;

                        if (cbxLibro1 != null)
                        {
                            foreach (Control cbx in this.pnlCbxLibros.Controls.OfType<ComboBox>())
                            {
                                if (cbx.Name == "cbxLibro1")
                                {
                                    List<Libro> listaL = objPrestamos.LeerLibroXNombre(cbxLibro1.Text);
                                    foreach (Libro itemL in listaL)
                                    {
                                        InfoLibroXPrestamo.IDLibro = itemL.IDLibro;
                                        break;
                                    }
                                }

                                InfoLibroXPrestamo.FechaDevolucion = Convert.ToDateTime(txtFechaDevolucion.Text);

                                objPrestamos.ActualizarLibroXPrestamo(InfoLibroXPrestamo);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL ACTUALIZAR EL PRESTAMO  " + ex.ToString());
                band = true;
            }
            finally
            {
                if (band == false)
                {
                    MessageBox.Show("Los datos se han actualizado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close();

        }

    }
}
