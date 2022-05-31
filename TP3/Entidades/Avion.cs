using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
