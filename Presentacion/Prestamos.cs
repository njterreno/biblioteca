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
    public partial class frmPrestamos : Form
    {
        //Para mover el formulario
        public int xClick = 0, yClick = 0;

        frmNuevoLibro NuevoLibro = new frmNuevoLibro();

        frmNuevoPrestamo NuevoPrestamo = new frmNuevoPrestamo();

        clsPrestamos objPrestamos = new clsPrestamos();

        string NombreSocio = "", TituloLibro = "", Estado = "";

        public frmPrestamos()
        {
            InitializeComponent();
            this.ttMnj.SetToolTip(this, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.pnlAccesosDirectosPrestamo, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.dgvInfoPrestamos, "Aquí aparecerá la información de cada préstamo, para modificar uno haga click sobre él y luego presione 'Modificar'");
            this.ttMnj.SetToolTip(this.btnBuscarPrestamo, "Haga click aquí para visualizar información de todos los préstamos realizados y habilitar los botones 'Nuevo' y 'Modificar'");
            this.ttMnj.SetToolTip(this.txtTituloLibroPrestamo, "Vaya ingresando letras que correspondan a un título de un libro que desee filtrar");
            this.ttMnj.SetToolTip(this, "Haga click sobre el botón que corresponda según lo que desee realizar, o bien presione 'Salir' para salir de aquí");
            this.ttMnj.SetToolTip(this.btnNuevoPrestamo, "Haga click aquí para confeccionar un nuevo préstamo");
            this.ttMnj.SetToolTip(this.btnModificarPrestamo, "Haga click aquí para modificar los datos de un prestamo. Recuerde seleccionar del listado el préstamo que desea modificar");
            this.ttMnj.SetToolTip(this.btnSalirPrestamo, "Haga click aqúi para salir de esta ventana");

            List<Prestamo> listaP = objPrestamos.LeerPrestamos();
            foreach (Prestamo itemP in listaP)
            {
                List<Socio> listaS = objPrestamos.LeerSocioXID(itemP.IDSocio);
                foreach (Socio itemS in listaS)
                {
                    NombreSocio = itemS.Nombre;
                }

                List<LibroXPrestamo> listaLxP = objPrestamos.LeerPrestamoXID(itemP.IDPrestamo);
                foreach (LibroXPrestamo itemLxP in listaLxP)
                {
                    List<Libro> listaL = objPrestamos.LeerLibroXID(itemLxP.IDLibro);
                    foreach (Libro itemL in listaL)
                    {
                        TituloLibro = itemL.Titulo;
                    }
                }
            }

            btnNuevoPrestamo.Enabled = false;
            btnModificarPrestamo.Enabled = false;
        }

        //Para mover el formulario
        private void BiblioSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnSalirCruzPrestamo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirPrestamo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoPrestamoPrestamo_Click(object sender, EventArgs e)
        {
            frmNuevoPrestamo NuevoPrestamo = new frmNuevoPrestamo();

            NuevoPrestamo.btnActualizarPrestamo.Visible = false;

            NuevoPrestamo.ShowDialog();

            NuevoLibro.LlenarCombo(NuevoPrestamo.cbxLibro1);

            dgvInfoPrestamos.Rows.Clear();

            btnBuscarPrestamo.PerformClick();

            NuevoPrestamo.btnActualizarPrestamo.Visible = true;
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            dgvInfoPrestamos.Rows.Clear();

            if (dgvInfoPrestamos.RowCount == 1)
            {
                List<Prestamo> listaP = objPrestamos.LeerPrestamos();
                foreach (Prestamo itemP in listaP)
                {
                    List<Socio> listaS = objPrestamos.LeerSocioXID(itemP.IDSocio);
                    foreach (Socio itemS in listaS)
                    {
                        NombreSocio = itemS.Nombre;
                    }

                    List<LibroXPrestamo> listaLxP = objPrestamos.LeerPrestamoXID(itemP.IDPrestamo);
                    foreach (LibroXPrestamo itemLxP in listaLxP)
                    {
                        List<Libro> listaL = objPrestamos.LeerLibroXID(itemLxP.IDLibro);
                        foreach (Libro itemL in listaL)
                        {
                            TituloLibro = itemL.Titulo;
                        }

                        if (DateTime.Now > itemLxP.FechaDevolucion)
                        {
                            itemP.IDEstado = 7;
                            List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
                            foreach (Estado itemE in listaE)
                            {
                                Estado = itemE.Nombre;
                            }

                        }
                        else if (DateTime.Now < itemLxP.FechaDevolucion)
                        {
                            itemP.IDEstado = 5;
                            List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
                            foreach (Estado itemE in listaE)
                            {
                                Estado = itemE.Nombre;
                            }
                        }
                        else
                        {
                            itemP.IDEstado = 6;
                            List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
                            foreach (Estado itemE in listaE)
                            {
                                Estado = itemE.Nombre;
                            }
                        }

                        dgvInfoPrestamos.Rows.Add(itemP.IDPrestamo, NombreSocio, TituloLibro, Estado, itemP.FechaPrestamo, itemLxP.FechaDevolucion);
                    }                    
                }                
            }

            //foreach (DataGridViewRow row in dgvInfoPrestamos.Rows)
            //{
            //    for (int i = 0; i < dgvInfoPrestamos.RowCount; i++)
            //    {

            //        if (dgvInfoPrestamos.Rows[i].Cells[2].Value.ToString().Equals("Vencido"))
            //        {
            //            dgvInfoPrestamos.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
            //        }
            //        else if (dgvInfoPrestamos.Rows[i].Cells[2].Value.ToString().Equals("En Proceso"))
            //        {
            //            dgvInfoPrestamos.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
            //        }
            //        else if (dgvInfoPrestamos.Rows[i].Cells[2].Value.ToString().Equals("Devuelto"))
            //        {
            //            dgvInfoPrestamos.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
            //        }

            //    }
            //}

            btnNuevoPrestamo.Enabled = true;
            btnModificarPrestamo.Enabled = true;
        }

        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            frmNuevoPrestamo NuevoPrestamo = new frmNuevoPrestamo();

            NuevoPrestamo.btnGuardarPrestamo.Visible = false;

            int i = dgvInfoPrestamos.CurrentRow.Index;

            NuevoPrestamo.CargarTxt(Convert.ToInt32(dgvInfoPrestamos.Rows[i].Cells[0].Value.ToString()));

            NuevoLibro.LlenarCombo(NuevoPrestamo.cbxLibro1);

            dgvInfoPrestamos.Rows.Clear();

            btnBuscarPrestamo.PerformClick();

            NuevoPrestamo.btnGuardarPrestamo.Visible = true;
        }

        private void txtTituloLibroPrestamo_TextChanged(object sender, EventArgs e)
        {
            dgvInfoPrestamos.Rows.Clear();

            if (dgvInfoPrestamos.RowCount == 1)
            {
                List<Libro> listaL = objPrestamos.LeerLibroXNombreBusqueda(txtTituloLibroPrestamo.Text);
                foreach (Libro itemL in listaL)
                {
                    TituloLibro = itemL.Titulo;

                    List<LibroXPrestamo> listaLxP = objPrestamos.LeerLibroXIDBusqueda(itemL.IDLibro);
                    foreach (LibroXPrestamo itemLxP in listaLxP)
                    {
                        List<Prestamo> listaP = objPrestamos.LeerPrestamoXIDBusqueda(itemLxP.IDPrestamo);
                        foreach (Prestamo itemP in listaP)
                        {
                            List<Socio> listaS = objPrestamos.LeerSocioXID(itemP.IDSocio);
                            foreach (Socio itemS in listaS)
                            {
                                NombreSocio = itemS.Nombre;
                            }

                            if (DateTime.Now > itemLxP.FechaDevolucion)
                            {
                                itemP.IDEstado = 7;
                                List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
                                foreach (Estado itemE in listaE)
                                {
                                    Estado = itemE.Nombre;
                                }

                            }
                            else if (DateTime.Now < itemLxP.FechaDevolucion)
                            {
                                itemP.IDEstado = 5;
                                List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
                                foreach (Estado itemE in listaE)
                                {
                                    Estado = itemE.Nombre;
                                }
                            }
                            else
                            {
                                itemP.IDEstado = 6;
                                List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
                                foreach (Estado itemE in listaE)
                                {
                                    Estado = itemE.Nombre;
                                }
                            }

                            dgvInfoPrestamos.Rows.Add(itemP.IDPrestamo, NombreSocio, TituloLibro, Estado, itemP.FechaPrestamo, itemLxP.FechaDevolucion);
                        }
                    }
                }
            }

            btnNuevoPrestamo.Enabled = true;
            btnModificarPrestamo.Enabled = true;
        }

        private void txtSocioPrestamo_TextChanged(object sender, EventArgs e)
        {
        //    dgvInfoPrestamos.Rows.Clear();

        //    if (dgvInfoPrestamos.RowCount == 1)
        //    {
        //        List<Socio> listaS = objPrestamos.LeerSocioXNombreBusqueda(txtSocioPrestamo.Text);
        //        foreach (Socio itemS in listaS)
        //        {
        //            NombreSocio = itemS.Nombre;

        //            List<Prestamo> listaP = objPrestamos.LeerPrestamosXIDSocio(itemS.IDSocio);
        //            foreach (Prestamo itemP in listaP)
        //            {
        //                List<LibroXPrestamo> listaLxP = objPrestamos.LeerLibroXIDPrestamo(itemP.IDPrestamo);
        //                foreach (LibroXPrestamo itemLxP in listaLxP)
        //                {
        //                    List<Libro> listaL = objPrestamos.LeerLibroXIDBusquedaXSocio(itemLxP.IDLibro);

        //                    if (DateTime.Now > itemLxP.FechaDevolucion)
        //                    {
        //                        itemP.IDEstado = 7;
        //                        List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
        //                        foreach (Estado itemE in listaE)
        //                        {
        //                            Estado = itemE.Nombre;
        //                        }

        //                    }
        //                    else if (DateTime.Now < itemLxP.FechaDevolucion)
        //                    {
        //                        itemP.IDEstado = 5;
        //                        List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
        //                        foreach (Estado itemE in listaE)
        //                        {
        //                            Estado = itemE.Nombre;
        //                        }
        //                    }
        //                    else
        //                    {
        //                        itemP.IDEstado = 6;
        //                        List<Estado> listaE = objPrestamos.LeerEstadosXID(itemP.IDEstado);
        //                        foreach (Estado itemE in listaE)
        //                        {
        //                            Estado = itemE.Nombre;
        //                        }
        //                    }

        //                    dgvInfoPrestamos.Rows.Add(itemP.IDPrestamo, NombreSocio, TituloLibro, Estado, itemP.FechaPrestamo, itemLxP.FechaDevolucion);
        //                }
        //            }
        //        }
        //    }
        }
    }
}
