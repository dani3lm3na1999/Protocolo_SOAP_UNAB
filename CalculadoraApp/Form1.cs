using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraApp
{
    public partial class Form1 : Form
    {
        private CalculadoraServiceReference.CalculadoraClient cliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            cliente = new CalculadoraServiceReference.CalculadoraClient();

            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);


            MessageBox.Show($"El resultado es: {cliente.Sum(num1, num2)}",
                "Calculadora Básica", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            cliente = new CalculadoraServiceReference.CalculadoraClient();

            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);


            MessageBox.Show($"El resultado es: {cliente.Subtract(num1, num2)}",
                "Calculadora Básica", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            cliente = new CalculadoraServiceReference.CalculadoraClient();

            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);


            MessageBox.Show($"El resultado es: {cliente.Multiply(num1, num2)}",
                "Calculadora Básica", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            try
            {
                cliente = new CalculadoraServiceReference.CalculadoraClient();

                int num1 = int.Parse(txtNum1.Text);
                int num2 = int.Parse(txtNum2.Text);


                MessageBox.Show($"El resultado es: {cliente.Divide(num1, num2)}",
                    "Calculadora Básica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ocurrio un error inesperado",
                    "Calculadora Básica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
