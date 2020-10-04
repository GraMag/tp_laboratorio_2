using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }

        private ETipo tipo;
        
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Marca del Sedan</param>
        /// <param name="chasis">Codigo de chasis</param>
        /// <param name="color">Color del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca">Marca del Sedan</param>
        /// <param name="chasis">Codigo de chasis</param>
        /// <param name="color">Color del Sedan</param>
        /// <param name="tipo">Cantidad de puertas</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return Vehiculo.ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Sobreescribe el metodo Mostrar() con la informacion del Sedan 
        /// </summary>
        /// <returns>string con los datos del Sedan</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
