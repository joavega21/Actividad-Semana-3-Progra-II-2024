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
    public partial class Ejercicio3 : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        string accion = "Nuevo";

        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void ActuliazarDsPaciente() {
            ds.Clear();
            ds = objConexion.ObtenerDatos();
            dt = ds.Tables["Vacunas"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["IdPaciente"] };
            MostrarDatosPaciente();
        }

        private void MostrarDatosPaciente() {
            if (dt.Rows.Count > 0) {
                txtNumRegistro.Text = dt.Rows[posicion].ItemArray[1].ToString();
                txtNombrePaciente.Text = dt.Rows[posicion].ItemArray[2].ToString();
                chbHepatitisA.Text = dt.Rows[posicion].ItemArray[3].ToString();
                chbHepatitisB.Text = dt.Rows[posicion].ItemArray[4].ToString();
                chbPolio.Text = dt.Rows[posicion].ItemArray[5].ToString();
                chbNeumococo.Text = dt.Rows[posicion].ItemArray[6].ToString();

                lblNavegacion.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            } else {
                LimpiarCajas();
            }
        }

        private void LimpiarCajas() {
            txtNumRegistro.Text = "";
            txtNombrePaciente.Text = "";
            chbHepatitisA.Text = "";
            chbHepatitisB.Text = "";
            chbPolio.Text = "";
            chbNeumococo.Text = "";
        }

        private void Ejercicio3_Load(object sender, EventArgs e) {
            ActuliazarDsPaciente();
            dgvDatosPaciente.DataSource = dt.DefaultView;

        }

        private void btnSiguiente_Click(object sender, EventArgs e) {
            if (posicion < dt.Rows.Count - 1) {
                posicion++;
                MostrarDatosPaciente();
            } else {
                MessageBox.Show("Ultimo registro", "Navegacion de pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (posicion > 0) {
                posicion--;
                MostrarDatosPaciente();
            } else {
                MessageBox.Show("Primer registro", "Navegacion de pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnUltimo_Click(object sender, EventArgs e) {
            posicion = dt.Rows.Count - 1;
            MostrarDatosPaciente();
        }

        private void btnPrimero_Click(object sender, EventArgs e) {
            posicion = 0;
            MostrarDatosPaciente();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            if (btnAgregar.Text == "Agregar") {
                btnAgregar.Text = "Guardar";
                btnModificiar.Text = "Cancelar";
                Activar_Desactivar(false);
                LimpiarCajas();
                accion = "Nuevo";
            } else {
                String[] pacientes = new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),
                    txtNumRegistro.Text,
                    txtNombrePaciente.Text,
                    chbHepatitisA.Text = vacuna,
                    chbHepatitisB.Text = vacuna,
                    chbPolio.Text = vacuna,
                    chbNeumococo.Text = vacuna

                };
                String Respuesta = objConexion.AdministrarPaciente(pacientes, accion);
                if (Respuesta != "1") {
                    MessageBox.Show("Error al intentar guardar: " + Respuesta, "Edicion de evento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    ActuliazarDsPaciente();
                    Activar_Desactivar(true);
                    btnAgregar.Text = "Agregar";
                    btnModificiar.Text = "Modificar";
                }
            }
        }

        private void btnModificiar_Click(object sender, EventArgs e) {
            if(btnModificiar.Text == "Modificar") {
                btnAgregar.Text = "Guardar";
                btnModificiar.Text = "Cancelar";
                Activar_Desactivar(false);
                accion = "Modificar";
            } else {
                MostrarDatosPaciente();
                btnAgregar.Text = "Agregar";
                btnModificiar.Text = "Modificar";
                Activar_Desactivar(true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Esta seguro que desea eliminar: " + txtNombrePaciente.Text, "Eliminar paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                String Respuesta = objConexion.AdministrarPaciente(new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),

                }, "Eliminar");
                if (Respuesta != "1") {
                    MessageBox.Show("Error al eliminar registro" + Respuesta, "Eliminando paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    posicion = 0;
                    ActuliazarDsPaciente();
                }
            }
        }

        private void Activar_Desactivar(Boolean estado) {
            grbDatos.Enabled = !estado;
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
        }

        private void txtBuscaPaciente_TextChanged(object sender, EventArgs e) {
            FiltrarPaciente(txtBuscaPaciente.Text);
        }

        private void FiltrarPaciente(String valor) {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDatosPaciente.DataSource;
            bs.Filter = "Registro like '%" + valor + "%' OR Nombre like '%" + valor + "%' ";
            dgvDatosPaciente.DataSource = bs;
        }

        private void SeleccionarPaciente() {
            int idPaciente = int.Parse(dgvDatosPaciente.CurrentRow.Cells["IdPaciente"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(idPaciente));
            MostrarDatosPaciente();
        }

        private void dgvDatosPaciente_CellClick(object sender, DataGridViewCellEventArgs e) {
            SeleccionarPaciente();
        }

        private void txtBuscaPaciente_KeyUp(object sender, KeyEventArgs e) {
            FiltrarPaciente(txtBuscaPaciente.Text);
            if (e.KeyCode == Keys.Enter) {
                SeleccionarPaciente();
            }
        }
        string vacuna;

        private void chbHepatitisA_CheckedChanged(object sender, EventArgs e) {
            vacuna = "Hepatitis A";
        }

        private void chbHepatitisB_CheckedChanged(object sender, EventArgs e) {
            vacuna = "Hepatitis B";
        }

        private void chbPolio_CheckedChanged(object sender, EventArgs e) {
            vacuna = "Polio";
        }

        private void chbNeumococo_CheckedChanged(object sender, EventArgs e) {
            vacuna = "Neumococo";
        }
    }
}
