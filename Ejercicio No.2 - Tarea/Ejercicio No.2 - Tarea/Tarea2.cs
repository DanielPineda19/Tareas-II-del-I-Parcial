using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_No._2___Tarea
{
    public partial class Tarea2 : Form
    {
        public Tarea2()
        {
            InitializeComponent();
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            if (Nota1TextBox.Text == "")
            {
                errorProvider1.SetError(Nota1TextBox, "Ingrese la nota del primer parcial");
                return;
            }
            if (Nota2TextBox.Text == "")
            {
                errorProvider1.SetError(Nota2TextBox, "Ingrese la nota del segundo parcial");
                return;
            }
            if (Nota3TextBox.Text == "")
            {
                errorProvider1.SetError(Nota3TextBox, "Ingrese la nota del tercer parcial");
                return;
            }
            if (Nota4TextBox.Text == "")
            {
                errorProvider1.SetError(Nota4TextBox, "Ingrese la nota del cuarto parcial");
                return;
            }
            errorProvider1.Clear(); 


            decimal Nota1 = Convert.ToDecimal(Nota1TextBox.Text);
            decimal Nota2 = Convert.ToDecimal(Nota2TextBox.Text);
            decimal Nota3 = Convert.ToDecimal(Nota3TextBox.Text);
            decimal Nota4 = Convert.ToDecimal(Nota4TextBox.Text);

            decimal Promedio = await CalcularPromedioAsync(Nota1, Nota2, Nota3, Nota4);


            PromedioTextBox.Text = "El promedio del estudiante es: " + Promedio + "%";

        }

        private async Task<decimal> CalcularPromedioAsync(decimal N1, decimal N2, decimal N3, decimal N4)
        {

            decimal promedio = await Task.Run(() =>
            {
                return (N1 + N2 + N3 + N4) / 4;
            });

            return promedio;

        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            AlumnoTextBox.Clear();
            Nota1TextBox.Clear();
            Nota2TextBox.Clear();
            Nota3TextBox.Clear();
            Nota4TextBox.Clear();
            PromedioTextBox.Clear();
        }

        
    }
}
