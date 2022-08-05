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
        public Tickets ticketAEliminar;
        public List<Tickets> tickets;
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
                
                evento.OntiempoFinalizado += NotificarCargaDeTickets;
                evento.OntiempoRestante += MostrarTiempoRestante;

                evento.MensajeTiempoFinalizado(3);
                tickets = new List<Tickets>();
                tickets = await CargarDataGrid();
                dgv_Tickets.DataSource = tickets;
                dgv_Tickets.ClearSelection();
                label2.Hide();
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "GestionTickets"));
                MessageBox.Show("Hay errores en la carga del formulario", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NotificarCargaDeTickets()
        {
            if (tickets.Count == 0)
            {
                MessageBox.Show("No se pudo cargar lo pedido.\nSi es la primera vez que inicia el sistema es probable que tenga que generar un nuevo ticket cargando un nuevo pasajero en el sistema", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Se cargaron los datos pedidos", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void MostrarTiempoRestante(int segundos)
        {
            if (this.InvokeRequired)
            {
                Action<int> del = MostrarTiempoRestante;
                Invoke(del, segundos);
            }
            else
            {
                label2.Text = $"Cargando {segundos}";
            }
        }

        private async Task<List<Tickets>> CargarDataGrid()
        {
            TicketDAO ticketDAO = new TicketDAO();
            List<Tickets> tickets = await Task.Run(() => 
            {
                Thread.Sleep(2500);
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
                    throw new Exception("Atencion debe seleccionarse una fila que no este vacia");
                }
                else
                {
                    if (ticketAEliminar is null)
                    {
                        MessageBox.Show("Antes de eliminar tiene que seleccionar un ticket", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        DialogResult dialogResult = MessageBox.Show($"Esta seguro que desea eliminar de la base:\n{ticketAEliminar.ToString()} ?", "ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            TicketDAO ticketDAO = new TicketDAO();
                            ticketDAO.Eliminar(ticketAEliminar);
                            MessageBox.Show("Ticket eliminado exitosamente", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgv_Tickets.DataSource = await CargarDataGrid();
                            dgv_Tickets.ClearSelection();
                            ticketAEliminar = null;

                        }
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
                    Tickets auxTicket = (Tickets)dgv_Tickets.CurrentRow.DataBoundItem;
                    if(auxTicket is not null)
                    {
                        ticketAEliminar = new Tickets(auxTicket.Dni, auxTicket.Nombre, auxTicket.Apellido, auxTicket.Asiento, auxTicket.Destino, auxTicket.IdAvion, auxTicket.Fecha);
                    }
                }
            }
            catch (Exception ex)
            {
                new Text().Save("logError.txt", LogErrors.LogError(ex, "GestionTickets"));
                MessageBox.Show("Ocurrio un error", "ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
