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
    public partial class frmLibros : Form
    {
        //Para mover el formulario
        public int xClick = 0, yClick = 0;

        clsLibros objLibro = new clsLibros();

        Libro InfoLibro = new Libro();

        public frmLibros()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.pnlAccesosDirectosLibros, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.dgvInfoLibros, "Aquí aparecerá la información de cada libro, para modificar uno haga click sobre él y luego presione 'Modificar'");
            this.ttMnj.SetToolTip(this.btnBuscarLibro, "Haga click aquí para visualizar información de todos los libros y habilitar los botones 'Nuevo' y 'Modificar'");
            this.ttMnj.SetToolTip(this.txtTituloLibro, "Vaya ingresando letras que correspondan a un título de un libro que desee filtrar");
            this.ttMnj.SetToolTip(this.txtAutorLibro, "Vaya ingresando letras que correspondan a un nombre de un autor de un libro que desee filtrar");
            this.ttMnj.SetToolTip(this.btnNuevoLibro, "Haga click aquí para agregar un nuevo libro");
            this.ttMnj.SetToolTip(this.btnModificarLibro, "Haga click aquí para modificar los datos de un libro. Recuerde seleccionar del listado el libro que desea modificar");
            this.ttMnj.SetToolTip(this.btnSalirLibros, "Haga click aqúi para salir de esta ventana");



            btnNuevoLibro.Enabled = false;
            btnModificarLibro.Enabled = false;
            btnBajaOAltaLibro.Enabled = false;
        }

        //Para mover el formulario
        private void frmLibros_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            frmNuevoLibro NuevoLibro = new frmNuevoLibro();

            NuevoLibro.btnActualizarLibro.Visible = false;

            NuevoLibro.ShowDialog();

            NuevoLibro.LlenarCombo(NuevoLibro.cbxAutor1Libro);

            dgvInfoLibros.Rows.Clear();

            btnBuscarLibro.PerformClick();

            NuevoLibro.btnActualizarLibro.Visible = true;
        }

        private void btnSalirCruzLibros_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirLibros_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            dgvInfoLibros.Rows.Clear();

            if (dgvInfoLibros.RowCount == 0)
            {
                string Categoria = "", Estado = "", Ubicacion = "", Editorial = "";

                List<Libro> listaL = objLibro.LeerLibros();

                foreach (Libro itemL in listaL)
                {
                    for (int j = itemL.IDLibro; j < listaL.Count + 1; j++)
                    {
                        if (itemL.IDLibro == j)
                        {
                            List<Categoria> listaC = objLibro.LeerNombreCategoria(itemL.IDCategoria);
                            foreach (Categoria itemC in listaC)
                            {
                                if (itemL.IDLibro == j)
                                    Categoria = itemC.Nombre.ToString();
                            }

                            List<Estado> listaEs = objLibro.LeerNombreEstado(itemL.IDEstado);
                            foreach (Estado itemEs in listaEs)
                            {
                                if (itemL.IDLibro == j)
                                    Estado = itemEs.Nombre.ToString();
                            }

                            List<Ubicacion> listaU = objLibro.LeerNombreUbicacion(itemL.IDUbicacion);
                            foreach (Ubicacion itemU in listaU)
                            {
                                if (itemL.IDLibro == j)
                                    Ubicacion = itemU.Nombre.ToString();
                            }

                            List<Editorial> listaEd = objLibro.LeerNombreEditorial(itemL.IDEditorial);
                            foreach (Editorial itemEd in listaEd)
                            {
                                if (itemL.IDLibro == j)
                                    Editorial = itemEd.Nombre.ToString();
                            }

                            List<AutorXLibro> ListaAxL = objLibro.LeerIDAutores(itemL.IDLibro);

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

                            dgvInfoLibros.Rows.Add(itemL.IDLibro, itemL.Titulo, nombre, Categoria, Estado, Ubicacion, Editorial, itemL.Edicion, itemL.ISBN);
                        }
                    }
                }

                foreach (DataGridViewRow row in dgvInfoLibros.Rows)
                {
                    for (int i = 0; i < dgvInfoLibros.RowCount; i++)
                    {
                        if (dgvInfoLibros.Rows[i].Cells[4].Value.ToString().Equals("Dar De Baja"))
                        {
                            dgvInfoLibros.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }

            btnNuevoLibro.Enabled = true;
            btnModificarLibro.Enabled = true;
            btnBajaOAltaLibro.Enabled = true;
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            frmNuevoLibro NuevoLibro = new frmNuevoLibro();

            NuevoLibro.btnGuardarLibro.Visible = false;

            int i = dgvInfoLibros.CurrentRow.Index;

            NuevoLibro.CargarTxt(Convert.ToInt32(dgvInfoLibros.Rows[i].Cells[0].Value.ToString()));

            dgvInfoLibros.Rows.Clear();

            btnBuscarLibro.PerformClick();

            NuevoLibro.btnGuardarLibro.Visible = true;
        }

        private void txtTituloLibro_TextChanged(object sender, EventArgs e)
        {
            btnNuevoLibro.Enabled = true;
            btnModificarLibro.Enabled = true;

            dgvInfoLibros.Rows.Clear();

            string Categoria = "", Estado = "", Ubicacion = "", Editorial = "";

            List<Libro> listaLT = objLibro.LeerLibrosXTitulo(txtTituloLibro.Text.ToUpper());

            foreach (Libro itemLT in listaLT)
            {
                for (int j = listaLT.Count; j < listaLT.Count + 1; j++)
                {
                    if (listaLT.Count == j)
                    {
                        List<Categoria> listaC = objLibro.LeerNombreCategoria(itemLT.IDCategoria);

                        foreach (Categoria itemC in listaC)
                        {
                            if (listaLT.Count == j)
                                Categoria = itemC.Nombre.ToString();
                        }

                        List<Estado> listaEs = objLibro.LeerNombreEstado(itemLT.IDEstado);
                        foreach (Estado itemEs in listaEs)
                        {
                            if (listaLT.Count == j)
                                Estado = itemEs.Nombre.ToString();
                        }

                        List<Ubicacion> listaU = objLibro.LeerNombreUbicacion(itemLT.IDUbicacion);
                        foreach (Ubicacion itemU in listaU)
                        {
                            if (listaLT.Count == j)
                                Ubicacion = itemU.Nombre.ToString();
                        }

                        List<Editorial> listaEd = objLibro.LeerNombreEditorial(itemLT.IDEditorial);

                        foreach (Editorial itemEd in listaEd)
                        {
                            if (listaLT.Count == j)
                                Editorial = itemEd.Nombre.ToString();
                        }

                        List<AutorXLibro> ListaAxL = objLibro.LeerIDAutores(itemLT.IDLibro);

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

                        dgvInfoLibros.Rows.Add(itemLT.IDLibro, itemLT.Titulo, nombre, Categoria, Estado, Ubicacion, Editorial, itemLT.Edicion, itemLT.ISBN);
                    }
                }
            }

            foreach (DataGridViewRow row in dgvInfoLibros.Rows)
            {
                for (int i = 0; i < dgvInfoLibros.RowCount; i++)
                {
                    if (dgvInfoLibros.Rows[i].Cells[4].Value.ToString().Equals("Dar De Baja"))
                    {
                        dgvInfoLibros.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void txtAutorLibro_TextChanged(object sender, EventArgs e)
        {
            btnNuevoLibro.Enabled = true;
            btnModificarLibro.Enabled = true;

            dgvInfoLibros.Rows.Clear();

            string Categoria = "", Estado = "", Ubicacion = "", Editorial = "";

            List<Autor> listaA = objLibro.LeerAutorXNombreBusqueda(txtAutorLibro.Text);

            foreach (Autor itemA in listaA)
            {
                List<AutorXLibro> listaLxA = objLibro.LeerLibrosXAutor(itemA.IDAutor);

                foreach (AutorXLibro itemLxA in listaLxA)
                {
                    List<Libro> listaLXID = objLibro.LeerLibrosXID(itemLxA.IDLibro);

                    foreach (Libro itemLXID in listaLXID)
                    {
                        for (int j = listaLxA.Count; j < listaLxA.Count + 1; j++)
                        {
                            if (listaLxA.Count == j)
                            {
                                List<Categoria> listaC = objLibro.LeerNombreCategoria(itemLXID.IDCategoria);

                                foreach (Categoria itemC in listaC)
                                {
                                    if (listaLxA.Count == j)
                                        Categoria = itemC.Nombre.ToString();
                                }

                                List<Estado> listaEs = objLibro.LeerNombreEstado(itemLXID.IDEstado);
                                foreach (Estado itemEs in listaEs)
                                {
                                    if (listaLxA.Count == j)
                                        Estado = itemEs.Nombre.ToString();
                                }

                                List<Ubicacion> listaU = objLibro.LeerNombreUbicacion(itemLXID.IDUbicacion);
                                foreach (Ubicacion itemU in listaU)
                                {
                                    if (listaLxA.Count == j)
                                        Ubicacion = itemU.Nombre.ToString();
                                }

                                List<Editorial> listaEd = objLibro.LeerNombreEditorial(itemLXID.IDEditorial);

                                foreach (Editorial itemEd in listaEd)
                                {
                                    if (listaLxA.Count == j)
                                        Editorial = itemEd.Nombre.ToString();
                                }

                                List<AutorXLibro> ListaAxL = objLibro.LeerIDAutores(itemLXID.IDLibro);

                                string[] vect = new string[ListaAxL.Count];

                                int cont = 0;
                                foreach (AutorXLibro itemAxL in ListaAxL)
                                {
                                    List<Autor> ListaAu = objLibro.LeerNombreAutores(itemAxL.IDAutor);

                                    foreach (Autor itemAu in ListaAu)
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

                                dgvInfoLibros.Rows.Add(itemLXID.IDLibro, itemLXID.Titulo, nombre, Categoria, Estado, Ubicacion, Editorial, itemLXID.Edicion, itemLXID.ISBN);
                            }
                        }
                    }

                    foreach (DataGridViewRow row in dgvInfoLibros.Rows)
                    {
                        for (int i = 0; i < dgvInfoLibros.RowCount; i++)
                        {
                            if (dgvInfoLibros.Rows[i].Cells[4].Value.ToString().Equals("Dar De Baja"))
                            {
                                dgvInfoLibros.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }       
        }
    }
}
