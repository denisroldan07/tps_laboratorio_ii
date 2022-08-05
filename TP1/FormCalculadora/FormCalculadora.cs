using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama al metodo operar al hacer click en el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (textNumero1.Text == "" && textNumero2.Text == "")
            {
                lblResultado.Text = "No se puede operar";
            } else if(textNumero1.Text == "")
            {
                lblResultado.Text = "No se puede operar";
            } else if(textNumero2.Text == "")
            {
                lblResultado.Text = "No se puede operar";
            } else
            {
                lblResultado.Text = Operar(textNumero1.Text, textNumero2.Text, cmbOperador.Text).ToString();
                lstOperaciones.Items.Add($"{textNumero1.Text} {cmbOperador.Text}{textNumero2.Text} {"="} {lblResultado.Text}{"\n"}");
                if (btnConvertirABinario.Enabled == false)
                {
                    btnConvertirABinario.Enabled = true;
                }
            }

            
        }

        /// <summary>
        /// Recibe los parametros que estan en textNumero 1 y 2 y al cmbOperador para luego efectuar la operacion mediante la funcion Operar de la libreria Calculadora
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>
        private double Operar(string numero1 , string numero2 , string operador)
        {
            Operando numeroUno = new Operando(numero1);
            Operando numeroDos = new Operando(numero2);
            char operadorChar = char.Parse(operador);

            return Calculadora.Operar(numeroUno,numeroDos,operadorChar);
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Invoca al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Carga en memoria el windows form y borra el contenido de textBox , comboBox , label y listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Vuelve por defecto los componentes
        /// </summary>
        private void Limpiar()
        {
            this.textNumero1.Text = string.Empty;
            this.textNumero2.Text = string.Empty;
            this.cmbOperador.Text = string.Empty;
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.lblResultado.Text = "0";
            this.lstOperaciones.Items.Clear();
            
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultadoAux = lblResultado.Text;
            Operando numeroDecimal = new Operando();
            lblResultado.Text = numeroDecimal.DecimalBinario(lblResultado.Text);
            lstOperaciones.Items.Add($"El numero decimal {resultadoAux} en binario es: {lblResultado.Text}");
            btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultadoAux = lblResultado.Text;
            Operando numeroDecimal = new Operando();
            lblResultado.Text = numeroDecimal.BinarioDecimal(lblResultado.Text);
            lstOperaciones.Items.Add($"El numero binario {resultadoAux} en decimal es: {lblResultado.Text}");
            btnConvertirADecimal.Enabled = false;
        }

        private void FormCalculadora_FormClosing(object sender , FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("¿ Seguro de querer salir ?","Salir" , MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(answer == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
