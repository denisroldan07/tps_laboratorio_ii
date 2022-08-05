using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tickets
    {
        
        public long Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Asiento { get; set; }
        public string Destino { get; set; }
        public int IdAvion { get; set; }

        public DateTime Fecha { get; set; }

        public Tickets(long dni,string nombre, string apellido, int asiento, string destino, int idAvion, DateTime fecha)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Asiento = asiento;
            Destino = destino;
            IdAvion = idAvion;
            Fecha = fecha;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ticket:\n");
            sb.AppendLine($"Nombre y Apellido:{Nombre} {Apellido}\n");
            sb.AppendLine($"Numero de asiento:{Asiento}\n");
            sb.AppendLine($"Destino del avion:{Destino}\n");
            sb.AppendLine($"Numero de vuelo:{IdAvion}\n");
            sb.AppendLine($"Fecha de impresion:{Fecha}\n");

            return sb.ToString();
        }

    }
}
