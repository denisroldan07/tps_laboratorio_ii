using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PasajeroExtendida
    {
        public static string ImprimirPasajero(this Pasajero pasajero,Avion avion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(pasajero.ToString());
            sb.AppendLine(avion.ToString());

            return sb.ToString();
        }
    }
}
