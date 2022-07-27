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
        /// Crea una instancia de tipo Sedan con los atributos que recibe por parametro
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : this(marca, chasis, color,ETipo.CuatroPuertas){}

        /// <summary>
        /// Crea una instancia de tipo Sedan con los atributos que recibe por parametro
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo): base(chasis,marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        ///  Retorna el atributo tamanio
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Muestra los datos del vehiculo
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.Mostrar()}TIPO : {this.tipo}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
