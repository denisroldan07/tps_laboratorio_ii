using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivos<T>
    {
        bool Save(string file, T data);

        bool Read(string file, out T data);

        
    }
}
