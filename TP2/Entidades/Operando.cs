using System;
using System.Text;

namespace Entidades.Entidades
{
    public class Operando
    {

        #region Atributos

        /// <summary>
        /// Atributo privado de la clase
        /// </summary>
        private double numero;

        #endregion 

        #region Propiedades

        /// <summary>
        /// Propiedad de clase Numero
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value.ToString());
            }
        }

        #endregion 

        #region Constructores

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor de instancia para numeros de tipo double
        /// </summary>
        /// <param name="numero">numero de tipo double</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de instancia para string que representen un numero
        /// </summary>
        /// <param name="strNumero">variable tipo string que representa un numero</param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }

        #endregion  

        #region Validaciones

        /// <summary>
        /// Valida que el string pasado por parametro este compuesto solo de '0' y '1'
        /// </summary>
        /// <param name="binario">String a validar</param>
        /// <returns> Devuelve true si el string esta compuesto de '0' y '1' y false en caso contrario </returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
                

            }
            return true;
        }

        /// <summary>
        /// Verifica si el valor recibido es un valor numerico y lo retorna de tipo double
        /// </summary>
        /// <param name="strNumero"> Valor recibido en formato string </param>
        /// <returns>Retorna un tipo double. Si el TryParse es true convierte el string dado a valor double , en caso contrario se le asigna 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double resultado;
            if (!double.TryParse(strNumero, out resultado))
            {
                resultado = 0;
            }

            return resultado;
        }

        #endregion

        #region Conversores

        /// <summary>
        /// Valida que se trate de un numero binario y luego convertirá ese numero binario a decimal en caso de ser posible
        /// </summary>
        /// <param name="binario">Parametro recibido de tipo string</param>
        /// <returns>Valor convertido a decimal en caso de ser posible , de lo contrario devuelve "valor invalido"</returns>
        public string BinarioDecimal(string binario)
        {
            if (!EsBinario(binario))
            {
                return "Valor inválido";
            }

            StringBuilder bin = new StringBuilder();

            InvertirStringBuilder(binario, bin);

            int respuesta = 0;
            respuesta = CalcularNumeroDecimalDesdeBinario(bin, respuesta);

            return respuesta.ToString();
        }

        /// <summary>
        /// Convierte el numero recibido a binario
        /// </summary>
        /// <param name="numero">Parametro a ser transformado a binario</param>
        /// <returns>Devuelve un numero binario de tipo string , en caso contrario devuelve "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {
            int numeroEntero;
            Operando numeroOperando = new Operando(numero);
            StringBuilder bin = new StringBuilder();

            numeroEntero = (int)numeroOperando.numero;
            numeroEntero = Math.Abs(numeroEntero);

            ConvertirDeDecimalABinario(numeroEntero, bin);

            InvertirStringBuilder(bin.ToString(), bin);

            return bin.ToString();
        }

        /// <summary>
        /// Convierte el numero recibido a binario
        /// </summary>
        /// <param name="numero">Parametro a ser transformado a binario</param>
        /// <returns>Devuelve un numero binario de tipo string , en caso contrario devuelve "Valor invalido"</returns>
        public string DecimalBinario(string numero)
        {
            double numeroDecimal;

            if (double.TryParse(numero, out numeroDecimal))
            {
                return DecimalBinario(numeroDecimal);
            }

            return "Valor invalido";
        }

        #endregion

        #region Sobrecarga de operadores
        
        /// <summary>
        /// Calcula la suma de dos numeros
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>El resultado de la suma de dos numeros</returns>
        public static double operator +(Operando n1,Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Calcula la resta entre dos numeros
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>El resultado de la resta entre dos numeros</returns>
        public static double operator -(Operando n1 , Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Calcula la multiplicacion entre dos numeros 
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>El producto entre dos numeros</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Calcula el cociente entre dos numeros
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <returns>El cociente de la division</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }

        #endregion

        #region Funciones auxiliares

        private static int CalcularNumeroDecimalDesdeBinario(StringBuilder bin, int respuesta)
        {
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1')
                {
                    if (i == 0)
                    {
                        respuesta += 1;
                    }
                    else
                    {
                        respuesta += (int)Math.Pow(2, i);
                    }
                }

            }

            return respuesta;
        }

        private static void InvertirStringBuilder(string binario, StringBuilder bin)
        {
            bin.Clear();
            for (int i = binario.Length-1; i >= 0; i--)
            {
                bin.Append(binario[i]);
            }
        }

        private static void ConvertirDeDecimalABinario(int numeroEntero, StringBuilder bin)
        {
           
            do
            {
                if (numeroEntero % 2 == 0)
                {
                    bin.Append("0");
                }
                else
                {
                    bin.Append("1");
                }

                numeroEntero = numeroEntero / 2;

            } while (numeroEntero > 0);
        }
        #endregion
    }
}
