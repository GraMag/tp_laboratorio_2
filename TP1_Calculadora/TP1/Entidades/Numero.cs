using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor sin parametros.
        /// Inicializa el numero en 0
        /// </summary>
        public Numero()
        {
            numero = 0;
        }

        /// <summary>
        /// Constructor con un parametro double
        /// </summary>
        /// <param name="numero">Numero</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor con un parametro string
        /// </summary>
        /// <param name="strNumero">Cadena de numeros</param>
        public Numero(string strNumero)
        {
            SetNumero(strNumero);
        }

        /// <summary>
        /// Setter
        /// </summary>
        /// <param name="numero">Cadena de numeros</param>
        public void SetNumero(string numero)
        {
            this.numero = Numero.ValidarNumero(numero);
        }

        /// <summary>
        /// Convierte de un numero binario a decimal
        /// </summary>
        /// <param name="binario">Cadena numerica binaria</param>
        /// <returns>[Valor decimal] Si puede convertirse [Valor invalido] si "binario" no es un numero binario</returns>
        public static string BinarioDecimal(string binario)
        {
            //valida que sea binario
            if (Numero.EsBinario(binario))
            {
                double numeroDecimal = 0;

                for(int i = binario.Length-1 ; i >= 0; i--)
                {
                    // Si el valor en la posicion [i] es 1 calcula el valor
                    if (binario[i] == '1') 
                    {
                        numeroDecimal += Math.Pow(2, (binario.Length - 1 - i));
                    }
                }
                return numeroDecimal.ToString(); // Resultado convertido a string
            } else {
                return "Valor invalido"; // No era un numero binario
            }
        }

        /// <summary>
        /// Convierte de decimal a binario
        /// </summary>
        /// <param name="numero">Numero</param>
        /// <returns>["Valor Invalido"] si es 0 o negativo [Numero binario] si se puede convertir</returns>
        public static string DecimalBinario(double numero)
        {
            string result = "";

            if(numero <= 0) // Si no es un numero entero positivo no se puede convertir
            {
                result = "Valor invalido";
            } 
            else
            {
                if ((int)numero == 1)
                {
                    result = "1";
                }
                else
                {
                    while (numero > 0)
                    {
                        result = numero % 2 + result;
                        numero = (int)numero / 2;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Convierte de decimal a binario
        /// </summary>
        /// <param name="numero">Cadena de caracteres numericos</param>
        /// <returns>["Valor Invalido"] si es 0 o negativo [Numero binario] si se puede convertir</returns>
        public static string DecimalBinario(string numero)
        {
            Numero numer0 = new Numero(numero);
            return DecimalBinario(numer0.numero);
        }

        /// <summary>
        /// Comprueba si la cadena ingresada es un numero binario.
        /// </summary>
        /// <param name="binario">Cadena de caracteres</param>
        /// <returns>Devuelve [false] si no es un numero binario
        /// [true] si es un numero binario <returns>
        private static bool EsBinario(string binario)
        {
            for(int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Suma de dos numeros 
        /// </summary>
        /// <param name="n1">Sumando 1</param>
        /// <param name="n2">Sumando 2</param>
        /// <returns>Total</returns>
        public static double operator + (Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Resta de dos numeros
        /// </summary>
        /// <param name="n1">Minuendo</param>
        /// <param name="n2">Sustraendo</param>
        /// <returns>Diferencia</returns>
        public static double operator - (Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Multiplica dos numeros
        /// </summary>
        /// <param name="n1">Factor 1</param>
        /// <param name="n2">Factor 2</param>
        /// <returns>Producto</returns>
        public static double operator * (Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
         
        
        /// <summary>
        /// Divide dos numeros
        /// </summary>
        /// <param name="n1">Dividendo</param>
        /// <param name="n2">Divisor</param>
        /// <returns> [Resultado de la operacion] si el divisor es distinto de 0. [MinValue] si el divisor es 0 </returns>
        public static double operator / (Numero n1, Numero n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            } else
            {
                return n1.numero / n2.numero;
            }
        }

        /// <summary>
        /// Valida que el dato ingresado sea un numero. 
        /// </summary>
        /// <param name="strNumero">Numero en formato string</param>
        /// <returns>Devuelve [0] si el atributo ingresado no se puede convertir en numero. 
        /// [double n] El numero ingresado si es un numero valido</returns>
        private static double ValidarNumero(string strNumero)
        {
            StringBuilder sb = new StringBuilder(strNumero);
            for(int i = 0; i < strNumero.Length; i++)
            {
                if (strNumero[i].Equals('.'))
                {
                    sb.Replace('.', ',');
                }
            }
            double.TryParse(sb.ToString(), out double numero); // El metodo tryparse si no puede convertir el numero devuelve 0

            return numero;
        }
    }
}
