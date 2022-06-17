using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;

namespace FormApp
{
    public partial class BuscarPasajero : Form
    {
        public static Pasajero pasajero;
        public BuscarPasajero()
        {
            InitializeComponent();
            lstBox_DatosPasajero.Hide();
            btn_Ticket.Hide();
        }

        private void btn_BuscarPasajero_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox_DNI.Text) || string.IsNullOrEmpty(txtBox_IdVuelo.Text))
                {
                    MessageBox.Show("Debe completar todos los campos del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!long.TryParse(txtBox_DNI.Text, out _) && (txtBox_DNI.Text.Length == 7 || txtBox_DNI.Text.Length == 8) || !(int.TryParse(txtBox_IdVuelo.Text,out _)))
                {
                    MessageBox.Show("Error en la carga del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    long dni = long.Parse(txtBox_DNI.Text);
                    int idVuelo = int.Parse(txtBox_IdVuelo.Text);

                    if(Avion.BuscarPasajeroEnAviones(dni,idVuelo,Vuelos.vuelos,out Pasajero pasajero))
                    {
                        BuscarPasajero.pasajero = pasajero;
                        lstBox_DatosPasajero.Show();
                        btn_Ticket.Show();
                        lstBox_DatosPasajero.Items.Add($"Pasajero: {pasajero.Nombre} {pasajero.Apellido}");
                        lstBox_DatosPasajero.Items.Add($"DNI: {pasajero.Dni}");
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el pasajero en el avion especificado", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "BuscarPasajero"));
                MessageBox.Show("Hay errores en la carga del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Ticket_Click(object sender, EventArgs e)
        {
            try
            {
                Avion avion = Vuelos.ObtenerAvion(int.Parse(txtBox_IdVuelo.Text));
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(avion.ToString());
                sb.AppendLine(pasajero.ToString());

                MessageBox.Show(sb.ToString(),"Ticket de vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Text().Save("Tickets.txt", sb.ToString());

            }
            catch (Exception ex)
            {

                new Text().Save("logError.txt", LogErrors.LogError(ex, "BuscarPasajero"));
                MessageBox.Show("Ocurrio un error en la generación del ticket", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
