using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            if (Num1TextBox.Text == "")
            {
                errorProvider1.SetError(Num1TextBox, "Ingrese un valor");
                return;
            }
            errorProvider1.Clear();

            if(Num2TextBox.Text == String.Empty) //Otra forma de declarar, pero siempre con el mismo resultado
            {
                errorProvider1.SetError(Num2TextBox, "Ingrese un valor");
                return;
            }
            errorProvider1.Clear();
        }
    }
}
