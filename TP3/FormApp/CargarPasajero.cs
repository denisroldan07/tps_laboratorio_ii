using System.Collections.Generic;
using System.Text;
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
        private void btn_ReservarLugar2_Click(object sender, System.EventArgs e)
        {
            idVuelo = 2;
            ChequearDisponibilidadDeAsientos(idVuelo);
            MostrarBotonesDeAsientos();
        }
        private void btn_ReservarLugar3_Click(object sender, System.EventArgs e)
        {
            idVuelo = 3;
            ChequearDisponibilidadDeAsientos(idVuelo);
            MostrarBotonesDeAsientos();
        }
        private void btn_ReservarLugar4_Click(object sender, System.EventArgs e)
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
        private void CargarPasajero(int idAsiento, int idVuelo)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox_Nombre.Text) || string.IsNullOrEmpty(txtBox_Apellido.Text) || string.IsNullOrEmpty(txtBox_DNI.Text))
                {
                    MessageBox.Show("Debe completar todos los campos del formulario");
                }
                else
                {
                    if (!Regex.IsMatch(txtBox_Nombre.Text, @"^[\p{L}]+$") || !Regex.IsMatch(txtBox_Apellido.Text, @"^[\p{L}]+$") || (!long.TryParse(txtBox_DNI.Text, out _) && (txtBox_DNI.Text.Length == 7 || txtBox_DNI.Text.Length == 8)))
                    {
                        MessageBox.Show("Hay errores en la carga del formulario");
                    }
                    else
                    {
                        var nombre = txtBox_Nombre.Text;
                        var apellido = txtBox_Apellido.Text;
                        long dni = long.Parse(txtBox_DNI.Text);

                        Pasajero pasajero = new Pasajero(nombre, apellido, dni);

                        if (ChequearPasajeroRepetido(idVuelo,pasajero))
                        {
                            MessageBox.Show("El pasajero que quiere ingresar ya esta en el avión");
                        }
                        else
                        {
                            if (AsignarAsientoAlPasajero(idAsiento, idVuelo, pasajero))
                            {
                                MessageBox.Show($"Pasajero {pasajero.Nombre} cargado correctamente !");
                            }
                            else
                            {
                                MessageBox.Show($"Hubo un error en la carga del pasajero {pasajero.Nombre}");
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                new Text().Save("logError.txt",LogError(ex));
                MessageBox.Show("Hay errores en la carga del formulario");
            }

        }
        private bool AsignarAsientoAlPasajero(int idAsiento, int idVuelo, Pasajero pasajero)
        {
            bool ans = false;

            for (int i = 0; i < 4; i++)
            {
                Avion avionAux = Vuelos.vuelos[i];
                if (avionAux.Id == idVuelo)
                {
                    foreach (var asiento in avionAux.Pasajeros)
                    {
                        if (asiento.Key == idAsiento)
                        {
                            Vuelos.vuelos[i].Pasajeros.Remove(idAsiento);
                            Vuelos.vuelos[i].Pasajeros.Add(idAsiento, pasajero);
                            ans = true;
                            break;
                        }
                    }
                }
            }

            return ans;
        }
        
        private bool ChequearPasajeroRepetido(int idVuelo,Pasajero pasajero)
        {
            bool ans = false;
            for (int i = 0; i < 4; i++)
            {
                Avion avionAux = Vuelos.vuelos[i];
                if (avionAux.Id == idVuelo)
                {
                    foreach (var pasajeroDni in avionAux.Pasajeros)
                    {
                        if(pasajeroDni.Value == null)
                        {
                            continue;
                        }
                        if (pasajeroDni.Value.Dni == pasajero.Dni)
                        {
                            ans = true;
                            return ans;
                        }
                    }
                }
            }

            return ans;
        }
        #endregion
        public static string LogError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nDate: {DateTime.Now}");
            sb.AppendLine($"\nError: {ex.Message}");
            return sb.ToString();
        }

        #region AuxiliaresInterface
        private void GenerarInterfaceForm()
        {
            lstBox_Avion1.Items.Clear();
            lstBox_Avion2.Items.Clear();
            lstBox_Avion3.Items.Clear();
            lstBox_Avion4.Items.Clear();
            OcultarBotones();
            
            Avion avion1 = Vuelos.ObtenerAvion(1);
            Avion avion2 = Vuelos.ObtenerAvion(2);
            Avion avion3 = Vuelos.ObtenerAvion(3);
            Avion avion4 = Vuelos.ObtenerAvion(4);
            
            GenerarInformacionDeVuelo(avion1,lstBox_Avion1,1);
            GenerarInformacionDeVuelo(avion2,lstBox_Avion2,2);
            GenerarInformacionDeVuelo(avion3,lstBox_Avion3,3);
            GenerarInformacionDeVuelo(avion4,lstBox_Avion4,4);
            
            ChequearLugarDisponible(avion1);
            ChequearLugarDisponible(avion2);
            ChequearLugarDisponible(avion3);
            ChequearLugarDisponible(avion4);
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

        private void ChequearLugarDisponible(Avion avion1)
        {
            foreach (KeyValuePair<int, Pasajero> pasajeros in avion1.Pasajeros)
            {
                if (pasajeros.Value == null)
                {
                    btn_Asiento1.Enabled = false;
                }
                break;
            }
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
