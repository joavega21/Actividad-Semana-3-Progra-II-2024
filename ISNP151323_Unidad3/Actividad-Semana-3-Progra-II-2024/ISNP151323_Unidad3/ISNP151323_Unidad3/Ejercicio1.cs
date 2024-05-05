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
    public partial class Ejercicio1 : Form
    {

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            ActuliazarDsAlumnos();
            dgvDatosAlumno.DataSource = dt.DefaultView;
        }
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        int posicion = 0;
        string accion = "Nuevo";
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void ActuliazarDsAlumnos()
        {
            ds.Clear();
            ds = objConexion.ObtenerDatos();
            dt = ds.Tables["alumnos"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["IdAlumno"] };
            MostrarDatosAlumnos();
        }

        private void MostrarDatosAlumnos()
        {
            if (dt.Rows.Count > 0)
            {
                txtCodigoAlumno.Text = dt.Rows[posicion].ItemArray[1].ToString();
                txtNombreAlumno.Text = dt.Rows[posicion].ItemArray[2].ToString();
                txtEdadAlumno.Text = dt.Rows[posicion].ItemArray[3].ToString();
                txtPromedioAlumno.Text = dt.Rows[posicion].ItemArray[4].ToString();
                cmbSexoAlumno.Text = dt.Rows[posicion].ItemArray[5].ToString();
                txtLab1.Text = dt.Rows[posicion].ItemArray[6].ToString();
                txtLab2.Text = dt.Rows[posicion].ItemArray[7].ToString();
                txtParcial.Text = dt.Rows[posicion].ItemArray[8].ToString();

                lblNavegacion.Text = (posicion + 1) + " de " + dt.Rows.Count.ToString();
            } else
            {
                LimpiarCajas();
            }
        }
        private void LimpiarCajas()
         {
            txtCodigoAlumno.Text = "";
            txtNombreAlumno.Text = "";
            txtEdadAlumno.Text = "";
            txtPromedioAlumno.Text = "";
            cmbSexoAlumno.Text = "";
            txtLab1.Text = "";
            txtLab2.Text = "";
            txtParcial.Text = "";
         }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(posicion < dt.Rows.Count-1)
            {
                posicion++;
                MostrarDatosAlumnos();
            }else
            {
                MessageBox.Show("Ultimo registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarDatosAlumnos();
            } else
            {
                MessageBox.Show("Primer registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            posicion = dt.Rows.Count - 1;
            MostrarDatosAlumnos();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            MostrarDatosAlumnos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Text == "Agregar")
            {
                btnAgregar.Text = "Guardar";
                btnModificiar.Text = "Cancelar";
                Activar_Desactivar(false);
                LimpiarCajas();
                accion = "Nuevo";
            }else
            {
                String[] alumnos = new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),
                    txtCodigoAlumno.Text,
                    txtNombreAlumno.Text,
                    txtEdadAlumno.Text,
                    txtPromedioAlumno.Text,
                    cmbSexoAlumno.Text,
                    txtLab1.Text,
                    txtLab2.Text,
                    txtParcial.Text
                };
                String Respuesta = objConexion.AdministrarAlumnos(alumnos, accion);
                if (Respuesta != "1")
                {
                    MessageBox.Show("Error al intentar guardar: " + Respuesta, "Edicion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    ActuliazarDsAlumnos();
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
                MostrarDatosAlumnos();
                btnAgregar.Text = "Agregar";
                btnModificiar.Text = "Modificar";
                Activar_Desactivar(true);
            }
        }
        private void Activar_Desactivar(Boolean estado)
        {
            grbDatos.Enabled = !estado;
            grbNavegacion.Enabled = estado;
            btnEliminar.Enabled = estado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtLab1.Text),
                   nota2 = double.Parse(txtLab2.Text),
                   nota3 = double.Parse(txtParcial.Text),
                   promedio = 0;
            promedio = Math.Round((nota1 * 0.30) + (nota2 * 0.30) + (nota3 * 0.40),2);
            txtPromedioAlumno.Text = promedio.ToString();
        }
        private void FiltrarAlumno(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvDatosAlumno.DataSource;
            bs.Filter = "Codigo like '%" + valor + "%' OR Nombre like '%" + valor + "%' ";
            dgvDatosAlumno.DataSource = bs;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarAlumno(txtBuscar.Text);
        }
        private void SeleccionarAlumno()
        {
            int idAlumno = int.Parse(dgvDatosAlumno.CurrentRow.Cells["IdAlumno"].Value.ToString());
            posicion = dt.Rows.IndexOf(dt.Rows.Find(idAlumno));
            MostrarDatosAlumnos();
        }

        private void dgvDatosAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarAlumno();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarAlumno(txtBuscar.Text);
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionarAlumno();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar: " + txtNombreAlumno.Text, "Eliminar alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String Respuesta = objConexion.AdministrarAlumnos(new string[]
                {
                    dt.Rows[posicion].ItemArray[0].ToString(),

                }, "Eliminar");
                if (Respuesta != "1")
                {
                    MessageBox.Show("Error al eliminar registro" + Respuesta, "Eliminando alumno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    posicion = 0;
                    ActuliazarDsAlumnos();
                }
            }
        }
    }
}
