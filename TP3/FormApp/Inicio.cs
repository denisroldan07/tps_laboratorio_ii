using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using Entidades;


namespace FormApp
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();

            try
            {
                List<Avion> aviones;
                if (!new Json<List<Avion>>().Read(@"\Vuelos.json", out aviones))
                {
                    MessageBox.Show("Hubo un error en la carga de datos");
                }
                else
                {
                    Vuelos.vuelos = aviones;
                }

            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "form Inicio"));
                MessageBox.Show("Error fatal , por favor comunicarse con el área de sistemas", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void LoadForm(object form)
        {
            if (panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelMain.Controls.Add(f);
            panelMain.Tag = f;
            f.Show();
        }

        private void btn_CargarPasajero_Click(object sender, EventArgs e)
        {

            LoadForm(new CargarPasajeroForm());

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            try
            {
                new Json<List<Avion>>().Save(@"\Vuelos.json", Vuelos.vuelos);
                Application.Exit();
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "btn_Cerrar"));
                MessageBox.Show("Hay errores al cerrar el formulario");
                Application.Exit();
            }
        }

        private void btn_BuscarPasajero_Click(object sender, EventArgs e)
        {
            LoadForm(new BuscarPasajero());
        }

        private void btn_ModificarPasajero_Click(object sender, EventArgs e)
        {
            LoadForm(new ModificarPasajero());
        }

        private void btn_EliminarPasajero_Click(object sender, EventArgs e)
        {
            LoadForm(new BorrarPasajero());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                new Json<List<Avion>>().Save(@"\Vuelos.json", Vuelos.vuelos);
                Application.Exit();
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "btn_Cerrar"));
                MessageBox.Show("Hay errores al cerrar el formulario");
                Application.Exit();
            }
        }
    }
}
