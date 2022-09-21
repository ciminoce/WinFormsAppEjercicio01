using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class FrmOperacionesBasicas : Form
    {
        public FrmOperacionesBasicas()
        {
            InitializeComponent();
        }

        private int numero1;
        private int numero2;
        private int cantidadSumas;
        private int cantidadRestas;
        private int cantidadProductos;
        private int cantidadDivisiones;

        /// <summary>
        /// Manejador del evento click del boton SumarButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SumarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var sumar = ObtenerSuma(numero1, numero2);
                MessageBox.Show(sumar.ToString(), "Resultado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cantidadSumas++;
                SumasTextBox.Text = cantidadSumas.ToString();
                //Limpiar textos
                LimpiarControles();
            }
        }
        /// <summary>
        /// Método para limpiar cuadros de texto
        /// </summary>
        private void LimpiarControles()
        {
            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            Numero1TextBox.Focus(); //situa el cursor en dicho control
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
            //TODO: Preguntar si me quiero ir del programa.
            DialogResult dr = MessageBox.Show("¿Desea salir del programa?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            //Cerrar la aplicación
            //StringBuilder sb = new StringBuilder();
            
            //if (cantidadRestas==0)
            //{
            //    sb.AppendLine("No se realizaron restas");

            //}else if (cantidadRestas==1)
            //{
            //    sb.AppendLine("Se realizó 1 resta");
            //}
            //else
            //{
            //    sb.AppendLine($"Se realizaron {cantidadRestas} restas");
                
            //}
            //sb.AppendLine($"Se realizaron {cantidadSumas} sumas");
            //MessageBox.Show(sb.ToString(),"Estadìsticas",
            //    MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            Application.Exit();
        }

        private void RestarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var restar = ObtenerResta(numero1, numero2);
                MessageBox.Show(restar.ToString(), "Resultado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cantidadRestas++;
                RestasTextBox.Text = cantidadRestas.ToString();
                //Limpiar textos
               LimpiarControles();

            }

        }

        private int ObtenerResta(int nro1, int nro2) => nro1 - nro2;

        private void MultiplicarButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var producto = ObtenerProducto(numero1, numero2);
                cantidadProductos++;
                ProductosTextBox.Text = cantidadProductos.ToString();
                MessageBox.Show(producto.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
            }
        }

        private int ObtenerProducto(int nro1, int nro2) => nro1 * nro2;

        private void DividirButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (numero2!=0)
                {
                    var dividir = ObtenerCociente(numero1, numero2);
                    cantidadDivisiones++;
                    CocientesTextBox.Text = cantidadDivisiones.ToString();
                    MessageBox.Show(dividir.ToString(), "Resultado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LimpiarControles();

                }
                else
                {
                    ErroresErrorProvider.SetError(Numero2TextBox,"El divisor no puede ser cero");
                }
            }
        }

        private double ObtenerCociente(int nro1, int nro2) =>(double) nro1 / nro2;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            if (MostrarButton.BackColor==Color.Transparent)
            {
                this.Width = 500;
                MostrarButton.BackColor = Color.OrangeRed;
                MostrarButton.Image = Resources.arrow_pointing_left_36px;

            }
            else
            {
                this.Width = 279;
                MostrarButton.BackColor = Color.Transparent;
                MostrarButton.Image = Resources.arrow_36px;

            }
        }

        private void FrmOperacionesBasicas_Load(object sender, EventArgs e)
        {
            this.Width = 279;
            
        }
    }
}
