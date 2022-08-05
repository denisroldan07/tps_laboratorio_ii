using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades

{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion pedida , previo una validacion
        /// </summary>
        /// <param name="n1">Primer operando</param>
        /// <param name="n2">Segundo operando</param>
        /// <param name="operador">Operador seleccionado</param>
        /// <returns>Resultado de la operacion devuelto en tipo double</returns>
        public static double Operar(Operando n1 , Operando n2 , char operador)
        {
            double result = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
            }

            return result;
        }

        /// <summary>
        /// Valida que el operador sea un operador valido
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Devuelve el operador correcto en caso contrario devuelve '+'</returns>
        private static char ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }

            return '+';
        }
    }
}
