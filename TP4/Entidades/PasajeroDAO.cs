using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class PasajeroDAO
    {
        private static string connectionString;
        private SqlConnection connection;

        static PasajeroDAO()
        {
            connectionString = @"Server=localhost;Database=Vuelos;Trusted_Connection=True;";
        }

        public PasajeroDAO()
        {
            new SqlConnection(connectionString);
        }

        public void Guardar(Pasajero pasajero,int idAvion)
        {
            try
            {
                connection = new SqlConnection(PasajeroDAO.connectionString);
                connection.Open();

                string query = "INSERT INTO Pasajero (dni,nombre,apellido,Id_Asiento,Id_Avion) VALUES (@dni,@nombre,@apellido,@Id_Asiento,@Id_Avion)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("dni", pasajero.Dni);
                command.Parameters.AddWithValue("nombre", pasajero.Nombre);
                command.Parameters.AddWithValue("apellido", pasajero.Apellido);
                command.Parameters.AddWithValue("Id_Asiento", pasajero.IdAsiento);
                command.Parameters.AddWithValue("Id_Avion", idAvion);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Pasajero> Leer(int idAvion)
        {
            List<Pasajero> listaPasajeros = new List<Pasajero>();
            try
            {
           
                using(SqlConnection connection = new SqlConnection(PasajeroDAO.connectionString))
                {
                    string query = "SELECT * FROM Pasajero WHERE Id_Avion = @idAvion";
           
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("Id_Avion",idAvion);

                    SqlDataReader dataReader = command.ExecuteReader();
                    while(dataReader.Read())
                    {
                        long dni = dataReader.GetInt64(0);
                        string nombre = dataReader.GetString(1);
                        string apellido = dataReader.GetString(2);
                        int idAsiento = dataReader.GetInt32(3);

                        Pasajero pasajero = new Pasajero(nombre,apellido,dni,idAsiento);
                        listaPasajeros.Add(pasajero);
                    }
                }

                return listaPasajeros;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
