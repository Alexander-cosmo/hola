using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio3 Ej3 = new Ejercicio3();
            Ej3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1 Ej1 = new Ejercicio1();
            Ej1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio2 Ej2 = new Ejercicio2();
            Ej2.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
