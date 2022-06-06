using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public static class Vuelos
    {
        #region Atributos
        
        public static List<Avion> vuelos;

        #endregion

        #region Constructor
        static Vuelos()
        {
        }

        #endregion

        #region Metodos

        public static Avion ObtenerAvion(int id)
        {
            if(vuelos != null)
            {
                Avion avion = new Avion();
                foreach (var avion1 in vuelos)
                {
                    if (avion1.Id == id)
                    {
                        avion.Id = avion1.Id;
                        avion.Pasajeros = avion1.Pasajeros;
                        avion.Destino = avion1.Destino;
                        break;
                    }
                }
            return avion;
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
