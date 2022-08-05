using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FormFormatErrorException : Exception
    {
        public FormFormatErrorException()
        {
        }

        public FormFormatErrorException(string message) : base(message)
        {
        }

        public FormFormatErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
