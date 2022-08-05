using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LogErrors
    {
        public static string LogError(Exception ex,string form)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Origen del Error: {form}");
            sb.AppendLine($"\nDate: {DateTime.Now}");
            sb.AppendLine($"\nError: {ex.Message}");
            return sb.ToString();
        }
    }
}
