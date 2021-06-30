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
    public partial class frmNuevoLibro : Form
    {
        //Para mover el formulario
        public int xClick = 0, yClick = 0;

        clsLibros objLibro = new clsLibros();

        Libro InfoLibro = new Libro();

        frmLibros Libros = new frmLibros();

        public frmNuevoLibro()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Llene los campos y luego presione 'Guardar' o 'Actualizar' para guardar o actualizar los datos de un libro, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.pnlCbxAutores, "Llene los campos y luego presione 'Guardar' o 'Actualizar' para guardar o actualizar los datos de un libro, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.txtTituloLibro, "Ingrese el título del libro");
            this.ttMnj.SetToolTip(this.txtEdicionLibro, "Ingrese la edición del libro. Por ej. Tercera");
            this.ttMnj.SetToolTip(this.txtEditorialLibro, "Ingrese la editorial del libro. Por ej. Santillan");
            this.ttMnj.SetToolTip(this.txtISBNLibro, "Ingrese el ISBN del libro. Por ej. 49685165144");
            this.ttMnj.SetToolTip(this.txtUbicacionLibro, "Ingrese la ubicación del libro. Por ej. j8");
            this.ttMnj.SetToolTip(this.cbxAutor1Libro, "Seleccione el autor del libro");
            this.ttMnj.SetToolTip(this.cbxCategoriaLibro, "Seleccione la categoría a la que pertenece el libro");
            this.ttMnj.SetToolTip(this.cbxEstadoLibro, "Seleccione el estado del libro");
            this.ttMnj.SetToolTip(this.btnGuardarLibro, "Presione aquí para guardar los datos del libro");
            this.ttMnj.SetToolTip(this.btnActualizarLibro, "Presione aquí para actualizar los datos del libro");
            this.ttMnj.SetToolTip(this.btnSalirLibro, "Presione aquí para salir de esta ventana");


            //Llenar combo Categoria
            cbxCategoriaLibro.DataSource = objLibro.LeerCategorias();
            cbxCategoriaLibro.ValueMember = "IDCategoria";
            cbxCategoriaLibro.DisplayMember = "Nombre";

            LlenarCombo(cbxAutor1Libro);
            
            //Llenar combo Estado
            List<Estado> ListaEstados = objLibro.LeerEstados();

            foreach (Estado item in ListaEstados)
            {
                if (item.IDEstado == 3)
                {
                    cbxEstadoLibro.Items.Add(item.Nombre);
                }
                else if (item.IDEstado == 4)
                {
                    cbxEstadoLibro.Items.Add(item.Nombre);
                }

                cbxEstadoLibro.Text = "Dar de Alta";
            }          
        }        

        //Para mover el formulario
        private void frmNuevoLibro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }       

        private void btnSalirCruzNuevoLibro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirLibro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            bool band=false;

            try
            {
                //Guardar Editorial
                Editorial Editorial = new Editorial();
                Editorial.Nombre = txtEditorialLibro.Text;

                objLibro.CrearEditorial(Editorial);

                List<Editorial> listaEd = objLibro.LeerIDEditorial(Editorial.Nombre);
                foreach (Editorial itemEd in listaEd)
                {
                    InfoLibro.IDEditorial = itemEd.IDEditorial;
                }

                //Guardar Ubicacion
                Ubicacion Ubicacion = new Ubicacion();
                Ubicacion.Nombre = txtUbicacionLibro.Text;

                objLibro.CrearUbicacion(Ubicacion);

                List<Ubicacion> listaU = objLibro.LeerIDUbicacion(Ubicacion.Nombre);
                foreach (Ubicacion itemU in listaU)
                {
                    InfoLibro.IDUbicacion = itemU.IDUbicacion;
                }
     
                //Guardar Estado
                List<Estado> ListaEstadosLibros = objLibro.LeerEstadoNombre(cbxEstadoLibro.Text);

                foreach (var i in ListaEstadosLibros)
                {
                    InfoLibro.IDEstado = i.IDEstado;
                }

                InfoLibro.Titulo = txtTituloLibro.Text;
                InfoLibro.IDCategoria = Convert.ToInt32(cbxCategoriaLibro.SelectedValue);
                InfoLibro.Edicion = txtEdicionLibro.Text;
                InfoLibro.ISBN = txtISBNLibro.Text;

                objLibro.CrearLibro(InfoLibro);

                //Guardar Autores
                AutorXLibro autorXlibro = new AutorXLibro();

                Autor autor = new Autor();
                autor.Nombre = cbxAutor1Libro.Text;                

                List<Autor> listaA = objLibro.LeerAutorXNombre(cbxAutor1Libro.Text);
                foreach (Autor itemA in listaA)
                {
                    autorXlibro.IDAutor = itemA.IDAutor;
                }                 

                List<Libro> listaL = objLibro.LeerLibrosXTitulo(txtTituloLibro.Text);
                foreach(Libro itemL in listaL)
                {
                    autorXlibro.IDLibro=itemL.IDLibro;
                }

                objLibro.CrearAutorXLibro(autorXlibro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA AL GUARDAR EL LIBRO  " + ex.ToString());
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

        private void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            bool band = false;

            try
            {
                //Guardar Editorial
                Editorial Editorial = new Editorial();
                Editorial.Nombre = txtEditorialLibro.Text;

                objLibro.CrearEditorial(Editorial);

                List<Editorial> listaEd = objLibro.LeerIDEditorial(Editorial.Nombre);
                foreach (Editorial itemEd in listaEd)
                {
                    InfoLibro.IDEditorial = itemEd.IDEditorial;
                }

                //Guardar Ubicacion
                Ubicacion Ubicacion = new Ubicacion();
                Ubicacion.Nombre = txtUbicacionLibro.Text;

                objLibro.CrearUbicacion(Ubicacion);

                List<Ubicacion> listaU = objLibro.LeerIDUbicacion(Ubicacion.Nombre);
                foreach (Ubicacion itemU in listaU)
                {
                    InfoLibro.IDUbicacion = itemU.IDUbicacion;
                }

                //Guardar Estado
                List<Estado> ListaEstadosLibros = objLibro.LeerEstadoNombre(cbxEstadoLibro.Text);

                foreach (var i in ListaEstadosLibros)
                {
                    InfoLibro.IDEstado = i.IDEstado;
                }

                InfoLibro.Titulo = txtTituloLibro.Text;
                InfoLibro.IDCategoria = Convert.ToInt32(cbxCategoriaLibro.SelectedValue);
                InfoLibro.Edicion = txtEdicionLibro.Text;
                InfoLibro.ISBN = txtISBNLibro.Text;


                objLibro.ActualizarLibro(InfoLibro);


                //Guardar Autores
                AutorXLibro autorXlibro = new AutorXLibro();

                Autor autor = new Autor();
                autor.Nombre = cbxAutor1Libro.Text;

                List<Autor> listaA = objLibro.LeerAutorXNombre(cbxAutor1Libro.Text);
                foreach (Autor itemA in listaA)
                {
                    autorXlibro.IDAutor = itemA.IDAutor;
                }

                List<Libro> listaL = objLibro.LeerLibrosXTitulo(txtTituloLibro.Text);
                foreach (Libro itemL in listaL)
                {
                    autorXlibro.IDLibro = itemL.IDLibro;
                }

                objLibro.ActualizarAutorXLibro(autorXlibro);
                
                this.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("PROBLEMA EN LA ACTUALIZACIÓN DEL LIBRO   " + ex2.ToString());
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

        public void CargarTxt(int IDL)
        {
            try
            {
                InfoLibro = objLibro.LeerPorID(IDL);

                List<Estado> ListaEstadosLibros = objLibro.LeerEstadoID(InfoLibro.IDEstado);

                txtTituloLibro.Text = InfoLibro.Titulo;

                List<AutorXLibro> ListaAxL = objLibro.LeerIDAutores(InfoLibro.IDLibro);

                string[] vect = new string[ListaAxL.Count];

                int cont = 0;
                foreach (AutorXLibro itemAxL in ListaAxL)
                {
                    List<Autor> ListaA = objLibro.LeerNombreAutores(itemAxL.IDAutor);

                    foreach (Autor itemA in ListaA)
                    {
                        vect[cont] = itemA.Nombre;
                    }

                    cont = cont + 1;
                }

                string nombre = "";

                for (int i = 0; i < ListaAxL.Count - 1; i++)
                {
                    nombre = nombre + vect[i] + " - ";
                }

                nombre = nombre + vect[cont - 1];

                //MessageBox.Show("Test" + vect + nombre);

                foreach (Control cbx in this.pnlCbxAutores.Controls.OfType<ComboBox>())
                {
                    if (cbx.Name == "cbxAutor1Libro" & nombre != null)
                    {
                        cbxAutor1Libro.Text = vect[0];
                        CrearComboBoxMod("cbxAutor2Libro", new Point(1, 45), new Size(176, 20));
                    }
                    else if (cbx.Name == "cbxAutor2Libro" & nombre != null)
                    {
                        cbx.Text = vect[1];
                        CrearComboBoxMod("cbxAutor3Libro", new Point(1, 75), new Size(176, 20));
                    }
                    else if (cbx.Name == "cbxAutor3Libro" & nombre != null)
                    {
                        cbx.Text = nombre;
                        CrearComboBoxMod("cbxAutor4Libro", new Point(1, 105), new Size(176, 20));
                    }
                    else if (cbx.Name == "cbxAutor4Libro" & nombre != null)
                    {
                        cbx.Text = nombre;
                        CrearComboBoxMod("cbxAutor5Libro", new Point(1, 135), new Size(176, 20));
                    }
                    else if (cbx.Name == "cbxAutor5Libro" & nombre != null)
                    {
                        cbx.Text = nombre;
                        CrearComboBoxMod("cbxAutor6Libro", new Point(1, 165), new Size(176, 20));
                    }
                    else if (cbx.Name == "cbxAutor6Libro" & nombre != null)
                    {
                        cbx.Text = nombre;
                        CrearComboBoxMod("cbxAutor7Libro", new Point(1, 195), new Size(176, 20));
                    }
                    else if (cbx.Name == "cbxAutor7Libro" & nombre != null)
                    {
                        cbx.Text = nombre;
                    }
                }

                cbxCategoriaLibro.SelectedValue = InfoLibro.IDCategoria;

                txtISBNLibro.Text = InfoLibro.ISBN.ToString();

                foreach (var i in ListaEstadosLibros)
                {
                    cbxEstadoLibro.Text = i.Nombre;
                }

                List<Ubicacion> listaU = objLibro.LeerNombreUbicacion(InfoLibro.IDUbicacion);
                foreach (Ubicacion itemU in listaU)
                {
                    txtUbicacionLibro.Text = itemU.Nombre;                    
                }
                
                List<Editorial> listaEd = objLibro.LeerNombreEditorial(InfoLibro.IDEditorial);
                foreach (Editorial itemEd in listaEd)
                {
                    txtEditorialLibro.Text = itemEd.Nombre;
                }
                
                txtEdicionLibro.Text = InfoLibro.Edicion;

                this.ShowDialog();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("PROBLEMA AL CARGAR LOS DATOS PARA MODIFICARLOS   " + ex3.ToString());
            }
        }

        public void btnAgregarComboBox_Click(object sender, EventArgs e)
        {
            foreach (Control cbx in this.pnlCbxAutores.Controls.OfType<ComboBox>())
            {
                if (cbx.Name == "cbxAutor1Libro")
                {
                    CrearComboBoxAutores("cbxAutor2Libro", new Point(1, 45), new Size(176, 20));                    
                }
                else if (cbx.Name == "cbxAutor2Libro")
                {
                    CrearComboBoxAutores("cbxAutor3Libro", new Point(1, 75), new Size(176, 20));
                }
                else if (cbx.Name == "cbxAutor3Libro")
                {
                    CrearComboBoxAutores("cbxAutor4Libro", new Point(1, 105), new Size(176, 20));
                }
                else if (cbx.Name == "cbxAutor4Libro")
                {
                    CrearComboBoxAutores("cbxAutor5Libro", new Point(1, 135), new Size(176, 20));
                }
                else if (cbx.Name == "cbxAutor5Libro")
                {
                    CrearComboBoxAutores("cbxAutor6Libro", new Point(1, 165), new Size(176, 20));
                }
                else if (cbx.Name == "cbxAutor6Libro")
                {
                    CrearComboBoxAutores("cbxAutor7Libro", new Point(1, 195), new Size(176, 20));
                }
                else if (cbx.Name == "cbxAutor7Libro")
                {
                    btnAgregarCbx.Enabled = false;
                }                
            }
        }        

        public void CrearComboBoxAutores(string nombre, Point ubicacion, Size tamaño)
        {
            ComboBox cbx = new ComboBox();
            cbx.Name = nombre;
            cbx.Location = (ubicacion);
            cbx.Size = (tamaño);
            LlenarCombo(cbx);
            this.pnlCbxAutores.Controls.Add(cbx);           
        }

        public void CrearComboBoxMod(string nombre, Point ubicacion, Size tamaño)
        {
            ComboBox cbx = new ComboBox();
            cbx.Name = nombre;
            cbx.Location = (ubicacion);
            cbx.Size = (tamaño);
            cbx.Tag = "Autor";
            this.pnlCbxAutores.Controls.Add(cbx);
        }        

        public void LlenarCombo(ComboBox cbx)
        {            
            cbx.DataSource = objLibro.LeerAutores();
            cbx.ValueMember = "IDAutor";
            cbx.DisplayMember = "Nombre";
            
            //cbx.SelectedIndex = -1;

            cbx.AutoCompleteCustomSource = CargarDatos();
            cbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbx.AutoCompleteSource = AutoCompleteSource.CustomSource; 
        }

        public AutoCompleteStringCollection CargarDatos()
        {
                List<Autor> autores = objLibro.LeerAutores();
                AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
                foreach (Autor itemC in autores)
                {
                    datos.Add(itemC.Nombre);                
                }

           return datos;
        }
    }
}
