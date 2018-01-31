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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()



        {

            InitializeComponent();

            
        }
        Class1 conectar = new Class1();



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
    }
}
