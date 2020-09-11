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
        public static double Operar(int num1, int num2, string operador)
        {
            double result = 0;
            
            Numero number1 = new Numero(num1);
            Numero number2 = new Numero(num2);

            switch (Calculadora.ValidarOperador(operador[0]))
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
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
