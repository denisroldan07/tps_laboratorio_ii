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
            InstanciarVuelos();
        }

        #endregion

        #region Metodos

        private static void InstanciarVuelos()
        {
            try
            {
                new Json<List<Avion>>().Read("Vuelos.json", out vuelos);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los datos", ex);
            }

        }

        public static Avion ObtenerAvion(int id)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
               
            }
            
        }

        #endregion
    }
}
