using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class accesoBD
    {
        public accesoBD() { }
        static string conexion = @"Data Source=localhost;Initial Catalog=db_CRUMAR;Integrated Security=True";

        public SqlConnection cadena = new SqlConnection(conexion);
        //Comando
        SqlCommand comando = new SqlCommand();

        //Lector	
        SqlDataReader lector;

        //Sentencia para sql
        string sentencia = "";

        #region Usuarios

        public bool autenticarUsuario(string _usuario, string _pass)
        {
            try
            {
                bool bandera = false;
                sentencia = "select * from usuariosAdmin.tbEmpleados where usuario =@usr and pass =@pass";

                comando = new SqlCommand(sentencia, cadena);

                comando.Parameters.AddWithValue("@usr", _usuario);
                comando.Parameters.AddWithValue("@pass", _pass);

                cadena.Open();

                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    bandera = true;
                }
                else
                {
                    bandera = false;
                }
                return bandera;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cadena.Close();
            }
        }
        #endregion
        public DataSet consultaUsuarios()
        {
            try
            {
                sentencia = "select * from usuariosAdmin.tbEmpleados";
                SqlDataAdapter adaptadores = new SqlDataAdapter(sentencia, cadena);

                DataSet datos = new DataSet();

                adaptadores.Fill(datos, "tbEmpleados");
                return datos;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cadena.Close();
            }
        }
    }
}
