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

namespace FormApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            IngresoUsuario user = new IngresoUsuario();
            Hide();
            user.Show();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            IngresoAdmin admin = new IngresoAdmin();
            Hide();
            admin.Show();
        }
    }
}
