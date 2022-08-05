using System.Collections.Generic;
using Archivos;

namespace Entidades
{
    public class Avion
    {
        public enum EDestino
        {
            Cordoba,
            Aeroparque,
            Mendoza
        }

        #region Atributos

        private int id;
        private Dictionary<int, Pasajero> pasajeros;
        private EDestino destino;

        #endregion

        #region Propiedades

        public int Id { get => id; set => id = value; }
        public Dictionary<int, Pasajero> Pasajeros { get => pasajeros; set => pasajeros = value ; }
        
        public EDestino Destino { get => destino; set => destino = value; }

        #endregion

        #region Constructores
      
        public Avion()
        {
            pasajeros = new Dictionary<int, Pasajero>();
        }

        public Avion(int id, Dictionary<int, Pasajero> pasajeros, EDestino destino) : base()
        {
            Id = id;
            Pasajeros = pasajeros;
            Destino = destino;
        }

        #endregion

        #region Metodos

        public static bool ObtenerPasajeros(int idVuelo,Avion avion,out List<Pasajero> pasajeros)
        {
            List<Pasajero> pasajerosAux = new List<Pasajero>();
            if (avion.Id == idVuelo)
            {
                foreach (var pasajero in avion.Pasajeros)
                {
                    if (pasajero.Value == null)
                    {
                        continue;
                    }
                    else 
                    {
                        pasajerosAux.Add(pasajero.Value);
                    }
                }
                pasajeros = pasajerosAux;
                return true;
            }

            pasajeros = null;
            return false;
        }

        public static bool BuscarPasajeroEnAviones(long dni, int idVuelo, List<Avion> aviones, out Pasajero pasajero)
        {
            for (int i = 0; i < 4; i++)
            {
                Avion avionAux = aviones[i];
                if(BuscarPasajeroEnAvion(dni, idVuelo, avionAux, out pasajero))
                {
                    return true;
                }                
            }

            pasajero = null;
            return false;
        }

        public static bool BuscarPasajeroEnAvion(long dni, int idVuelo, Avion avion, out Pasajero pasajero)
        {
            if (avion.Id == idVuelo)
            {
                foreach (var pasajeroDni in avion.Pasajeros)
                {
                    if (pasajeroDni.Value == null)
                    {
                        continue;
                    }
                    if (pasajeroDni.Value.Dni == dni)
                    {
                        pasajero = pasajeroDni.Value;
                        pasajero.IdAsiento = pasajeroDni.Key;
                        return true;
                    }
                }
            }

            pasajero = null;
            return false;
        }

        public static bool BuscarAsiento(int idAsiento, int idVuelo, Avion avion)
        {
            if (avion.Id == idVuelo)
            {
                foreach (var asiento in avion.Pasajeros)
                {
                    if (asiento.Key == idAsiento)
                    {
                        avion.Pasajeros.Remove(idAsiento);
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Chequea si ya esta la persona en alguno de los vuelos
        /// </summary>
        /// <param name="idVuelo"></param>
        /// <param name="pasajero"></param>
        /// <returns>Devuelve verdadero si la encuentra y false en caso contrario</returns>
        public static bool ChequearPasajeroRepetido(List<Avion> listaAviones,Pasajero pasajero)
        {
            for (int i = 0; i < listaAviones.Count; i++)
            {
                Avion avionAux = listaAviones[i];
                foreach (var asiento in avionAux.Pasajeros)
                {
                    if (asiento.Value == null)
                    {
                        continue;
                    }

                    if (asiento.Value.Dni == pasajero.Dni)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        #endregion
        #region Sobrecarga

        public override string ToString()
        {
            return $"Numero de vuelo: {Id}\nDestino: {Destino}";
        }

        #endregion
    }
}
