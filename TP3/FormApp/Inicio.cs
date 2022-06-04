using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
        }

        public void LoadForm(object form)
        {
            if(panelMain.Controls.Count > 0)
            {
                
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
            Application.Exit();
        }
    }
}
