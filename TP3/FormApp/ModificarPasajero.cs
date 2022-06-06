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
using System.Text.RegularExpressions;

namespace FormApp
{
    public partial class ModificarPasajero : Form
    {
        public static int idVuelo;
        public static long dniPasajeroAModificar;
        public static Pasajero pasajeroAModificar;

        public ModificarPasajero()
        {
            InitializeComponent();
        }

        private void ModificarPasajero_Load(object sender, EventArgs e)
        {
            GenerarInterfaceForm();
        }

        #region BotonesModificar

        private void btn_Modificar1_Click(object sender, EventArgs e)
        {
            idVuelo = 1;
            MostrarListaDePasajeros(idVuelo);
        }

        private void btn_Modificar2_Click(object sender, EventArgs e)
        {
            idVuelo = 2;
            MostrarListaDePasajeros(idVuelo);
        }

        private void btn_Modificar3_Click(object sender, EventArgs e)
        {
            idVuelo = 3;
            MostrarListaDePasajeros(idVuelo);
        }

        private void btn_Modificar4_Click(object sender, EventArgs e)
        {
            idVuelo = 4;
            MostrarListaDePasajeros(idVuelo);
        }
        #endregion

        /// <summary>
        /// Evento que verifica si el dni ingresado por text box es valido y procede a guardar en variables estaticas la informacion necesaria para poder luego hacer la modificacion del pasajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ModificarPasajero_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox_DNI.Text))
                {
                    MessageBox.Show("Complete el campo DNI", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!long.TryParse(txtBox_DNI.Text, out _) || txtBox_DNI.Text.Length < 7 || txtBox_DNI.Text.Length > 8)
                {
                    MessageBox.Show("DNI inválido", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    long dni = long.Parse(txtBox_DNI.Text);
                    Avion avion = Vuelos.ObtenerAvion(idVuelo);
                    if (!Avion.BuscarPasajeroEnAvion(dni, idVuelo, avion, out Pasajero pasajero))
                    {
                        MessageBox.Show("El DNI que ingresó no pertenece a este vuelo", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBox_DNI.Clear();
                    }
                    else
                    {
                        pasajeroAModificar = pasajero;
                        dniPasajeroAModificar = dni;
                        txtBox_Nombre.Show();
                        txtBox_Apellido.Show();
                        btn_AceptarCambios.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "ModificarPasajero"));
                MessageBox.Show("Ocurrio un error", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que modifica un pasajero , primero chequea que los datos son validos y luego gracias a las variables estaticas guardadas con la informacion necesaria modifica el pasajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AceptarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtBox_Nombre.Text) || string.IsNullOrEmpty(txtBox_Apellido.Text))
                {
                    MessageBox.Show("Debe completar todos los campos del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if(!Regex.IsMatch(txtBox_Nombre.Text, @"^[\p{L}]+$") || !Regex.IsMatch(txtBox_Apellido.Text, @"^[\p{L}]+$"))
                {
                    MessageBox.Show("Hay errores en los campos del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else if(txtBox_Nombre.Text == pasajeroAModificar.Nombre)
                {
                    MessageBox.Show("El nombre no puede ser el mismo en una modificación", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    pasajeroAModificar.Nombre = txtBox_Nombre.Text;
                    pasajeroAModificar.Apellido = txtBox_Apellido.Text;

                    Avion avionAux = Vuelos.ObtenerAvion(idVuelo);
                    foreach (var pasajero in avionAux.Pasajeros)
                    {
                        if(pasajero.Value == null)
                        {
                            continue;
                        }

                        if(pasajero.Value.Dni == dniPasajeroAModificar)
                        {
                            pasajero.Value.Nombre = pasajeroAModificar.Nombre;
                            pasajero.Value.Apellido = pasajeroAModificar.Apellido;
                        }
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        Avion aux = Vuelos.vuelos[i];
                        if(idVuelo == aux.Id)
                        {
                            Vuelos.vuelos[i] = avionAux;
                            break;
                        }
                    }
                }

                GenerarInterfaceForm();
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "ModificarPasajero"));
                MessageBox.Show("Ocurrio un error", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region AuxiliaresInterface

        private void GenerarInterfaceForm()
        {
            lstBox_Avion1.Items.Clear();
            lstBox_Avion2.Items.Clear();
            lstBox_Avion3.Items.Clear();
            lstBox_Avion4.Items.Clear();
            lstBox_Pasajeros.Items.Clear();
            OcultarBotones();

            if (Vuelos.vuelos == null)
            {
                MessageBox.Show("Error fatal , por favor comunicarse con el área de sistemas", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {

                Avion avion1 = Vuelos.ObtenerAvion(1);
                Avion avion2 = Vuelos.ObtenerAvion(2);
                Avion avion3 = Vuelos.ObtenerAvion(3);
                Avion avion4 = Vuelos.ObtenerAvion(4);

                GenerarInformacionDeVuelo(avion1, lstBox_Avion1, 1);
                GenerarInformacionDeVuelo(avion2, lstBox_Avion2, 2);
                GenerarInformacionDeVuelo(avion3, lstBox_Avion3, 3);
                GenerarInformacionDeVuelo(avion4, lstBox_Avion4, 4);

            }
        }
        private void GenerarInformacionDeVuelo(Avion avion, ListBox listBox, int id)
        {
            listBox.Items.Add($"Vuelo: {avion.Id}");
            listBox.Items.Add($"Destino: {avion.Destino}");
            MostrarEspacioEnAvion(avion, listBox);
        }

        private static void MostrarEspacioEnAvion(Avion avion, ListBox listBox)
        {
            int count = 0;
            foreach (KeyValuePair<int, Pasajero> asiento in avion.Pasajeros)
            {
                if (asiento.Value != null)
                {
                    count++;
                }
            }

            if (count == 4)
            {
                listBox.Items.Add("Asientos: Completo");
            }
            else
            {
                listBox.Items.Add($"Asientos: {4 - count}");
            }
        }

        private void MostrarListaDePasajeros(int idVuelo)
        {
            lstBox_Pasajeros.Items.Clear();

            Avion avion = Vuelos.ObtenerAvion(idVuelo);
            if (Avion.ObtenerPasajeros(idVuelo, avion, out List<Pasajero> pasajeros))
            {
                foreach (Pasajero pasajero in pasajeros)
                {
                    lstBox_Pasajeros.Items.Add(pasajero.ToString());
                }
            }

            MostrarBotones();
        }

        private void OcultarBotones()
        {
            txtBox_Nombre.Hide();
            txtBox_Apellido.Hide();
            txtBox_DNI.Hide();
            lstBox_Pasajeros.Hide();
            btn_ModificarPasajero.Hide();
            btn_AceptarCambios.Hide();
            btn_Atras.Hide();
        }

        private void MostrarBotones()
        {
            lstBox_Pasajeros.Show();
            btn_Atras.Show();
            txtBox_DNI.Show();
            btn_ModificarPasajero.Show();
        }
        #endregion

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            GenerarInterfaceForm();
        }


    }
}
