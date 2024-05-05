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
    public partial class Ejercicio2 : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        string accion = "Nuevo";

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void ActuliazarDsEventos() {
            ds.Clear();
            ds = objConexion.ObtenerDatos();
            dt = ds.Tables["agenda"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["IdEvento"] };
            MostrarDatosEvento();
        }

        private void MostrarDatosEvento() {
            if (dt.Rows.Count > 0) {
                txtNombreEvento.Text = dt.Rows[posicion].ItemArray[1].ToString();
                txtDescripcionEvento.Text = dt.Rows[posicion].ItemArray[2].ToString();
                txtFechaEvento.Text = dt.Rows[posicion].ItemArray[3].ToString();
                
                lblNavegacion.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            } else {
                LimpiarCajas();
            }
        }
        private void LimpiarCajas() {
            txtNombreEvento.Text = "";
            txtDescripcionEvento.Text = "";
            txtFechaEvento.Text = "";
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            ActuliazarDsEventos();
            dgvDatosEvento.DataSource = dt.DefaultView;
        }

        private void btnSiguiente_Click(object sender, EventArgs e) {
            if (posicion < dt.Rows.Count - 1) {
                posicion++;
                MostrarDatosEvento();
            } else {
                MessageBox.Show("Ultimo registro", "Navegacion de eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;
                MostrarDatosEvento();
            } else {
                MessageBox.Show("Primer registro", "Navegacion de eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            posicion = dt.Rows.Count - 1;
            MostrarDatosEvento();
        }

        private void btnPrimero_Click(object sender, EventArgs e) {
            posicion = 0;
            MostrarDatosEvento();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if (btnAgregar.Text == "Agregar") {
                btnAgregar.Text = "Guardar";
                btnModificiar.Text = "Cancelar";
                Activar_Desactivar(false);
                LimpiarCajas();
                accion = "Nuevo";
            } else {
                String[] eventos = new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),
                    txtNombreEvento.Text,
                    txtDescripcionEvento.Text,
                    txtFechaEvento.Text
                };
                String Respuesta = objConexion.AdministrarEvento(eventos, accion);
                if (Respuesta != "1") {
                    MessageBox.Show("Error al intentar guardar: " + Respuesta, "Edicion de evento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    ActuliazarDsEventos();
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
                MostrarDatosEvento();
                btnAgregar.Text = "Agregar";
                btnModificiar.Text = "Modificar";
                Activar_Desactivar(true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro que desea eliminar: " + txtNombreEvento.Text, "Eliminar evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                String Respuesta = objConexion.AdministrarEvento(new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),

                }, "Eliminar");
                if (Respuesta != "1") {
                    MessageBox.Show("Error al eliminar registro" + Respuesta, "Eliminando evento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    posicion = 0;
                    ActuliazarDsEventos();
                }
            }
        }

        private void Activar_Desactivar(Boolean estado) {
            grbDatos.Enabled = !estado;
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
        }

        private void txtBuscaEvento_TextChanged(object sender, EventArgs e) {
            FiltrarEvento(txtBuscaEvento.Text);
        }

        private void FiltrarEvento(String valor) {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDatosEvento.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%' ";
            dgvDatosEvento.DataSource = bs;
        }

        private void SeleccionarEvento() {
            int idEvento = int.Parse(dgvDatosEvento.CurrentRow.Cells["IdEvento"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(idEvento));
            MostrarDatosEvento();
        }

        private void dgvDatosEvento_CellClick(object sender, DataGridViewCellEventArgs e) {
            SeleccionarEvento();
        }

        private void txtBuscaEvento_KeyUp(object sender, KeyEventArgs e) {
            FiltrarEvento(txtBuscaEvento.Text);
            if (e.KeyCode == Keys.Enter) {
                SeleccionarEvento();
            }
        }
    }
}
