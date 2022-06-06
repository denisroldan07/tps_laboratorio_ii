using System;
using Archivos;

namespace Entidades
{
    public class Pasajero
    {
        #region Atributos

        private string nombre;
        private string apellido;
        private long dni;

        #endregion

        #region Propiedades

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long Dni { get => dni; set => dni = value; }
        
        #endregion

        #region Constructores

        public Pasajero() { }

        public Pasajero(string nombre, string apellido, long dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        #endregion

        #region Metodos

        public bool SerializarPasajero()
        {
            return new Xml<Pasajero>().Save("Pasajeros.xml",this);
        }

        #endregion

        #region Sobrecarga

        public override string ToString()
        {
            return $"Pasajero: {Nombre} {Apellido} \nDNI: {Dni}";
        }
        #endregion
    }
}
