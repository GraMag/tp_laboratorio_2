using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama al metodo que realiza operaciones y muestra el resultado en lblResultado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Operar(txtBoxNumero1.Text, txtBoxNumero2.Text, comboBoxSigno.Text).ToString("#.##");
            buttonConvertirABinario.Enabled = true; 
        }

        /// <summary>
        /// Llama al metodo que limpia la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Cierra el programa previa confirmacion del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cerrar?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Al clickear el boton convierte el resultado de la operacion de decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
            buttonConvertirABinario.Enabled = false;
            buttonConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Al clickaer el boton convierte el resultado de la operacion de binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvertirADecimal_Click(object sender, EventArgs e)
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            buttonConvertirABinario.Enabled = true;
            buttonConvertirADecimal.Enabled = false;
        }

        /// <summary>
        /// Reinicia los valores de los elementos en pantalla
        /// </summary>
        private void Limpiar()
        {
            txtBoxNumero1.Text = "";
            txtBoxNumero2.Text = "";
            lblResultado.Text = "";
            comboBoxSigno.SelectedIndex = 0;
        }

        /// <summary>
        /// Valida que los valores ingresados son numeros enteros, si lo son realiza las operaciones, sino devuelte 0
        /// </summary>
        /// <param name="numero1">Numero entero</param>
        /// <param name="numero2">Numero entero</param>
        /// <param name="operador">Operador aritmetico</param>
        /// <returns>[Resultado de la operacion] si puede realizarse el calculo. [0] Si no se pudo calcular</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            if (int.TryParse(numero1, out int num1) && int.TryParse(numero2, out int num2))
            {
                return Calculadora.Operar(num1, num2, operador);
            }
            else
            {
                return 0;
            }
        }
    }
}
