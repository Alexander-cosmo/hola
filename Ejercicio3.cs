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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
             string estado1 = "";
            string sexo = "";
            string check = "";

            if (rbsoltero.Checked == true){
                estado1 = "soltero";
            }
            if(rbCasado.Checked == true)
            {
                estado1 = "Casado";
            }

            if(rbMasculino.Checked == true)
            {
                sexo = "Masculino";
            }
            if(rbFemenino.Checked== true)
            {
                sexo = "Femenino";
            }
           /// string trabajo = cbloficio.SelectedItems.ToString();

            lbl1.Text = estado1;
            lbl2.Text = sexo;
            int c = 0;
                        
            foreach(object item in cbloficio.CheckedItems)
            {
                if (c == 0)
                {
                    check = check  + item;
                }
                else
                {
                    check = check + "/" + item;
                }
                c++;
                
            }
            lbl3.Text = check;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
