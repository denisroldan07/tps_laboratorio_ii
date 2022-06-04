using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            vuelos = new List<Avion>(4);
           
            Avion avion1 = new Avion(id:1, 
                                     pasajeros: new Dictionary<int, Pasajero>(4) 
                                               { 
                                                 { 1, new Pasajero(nombre:"Denis",apellido:"Roldan",dni:38797877) },
                                                 { 2, new Pasajero(nombre:"Milagros",apellido:"Patane",dni:37860480) },
                                                 { 3, null },
                                                 { 4, null }
                                               }, 
                                     destino:Avion.EDestino.Cordoba
                                    );
            
            Avion avion2 = new Avion(id:2, 
                                     pasajeros:new Dictionary<int, Pasajero>(4) { 
                                                                                    { 1,new Pasajero(nombre:"Maximiliano",apellido:"Neiner",dni:25123456) },
                                                                                    { 2, null },
                                                                                    { 3, null },
                                                                                    { 4, null },
                                                                                }, 
                                     destino:Avion.EDestino.Aeroparque
                                     );

            Avion avion3 = new Avion(id:3,
                                     pasajeros: new Dictionary<int, Pasajero>(4) { { 1, new Pasajero(nombre: "Juan", apellido: "Terzano", dni: 35123456) },
                                                                                   { 2, new Pasajero(nombre:"Lucas",apellido:"Rodriguez",dni:36860480) },
                                                                                   { 3, new Pasajero(nombre:"Leandro",apellido:"Gonzales",dni:35860480) },
                                                                                   { 4, new Pasajero(nombre:"Carolina",apellido:"Gomez",dni:34860480) }

                                                                                 },
                                     destino: Avion.EDestino.Mendoza
                                     );

            Avion avion4 = new Avion(id:4,
                         pasajeros: new Dictionary<int, Pasajero>(4) { { 1, new Pasajero(nombre: "Juan", apellido: "Terzano", dni: 35123456) },
                                                                       { 2, new Pasajero(nombre:"Camila",apellido:"Rodriguez",dni:40860480) },
                                                                       { 3, new Pasajero(nombre:"Sebastian",apellido:"Gonzales",dni:13860480) },
                                                                       { 4, new Pasajero(nombre:"Carolina",apellido:"Gomez",dni:34860480) }

                                                                     },
                         destino: Avion.EDestino.Aeroparque
                         );

            vuelos.Add(avion1);
            vuelos.Add(avion2);
            vuelos.Add(avion3);
            vuelos.Add(avion4);
        }

        public static Avion ObtenerAvion(int id)
        {
            try
            {
                //if(!ChequearId(id))
                //{
                //    //throw new Exception();
                //}
                
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

        #region Auxiliares

        private static bool ChequearId(int id)
        {
            bool ans = false;
            foreach (Avion avionKey in vuelos)
            {
                if (avionKey.Pasajeros.ContainsKey(id))
                {
                    ans = true;
                    return ans;
                }
            }

            return ans;
        }

        #endregion
    }
}
