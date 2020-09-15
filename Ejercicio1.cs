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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbnum1.SelectedIndex == -1)
            {
                MessageBox.Show("no selecciono nada");
            }
            else
            {
                lbnumero2.Items.Add(lbnum1.SelectedItem);
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text.Trim() == "")
            {
                MessageBox.Show("No se a ingresado nada");
            }
            else
            {
                lbnum1.Items.Add(txtnombre.Text);
                txtnombre.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbnum1.SelectedIndex == -1)
            {
                MessageBox.Show("no selecciono nada");
            }
            else
            {
                foreach (object item in lbnum1.SelectedItems)
                {
                    lbnumero2.Items.Add(item);
                }

                
           
            }




        }
    }
}
