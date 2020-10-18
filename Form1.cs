using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agrego referencias a BusinessModelLayer y DataLayer para usar el tipo de dato Lista.Personas
            // Asi mismo, agrego nuget de EF en PresentationLayer, y ConectionStrings de DataLayer
            dataGridView1.DataSource =  BusinessModelLayer.People.lstGetPeople();

            // Para asignar el servicio a campo de formulario
            // Agregar referencia a ServicesLayer
            textBox1.Text =  ServicesLayer.Service.GetPost();
        }
    }
}
