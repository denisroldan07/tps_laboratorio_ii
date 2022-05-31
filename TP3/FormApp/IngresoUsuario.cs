using System;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Text;
using System.Text.RegularExpressions;

namespace FormApp
{
    public partial class IngresoUsuario : Form
    {
        public IngresoUsuario()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampoVacio(txtBox_Nombre.Text) || ValidarCampoVacio(txtBox_Apellido.Text) || ValidarCampoVacio(txtBox_NewUserDni.Text)) 
                {
                    MessageBox.Show("Hay campos vacios");
                } else if(!IsAlphabets(txtBox_Nombre.Text) && !IsAlphabets(txtBox_Apellido.Text))
                {
                    txtBox_Nombre.Clear();
                    txtBox_Apellido.Clear();
                    MessageBox.Show("Por favor ingrese nombre o apellido válidos");
                } else if(!long.TryParse(txtBox_NewUserDni.Text,out _))
                {
                    txtBox_NewUserDni.Clear();
                    MessageBox.Show("Por favor ingrese un dni válido");
                }
                else
                {
                    var nombre = txtBox_Nombre.Text;
                    var apellido = txtBox_Apellido.Text;
                    long dni = long.Parse(txtBox_DNI.Text);
                    
                    Pasajero pasajero = new Pasajero(nombre, apellido, dni);
                    Global.pasajeros.Add(pasajero);
                    //new Xml<Pasajero>().Save("Pasajeros.xml", pasajero);
                    //Pasar al siguiente form
                }
            }
            catch (FormatException ex)
            {
                new Text().Save("Log.txt", IngresoUsuario.GuardarErrorEnLog(ex));
                MessageBox.Show("Hay datos inválidos");
            }
            catch (Exception ex)
            {
                new Text().Save("Log.txt", IngresoUsuario.GuardarErrorEnLog(ex));
                MessageBox.Show("Ocurrio un error inesperado");
            } 
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {    

        }

        #region FuncionesAuxiliares

        private static string GuardarErrorEnLog(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{DateTime.Now} - {ex} \n\n");
            return sb.ToString();
        }

        #endregion

        #region Validaciones

        private static bool ValidarCampoVacio(string textBox)
        {
            return string.IsNullOrEmpty(textBox);
        }

        public bool IsAlphabets(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return false;
            }

            for (int i = 0; i < inputString.Length; i++)
            {

                if (!char.IsLetter(inputString[i]))
                {
                    return false;

                }
            }

            return true;
        }

        #endregion




    }
}
