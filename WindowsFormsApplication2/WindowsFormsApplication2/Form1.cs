using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_Datos;
using Npgsql;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        static string cadenaConexion = null;
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;
    

        public static void Conexion()
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

        public Form1()

        {
            InitializeComponent();
            this.CenterToScreen();
            Conexion();
            conexion.Open();
            List<String> lista = new List<String>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT nombre FROM estudiantes", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBoxEstudiantes.Items.Add(dr.GetString(0));
                }
            }
            conexion.Close();

        }

         Datos conectar = new Datos();//Aqui instacio los metodos de la clase datos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntInsertar_Click(object sender, EventArgs e)
        {
  
            int cedula = int.Parse(txtCedula.Text);
            string nombre = txtNombre.Text;
            string residencia = txtResidencia.Text;
            string fecha = dateTimePicker1.Text;

            //Conectamos la database y guardamos la informacion
            conectar.InsertarEstudiante(cedula, nombre, residencia, fecha);
            MessageBox.Show("Se ha insertado con exito");








        }

        private void comboBoxEstudiantes_SelectedIndexChanged(object sender, EventArgs e)

        {
            Conexion();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT cedula,nombre,residencia, fecha FROM estudiantes WHERE nombre = '" + comboBoxEstudiantes.SelectedItem + "'", conexion);
            NpgsqlDataReader leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    textBox1.Text = leer.GetString(0);
                    textBox2d.Text = leer.GetString(1);
                    texResidencia.Text = leer.GetString(2);
                    dateTimePicker2.Value = leer.GetDateTime(3);

                }

                conexion.Close();



            }

        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


