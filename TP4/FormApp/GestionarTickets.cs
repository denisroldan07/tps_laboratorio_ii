using Entidades;
using Archivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FormApp
{
    public partial class GestionarTickets : Form
    {
        public static Tickets ticketAEliminar;
        public GestionarTickets()
        {
            InitializeComponent();
        }

        private async void GestionarTickets_Load(object sender, EventArgs e)
        {
            try
            {
                Evento evento = new Evento();

                label2.Show();
                evento.tiempoFinalizado += NotificarCargaDeTickets;
                evento.tiempoRestante += MostrarTiempoRestante;
                evento.MensajeTiempoFinalizado(8);
                dgv_Tickets.DataSource = await CargarDataGrid();
                label2.Hide();
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "GestionTickets"));
                MessageBox.Show("Hay errores en la carga del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task<List<Tickets>> CargarDataGrid()
        {
            TicketDAO ticketDAO = new TicketDAO();
            List<Tickets> tickets = await Task.Run(() => 
            { 
                                                            
                Thread.Sleep(8000);
                return ticketDAO.Leer();                                                                
            
            });

            return tickets;
        }

        private async void btn_EliminarTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Tickets.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Debe seleccionarse una fila que no este vacia", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"Esta seguro que desea eliminar de la base:\n{ticketAEliminar.ToString()} ?", "ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {

                        TicketDAO ticketDAO = new TicketDAO();
                        ticketDAO.Eliminar(ticketAEliminar);
                        MessageBox.Show("Ticket eliminado exitosamente", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarDataGrid();
                    
                    }
                }

            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "GestionTickets"));
                MessageBox.Show("Ocurrio un error", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Tickets_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgv_Tickets.SelectedRows.Count > 0)
                {
                    ticketAEliminar = (Tickets)dgv_Tickets.CurrentRow.DataBoundItem;
                }
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "GestionTickets"));
                MessageBox.Show("Ocurrio un error", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotificarCargaDeTickets()
        {
            MessageBox.Show("Se cargaron los datos pedidos", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void MostrarTiempoRestante(int segundos)
        {
            if(this.InvokeRequired)
            {
                Action<int> del = MostrarTiempoRestante;
                Invoke(del, segundos);
            }
            else 
            { 
                label2.Text = $"Cargando {segundos}";
            }
        }
    }
}
