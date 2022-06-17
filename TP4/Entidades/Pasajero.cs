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
        private int idAsiento;

        #endregion

        #region Propiedades

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long Dni { get => dni; set => dni = value; }
        
        public int IdAsiento { get => idAsiento; set => idAsiento = value; }
        #endregion

        #region Constructores

        public Pasajero() { }

        public Pasajero(string nombre, string apellido, long dni,int idAsiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            IdAsiento = idAsiento;
        }

        #endregion

        #region Sobrecarga

        public override string ToString()
        {
            return $"Pasajero: {Nombre} {Apellido} \nDNI: {Dni} \nN° Asiento: {IdAsiento}";
        }
        #endregion
    }
}
