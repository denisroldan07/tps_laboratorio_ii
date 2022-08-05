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
        }

        private void btn_BuscarPasajero_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox_DNI.Text) || string.IsNullOrEmpty(txtBox_IdVuelo.Text))
                {
                    throw new FormFormatErrorException("Debe completar todos los campos del formulario");
                }
                else if (!long.TryParse(txtBox_DNI.Text, out _) && (txtBox_DNI.Text.Length == 7 || txtBox_DNI.Text.Length == 8) || !(int.TryParse(txtBox_IdVuelo.Text,out _)))
                {
                    throw new FormFormatErrorException("Error en la carga del formulario");
                } 
                else
                {
                    long dni = long.Parse(txtBox_DNI.Text);
                    int idVuelo = int.Parse(txtBox_IdVuelo.Text);

                    if(Avion.BuscarPasajeroEnAviones(dni,idVuelo,Vuelos.vuelos,out Pasajero pasajero))
                    {
                        BuscarPasajero.pasajero = pasajero;
                        MessageBox.Show(pasajero.ImprimirPasajero(Vuelos.ObtenerAvion(idVuelo)), "Informacion del pasajero:", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show(ex.Message, "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
