using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ISNP151323_Unidad3
{
    internal class Conexion {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Conexion() {
            string Cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BD_Actividades.mdf;Integrated Security=True";
            miConexion.ConnectionString = Cadena;
            miConexion.Open();
        }
        public DataSet ObtenerDatos(){
            ds.Clear();
            miComando.Connection = miConexion;
            miComando.CommandText = "select * from alumnos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(ds, "alumnos");

            miComando.CommandText = "select * from agenda";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(ds, "agenda");

            miComando.CommandText = "select * from Vacunas";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(ds, "Vacunas");

            miComando.CommandText = "select * from peliculas";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(ds, "peliculas");
            return ds;
        }
        public string AdministrarAlumnos(String[]alumnos, String accion)
        {
            String sql = "";
            if(accion == "Nuevo")
            {
                sql = "INSERT INTO alumnos (Codigo, Nombre, Edad, Sexo, Nota1, Nota2, Parcial , Promedio) VALUES ('"+ alumnos[1] + "', " +
                    "'"+ alumnos[2] + "', '"+ alumnos[3] + "', '"+ alumnos[4] + "',  '"+ alumnos[5] + "',  '"+ alumnos[6] + "',  '"+ alumnos[7] + "',  '"+ alumnos[8] + "')";
            }else if(accion == "Modificar")
            {
                sql = "UPDATE alumnos SET Codigo = '" + alumnos[1] + "', " +
                    "Nombre = '" + alumnos[2] + "', Edad = '" + alumnos[3] + "', Sexo = '" + alumnos[4] + "', Nota1 = '" + alumnos[5] + "', Nota2 = '" + alumnos[6] + "', Parcial = '" + alumnos[7] + "', Promedio = '" + alumnos[8] + "'" +
                    "WHERE IdAlumno = '" + alumnos[0] + "'";
            }else if (accion == "Eliminar")
            {
                sql = "DELETE alumnos WHERE IdAlumno = '" + alumnos[0] + "'";
            }
            return EjecutarSQL(sql);
        }

        public string AdministrarEvento(String[] agenda, String accion) {
            String sql = "";
            if (accion == "Nuevo") {
                sql = "INSERT INTO agenda (Nombre, Texto, Fecha) VALUES ('" + agenda[1] + "', " + "'" + agenda[2] + "', '" + agenda[3] + "')";
            } else if (accion == "Modificar") {
                sql = "UPDATE agenda SET Nombre = '" + agenda[1] + "', " +
                    "Texto = '" + agenda[2] + "', Fecha = '" + agenda[3] + "'" +
                    "WHERE IdEvento = '" + agenda[0] + "'";
            } else if (accion == "Eliminar") {
                sql = "DELETE agenda WHERE IdEvento = '" + agenda[0] + "'";
            }
            return EjecutarSQL(sql);
        }

        public string AdministrarPaciente(String[] paciente, String accion) {
            String sql = "";
            if (accion == "Nuevo") {
                sql = "INSERT INTO Vacunas (Registro, Nombre, Vacuna1, Vacuna2, Vacuna3, Vacuna4) VALUES ('" + paciente[1] + "', " +
                    "'" + paciente[2] + "', '" + paciente[3] + "', '" + paciente[4] + "',  '" + paciente[5] + "',  '" + paciente[6] + "')";
            } else if (accion == "Modificar") {
                sql = "UPDATE Vacunas SET Registro = '" + paciente[1] + "', " +
                    "Nombre = '" + paciente[2] + "', Vacuna1 = '" + paciente[3] + "', Vacuna2 = '" + paciente[4] + "', Vacuna3 = '" + paciente[5] + "', Vacuna4 = '" + paciente[6] + "'" +
                    "WHERE IdPaciente = '" + paciente[0] + "'";
            } else if (accion == "Eliminar") {
                sql = "DELETE Vacunas WHERE IdPaciente = '" + paciente[0] + "'";
            }
            return EjecutarSQL(sql);
        }

        public string AdministrarPeliculas(String[] pelicula, String accion) {
            String sql = "";
            if (accion == "Nuevo") {
                sql = "INSERT INTO peliculas (NoPelicula, Titulo, Formato, Genero, Cantidad) VALUES ('" + pelicula[1] + "', " +
                    "'" + pelicula[2] + "', '" + pelicula[3] + "', '" + pelicula[4] + "',  '" + pelicula[5] + "')";
            } else if (accion == "Modificar") {
                sql = "UPDATE peliculas SET NoPelicula = '" + pelicula[1] + "', " +
                    "Titulo = '" + pelicula[2] + "', Formato = '" + pelicula[3] + "', Genero = '" + pelicula[4] + "', Cantidad = '" + pelicula[5] + "'" +
                    "WHERE IdPelicula = '" + pelicula[0] + "'";
            } else if (accion == "Eliminar") {
                sql = "DELETE peliculas WHERE IdPelicula = '" + pelicula[0] + "'";
            }
            return EjecutarSQL(sql);
        }

        private string EjecutarSQL(string sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }catch (Exception ex)
            {
                return ex.Message;
            }
           
        }
    }
}
