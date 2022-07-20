using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System;

namespace FormApp
{
   public partial class CargarPasajeroForm : Form
   {
        public static int idVuelo;
        public static int idAsiento;
        public CargarPasajeroForm()
        {
            InitializeComponent();
        }

        private void CargarPasajeroForm_Load(object sender, System.EventArgs e)
        {
            GenerarInterfaceForm();
        }

        #region InterfaceBotones

        private void btn_ReservarLugar1_Click(object sender, System.EventArgs e)
        {
            idVuelo = 1;
            ChequearDisponibilidadDeAsientos(idVuelo);
            MostrarBotonesDeAsientos();
        }

        private void btn_ReservarLugar2_Click(object sender, EventArgs e)
        {
            idVuelo = 2;
            ChequearDisponibilidadDeAsientos(idVuelo);
            MostrarBotonesDeAsientos();
        }

        private void btn_ReservarLugar3_Click(object sender, EventArgs e)
        {
            idVuelo = 3;
            ChequearDisponibilidadDeAsientos(idVuelo);
            MostrarBotonesDeAsientos();
        }

        private void btn_ReservarLugar4_Click(object sender, EventArgs e)
        {
            idVuelo = 4;
            ChequearDisponibilidadDeAsientos(idVuelo);
            MostrarBotonesDeAsientos();
        }


        private void btn_Asiento1_Click(object sender, System.EventArgs e)
        {
            idAsiento = 1;
            MostrarCamposCargarPasajero();
        }

        private void btn_Asiento2_Click(object sender, System.EventArgs e)
        {
            idAsiento = 2;
            MostrarCamposCargarPasajero();
        }

        private void btn_Asiento3_Click(object sender, System.EventArgs e)
        {
            idAsiento = 3;
            MostrarCamposCargarPasajero();
        }

        private void btn_Asiento4_Click(object sender, System.EventArgs e)
        {
            idAsiento = 4;
            MostrarCamposCargarPasajero();
        }

        #endregion
        private void btn_CargarPasajero_Click(object sender, System.EventArgs e)
        {
            CargarPasajero(idAsiento,idVuelo);
            GenerarInterfaceForm();
        }

        #region CargarPasajeroAux

        /// <summary>
        /// Funcion que carga un pasajero en el avion correspondiente , primero chequea que los datos del formulario esten bien puestos , luego se fija si no esta repetido y por ultimo busca el asiento correspondiente con el id y agrega el pasajero
        /// </summary>
        /// <param name="idAsiento">Parametro para poder ubicar en el diccionario al nuevo pasajero</param>
        /// <param name="idVuelo">Parametro para poder ubicar en la clase estatica el vuelo correspondiente</param>
        private void CargarPasajero(int idAsiento, int idVuelo)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox_Nombre.Text) || string.IsNullOrEmpty(txtBox_Apellido.Text) || string.IsNullOrEmpty(txtBox_DNI.Text))
                {
                    throw new FormFormatErrorException("Debe completar todos los campos del formulario");
                }
                else if (!Regex.IsMatch(txtBox_Nombre.Text, @"^[\p{L}]+$") || !Regex.IsMatch(txtBox_Apellido.Text, @"^[\p{L}]+$") || !long.TryParse(txtBox_DNI.Text, out _))
                {
                    throw new FormFormatErrorException("Hay errores en la carga del formulario");

                }
                else if ((txtBox_DNI.Text.Length < 7) || (txtBox_DNI.Text.Length > 8))
                {
                    throw new FormFormatErrorException("Ingreso un Dni con la cantidad de numeros inválida");
                }
                else
                {
                    var nombre = txtBox_Nombre.Text;
                    var apellido = txtBox_Apellido.Text;
                    long dni = long.Parse(txtBox_DNI.Text);

                    Pasajero pasajero = new Pasajero(nombre, apellido, dni,idAsiento);

                    if (Avion.ChequearPasajeroRepetido(idVuelo,pasajero))
                    {
                        throw new FormFormatErrorException("El dni del pasajero que quiere cargar ya se encuentra en este vuelo o en otro de nuestra aerolinea , por favor le recordamos que el dni tiene que ser único e irrepetible");
                    }
                    else
                    {
                        if (AsignarAsientoAlPasajero(idAsiento, idVuelo, pasajero))
                        {
                            MessageBox.Show($"Pasajero {pasajero.Nombre} cargado correctamente !\n El numero de vuelo es {idVuelo}", "Carga correcta !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new Json<List<Avion>>().Save("Vuelos.json", Vuelos.vuelos);
                        }
                        else
                        {
                            MessageBox.Show($"Hubo un error en la carga del pasajero {pasajero.Nombre}");
                        }
                    }
                }
                
            }
            catch (FormFormatErrorException ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "CargarPasajero - FormFormatErrorException"));
                MessageBox.Show(ex.Message, "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt",LogErrors.LogError(ex,"CargarPasajero"));
                MessageBox.Show(ex.Message,"ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool AsignarAsientoAlPasajero(int idAsiento, int idVuelo, Pasajero pasajero)
        {
            for (int i = 0; i < 4; i++)
            {
                Avion avionAux = Vuelos.vuelos[i];
                if(Avion.BuscarAsiento(idAsiento,idVuelo,avionAux))
                {
                    Vuelos.vuelos[i].Pasajeros.Add(idAsiento, pasajero);
                    return true;
                }
            }
            
            return false;
        }
        

        #endregion


        #region AuxiliaresInterface
        private void GenerarInterfaceForm()
        {
            lstBox_Avion1.Items.Clear();
            lstBox_Avion2.Items.Clear();
            lstBox_Avion3.Items.Clear();
            lstBox_Avion4.Items.Clear();
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

        private void GenerarInformacionDeVuelo(Avion avion , ListBox listBox, int id)
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

        private void ChequearDisponibilidadDeAsientos(int id)
        {
            btn_Asiento1.Enabled = true;
            btn_Asiento2.Enabled = true;
            btn_Asiento3.Enabled = true;
            btn_Asiento4.Enabled = true;

            Avion avion = Vuelos.ObtenerAvion(id);
            foreach (KeyValuePair<int, Pasajero> asiento in avion.Pasajeros)
            {
                switch (asiento.Key)
                {
                    case 1:
                        if (asiento.Value != null)
                        {
                            btn_Asiento1.Enabled = false;
                            
                        }
                        break;
                    case 2:
                        if (asiento.Value != null)
                        {
                            btn_Asiento2.Enabled = false;
                        }
                        break;
                    case 3:
                        if (asiento.Value != null)
                        {
                            btn_Asiento3.Enabled = false;
                        }
                        break;
                    case 4:
                        if (asiento.Value != null)
                        {
                            btn_Asiento4.Enabled = false;
                        }
                        break;
                }
            }
        }

        private void OcultarBotones()
        {
            txtBox_Nombre.Hide();
            txtBox_Apellido.Hide();
            txtBox_DNI.Hide();
            btn_CargarPasajero.Hide();
            btn_Asiento1.Hide();
            btn_Asiento2.Hide();
            btn_Asiento3.Hide();
            btn_Asiento4.Hide();
            btn_Atras.Hide();
        }

        private void MostrarBotonesDeAsientos()
        {
            btn_Asiento1.Show();
            btn_Asiento2.Show();
            btn_Asiento3.Show();
            btn_Asiento4.Show();
            btn_Atras.Show();
        }

        private void MostrarCamposCargarPasajero()
        {
            txtBox_Nombre.Show();
            txtBox_Apellido.Show();
            txtBox_DNI.Show();
            btn_CargarPasajero.Show();
        }


        #endregion

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            GenerarInterfaceForm();
        }

    }
}
