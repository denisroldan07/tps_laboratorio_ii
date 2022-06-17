using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Text.RegularExpressions;

namespace FormApp
{
    public partial class ModificarPasajero : Form
    {
        public static int idVuelo;
        public static Pasajero pasajeroOriginal = new Pasajero();
        public static Pasajero pasajeroAModificar = new Pasajero();

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
        /// Evento que modifica un pasajero , primero chequea que los datos son validos y luego gracias a las variables estaticas guardadas con la informacion necesaria modifica el pasajero
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AceptarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBox_Nombre.Text) || string.IsNullOrEmpty(txtBox_Apellido.Text) || string.IsNullOrEmpty(txtBox_DNI.Text) || cmb_AsientosLibres.SelectedItem == null)
                {
                    MessageBox.Show("Debe completar todos los campos del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Regex.IsMatch(txtBox_Nombre.Text, @"^[\p{L}]+$") || !Regex.IsMatch(txtBox_Apellido.Text, @"^[\p{L}]+$") || !long.TryParse(txtBox_DNI.Text, out _))
                {
                    MessageBox.Show("Hay errores en los campos del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((txtBox_DNI.Text.Length < 7) || (txtBox_DNI.Text.Length > 8))
                {
                    MessageBox.Show("Ingreso un Dni con la cantidad de numeros inválida", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtBox_Nombre.Text == pasajeroAModificar.Nombre)
                {
                    MessageBox.Show("El nombre no puede ser el mismo en una modificación", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    DialogResult dialogResult = MessageBox.Show($"Esta seguro que desea modificar: {pasajeroOriginal.ToString()} ?", "ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        pasajeroAModificar.Nombre = txtBox_Nombre.Text;
                        pasajeroAModificar.Apellido = txtBox_Apellido.Text;
                        pasajeroAModificar.Dni = long.Parse(txtBox_DNI.Text);
                        pasajeroAModificar.IdAsiento = int.Parse(cmb_AsientosLibres.SelectedItem.ToString());

                        Avion avionAux = Vuelos.ObtenerAvion(idVuelo);
                        foreach (var pasajero in avionAux.Pasajeros)
                        {
                            if (pasajero.Value == null)
                            {
                                continue;
                            }

                            if (pasajero.Value.Dni == pasajeroAModificar.Dni)
                            {
                                //Una vez que encuentro al pasajero, cambio su valor a null dejando libre el asiento y busco la key del asiento a donde voy a mover al pasajero.

                                //Borro del diccionario el pasajero del asiento ocupado y borro el asiento que esta libre
                                avionAux.Pasajeros.Remove(pasajero.Key);
                                avionAux.Pasajeros.Remove(pasajeroAModificar.IdAsiento);

                                //Ahora actualizo el primer asiento borrado dejandolo libre y luego agrego el pasajero modificado
                                avionAux.Pasajeros.Add(pasajero.Key, null);
                                avionAux.Pasajeros.Add(pasajeroAModificar.IdAsiento, pasajeroAModificar);
                                break;
                            }
                        }

                        //Actualizo la lista de Vuelos con la nueva modificacion
                        for (int i = 0; i < 4; i++)
                        {
                            Avion aux = Vuelos.vuelos[i];
                            if (idVuelo == aux.Id)
                            {
                                Vuelos.vuelos[i] = avionAux;
                                break;
                            }
                        }

                        new Json<List<Avion>>().Save("Vuelos.json", Vuelos.vuelos);
                        MessageBox.Show($"El pasajero {pasajeroOriginal.ToString()} \nfue modificado exitosamente con la siguiente informacion:\n{pasajeroAModificar.ToString()}", "MODIFICACIÓN EXITOSA!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarListaDePasajeros(idVuelo);
                        OcultarBotones();
                    }
                    else
                    {
                        MostrarListaDePasajeros(idVuelo);
                    }
                }
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
            dgv_Pasajeros.Hide();
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
            txtBox_Nombre.Hide();
            txtBox_Apellido.Hide();
            txtBox_DNI.Hide();
            cmb_AsientosLibres.Hide();
            btn_AceptarCambios.Hide();
            btn_Atras.Hide();
        }

        private void MostrarBotonesModificacionPasajero()
        {
            txtBox_Nombre.Show();
            txtBox_Apellido.Show();
            txtBox_DNI.Show();
            cmb_AsientosLibres.Show();
            btn_AceptarCambios.Show();
        }

        private void dgv_Pasajeros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_Pasajeros.SelectedRows.Count > 0)
                {
                    if (dgv_Pasajeros.CurrentRow.DataBoundItem == null)
                    {
                        MessageBox.Show("Debe seleccionarse una fila que no este vacia", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Pasajero pasajero = (Pasajero)dgv_Pasajeros.CurrentRow.DataBoundItem;
                        Avion avion = Vuelos.ObtenerAvion(idVuelo);
                        MostrarBotonesModificacionPasajero();
                        pasajeroOriginal.Nombre = pasajero.Nombre;
                        pasajeroOriginal.Apellido = pasajero.Apellido;
                        pasajeroOriginal.Dni = pasajero.Dni;
                        pasajeroOriginal.IdAsiento = pasajero.IdAsiento;

                        txtBox_DNI.Text = pasajero.Dni.ToString();
                        txtBox_DNI.Enabled = false;
                        txtBox_Nombre.Text = pasajero.Nombre;
                        txtBox_Apellido.Text = pasajero.Apellido;

                        List<int> asientosVacios = DevolverAsientosVacios(avion);
                        foreach (var asiento in asientosVacios)
                        {
                            cmb_AsientosLibres.Items.Add(asiento);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "ModificarPasajero"));
                MessageBox.Show("Ocurrio un error", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public List<int> DevolverAsientosVacios(Avion avion)
        {
            List<int> listaAsientosVacios = new List<int>();

            foreach (KeyValuePair<int, Pasajero> asiento in avion.Pasajeros)
            {
                if (asiento.Value == null)
                {
                    listaAsientosVacios.Add(asiento.Key);
                }
            }

            return listaAsientosVacios;
        }

        #endregion

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            GenerarInterfaceForm();
        }

        

        
 
    }
}
