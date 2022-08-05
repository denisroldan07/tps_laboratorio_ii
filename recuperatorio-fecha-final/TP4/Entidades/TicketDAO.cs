using Archivos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TicketDAO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        static TicketDAO()
        {
            connectionString = @"Server=localhost;Database=Vuelos;Trusted_Connection=True;";
        }

        public TicketDAO()
        {
            connection = new SqlConnection(TicketDAO.connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public void Guardar(Pasajero pasajero, Avion avion)
        {
            string destino = "";
            try
            {
                connection.Open();
                string query = "INSERT INTO tickets (dni,nombre,apellido,asiento,destino,avion,fecha) VALUES (@dni,@nombre,@apellido,@asiento,@destino,@avion,@fecha)";

                
                switch (avion.Destino)
                {
                    case Avion.EDestino.Cordoba:
                        destino = "Cordoba";
                        break;
                    case Avion.EDestino.Aeroparque:
                        destino = "Aeroparque";
                        break;
                    case Avion.EDestino.Mendoza:
                        destino = "Mendoza";
                        break;
                }

                command.CommandText = query;
                command.Parameters.AddWithValue("dni", pasajero.Dni);
                command.Parameters.AddWithValue("nombre", pasajero.Nombre);
                command.Parameters.AddWithValue("apellido", pasajero.Apellido);
                command.Parameters.AddWithValue("asiento", pasajero.IdAsiento);
                command.Parameters.AddWithValue("destino", destino);
                command.Parameters.AddWithValue("avion", avion.Id);
                command.Parameters.AddWithValue("fecha", DateTime.Now);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                
                new Text().Save("logError.txt", LogErrors.LogError(ex, "GeneracionDeTickets"));
              
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Tickets> Leer()
        {
            
            List<Tickets> listaTickets = new List<Tickets>();
            
            try
            {
                string query = "SELECT * FROM tickets";
                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    long dni = dataReader.GetInt64(0);
                    string nombre = dataReader.GetString(1);
                    string apellido = dataReader.GetString(2);
                    int asiento = dataReader.GetInt32(3);
                    string destino = dataReader.GetString(4);
                    int avion = dataReader.GetInt32(5);
                    DateTime fecha = dataReader.GetDateTime(6);

                    Tickets ticket = new Tickets(dni, nombre, apellido, asiento, destino, avion, fecha);
                    listaTickets.Add(ticket);
                }
                
                return listaTickets;
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "GeneracionDeTickets"));
                return null;
            }
        }

        public void Eliminar(Tickets ticket)
        {
            try
            {
                string query = "DELETE FROM tickets WHERE dni = @dni";

                connection.Open();

                command.Parameters.Clear();
                command.CommandText = query;
                command.Parameters.AddWithValue("dni",ticket.Dni);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "GeneracionDeTickets"));
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}

