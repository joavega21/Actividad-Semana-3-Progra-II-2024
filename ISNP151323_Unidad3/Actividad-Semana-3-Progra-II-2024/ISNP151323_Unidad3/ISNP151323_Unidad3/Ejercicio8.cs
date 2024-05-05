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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {
            ActuliazarDsCumple();
            dgvDatosCumple.DataSource = dt.DefaultView;
        }

        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        string accion = "Nuevo";

        private void ActuliazarDsCumple()
        {
            ds.Clear();
            ds = objConexion.ObtenerDatos();
            dt = ds.Tables["cumple"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["IdCumple"] };
            MostrarDatosCumple();
        }

        private void MostrarDatosCumple()
        {
            if (dt.Rows.Count > 0)
            {
                txtRegistro.Text = dt.Rows[posicion].ItemArray[1].ToString();
                txtNombre.Text = dt.Rows[posicion].ItemArray[2].ToString();
                txtTelefono.Text = dt.Rows[posicion].ItemArray[3].ToString();
                txtFecha.Text = dt.Rows[posicion].ItemArray[4].ToString();
                
                lblNavegacion.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            } else
            {
                LimpiarCajas();
            }
        }

        private void LimpiarCajas()
        {
            txtRegistro.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtFecha.Text = "";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < dt.Rows.Count - 1)
            {
                posicion++;
                MostrarDatosCumple();
            } else
            {
                MessageBox.Show("Ultimo registro", "Navegacion de cumpleañero", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarDatosCumple();
            } else
            {
                MessageBox.Show("Primer registro", "Navegacion de cumpleañero", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            posicion = dt.Rows.Count - 1;
            MostrarDatosCumple();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            MostrarDatosCumple();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Agregar")
            {
                btnAgregar.Text = "Guardar";
                btnModificiar.Text = "Cancelar";
                Activar_Desactivar(false);
                LimpiarCajas();
                accion = "Nuevo";
            } else
            {
                String[] cumples = new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),
                    txtRegistro.Text,
                    txtNombre.Text,
                    txtTelefono.Text,
                    txtFecha.Text
                };
                String Respuesta = objConexion.AdministrarCumple(cumples, accion);
                if (Respuesta != "1")
                {
                    MessageBox.Show("Error al intentar guardar: " + Respuesta, "Edicion de cumpleañero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    ActuliazarDsCumple();
                    Activar_Desactivar(true);
                    btnAgregar.Text = "Agregar";
                    btnModificiar.Text = "Modificar";
                }
            }
        }

        private void btnModificiar_Click(object sender, EventArgs e)
        {
            if (btnModificiar.Text == "Modificar")
            {
                btnAgregar.Text = "Guardar";
                btnModificiar.Text = "Cancelar";
                Activar_Desactivar(false);
                accion = "Modificar";
            } else
            {
                MostrarDatosCumple();
                btnAgregar.Text = "Agregar";
                btnModificiar.Text = "Modificar";
                Activar_Desactivar(true);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar: " + txtNombre.Text, "Eliminar cumpleañero", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String Respuesta = objConexion.AdministrarCumple(new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),

                }, "Eliminar");
                if (Respuesta != "1")
                {
                    MessageBox.Show("Error al eliminar registro" + Respuesta, "Eliminando cumpleañero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    posicion = 0;
                    ActuliazarDsCumple();
                }
            }
        }

        private void Activar_Desactivar(Boolean estado)
        {
            grbDatos.Enabled = !estado;
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
        }

        private void FiltrarCumple(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDatosCumple.DataSource;
            bs.Filter = "Registro like '%" + valor + "%' OR Nombre like '%" + valor + "%' ";
            dgvDatosCumple.DataSource = bs;
        }

        private void txtBuscaCumple_TextChanged(object sender, EventArgs e)
        {
            FiltrarCumple(txtBuscaCumple.Text);
        }

        private void SeleccionarCumple()
        {
            int idCumple = int.Parse(dgvDatosCumple.CurrentRow.Cells["IdCumple"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(idCumple));
            MostrarDatosCumple();
        }

        private void dgvDatosCumple_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarCumple();
        }

        private void txtBuscaCumple_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarCumple(txtBuscaCumple.Text);
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarCumple();
            }
        }
    }
}
