using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;




namespace capa_Datos
{
    public class Datos
    {
        static string cadenaConexion = null;
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public   static void Conexion()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "1414250816ma";
            string baseDatos = "sistema";

            cadenaConexion = "Server=" + servidor + "; " + "Port=" + puerto + "; " + "User Id=" + usuario + "; " + "Password=" + clave + "; " + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
            Console.WriteLine(cadenaConexion);



        }

        public void InsertarEstudiante(int cedula, string nombre, string residencia, string fecha)
        {
            Conexion();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO estudiantes (cedula, nombre, residencia, fecha) VALUES ('" + cedula + "', '" + nombre + "', '" + residencia + "', '" + fecha + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }




    }

}






        

        



    
