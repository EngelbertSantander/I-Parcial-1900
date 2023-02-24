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

            if(OperacionesComboBox.Text == String.Empty) 
            {
                errorProvider1.SetError(OperacionesComboBox, "Seleccione una operacion");
                return;
            }
            errorProvider1.Clear();

            decimal num1 = Convert.ToDecimal(Num1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Num2TextBox.Text);
            ResultadoLabel.Text = Calcular(num1, num2).ToString();

        }

        private decimal Calcular(decimal n1, decimal n2)
        {
            string operacion = OperacionesComboBox.Text;

            decimal resultado = 0;

            if (operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicación")
            {
                resultado = n1 * n2;
            }
            else if (operacion == "División")
            {
                if (n2 == 0)
                    resultado = 0;
                else 
                    resultado = n1 / n2;
            }
            return resultado;
        }

        //private decimal Calcular2(decimal n1, decimal n2) //En la nueva version de C# podemos quitar las llaves del codigo
        //{
        //    string operacion = OperacionesComboBox.Text;

        //    decimal resultado = 0;

        //    if (operacion == "Suma")
        //        resultado = n1 + n2;
        //    else if (operacion == "Resta")
        //        resultado = n1 - n2;
        //    else if (operacion == "Multiplicacion")
        //        resultado = n1 * n2;
        //    else if (operacion == "Division")
        //        resultado = n1 / n2;
        //    return resultado;
        //}
    }
}
