using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int numero1;
        private int numero2;
        private int cantidadSumas;

        /// <summary>
        /// Manejador del evento click del boton SumarButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SumarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //numero1 = int.Parse(Numero1TextBox.Text);
                //numero2 = int.Parse(Numero2TextBox.Text);
                var sumar = ObtenerSuma(numero1, numero2);
                MessageBox.Show(sumar.ToString(), "Resultado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cantidadSumas++;
                //Limpiar textos
                Numero1TextBox.Clear();
                Numero2TextBox.Clear();
                Numero1TextBox.Focus(); //situa el cursor en dicho control

            }
            //else
            //{
            //    MessageBox.Show("Hay errores en los datos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    Numero1TextBox.SelectAll();
            //    Numero1TextBox.Focus();
            //}
        }

        private int ObtenerSuma(int x, int y) => x + y;

        private bool ValidarDatos()
        {
            bool valido = true;
            ErroresErrorProvider.Clear();
            if (!int.TryParse(Numero1TextBox.Text, out numero1))
            {
                valido = false;
                ErroresErrorProvider.SetError(Numero1TextBox, "Número mal ingresado");
            }

            if (!int.TryParse(Numero2TextBox.Text, out numero2))
            {
                valido = false;
                ErroresErrorProvider.SetError(Numero2TextBox, "Número mal ingresado");

            }

            return valido;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            //TODO: Preguntar si me quiero ir del programa
            //Cerrar la aplicación
            MessageBox.Show($"Se realizaron {cantidadSumas} sumas");
            Application.Exit();
        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //numero1 = int.Parse(Numero1TextBox.Text);
                //numero2 = int.Parse(Numero2TextBox.Text);
                var restar = ObtenerResta(numero1, numero2);
                MessageBox.Show(restar.ToString(), "Resultado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                //Limpiar textos
                Numero1TextBox.Clear();
                Numero2TextBox.Clear();
                Numero1TextBox.Focus(); //situa el cursor en dicho control

            }

        }

        private int ObtenerResta(int nro1, int nro2) => nro1 - nro2;
    }
}
