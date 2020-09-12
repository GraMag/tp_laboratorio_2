using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza operaciones aritmeticas
        /// </summary>
        /// <param name="num1">Numero entero</param>
        /// <param name="num2">Numero entero</param>
        /// <param name="operador">Operador aritmetico</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double result = 0;
  
            switch (Calculadora.ValidarOperador(operador[0]))
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            return result;
        }

        /// <summary>
        /// Valida si el parametro es un operador valido
        /// </summary>
        /// <param name="operador">Operador aritmetico</param>
        /// <returns>Operador aritmetico</returns>
        private static string ValidarOperador(char operador)
        {
            if (!(operador == '+' || operador == '-' || operador == '*' || operador == '/'))
            {
                return "+";
            }
            else
            {
                return operador.ToString();
            }
        }
    }
}
