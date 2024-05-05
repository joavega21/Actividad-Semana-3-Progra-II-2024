using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISNP151323_Unidad3
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e) {
            ActuliazarDsPeliculas();
            dgvDatosPelicula.DataSource = dt.DefaultView;
        }

        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        string accion = "Nuevo";

        private void ActuliazarDsPeliculas() {
            ds.Clear();
            ds = objConexion.ObtenerDatos();
            dt = ds.Tables["peliculas"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["IdPelicula"] };
            MostrarDatosPeliculas();
        }

        private void MostrarDatosPeliculas() {
            if (dt.Rows.Count > 0) {
                txtNumPelicula.Text = dt.Rows[posicion].ItemArray[1].ToString();
                txtTitulo.Text = dt.Rows[posicion].ItemArray[2].ToString();
                cmbFormato.Text = dt.Rows[posicion].ItemArray[3].ToString();
                cmbGenero.Text = dt.Rows[posicion].ItemArray[4].ToString();
                txtCantidad.Text = dt.Rows[posicion].ItemArray[5].ToString();

                lblNavegacion.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            } else {
                LimpiarCajas();
            }
        }

        private void LimpiarCajas() {
            txtNumPelicula.Text = "";
            txtTitulo.Text = "";
            cmbFormato.Text = "";
            cmbGenero.Text = "";
            txtCantidad.Text = "";
        }

        private void btnSiguiente_Click(object sender, EventArgs e) {
            if (posicion < dt.Rows.Count - 1) {
                posicion++;
                MostrarDatosPeliculas();
            } else {
                MessageBox.Show("Ultimo registro", "Navegacion de peliculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;
                MostrarDatosPeliculas();
            } else {
                MessageBox.Show("Primer registro", "Navegacion de peliculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            posicion = dt.Rows.Count - 1;
            MostrarDatosPeliculas();
        }

        private void btnPrimero_Click(object sender, EventArgs e) {
            posicion = 0;
            MostrarDatosPeliculas();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if (btnAgregar.Text == "Agregar") {
                btnAgregar.Text = "Guardar";
                btnModificiar.Text = "Cancelar";
                Activar_Desactivar(false);
                LimpiarCajas();
                accion = "Nuevo";
            } else {
                String[] peliculas = new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),
                    txtNumPelicula.Text,
                    txtTitulo.Text,
                    cmbFormato.Text,
                    cmbGenero.Text,
                    txtCantidad.Text
                };
                String Respuesta = objConexion.AdministrarPeliculas(peliculas, accion);
                if (Respuesta != "1") {
                    MessageBox.Show("Error al intentar guardar: " + Respuesta, "Edicion de peliculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    ActuliazarDsPeliculas();
                    Activar_Desactivar(true);
                    btnAgregar.Text = "Agregar";
                    btnModificiar.Text = "Modificar";
                }
            }
        }

        private void btnModificiar_Click(object sender, EventArgs e) {
            if (btnModificiar.Text == "Modificar") {
                btnAgregar.Text = "Guardar";
                btnModificiar.Text = "Cancelar";
                Activar_Desactivar(false);
                accion = "Modificar";
            } else {
                MostrarDatosPeliculas();
                btnAgregar.Text = "Agregar";
                btnModificiar.Text = "Modificar";
                Activar_Desactivar(true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro que desea eliminar: " + txtTitulo.Text, "Eliminar pelicula", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                String Respuesta = objConexion.AdministrarPeliculas(new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),

                }, "Eliminar");
                if (Respuesta != "1") {
                    MessageBox.Show("Error al eliminar registro" + Respuesta, "Eliminando pelicula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    posicion = 0;
                    ActuliazarDsPeliculas();
                }
            }
        }

        private void Activar_Desactivar(Boolean estado) {
            grbDatos.Enabled = !estado;
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
        }

        private void FiltrarPelicula(String valor) {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDatosPelicula.DataSource;
            bs.Filter = "NoPelicula like '%" + valor + "%' OR Titulo like '%" + valor + "%' ";
            dgvDatosPelicula.DataSource = bs;
        }

        private void txtBuscaPelicula_TextChanged(object sender, EventArgs e) {
            FiltrarPelicula(txtBuscaPelicula.Text);
        }

        private void SeleccionarPelicula() {
            int idPelicula = int.Parse(dgvDatosPelicula.CurrentRow.Cells["IdPelicula"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(idPelicula));
            MostrarDatosPeliculas();
        }

        private void dgvDatosPelicula_CellClick(object sender, DataGridViewCellEventArgs e) {
            SeleccionarPelicula();
        }

        private void txtBuscaPelicula_KeyUp(object sender, KeyEventArgs e) {
            FiltrarPelicula(txtBuscaPelicula.Text);
            if (e.KeyCode == Keys.Enter) {
                SeleccionarPelicula();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
