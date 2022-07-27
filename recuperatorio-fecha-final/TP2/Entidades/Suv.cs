using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv: Vehiculo
    {
        /// <summary>
        /// Crea una instancia de tipo Suv con los atributos que recibe por parametro
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }
        /// <summary>
        /// Retorna el atributo tamanio
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            } 
        }

        /// <summary>
        /// Muestra los datos del vehiculo
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar()); 
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
