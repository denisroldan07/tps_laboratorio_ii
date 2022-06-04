using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Text : IArchivos<string>
    {
        string folder;

        public Text()
        {
            folder = string.Format("{0}{1}",AppDomain.CurrentDomain.BaseDirectory, @"\LogErrores");
        }

        public bool Save(string file,string data)
        {
            try
            {
                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                file = Path.Combine(folder, file);
                using (StreamWriter sw = new StreamWriter(file,true))
                {
                    sw.Write(data);
                    return true;
                }

            }
            catch (Exception)
            {
               throw new Exception($"Problemas al guardar el archivo: {file}");
            }
        }

        public bool Read(string file,out string data)
        {
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                file = Path.Combine(folder, file);
                using(StreamReader sr = new StreamReader(file))
                {
                    data = sr.ReadToEnd();
                    return true;
                }
            }
            catch (Exception)
            { 
                throw new Exception($"Problemas para leer el archivo: {file}");
            }
        }

    }
}
