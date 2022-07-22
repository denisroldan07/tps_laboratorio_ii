using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Archivos;

namespace FormApp
{
    public partial class BorrarPasajero : Form
    {
        public static int idVuelo;
        public static Pasajero pasajeroAEliminar = new Pasajero(); 
       
        public BorrarPasajero()
        {
            InitializeComponent();
        }

        private void BorrarPasajero_Load(object sender, EventArgs e)
        {
            GenerarInterfaceForm();
        }

        /// <summary>
        /// Evento que elimina un pasajero , muy parecido a la funcion modificar solamente que esta se guarda el valor de la key donde se encuentra el pasajero a eliminar y luego se crea otro keyvaluepair con la misma key anterior solo que con el value en null y se guarda en la lista estatica de vuelos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_EliminarPasajero_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Pasajeros.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Debe seleccionarse una fila que no este vacia", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"Esta seguro que desea eliminar del vuelo a:\n{pasajeroAEliminar.ToString()} ?", "ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dialogResult == DialogResult.Yes)
                    {
                        Avion avionAux = Vuelos.ObtenerAvion(idVuelo);
                        foreach (KeyValuePair<int,Pasajero> pasajero in avionAux.Pasajeros)
                        {
                            if(pasajero.Value.Dni == pasajeroAEliminar.Dni)
                            {
                                avionAux.Pasajeros.Remove(pasajero.Key);
                                avionAux.Pasajeros.Add(pasajero.Key, null);
                                break;
                            }
                        }
                        MessageBox.Show($"El pasajero {pasajeroAEliminar.ToString()}\neliminado exitosamente !", "BAJA REALIZADA EXITOSAMENTE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarListaDePasajeros(idVuelo);
                    }
                }
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "EliminarPasajero"));
                MessageBox.Show("Ocurrio un error", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region BotonesEliminar

        private void btn_Eliminar1_Click(object sender, EventArgs e)
        {
            idVuelo = 1;
            MostrarListaDePasajeros(idVuelo);
        }

        private void btn_Eliminar2_Click(object sender, EventArgs e)
        {
            idVuelo = 2;
            MostrarListaDePasajeros(idVuelo);
        }

        private void btn_Eliminar3_Click(object sender, EventArgs e)
        {
            idVuelo = 3;
            MostrarListaDePasajeros(idVuelo);
        }

        private void btn_Eliminar4_Click(object sender, EventArgs e)
        {
            idVuelo = 4;
            MostrarListaDePasajeros(idVuelo);
        }

        #endregion

        #region InterfaceForm
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
            List<Pasajero> pasajeros = new List<Pasajero>();
            Avion avion = Vuelos.ObtenerAvion(idVuelo);

            ObtenerPasajerosDataGrid(pasajeros, avion);

            btn_Atras.Show();
            btn_EliminarPasajero.Show();
            dgv_Pasajeros.Show();
            dgv_Pasajeros.DataSource = pasajeros;
        }

        private static void ObtenerPasajerosDataGrid(List<Pasajero> pasajeros, Avion avion)
        {
            foreach (KeyValuePair<int, Pasajero> pasajero in avion.Pasajeros)
            {
                pasajeros.Add(pasajero.Value);
            }
        }

        private void OcultarBotones()
        {
            dgv_Pasajeros.Hide();
            btn_EliminarPasajero.Hide();
            btn_Atras.Hide();
        }

        private void MostrarBotones()
        {
            dgv_Pasajeros.Show();
            btn_Atras.Show();
            btn_EliminarPasajero.Show();
        }

        #endregion

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            GenerarInterfaceForm();
        }

        private void dgv_Pasajeros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgv_Pasajeros.SelectedRows.Count > 0)
                {
                    pasajeroAEliminar = (Pasajero)dgv_Pasajeros.CurrentRow.DataBoundItem;
                }
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "ModificarPasajero"));
                MessageBox.Show("Ocurrio un error", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
