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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text.Trim() == "" || txtapellido.Text.Trim() == "")
            {
                MessageBox.Show("es obligatorio llenar ambos campos");
            }
            else
            {
                if (lbElementos.Items.Contains(txtnombre.Text + " " + txtapellido.Text))
                {
                    MessageBox.Show("el elemento ingresado ya existe en la lista");
                }
                else
                {
                    lbElementos.Items.Add(txtnombre.Text + " " + txtapellido.Text);
                }
                }
            txtapellido.Text = "";
            txtnombre.Text = "";
            


           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbElementos.SelectedIndex == -1)
            {
                MessageBox.Show("No a seleccionado ningun elemento de la lista,seleccione uno para borrar");
            }
            else
            {
                lbElementos.Items.RemoveAt(lbElementos.SelectedIndex);
            }
            
        }
    }
}
